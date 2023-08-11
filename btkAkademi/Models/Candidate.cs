namespace btkAkademi.Models
{
    public class Candidate
    {
        public string? Email { get; set; } = string.Empty;

        public string? FirstName { get; set; } = string.Empty;

        public string? Lastname { get; set; } = string.Empty;

        public string? FullName => $"{FirstName} {Lastname?.ToUpper()}";

        public int? Age { get; set; };

        public string? SelectedCourse { get; set; } = string.Empty;


        public dateTime ApplyAt { get; set; };

        public Candidate 
        {
        ApplyAt=DateTime.Now;
        }
    }
}