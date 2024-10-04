int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan"};

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 51, 87, 77, 68, 89, 75, 89 };
int[] loganScores = new int[] { 43, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";
Console.WriteLine("\n\t\t__  __  __  __  __  __  __  __  _");
Console.WriteLine("\t\t|Student\t|\tGrade\t|");
Console.WriteLine("\t\t|__  __  __  __ |__  __  __  __ |");

foreach(string name in studentNames)
{
    string currentStudent = name;

    if(currentStudent == "Sophia")
    {
        studentScores  = sophiaScores;
    }
    else if(currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if(currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if(currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradeAssignments = 0;

    foreach(int score in studentScores)
    {
        gradeAssignments += 1;

        if(gradeAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else 
        {
            sumAssignmentScores += score / 10;
        }

        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;        

        if(currentStudentGrade >= 97)
        {
            currentStudentLetterGrade = "A+";
        }
        else if(currentStudentGrade >= 93)
        {
            currentStudentLetterGrade = "A";
        }
        else if(currentStudentGrade >= 90)
        {
            currentStudentLetterGrade = "A-";
        }
        else if(currentStudentGrade >= 87)
        {
            currentStudentLetterGrade = "B+";
        }
        else if(currentStudentGrade >= 83)
        {
            currentStudentLetterGrade = "B";
        }
        else if(currentStudentGrade >= 80)
        {
            currentStudentLetterGrade = "B-";
        }
        else if(currentStudentGrade >= 77)
        {
            currentStudentLetterGrade = "C+";
        }
        else if(currentStudentGrade >= 73)
        {
            currentStudentLetterGrade = "C";
        }
        else if(currentStudentGrade >= 70)
        {
            currentStudentLetterGrade = "C-";
        }
        else if(currentStudentGrade >= 67)
        {
            currentStudentLetterGrade = "D+";
        }
        else if(currentStudentGrade >= 63)
        {
            currentStudentLetterGrade = "D";
        }
        else if(currentStudentGrade >= 60)
        {
            currentStudentLetterGrade = "D-";
        }
        else
        {
            currentStudentLetterGrade = "F";
        }

    }
    
    Console.WriteLine($"\t\t|{currentStudent}\t\t|{currentStudentGrade}\t|{currentStudentLetterGrade}\t|");
    Console.WriteLine("\t\t|__  __  __  __ | __  __  __  _ |\n");
}