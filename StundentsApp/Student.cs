public class Student {
    private string name {get;set;}
    private string id {get;set;}
    private string classandsection {get;set;}
    public Student (){
        name = "";
        id = "";
        classandsection = "";
    }
    public Student(string nm, string Id, string clss){
        name = nm;
        id = Id;
        classandsection = clss;
    }

    public string oneLiner(){
        return $"{name};{id};{classandsection}";
    }
}