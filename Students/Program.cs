using System;

class Program
{
    public struct Student
    {
        public int idnum;
        public string firstName;
        public string lastName;
        public double score;
        public double over;

    }
    enum Remark
    {
        Poor = 1,
        Fair = 2,
        Good = 3,
        Excellent = 4,
    }

    static void Main()
    {
        try
        {
            Student s;
            Console.WriteLine("Enter your ID Number");
            s.idnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your First Name");
            s.firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            s.lastName = Console.ReadLine();

            Console.WriteLine("Enter your Score");
            s.score = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the  Overall Score");
            s.over = double.Parse(Console.ReadLine());


            Console.WriteLine("Name: {0}  {1} {2}", s.firstName, s.lastName, s.idnum);
            Console.WriteLine("Grade: {0} ", s.score);
            double grade = (s.score / s.over) * 100;


            if (grade >= 95)
            {
                int exce = (int)Remark.Excellent;
                Console.WriteLine("Remarks: {0}", exce);
            }
            else if (grade >= 85 && grade < 95)
            {
                int good = (int)Remark.Fair;
                Console.WriteLine("Remarks: {0}", good);
            }
            else if (grade >= 75 && grade < 85)
            {
                int fair = (int)Remark.Fair;
                Console.WriteLine("Remarks: {0}", fair);
            }
            else if (grade < 75)
            {
                int poor = (int)Remark.Fair;
                Console.WriteLine("Remarks: {0}", poor);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter valid characters only.");
        }
    }

}