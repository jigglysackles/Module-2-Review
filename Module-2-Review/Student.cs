namespace Module_2_Review;

public class Student
{
    //Custom Constructor
    public Student(string name, int id)
    {
        Name = name;
        ID = id;
        Grades = new List<double>();
    }

    //default
    public Student()
    {
        Name = "none";
        ID = 0;
        Grades = new List<double>();
    }

    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; }


    //methods

    public void AddGrade(double grade)
    {
        if (grade < 0 || grade > 100) throw new ArgumentException("Grade must be between 0 and 100", nameof(grade));

        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        return Grades.Any() ? Grades.Average() : 0;
    }
}