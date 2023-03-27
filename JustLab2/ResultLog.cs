namespace JustLab2;

public class ResultLog
{
    public required RunMode Mode { get; set; }
    public required TimeSpan Ellapsed { get; set; }
    public required int Difficulty { get; set; }
    public required int ArrayLength { get; set; }
    public required string Status { get; set; }
}
