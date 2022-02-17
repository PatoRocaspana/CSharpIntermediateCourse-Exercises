using ClassesExerciseOne;

var stopWatch = new Stopwatch();

//First Stopwatch use
stopWatch.Start();

Thread.Sleep(2900);

try
{
    stopWatch.Start();
}
catch (InvalidOperationException)
{
    Console.WriteLine("The StopWatch is already running.!");
}

stopWatch.End();
Console.WriteLine($"Duration: {stopWatch.Duration.Milliseconds} milliseconds");

//Second Stopwatch use
stopWatch.Start();
Thread.Sleep(1500);
stopWatch.End();

Console.WriteLine($"Duration: {stopWatch.Duration.Milliseconds} milliseconds");
