// Program.cs
Console.WriteLine("=== CareerQuest ===");
Console.WriteLine("Type 'help' for commands.");

var jobs = new List<JobApplication>();

while (true)
{
    Console.WriteLine("\ncommand: ");
    var input = Console.ReadLine()?.Trim() ?? "";

    if (string.IsNullOrWhiteSpace(input))
    {
        continue;
    }

    var cmd = input.ToLowerInvariant();

    switch (cmd)
    {
        case "help":
            Console.WriteLine("Commands:");
            Console.WriteLine(" help      - show this list");
            Console.WriteLine(" add-job   - add a job");
            Console.WriteLine(" list-jobs - show jobs");
            Console.WriteLine(" about     - about the app");
            Console.WriteLine(" quit      - exit the app");
            break;

        case "add-job":
            Console.Write("Company: ");
            var company = Console.ReadLine() ?? "";
            Console.Write("Role: ");
            var role = Console.ReadLine() ?? "";

            var job = new JobApplication { Company = company, Role = role };
            jobs.Add(job);
            Console.WriteLine("Added.");
            break;

        case "list-jobs":
            if (jobs.Count == 0)
            {
                Console.WriteLine("(no jobs yet)");
                break;
            }

            Console.WriteLine("Jobs: ");
            foreach (var j in jobs)
            {
                Console.WriteLine($"- {j.Company} | {j.Role}");
                
            }
            break;

        case "about":
            Console.WriteLine("CareerQuest v0.1 - track jobs and practice C#");
            break;

        case "quit":
            Console.WriteLine("Bye!");
            return;

        default:
            Console.WriteLine("Unknown command. Type 'help'.");
            break;
    }

}

class JobApplication
{
    public string Company { get; set; } = "";
    public string Role { get; set; } = "";
}