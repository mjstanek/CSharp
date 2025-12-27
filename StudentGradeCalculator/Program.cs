// Created while following along with the Microsoft Learn Course:
// Guided project - Develop foreach and if-elseif-else structures to process array data in C#
// In concurrence with the freeCodeCamp certification path

/* The goal of this program is to use branching and looping statements
 * to process array data to calculate a student's grade.
 * Overview for version 1.0:
 * Four Students, each with five exams
 * The overall exam score is the average of the five exams
 * Extra Credit is in play, but are worth 10% of an exam score
 * Extra Credit is to be added to the total exam score before averaging
 * Letter grades will need to be assigned
 * Application must support adding other students or assignments with minimal impact
 * Overview for version 1.1:
 * Create a more in depth score report:
 * Exam Score \t Overall Grade \t Extra Credit
 */

/*
 * Proof of concept that I can do If-Else If-Else conditions for Letter Grade
int score = 81;
int divScore = score / 10;
int modScore = score % 10;
Console.WriteLine($"{score} divided by 10 is {divScore} and modulus 10 is {modScore}");
*/

using System.Security.Cryptography.X509Certificates;

int currentAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
/*
 * v 1.0 unit tests
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };
*/

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string studentName in studentNames)
{
    string currentStudent = studentName;
    string currentStudentLetter = "";
    string currentStudentModifier = "";

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }
    /*
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    */
    else
        continue;
    decimal sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCredit = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        if (gradedAssignments < currentAssignments)
        {
            sumAssignmentScores += score;
            currentStudentExamScore += score;
        }
        else
        {
            sumAssignmentScores += (score * .1m);
            currentStudentExtraCredit += (score * .1m);
        }
        gradedAssignments++;
    }
    currentStudentExamScore /= currentAssignments;
    currentStudentExtraCredit /= currentAssignments;
    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    int currentStudentGradeDivided = (int)currentStudentGrade / 10;
    if (currentStudentGradeDivided >= 9)
    {
        currentStudentLetter = "A";
    }
    else if (currentStudentGradeDivided == 8)
    {
        currentStudentLetter = "B";
    }
    else if (currentStudentGradeDivided == 7)
    {
        currentStudentLetter = "C";
    }
    else if (currentStudentGradeDivided == 6)
    {
        currentStudentLetter = "D";
    }
    else
    {
        currentStudentLetter = "F"; 
    }
    
    int currentStudentGradeModulus = (int)currentStudentGrade % 10;

    if (currentStudentGradeModulus >= 7 || 
        (currentStudentGradeModulus == 0 && currentStudentLetter == "A"))
    {
        currentStudentModifier = "+";
    }
    else if (currentStudentGradeModulus <= 2)
    {
        currentStudentModifier = "-";
    }

        Console.WriteLine($"{currentStudent}:\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetter}{currentStudentModifier}\t\t{currentStudentExtraCredit}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

// Technically the final output was different from the Microsoft desired output, but
// I kinda prefer the way I had it as an actual breakdown.
