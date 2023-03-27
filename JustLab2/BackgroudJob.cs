using System.Diagnostics;

namespace JustLab2;

public enum RunMode
{
    ParallelFor,
    ParallelForEach,
    DefaultFor,
}

public class BackgroudJob
{
    public delegate double AlgFunc(int index);

    private static readonly AlgFunc[] algs = new AlgFunc[]
    {
        (i) => ((double) i) / 10,
        (i) => ((double) i) / Math.PI,
        (i) => Math.Exp(i) / Math.Pow(i, Math.PI),
        (i) => Math.Exp(i* Math.PI) / Math.Pow(i, Math.PI),
    };

    private double[] array;
    private int difficultyValue;
    private double braakFrom;
    private double breakTo;
    private bool useBreakRange;


    private CancellationTokenSource cancelSource;
    private Task? runningTask;
    private RunMode runMode;

    private object _lock = new();
    private int _counter;

    public int Counter
    {
        get
        {
            lock (_lock)
                return _counter;
        }
    }

    public int ProgressPercent
    {
        get
        {
            return (int)Math.Round((Counter / array.Length) * 100.0);
        }
    }

    public object[] ResultData
    {
        get => new object[]
        {
            runMode,
            Watch.Elapsed,
            difficultyValue,
            array.Length,
            cancelSource.IsCancellationRequested ? "Canceled" : "Completed"
        };
    }

    public Stopwatch Watch { get; private set; } = new();


    public BackgroudJob(
        int arrayLength,
        int difficulty,
        double rangeFrom,
        double rangeTo,
        bool useBreakRange)
    {
        array = new double[arrayLength];
        difficultyValue = difficulty;
        braakFrom = (double)rangeFrom;
        breakTo = (double)rangeTo;
        if (braakFrom > breakTo)
            breakTo = double.MaxValue;
        this.useBreakRange = useBreakRange;
        _counter = 0;
        cancelSource = new CancellationTokenSource();
    }

    public void Run(RunMode mode)
    {
        runMode = mode;
        Watch.Start();
        runningTask = Task.Run(() =>
        {
            _ = mode switch
            {
                RunMode.ParallelFor => RunParallelFor(),
                RunMode.ParallelForEach => RunParallelForEach(),
                RunMode.DefaultFor => RunDefaultFor(),
            };
        });
    }

    public void Cancel()
    {
        cancelSource.Cancel();
    }

    private bool IsBreackRange(int i)
    {
        return cancelSource.IsCancellationRequested
                     || useBreakRange && array[i] > braakFrom && array[i] < breakTo;
    }

    private bool RunParallelFor()
    {
        return Parallel.For(0, array.Length, (i, context) =>
         {
             lock (_lock)
                 _counter++;

             array[i] = algs[difficultyValue].Invoke(i);

             if (IsBreackRange(i))
             {
                 lock (_lock)
                     _counter = array.Length;

                 Watch.Stop();
                 context.Break();
             }
         }).IsCompleted;
    }

    private bool RunParallelForEach()
    {
        return Parallel.ForEach(array, (element, context, i) =>
        {
            lock (_lock)
                _counter++;

            var index = (int)i;
            array[i] = algs[difficultyValue].Invoke(index);

            if (IsBreackRange(index))
            {
                lock (_lock)
                    _counter = array.Length;

                Watch.Stop();
                context.Break();
            }
        }).IsCompleted;
    }

    private bool RunDefaultFor()
    {
        for (int i = 0; i < array.Length; i++)
        {
            lock (_lock)
                _counter++;
            array[i] = algs[difficultyValue].Invoke(i);

            if (IsBreackRange(i))
            {
                _counter = array.Length;
                break;
            }
        }
        Watch.Stop();
        return true;
    }
}
