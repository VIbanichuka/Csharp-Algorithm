namespace C__Algorithm;

public class StopWatch
{
    public bool IsRunning { get; set; }
    public DateTime StartTimer { get; private set; }

    public void StartTime()
    {
        if (IsRunning)
        {
            throw new InvalidOperationException("Stopwatch is already running");
        }
        StartTimer = DateTime.Now;
        IsRunning = true;
    }

    public TimeSpan StopTime()
    {
        if(!IsRunning)
        {
            throw new InvalidOperationException("Stopwatch is not running");
        }
        TimeSpan duration = DateTime.Now - StartTimer;
        IsRunning = false;
        return duration;
    }
}
