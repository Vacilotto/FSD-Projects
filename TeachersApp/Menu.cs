﻿// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Windows;

Main();

void Main()
{
    mainMenu();
    /*
    string fileName = Directory.GetCurrentDirectory() + "\\data.txt";
    List<Teacher> listTeachers = new List<Teacher>();
    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);
        listTeachers = generateList(lines);
    }
    else
    {
        System.Console.WriteLine("File isn't present on the specified path.\n" +
    $"Specified file path: {fileName}");
    }

    string[] textToFile = genListToSave(listTeachers);
    File.Delete(fileName);

    updateFile(fileName, textToFile);
    */

}

//Method to open and read the file, returning a list of teachers
List<Teacher> loadList(string fileName)
{
    List<Teacher> listTeachers = new List<Teacher>();
    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);
        listTeachers = generateList(lines);
    }
    else
    {
        System.Console.WriteLine("File isn't present on the specified path.\n" +
    $"Specified file path: {fileName}");
        return null;
    }
    return listTeachers;
}


//Method created to read the file and generate a List of Teachers
List<Teacher> generateList(string[] list)
{

    List<Teacher> lista = new List<Teacher>();

    foreach (string line in list)
    {
        string[] str = line.Split(';');
        Teacher stud = new Teacher(str[0], str[1], str[2]);
        lista.Add(stud);
    }
    lista.RemoveAt(0);
    return lista;
}

//Method created to generate an array of strings that'll be added in the file to save.
string[] genListToSave(List<Teacher> list)
{
    List<string> text = new List<string>();
    text.Add("Name;Id;Class");
    foreach (Teacher teacher in list)
    {
        string s = $"{teacher.name};{teacher.id};{teacher.classandsection}";
        text.Add(s);
    }
    return text.ToArray();
}

//Method create to update the file using the file path and the list of Teachers already in string formats(use genListToSave if needed)
void updateFile(string path, string[] list)
{
    using (StreamWriter sw = File.CreateText(path))
    {
        foreach (string s in list)
        {
            sw.WriteLine(s);
        }
    }

}

//Method created to generate a new file if the original one can't be foudn
void createFile(string fileName)
{
    using (StreamWriter sw = File.CreateText(fileName))
    {
        sw.WriteLine("Name;Id;Class");
    }
}


// Method created to act as the main menu for the application
void mainMenu()
{
    string fileName = Directory.GetCurrentDirectory() + "\\data.txt";

    System.Console.WriteLine("Welcome to Rainbow School system.");
    System.Console.WriteLine($"We're going to load the Teachers list from {fileName} \n");
    //Loading the list and storing it in the memory
    List<Teacher> listTeachers = loadList(fileName);

    //Working in the case of the file being deleted
    if (listTeachers == null)
    {
        System.Console.WriteLine("Oops! It seems the file doesn't exist, do you want to generate a new one?(y/n)");
        while (true)
        {

            string ans = Console.ReadLine();
            if (ans == "y" || ans == "Y")
            {
                createFile(fileName);
            }
            else if (ans == "n" || ans == "N")
            {
                System.Console.WriteLine("Closing the app.");
                Environment.Exit(1);
            }
            else
            {
                System.Console.WriteLine("Invalid input, please use y, Y, n or N. Please try again.");
                System.Console.WriteLine();
            }
        }
    }
    //Executing the main menu options which are: Listing, Updating, Adding and removing.
    while (true)
    {
        System.Console.WriteLine("\nPlease select one of below options:\n 1 - List all teachers\n 2 - Add a new teacher\n 3 - Remove a teacher\n 4 - Update an existing teacher" +
            "\n 5 - Close application");
        string ans = Console.ReadLine();
        if (ans == null || !"12345".Contains(ans))
        {
            System.Console.WriteLine("Invalid option, please select one of the valid options below.");
        }
        else
        {
            switch (ans)
            {
                case "1":
                    TeacherInterface.listTeachers(listTeachers);
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":
                    string[] textToFile = genListToSave(listTeachers);
                    File.Delete(fileName);

                    updateFile(fileName, textToFile);
                    Environment.Exit(1);
                    break;
            }
        }
    }



}