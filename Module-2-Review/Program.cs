using Module_2_Review;

var grades = new List<double>();
var students = new List<Student>();

var tony = new Student();
tony.ID = 123;
tony.Name = "Tony";


var sam = new Student();
sam.ID = 456;
sam.Name = "Sam";

var frank = new Student();
frank.ID = 789;
frank.Name = "Frank";

var choc = new Student();
choc.ID = 987;
choc.Name = "Choc";

students.Add(tony);
students.Add(sam);
students.Add(frank);
students.Add(choc);


tony.AddGrade(23.2);
tony.AddGrade(55.7, 20.1, 8.8, 78.6);

sam.AddGrade(99);
sam.AddGrade(91.7, 89.7, 32.7, 39.7);

frank.AddGrade(67.3);
frank.AddGrade(65.2, 77.7, 48.1, 11.1);

choc.AddGrade(92.4);
choc.AddGrade(54.4, 87.6, 94.1, 27.9);


foreach (var student in students)
{
    Console.WriteLine($"Student: {student.Name} (ID: {student.ID})");
    Console.WriteLine($"Grades: {string.Join(", ", student.Grades)}");
    Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}\n");
}

