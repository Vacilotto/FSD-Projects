class TeacherInterface
{

    // Methods created to search for a specific teacher usign 3 different criteria

    // Search Teacher by Name
    Teacher searchTeacherByName(List<Teacher> list, String name)
    {
        foreach (Teacher tc in list)
            if (tc.name == name)
            {
                return tc;
            }
        return null;
    }

    // Search Teacher by ID
    Teacher searchTeacherById(List<Teacher> list, String id)
    {
        foreach (Teacher tc in list)
            if (tc.id == id)
            {
                return tc;
            }
        return null;
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


    // Method created to remove a teacher from the file using 3 different criteria to remove
    List<Teacher> removeByName(List<Teacher> list, string name)
    {
        List<Teacher> support = new List<Teacher>();
        foreach (Teacher tc in list)
        {
            if (tc.name == name)
            {
                list.Remove(tc);
            }
        }

        return support;
    }

    List<Teacher> removeById(List<Teacher> list, string id)
    {
        List<Teacher> support = new List<Teacher>();
        foreach (Teacher tc in list)
        {
            if (tc.id == id)
            {
                list.Remove(tc);
            }
        }

        return support;
    }

    List<Teacher> removeByClass(List<Teacher> list, string clas)
    {
        List<Teacher> support = new List<Teacher>();
        foreach (Teacher tc in list)
        {
            if (tc.classandsection == clas)
            {
                list.Remove(tc);
            }
        }

        return support;
    }

    // Method for creation of new teacher
    List<Teacher> addTeacher(List<Teacher> list, string name, string id, string clas)
    {
        List<Teacher> support = new List<Teacher>();
        support.Add(new Teacher(name, id, clas));

        return support;
    }

    public static void listTeachers(List<Teacher> list){
        System.Console.WriteLine("Name;Id;Class");
        foreach(Teacher t in list){
            string s = t.oneLiner(); 
            System.Console.WriteLine(s);
        }
    }
}