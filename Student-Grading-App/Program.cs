using System;
// See https://aka.ms/new-console-template for more information

/*string[] studentList;
studentList = new string [] {"Peter","Paul", "Mary", "Saul"};
*/

/*
    VERSION 2 Upgrade OF THE STUDENT GRADING APP


 Random rand = new Random();
//initialize current graded assignments
int gradedAssignments = 5; //number to divde by to determine final grade including extra credit
int extraCredit = 10;

//arrays to hold scores
//will iterate thru arrays to determine final grade

int[] bulmaScores = {93, 87, 98, 95, 100};
int[] vegetaScores = {80, 83, 82, 88, 85};
int[] gokuScores = {84, 96, 73, 85, 79};
int[] piccoloScores = {90, 92, 98, 100, 97};

//foreach loop to sum first Student's assignment grades (Bulma)
int currentGrade = 0;
int counter = 0;

void SetToZero(){
    if(currentGrade !=0 && counter !=0){
        currentGrade = 0;
        counter = 0;
    }
}
//initialize variables for final grades & extra credit
decimal bulmaFinalGrade;
decimal vegetaFinalGrade;
decimal gokuFinalGrade;
decimal piccoloFinalGrade;
//
bool bulmaExtraCredit = true;
bool vegetaExtraCredit = false;
bool gokuExtraCredit = false;
bool piccoloExtraCredit = true;
// -------------------------------

string letterGrade;
string bulmaLetterGrade;
string vegetaLetterGrade;
string gokuLetterGrade;
string piccoloLetterGrade;

foreach(int i in bulmaScores){
    currentGrade += i;
    //adding extra credit amount if needed
    if(bulmaScores[counter] == 4 && bulmaExtraCredit == true){
        currentGrade = currentGrade + extraCredit; 
    }
   counter++;
}
//sets final grade
 bulmaFinalGrade = currentGrade / gradedAssignments;

  switch(bulmaFinalGrade){
        case >= 96:
        letterGrade = "A+";
        break;

        case >= 94:
        letterGrade = "A";
        break;

        case >= 90:
        letterGrade = "A-";
        break;

        case >= 86:
        letterGrade = "B+";
        break;

        case >= 84:
        letterGrade = "B";
        break;

        case >= 80:
        letterGrade = "B-";
        break;

        case >= 76:
        letterGrade = "C+";
        break;

        case >= 74:
        letterGrade = "C";
        break;

        case >= 70:
        letterGrade = "C-";
        break;

        case >= 66:
        letterGrade = "D+";
        break;

        case >= 64:
        letterGrade = "D";
        break;

        case >= 60:
        letterGrade = "D-";
        break;

        default:
        letterGrade = "F";
        break;
        }     

    bulmaLetterGrade = letterGrade; 

//resets currentGrade to zero 
SetToZero();

foreach(int i in vegetaScores){
    currentGrade = currentGrade + i;
    //adding extra credit amount if needed

    if(vegetaScores[counter] == 4 && vegetaExtraCredit == true){
        currentGrade = currentGrade + extraCredit;
    }
    counter++;
}
//sets final grade
 vegetaFinalGrade = currentGrade / gradedAssignments;
 switch(vegetaFinalGrade){
        case >= 96:
        letterGrade = "A+";
        break;

        case >= 94:
        letterGrade = "A";
        break;

        case >= 90:
        letterGrade = "A-";
        break;

        case >= 86:
        letterGrade = "B+";
        break;

        case >= 84:
        letterGrade = "B";
        break;

        case >= 80:
        letterGrade = "B-";
        break;

        case >= 76:
        letterGrade = "C+";
        break;

        case >= 74:
        letterGrade = "C";
        break;

        case >= 70:
        letterGrade = "C-";
        break;

        case >= 66:
        letterGrade = "D+";
        break;

        case >= 64:
        letterGrade = "D";
        break;

        case >= 60:
        letterGrade = "D-";
        break;

        default:
        letterGrade = "F";
        break;
        }     

    vegetaLetterGrade = letterGrade;

//resets currentGrade to zero 
SetToZero();

foreach(int i in gokuScores){
    currentGrade = currentGrade + i;
    //adding extra credit amount if needed

    if(gokuScores[counter] == 4 && gokuExtraCredit == true){
        currentGrade = currentGrade + extraCredit;
    }
    counter++;
}
//sets final grade
gokuFinalGrade = currentGrade / gradedAssignments;
switch(gokuFinalGrade){
        case >= 96:
        letterGrade = "A+";
        break;

        case >= 94:
        letterGrade = "A";
        break;

        case >= 90:
        letterGrade = "A-";
        break;

        case >= 86:
        letterGrade = "B+";
        break;

        case >= 84:
        letterGrade = "B";
        break;

        case >= 80:
        letterGrade = "B-";
        break;

        case >= 76:
        letterGrade = "C+";
        break;

        case >= 74:
        letterGrade = "C";
        break;

        case >= 70:
        letterGrade = "C-";
        break;

        case >= 66:
        letterGrade = "D+";
        break;

        case >= 64:
        letterGrade = "D";
        break;

        case >= 60:
        letterGrade = "D-";
        break;

        default:
        letterGrade = "F";
        break;
        }     

    gokuLetterGrade = letterGrade;

//resets currentGrade to zero 
SetToZero();

foreach(int i in piccoloScores){
    currentGrade = currentGrade + i;
    //adding extra credit amount if needed

    if(piccoloScores[counter] == 4 && piccoloExtraCredit == true){
        currentGrade = currentGrade + extraCredit;
    }
    counter++;
}
//sets final grade
piccoloFinalGrade = currentGrade / gradedAssignments;

switch(piccoloFinalGrade){
        case >= 96:
        letterGrade = "A+";
        break;

        case >= 94:
        letterGrade = "A";
        break;

        case >= 90:
        letterGrade = "A-";
        break;

        case >= 86:
        letterGrade = "B+";
        break;

        case >= 84:
        letterGrade = "B";
        break;

        case >= 80:
        letterGrade = "B-";
        break;

        case >= 76:
        letterGrade = "C+";
        break;

        case >= 74:
        letterGrade = "C";
        break;

        case >= 70:
        letterGrade = "C-";
        break;

        case >= 66:
        letterGrade = "D+";
        break;

        case >= 64:
        letterGrade = "D";
        break;

        case >= 60:
        letterGrade = "D-";
        break;

        default:
        letterGrade = "F";
        break;
        }     

    piccoloLetterGrade = letterGrade;

//resets currentGrade to zero 
SetToZero();

//output
Console.WriteLine("Student\t\tScore\tGrade");
Console.WriteLine($"Bulma:\t\t {bulmaFinalGrade}\t{bulmaLetterGrade}");
//Console.WriteLine("Press Enter to continue to the next student grade.");
//Console.ReadLine();
Console.WriteLine("Student\t\tScore\tGrade");
Console.WriteLine($"Vegeta:\t\t {vegetaFinalGrade}\t{vegetaLetterGrade}");
//Console.WriteLine("Press Enter to continue to the next student grade.");
//Console.ReadLine();
Console.WriteLine("Student\t\tScore\tGrade");
Console.WriteLine($"Goku:\t\t {gokuFinalGrade}\t{gokuLetterGrade}");
//Console.WriteLine("Press Enter to continue to the next student grade.");
//Console.ReadLine();
Console.WriteLine("Student\t\tScore\tGrade");
Console.WriteLine($"Piccolo:\t{piccoloFinalGrade}\t{piccoloLetterGrade}");
Console.WriteLine("Press Enter to continue.");
Console.ReadLine();

*/

