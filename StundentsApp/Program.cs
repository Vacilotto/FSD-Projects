// See https://aka.ms/new-console-template for more information

using System.IO;

Main();

void Main(){
    string fileName = Directory.GetCurrentDirectory()+"\\data.txt";
    List<Teacher> listTeachers = null;
    if(File.Exists(fileName)){
        string[] lines = File.ReadAllLines(fileName);
        listTeachers = generateList(lines);
    }
    else{System.Console.WriteLine("File isn't present on the specified path.\n"+
    $"Specified file path: {fileName}");}
    
    string[] textToFile = genListToSave(listTeachers);
    File.Delete(fileName);
    

    updateFile(fileName,textToFile);


}


//Method created to read the file and generate a List of Teachers
List<Teacher> generateList(string[] list){
    
    List<Teacher> lista = new List<Teacher>();
    
    foreach(string line in list){
            string[] str = line.Split(';');
            Teacher stud = new Teacher(str[0],str[1],str[2]);
            lista.Add(stud);
        }
        lista.RemoveAt(0);
    return lista;
}

//Method created to generate an array of strings that'll be added in the file to save.
string[] genListToSave(List<Teacher> list){
    List<string> text = new List<string>();
    text.Add("Name;Id;Class");
    foreach(Teacher stud in list){
        string s = $"{stud.name};{stud.id};{stud.classandsection}";
        text.Add(s);
    }
    return text.ToArray();
}

//Method create to update the file using the file path and the list of Teachers already in string formats(use genListToSave if needed)
void updateFile(string path, string[] list){
    using (StreamWriter sw = File.CreateText(path))
            {
                foreach(string s in list){
                    sw.WriteLine(s);
                }
            }	

}

// Method created to search for a specific teacher

// Method created to remove a teacher from the file

// Method created to act as the main menu for the application