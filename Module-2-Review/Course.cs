namespace Module_2_Review;

public class Course
{
    // Create a class called Course
    //     The class will contain the following properties:
    // CourseName of type string
    //     CourseCode of type string
    //     The class will contain the following field:
    // EnrolledStudents of type List
    // Create a default constructor and initialize the list in its scope.
    //     Create a method to enroll students in a course.
    //     Your method logic should make sure there are no duplicate student enrollments in a course.
    //     Create a course and set the values of the properties.
    //     Add at least two students to the course.
    //     Display the course information and the students that are enrolled in it.
    
    
    
    //properties
    public string CourseName { get; set; } = "";
    public string CourseCode { get; set; } = "";
    
    //fields
    public List<String> _enrolledStudents = new List<String>();

    
    //Constructors
    public Course(List<String> enrolledStudents)
    {
        _enrolledStudents = enrolledStudents ?? new List<string>();
    }
    
    
}