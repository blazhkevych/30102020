using System;
namespace _30102020
{
    abstract class Human
    {
        protected string FirstName;
        protected internal string LastName;
        private DateTime Birthday;
        public int Height;
        public Human(string LN, string FN, DateTime Bday, int H)
        {
            LastName = LN;
            FirstName = FN;
            Birthday = Bday;
            Height = H;
        }
        public Human(string LN, string FN) : this(LN, FN, DateTime.Now, 54)
        {
        }
        public override string ToString()
        {
            return $"|{LastName,15} |{FirstName,15} |{Birthday.ToShortDateString()}| {Height,4}|";
        }
        public virtual void Print()
        {
            Console.WriteLine("I am a human!!!");
        }
        public abstract void Think();
        public abstract void Work();
    }
    // sealed class Student : Human
    class Student : Human
    {
        public string Academy { get; set; }
        public Student(string LN, string FN, DateTime Bday, int H, string Acad)
            : base(LN, FN, Bday, H)
        {
            Academy = Acad;
        }
        public Student(string LN, string FN, string Acad)
            : base(LN, FN)
        {
            Academy = Acad;
        }
        public Student() : base("No LN", "No name")
        {
        }
        public override string ToString()
        {
            return base.ToString() + $"{Academy,10}|";
        }
        public void PrintStudent()
        {
            Console.WriteLine("I am a Student!!!");
        }
        public override void Print()
        {
            Console.WriteLine("I am a Student!!!");
        }
        public override void Think()
        {
            Console.WriteLine("I Think a Student!!!");
        }
        public override void Work()
        {
            Console.WriteLine("I Work a Student!!!");
        }
        new string FirstName;
    }
    /*class Tutor : Student
    {
    }*/
    // Teacher
    class Teacher : Human
    {
        public string Spec { get; set; }
        public Teacher(string LN, string FN, DateTime Bday, int H, string Acad)
            : base(LN, FN, Bday, H)
        {
            Spec = Acad;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Spec,10}|";
        }
        public void PrintTeacher()
        {
            Console.WriteLine("I am a Teacher!!!");
        }
        //public new  void Print()
        //{
        //    Console.WriteLine("I am a Teacher!!!");
        //}
        public sealed override void Print()
        {
            Console.WriteLine("I am a Teacher!!!");
        }
        public override void Think()
        {
            Console.WriteLine("I Think a Teacher!!!");
        }
        public override void Work()
        {
            Console.WriteLine("I Work a Teacher!!!");
        }
    }
    // Manager
    class Manager : Human
    {
        public string Department { get; set; }
        public Manager(string LN, string FN, DateTime Bday, int H, string Acad)
            : base(LN, FN, Bday, H)
        {
            Department = Acad;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Department,10}|";
        }
        public void PrintManager()
        {
            Console.WriteLine("I am a Manager!!!");
        }
        public override void Print()
        {
            Console.WriteLine("I am a Manager!!!");
        }
        public override void Think()
        {
            Console.WriteLine("I Think a Manager!!!");
        }
        public override void Work()
        {
            Console.WriteLine("I Work a Manager!!!");
        }
    }
    class Professor : Teacher
    {
        public Professor(string LN, string FN, DateTime Bday, int H, string Acad)
            : base(LN, FN, Bday, H, Acad)
        {
        }
        //public override void Print()
        //{
        //    Console.WriteLine("I am a Professor!!!");
        //}
    }
    class Program
    {
        static void Test3()
        {
            int i = 10;
            object obj = i; //boxing
            Console.WriteLine(obj);
            int a = (int)obj; //unboxing
                              // double a = (double)obj; //error
            Console.WriteLine(a);
            if (obj is int)
                Console.WriteLine("int");
            if (obj is int rr)
                Console.WriteLine(rr);
            object[] arr = { 10.5, 10, "Ivan", true };
            foreach (var item in arr)
                Console.Write(item + "\t");


        }
        static void Test2()
        {
            Human[] list ={
                new Teacher("Tomson", "Ivan",new DateTime(1996, 10, 25), 201, "C++"),
                new Student("Stepanov", "Stepan",new DateTime(2013, 5, 23), 196, "Step"),
                new Manager("Makarov", "Makar",new DateTime(2010, 2, 25), 123, "Buh"),
                new Student("Petrenko", "Petro",new DateTime(2000, 8, 13), 156, "Step"),
            };
            /*foreach (var item in list)
            {
                // Console.WriteLine(item);
                //1
                try
                {
                    ((Student)item).PrintStudent();
                }
                catch
                { }
                Teacher t = item as Teacher;
                if (t != null) t.PrintTeacher();
                if (item is Manager m)
                    m.PrintManager();
                ////-----------------------------
                //item.GetType();
                switch (item.GetType().Name)
                {
                    case "Teacher": ((Teacher)item).PrintTeacher();  break;
                    case "Student": ((Student)item).PrintStudent();  break;
                }
        }
          */
            //foreach (var item in list)
            //{
            //    item.Print();
            //}
            foreach (var item in list)
            {
                item.Think();
            }


        }
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            Test3();
        }
        static void Test1()
        {
            Console.WriteLine("Hello World!");
            //Human man = new Human("Ivanenko", "Ivan", new DateTime(2010, 1, 23), 140);
            //Human man2 = new Human("Ivanenko", "Inna");
            //Console.WriteLine(man);
            //Console.WriteLine(man2);
            Student student = new Student("Petrenko", "Petro",
                new DateTime(1996, 10, 25), 196, "It Step");
            Console.WriteLine(student);
            Student student2 = new Student("Petrenko", "Dima", "It Step");
            Console.WriteLine(student);
            Console.WriteLine(student2);
            student2.Print();
            Human h = new Student("Petrenko", "Petro",
                new DateTime(1996, 10, 25), 196, "It Step");
            // h = student; work
            // student = h; error
        }
    }
}