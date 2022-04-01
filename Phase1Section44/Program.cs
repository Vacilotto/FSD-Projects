// See https://aka.ms/new-console-template for more information
RunApp();

async void RunApp(){
    string [] student3A, student3B;
    student3A = new string[]{"A1", "A2", "A3", "A4", "A5", "A6"};
    student3B = new string[]{"B1", "B2", "B3", "B4", "B5", "B6"};
    /*
    string [] subjects = new string[6];
    subjects[0] = "Physics";
    subjects[1] = "Chemistry";
    subjects[2] = "Biology";
    subjects[3] = "Calculus";
    subjects[4] = "Computer Science";
    subjects[5] = "Algebra";

    int[] marks = new int[6];

    for(int i = 0; i<6; i++){
        marks[i] = 100- (i*3);
    } 
    */

    object[][] subjectGrades = new object[6][6]{{"Physics",100},{},{},{}};

    System.Console.WriteLine("Students of Class 3A");
    foreach(string s in student3A){
        System.Console.Write(s + ", ");
    }
    System.Console.WriteLine();

    System.Console.WriteLine("Students of Class 3B");
    foreach(string s in student3B){
        System.Console.Write(s + ", ");
    }
    System.Console.WriteLine( );

    /*
    System.Console.WriteLine("Marks for Student1");
    int total = 0 ;
    for(int i =0;i < 6; i++){
        total += marks[i];
        System.Console.WriteLine(subjects[i] + " = "+marks[i]);
    }
    System.Console.WriteLine($"Grades average = {total/6}%");
    */
}