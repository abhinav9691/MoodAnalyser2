using MoodAnalyser2;



MoodAanalyser1 moodobj = new MoodAanalyser1();

Console.WriteLine("Enter your Mood:");
string message = Console.ReadLine();

Console.WriteLine(moodobj.AnalyseMood(message));