/* 

Version 1
*/

//assignments graded
int currentAssignments = 5;

//graded assignmnet scores for each student in arrays to loop thru later

int[] sophiaScores = {93, 87, 98, 95, 100};
int[] nicolasScores = {80, 83, 82, 88, 85};
int[] zahirahScores = {84, 96, 73, 85, 79};
int[] jeongScores = {90, 92, 98, 100, 97};

//itializing sum variables for each students total for all graded assigments combined  
int sophiaSum = sophiaScores[0] + sophiaScores[1] + sophiaScores[2] + sophiaScores[3] + sophiaScores[4];
int nicolasSum = nicolasScores[0] + nicolasScores[1] + nicolasScores[2] + nicolasScores[3] + nicolasScores[4];
int zahirahSum = zahirahScores[0] + zahirahScores[1] + zahirahScores[2] + zahirahScores[3] + zahirahScores[4];
int jeongSum = jeongScores[0] + jeongScores[1] + jeongScores[2] + jeongScores[3] + jeongScores[4];

//variables for average score
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;
//Create the output for viewing each student's total grades put together (not the average)
Console.WriteLine($" Student \t Grade \n Sophia: \t {sophiaScore} \t A \n Nicolas: \t {nicolasScore} \t B \n Zahirah: \t {zahirahScore} \t B \n Jeong: \t {jeongScore} \t A");
Console.ReadLine();