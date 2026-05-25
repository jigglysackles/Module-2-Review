Objective

Create a C# console application that manages student grades. It should allow the following:

    Creates students
    Add grades
    Calculates a student’s average grade
    Displaying student information

What to remember

    You will be making frequent commits as you work!
    Make comments next to your code – explain what you are doing!
    Remember to use proper naming conventions for variables and methods. Variables will use camelCasing and methods will use PascalCasing.
    All of your methods will be made static.

Step 1: Create Console Application

    Create a console application.
    Initialize the correct folder in the command line with Git.

Step 2: Create Classes

    Create a class called Student
        Create a property called Name of type string
        Create a property called ID of type int
        Create a property called Grades of type List
            ***Be sure to initialize the list

Step 3: Create Methods

    Create a method called AddGrade in the Student class
        The method will accept one parameter.
            It will be of type double.
            Name the parameter grade
        The return type will be void
        In the scope of the method add the grade to your Grades list

    Create a method called AddGrade in the Student class
        The method will accept a parameter of type double[]
        Use the params keyword
        Name the parameter grades
        The return type will be void.
        In the scope of the method add the grades to your Grades list using this code:
            Grades.AddRange(grades);
        Stage and Commit your work.

    Create a method called CalculateAverageGrade in the Student class
        The method will accept no parameters
        The return type will be a double.
        In the scope of the method, calculate a student’s grade average (use the Grades list).
        If there are no grades in the Grades list, the method should return 0.
        Stage and Commit your work.

Step 4: Create a List

    In the main method, create a List of type Student.
        Name it students

Step 5: Create Instances

    In the main method, create 4 instances (also called objects) of type Student.
        Each instance represents a student.
        You may use one or all of the following types of syntax to create your instances:
            Dot notation
            Object initializer syntax
            Custom constructor

Step 6: Populate the List

    Populate the list with your instances.
        Stage and Commit your work.

Step 7: Call Methods

    Call the AddGrade() method twice for each instance (or student) you create.
        Be sure to invoke the overloads.
        Examples:
            student1.AddGrade(94.3);
            student1.AddGrade(90.0, 78.9, 95.4);

Step 8: Loop through your list and Display Info

    Loop through your list of students
        You will decide what type of loop to use.
        Display the id, name, the list of grades, and average grade for each student
        Use string interpolation to do this.
        You may need to use a nested loop to see all the grades for each individual student in the list

Step 9: Push your work to Github

    Remember the git workflow to do this!

Note: You may need to reference a previous lesson to help you.
BONUS: Course Information

    Create a class called Course
    The class will contain the following properties:
        CourseName of type string
        CourseCode of type string
    The class will contain the following field:
        EnrolledStudents of type List
        Create a default constructor and initialize the list in its scope.
    Create a method to enroll students in a course.
        Your method logic should make sure there are no duplicate student enrollments in a course.
    Create a course and set the values of the properties.
    Add at least two students to the course.
    Display the course information and the students that are enrolled in it.
