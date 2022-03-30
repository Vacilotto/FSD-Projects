// See https://aka.ms/new-console-template for more information
DoApp();

void DoApp(){
    char[] s1= {'L','e','t','t','e','r','s'};
    string stringOfChar = new string(s1);

    System.Console.WriteLine(stringOfChar);
    foreach (char c in stringOfChar)
        System.Console.Write(c);
    System.Console.WriteLine();
    System.Console.WriteLine(stringOfChar[2]);

    string sentence = "This is a sentence";
    System.Console.WriteLine(sentence);
    foreach (char c in sentence)
        System.Console.Write(c);
    System.Console.WriteLine();
    System.Console.WriteLine(sentence[3]);

    sentence += ", that has additional content";
    System.Console.WriteLine(sentence);
    foreach (char c in sentence)
        System.Console.Write(c);
    System.Console.WriteLine();
    System.Console.WriteLine(sentence[20]);
}