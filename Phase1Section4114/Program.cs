using System.IO;

DoApp();

void DoApp(){
    string fileName = Directory.GetCurrentDirectory()+"\\data.txt";
    if(File.Exists(fileName)){
        string[] lines = File.ReadAllLines(fileName);
        foreach(string line in lines){
            string[] str = line.Split(';');
            System.Console.WriteLine($"Name: {str[0]}; Id: {str[1]}; Class: {str[2]}");
        }
    }
    else{System.Console.WriteLine("File isn't present on the specified path.\n"+
    $"Specified file path: {fileName}");}
}