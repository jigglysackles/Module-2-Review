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
        Grades = new List<double>();
    }

    //methods

    public void AddGrade(double grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentException("Grade must be between 0 and 100", nameof(grade));
        }

        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        return (Grades.Any()) ? Grades.Average() : 0;
    }
}