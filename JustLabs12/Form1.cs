namespace JustLabs12;

enum TaskMode
{
    Start,
    Stop
}

public partial class Form1 : Form
{
    private const int delayDelta = 200;

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Task.Factory.StartNew(BackgroundTask);
        Task.Factory.StartNew(BackgroundTask);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Task.Factory.StartNew(() =>
        {
            Task.WaitAll(
                Task.Factory.StartNew(BackgroundTask),
                Task.Factory.StartNew(BackgroundTask));
        });
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Task.Factory.StartNew(() =>
        {
            var taskId = Task.CurrentId!.Value;
            WriteOutput1(taskId, TaskMode.Start, "t3");
            Thread.Sleep(delayDelta * taskId);
            WriteOutput1(taskId, TaskMode.Stop, "t3");
        });

        Task.Factory.StartNew(() =>
        {
            var taskId = Task.CurrentId!.Value;
            WriteOutput2(taskId, TaskMode.Start, "t3");
            Thread.Sleep(delayDelta * taskId);
            WriteOutput2(taskId, TaskMode.Stop, "t3");
        });
    }

    private void button4_Click(object sender, EventArgs e)
    {

        Parallel.Invoke(
            () =>
            {
                var taskId = Task.CurrentId!.Value;
                WriteOutput1(taskId, TaskMode.Start, "t4");
                Thread.Sleep(delayDelta * taskId);
                WriteOutput1(taskId, TaskMode.Stop, "t4");
            },
            () =>
            {
                var taskId = Task.CurrentId!.Value;
                WriteOutput2(taskId, TaskMode.Start, "t4");
                Thread.Sleep(delayDelta * taskId);
                WriteOutput2(taskId, TaskMode.Stop, "t4");
            }
        );
    }

    private void BackgroundTask()
    {
        var taskId = Task.CurrentId!.Value;
        WriteOutput1(taskId, TaskMode.Start, "t12");
        WriteOutput2(taskId, TaskMode.Start, "t12");

        Thread.Sleep(delayDelta * taskId);

        WriteOutput1(taskId, TaskMode.Stop, "t12");
        WriteOutput2(taskId, TaskMode.Stop, "t12");
    }

    private void WriteOutput1(int taskId, TaskMode mode, string extraData)
    {
        Invoke(() =>
        {
            output1.Text = $"{mode} task {taskId} ({extraData})";
        });
    }

    private void WriteOutput2(int taskId, TaskMode mode, string extraData)
    {
        Invoke(() =>
        {
            output2.Text = $"{mode} task {taskId} ({extraData})";
        });
        //output2.Text = $"{mode} task {taskId} ({extraData})";
    }
}