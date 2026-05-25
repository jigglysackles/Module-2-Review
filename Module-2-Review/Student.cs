namespace Module_2_Review;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; }
    
    
    //default
    public Student()
    {
    }
    
    //Custom Constructor
    public Student(string name, int id)
    {
        Name = name;
        ID = id;
    }
    
    //methods
    
    public void double AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    
    public void double[] AddGrade(double[] grades)
    {
        Grades.Add(grades);
    }
    
    
    

    
}