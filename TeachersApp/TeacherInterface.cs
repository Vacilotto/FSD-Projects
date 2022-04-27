class TeacherInterface
{

    // Methods created to search for a specific teacher usign 3 different criteria

    // Search Teacher by Name
    Teacher searchTeacherByName(List<Teacher> list, string name)
    {
        foreach (Teacher tc in list)
            if (tc.name == name)
            {
                return tc;
            }
        return null;
    }

    // Search Teacher by ID
    Teacher searchTeacherById(List<Teacher> list, string id)
    {
        foreach (Teacher tc in list)
            if (tc.id == id)
            {
                return tc;
            }
        return null;
    }

    static List<Teacher> updateTeacherId(List<Teacher> list, string id, string newId)
    {
        foreach (Teacher tc in list)
            if (tc.id == id)
            {
                tc.id = newId;
            }
        return list;
    }

    static List<Teacher> updateTeacherName(List<Teacher> list, string id, string name)
    {
        foreach (Teacher tc in list)
            if (tc.id == id)
            {
                tc.name = name;
            }
        return list;
    }

    static List<Teacher> updateTeacherClass(List<Teacher> list, string id, string classe)
    {
        foreach (Teacher tc in list)
            if (tc.id == id)
            {
                tc.classandsection = classe;
            }
        return list;
    }

    // Search all teachers who works with selected class
    List<Teacher> searchTeacherByClass(List<Teacher> list, String clas)
    {
        List<Teacher> teachers = new List<Teacher>();
        foreach (Teacher tc in list)
            if (tc.classandsection == clas)
            {
                teachers.Add(tc);
            }
        return teachers;
    }


    // Method created to remove a teacher from the file using 2 different criteria to remove
    static List<Teacher> removeByName(List<Teacher> list, string name)
    {
        foreach (Teacher tc in list.ToList())
        {
            if (tc.name == name)
            {
                list.Remove(tc);
            }
        }

        return list;
    }

    static List<Teacher> removeById(List<Teacher> list, string id)
    {
        foreach (Teacher tc in list.ToList())
        {
            if (tc.id == id)
            {
                list.Remove(tc);
            }
        }

        return list;
    }


    // Method for creation of new teacher
    public static List<Teacher> addTeacher(List<Teacher> list, string name, string clas)
    {
        var last = list.Last();
        int id = Int32.Parse(last.id);
        list.Add(new Teacher(name, (id + 1).ToString(), clas));
        return list;
    }

    //Method created to print the list of teachers on the console
    public static void listTeachers(List<Teacher> list)
    {
        System.Console.WriteLine("Name;Id;Class");
        foreach (Teacher t in list)
        {
            string s = t.oneLiner();
            System.Console.WriteLine(s);
        }
    }

    public static List<Teacher> Update(List<Teacher> listTeachers, string option)
    {
        if (option == "1")
        {
            System.Console.WriteLine("Insert the Id of the teacher you want to update: ");
            var id = Console.ReadLine();
            System.Console.WriteLine("Insert the new name you want to use");
            var name = Console.ReadLine();
            listTeachers = updateTeacherName(listTeachers, id, name);
        }

        else if (option == "2")
        {
            System.Console.WriteLine("Insert the Id of the teacher you want to update: ");
            var id = Console.ReadLine();
            System.Console.WriteLine("Insert the new ID you want to use");
            var newId = Console.ReadLine();
            listTeachers = updateTeacherId(listTeachers, id, newId);
        }

        else
        {
            System.Console.WriteLine("Insert the Id of the teacher you want to update: ");
            var id = Console.ReadLine();
            System.Console.WriteLine("Insert the new class you want to use");
            var classe = Console.ReadLine();
            listTeachers = updateTeacherClass(listTeachers, id, classe);
        }
        return listTeachers;
    }

    public static List<Teacher> Remove(List<Teacher> listTeachers, string option)
    {
        if (option == "1")
        {
            System.Console.WriteLine("Input the name of the teacher to be removed: ");
            string name = Console.ReadLine();
            listTeachers = removeByName(listTeachers, name);
        }
        else
        {
            System.Console.WriteLine("Input the ID of the teacher to be removed: ");
            string id = Console.ReadLine();
            listTeachers = removeById(listTeachers, id);
        }
        return listTeachers;
    }
}