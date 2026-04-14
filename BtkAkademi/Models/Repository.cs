namespace BtkAkademi.Models
{
    public static class Repository
    {
        public static List<Candidate> applications = new();
        
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}