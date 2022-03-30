using System.Text;

DoApp();

void DoApp(){
    char[] s1= {'L','e','t','t','e','r','s'};
    string stringOfChar = new string(s1);

    Console.WriteLine(stringOfChar);
    foreach (char c in stringOfChar)
        Console.Write(c);
    Console.WriteLine();
    Console.WriteLine(stringOfChar[2]);

    string sentence = "This is a sentence";
    Console.WriteLine(sentence);
    foreach (char c in sentence)
        Console.Write(c);
    Console.WriteLine();
    Console.WriteLine(sentence[3]);

    sentence += ", that has additional content";
    Console.WriteLine(sentence);
    foreach (char c in sentence)
        Console.Write(c);
    Console.WriteLine();
    Console.WriteLine(sentence[20]);

    Console.WriteLine("The sentence contains the letter h : "+ sentence.Contains('h'));
    Console.WriteLine("The sentence contains the letter te : "+ sentence.Contains("te"));

    Console.WriteLine(sentence.ToUpper());
    Console.WriteLine(sentence.ToLower());

    string[] words = sentence.Split(" ");
    foreach(string s in words)
        Console.Write(s);
    Console.WriteLine();
    StringBuilder sb = new StringBuilder();
    foreach(string s in words){
        sb.Append(s + "; ");
    }
    sb.Length-=2;
    Console.WriteLine(sb.ToString());
}
