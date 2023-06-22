using MoodAnalyser2;

Console.WriteLine("Welcome to Mood Analyser Program");
MoodAanalyser1 moodobj = new MoodAanalyser1();

Console.WriteLine("Enter your Mood:");
string message = Console.ReadLine();

Console.WriteLine(moodobj.AnalyseMood(message));
