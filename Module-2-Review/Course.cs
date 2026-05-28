namespace Module_2_Review;

public class Course
{
    //fields
    private readonly List<int> _enrolledStudents;

    
    //Constructors
    public Course()
    {
        _enrolledStudents = new List<int>();
    }

    
    //properties
    public string CourseName { get; set; }
    public string CourseCode { get; set; }


    //method

    public bool EnrollStudent(int studentId)
    {
        if (_enrolledStudents.Contains(studentId))
        {
            Console.WriteLine($"{studentId} has already enrolled in the course.");
            return false;
        }

        _enrolledStudents.Add(studentId);
        Console.WriteLine($"Student: {studentId} has been successfully enrolled in {CourseName}:{CourseCode}.");
        return true;
    }

    public void ShowCourseEnrollements()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine($"Student IDs Enrolled in C-Sharp-101: {string.Join(", ", _enrolledStudents)}");
    }
}