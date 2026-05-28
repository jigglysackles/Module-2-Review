namespace Module_2_Review;

// Create a class called Course
// The class will contain the following properties:
//      CourseName of type string
//      CourseCode of type string
// The class will contain the following field:
//      EnrolledStudents of type List
//  Create a default constructor and initialize the list in its scope.
//  Create a method to enroll students in a course.
//  Your method logic should make sure there are no duplicate student enrollments in a course.
//  Create a course and set the values of the properties.
//  Add at least two students to the course.
//  Display the course information and the students that are enrolled in it.

public class Course
{
    
    //properties
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    
    //fields
    private List<string> _enrolledStudents;
    
    //Constructors
    public Course()
    {
        _enrolledStudents = new List<string>();
    }
    
    
    //method

    public bool EnrollStudent(string studentId)
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
}