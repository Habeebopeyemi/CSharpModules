using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

foreach (var name in studentNames)
{
    string currentStudent = name;
    int gradedAssignments = 0;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }else if(currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }else if(currentStudent == "Emma")
    {
        studentScores= emmaScores;
    }else if(currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    sumAssignmentScores = GetSum(studentScores);
    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
   
    int GetSum(int[] scores)
    {
        int result = 0;
        foreach (int score in scores)
        {
            gradedAssignments += 1;
            if(gradedAssignments <= currentAssignments)
                result += score;
            else
                result += score/10;
        }
        return result;
    }
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
