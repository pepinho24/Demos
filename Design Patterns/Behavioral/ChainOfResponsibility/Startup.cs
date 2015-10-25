namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using ChainOfResponsibility.DeveloperTeams;

    public class Startup
    {
        public static void Main()
        {
            var requests = new List<SoftwareRequest>
            {
                new SoftwareRequest(1, "Easy task"),
                new SoftwareRequest(3, "Normal task"),
                new SoftwareRequest(5, "Difficult task"),
                new SoftwareRequest(6, "Impossible task"),
            };

            var devTeamFactory = new DeveloperTeamFactory();
            var devTeam = devTeamFactory.CreateAndAttachDeveloperTeams();

            foreach (var request in requests)
            {
                PrintSeparator();

                var result = devTeam.HandleRequest(request);

                Console.WriteLine("Request: ");
                Console.WriteLine("\tDifficulty: {0}", request.Difficulty);
                Console.WriteLine("\tContent: {0}", request.Content);

                Console.WriteLine("Developer Team Response: {0}", result);

                PrintSeparator();
            }
        }

        private static void PrintSeparator(char separator = '=')
        {
            Console.WriteLine(new string(separator, Console.BufferWidth));
        }
    }
}
