// Write-along code from the Microsoft Learn Module
// Guided project - Calculate and print student grades
// Completed in concurrence with the freeCodeCamp certification

// The goal of this project is to create a console app to calculate
// and print the grades of students based on their scores.
// The final score is a simple average.

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Declare and initialize sum variables as 0
int sophiaSum = 0;
int nicolasSum = 0;
int zahirahSum = 0;
int jeongSum = 0;

// Add the scores for each student
sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Calculate the average score for each student
// by dividing the sum by the number of assignments
decimal sophiaAverage;
decimal nicolasAverage;
decimal zahirahAverage;
decimal jeongAverage;

sophiaAverage = (decimal)sophiaSum / currentAssignments;
nicolasAverage = (decimal)nicolasSum / currentAssignments;
zahirahAverage = (decimal)zahirahSum / currentAssignments;
jeongAverage = (decimal)jeongSum / currentAssignments;

// Display the final score for each student
Console.WriteLine("Final Scores:");
Console.WriteLine($"Sophia: {sophiaAverage} A");
Console.WriteLine($"Nicolas: {nicolasAverage} B");
Console.WriteLine($"Zahirah: {zahirahAverage} B");
Console.WriteLine($"Jeong: {jeongAverage} A");
