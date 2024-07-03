using System;
using System.Collections;
using System.Collections.Generic;

class Student{
    public int Id;
    public String name;
}

public class nonGene{
    public void Arrayl(){
        ArrayList arr = new ArrayList();

        arr.Add(1);
        arr.Add(5);
        arr.Add(10);

        var students = new List<Student>(){
            new Student(){Id = 1, name = "n1"},
            new Student(){Id = 2, name = "n2"},
            new Student(){Id = 3, name = "n3"}
        };

        
    }
}

// public class nonGene_class{
//     public static void Main(){
//         nonGene obj = new nonGene();
//         obj.Arrayl();
//     }
// }



