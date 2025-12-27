// Code created while following the Microsoft Learn Module
// Guided project - Calculate final GPA
// Completed in concurrence with the freeCodeCamp certification

// Variable initialization
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//  Grade points initialization
int gradeA = 4;
int gradeB = 3;
int gradeC = 2;
int gradeD = 1;
int gradeF = 0;

// Grades for each course
int course1Grade = gradeA; 
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// Create a varaible to hold total credit hours
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Create a variable to hold total grade points
int totalGradePoints = 0;
totalGradePoints += course1Grade * course1Credit;
totalGradePoints += course2Grade * course2Credit;
totalGradePoints += course3Grade * course3Credit;
totalGradePoints += course4Grade * course4Credit;
totalGradePoints += course5Grade * course5Credit;

// Calculate and store GPA
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// Display information - formatted
Console.WriteLine($"Student Name: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t{gradePointAverage:F2}");
