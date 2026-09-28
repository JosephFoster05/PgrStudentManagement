namespace PgrStudentManagement.Models;

public class Student
{
    public string StudentNumber { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";

    public string? Course { get; set; }

    public string? ModeOfStudy { get; set; }

    public DateTime? StartDate { get; set; }

    public Status Status { get; set; }

    public string? ThesisTitle { get; set; }

    

}