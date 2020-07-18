using StateBehaviorPattern.Model;
using StateBehaviorPattern.States;
using System;

namespace StateBehaviorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Document");
            var document = new Document();
            document.MoveTo<ReadyToProcessState>();
            document.MoveTo<ProcessedState>();
            document.MoveTo<ArchivedState>();
            document.MoveTo<NewState>();
        }
    }
}
