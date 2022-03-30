using System.IO;

DoApp();

void DoApp(){
    string dir = Directory.GetCurrentDirectory();
    string fileName = dir+"\\data.txt";

    if(File.Exists(fileName))
        System.Console.WriteLine($"{fileName} exists");
    else
        System.Console.WriteLine($"{fileName} does not exists");

    using(StreamWriter sw = new StreamWriter(fileName)){
        sw.WriteLine("linha 1");
        sw.WriteLine("linha 2");
    }

    System.Console.WriteLine($"{fileName} created");

    string[] lines = File.ReadAllLines(fileName);

    foreach(string s in lines)
        System.Console.WriteLine(s); 

    string fileText = File.ReadAllText(fileName);
    System.Console.WriteLine(fileText);

    File.Delete(fileName);
    System.Console.WriteLine($"{fileName} has been deleted");

}