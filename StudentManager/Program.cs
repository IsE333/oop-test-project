using Entities;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Student> students = new List<Student>();

//Student student = new Student("Enes Zeren");
//Console.WriteLine($"öğrenci ismi: {student.Name}");

while (true)
{
    Console.WriteLine("Yönetim Paneli \n işlem seçin:");
    Console.WriteLine("1. Öğrencileri Listele");
    Console.WriteLine("2. Öğrenci Ekle");
    Console.WriteLine("3. programı kapat");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            GetStudent(students);
            break;
        case "2":
            AddStudent(students);
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Geçersiz işlem");
            break;
    }
}

bool AddStudent(List<Student> students)
{
    try
    {
        Console.Write("Öğrenci ismini giriniz: ");
        string name = Console.ReadLine();

        Console.WriteLine("Öğrenci Ekleniyor...");
        Thread.Sleep(1000);

        Student student = new Student(name);
        students.Add(student);

        Console.WriteLine("Öğrenci Eklendi.");
        return true;
    }
    catch (Exception)
    {
        Console.WriteLine("Öğrenci eklenirken bir hata oluştu.");
        return false;
        //throw;
    }
}

void GetStudent(List<Student> students)
{
    if (students.Count == 0)
    {
        Console.WriteLine("Henüz öğrenci eklenmemiş.");
        return;
    }

    Console.WriteLine("Öğrenci listesi: \n");

    foreach (var student in students)
    {
        Console.WriteLine($"Öğrenci Adı: {student.Name} -- ortalama: {student.Mathemathics.Average} -- başarı durumu: {student.Mathemathics.IsPass()}");
    }

    Console.WriteLine($"Toplam öğrenci sayısı: {students.Count}");
}