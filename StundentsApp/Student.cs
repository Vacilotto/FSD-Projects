public class Teacher {
    public string name {get;set;}
    public string id {get;set;}
    public string classandsection {get;set;}
    public Teacher (){
        name = "";
        id = "";
        classandsection = "";
    }
    public Teacher(string nm, string Id, string clss){
        name = nm;
        id = Id;
        classandsection = clss;
    }

    public string oneLiner(){
        return $"{name};{id};{classandsection}";
    }
}