// See https://aka.ms/new-console-template for more information
using Project_15_6_6;

var classes = new[]
{
     new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
     new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
     new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
};

var allStudents = GetAllStudents(classes);

foreach (var student in allStudents)
{
    Console.WriteLine(student);
}

static List<string> GetAllStudents(Classroom[] classes)
{
    List<string> allStudents = new List<string>();

    foreach (var student in classes[0].Students)
    {
        allStudents.Add(student);
    }

    foreach (var student in classes[1].Students)
    {
        allStudents.Add(student);
    }

    foreach (var student in classes[2].Students)
    {
        allStudents.Add(student);
    }

    return allStudents;
}
