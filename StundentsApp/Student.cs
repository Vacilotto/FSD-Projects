public class Student {
    private string name {get;set;}
    private int id {get;set;}
    private string classandsection {get;set;}
    public Student (){
        name = "";
        id = 0;
        classandsection = "";
    }
    public Student(string nm, int Id, string clss){
        name = nm;
        id = Id;
        classandsection = clss;
    }

    public string oneLiner(){
        return $"{name};{id};{classandsection}";
    }
}