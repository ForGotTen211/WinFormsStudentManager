namespace StudentsManager;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Group { get; set; }
    public float AverageScore { get; set; }
    public DateTime AdmissionDate { get; set; }
}