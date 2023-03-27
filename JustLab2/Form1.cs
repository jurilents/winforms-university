namespace JustLab2;

public partial class Form1 : Form
{
    private BackgroudJob? activeJob;
    private int completedCount = 0;

    public Form1()
    {
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        if (CreateBackgroundJob())
            activeJob!.Run(RunMode.ParallelFor);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (CreateBackgroundJob())
            activeJob!.Run(RunMode.ParallelForEach);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (CreateBackgroundJob())
            activeJob!.Run(RunMode.DefaultFor);
    }

    private void cancel_Click(object sender, EventArgs e)
    {
        if (activeJob is not null)
        {
            activeJob.Cancel();
            statusState.Text = "Canceled";
        }
    }

    private void ResetStatusBar()
    {
        progressBar.Value = 0;
        percentBar.Text = "%";
        resultTimeBar.Text = "00:00:00";
        statusState.Text = "Running";
    }

    private bool CreateBackgroundJob()
    {
        ResetStatusBar();

        if (activeJob != null)
        {
            statusState.Text = "Another Running";
            return false;
        }

        activeJob = new BackgroudJob(
         arrayLength: (int)arrayLength.Value,
         difficulty: (int)difficulty.Value,
         rangeFrom: (double)rangeFrom.Value,
         rangeTo: (double)rangeTo.Value,
         useBreakRange: rangeToggle.Checked);

        var periodicTimer = new PeriodicTimer(new TimeSpan(0, 0, 0, 0, 100));
        Task.Run(async () =>
        {
            while (await periodicTimer.WaitForNextTickAsync())
            {
                var percent = activeJob.ProgressPercent;

                Invoke(() =>
                {
                    progressBar.Value = percent;
                    percentBar.Text = $"{percent}%";
                    resultTimeBar.Text = activeJob.Watch.Elapsed.ToString(@"hh\:mm\:ss");
                });

                if (percent >= 100)
                {
                    Invoke(() =>
                    {
                        activeJob.Watch.Stop();
                        statusState.Text = "Completed";
                        resultLog.Rows.Add(activeJob.ResultData);
                        completedOutput.Text = (++completedCount).ToString();
                        activeJob = null;
                    });
                    break;
                }
            }
        });

        return true;
    }


    private void diff1_Click(object sender, EventArgs e) => difficulty.Value = 0;
    private void diff2_Click(object sender, EventArgs e) => difficulty.Value = 1;
    private void diff3_Click(object sender, EventArgs e) => difficulty.Value = 2;
    private void diff4_Click(object sender, EventArgs e) => difficulty.Value = 3;
}