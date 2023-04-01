using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        DateTime date1 = new DateTime(2023, 04, 10, 8, 45, 00);
        DateTime date2 = new DateTime(2023, 05, 01, 8, 00, 00);
        DateTime date3 = new DateTime(2023, 05, 06, 9, 00, 00);

        Reception reception = new Reception("reception.info@email.com","Receiving New Students at BYU-I", "Getting enrolled for courses in person.", date1, "BYU-IDAHO Registration Office", "Rexbourg", "IDAHO");
        Lecture lecture = new Lecture("The Psychology of Self-Deciet", "The study of self-decit as a pathology","Dr. Jordan B. Peterson", "Phd. Clinical Psychology", date1, "Kigali Arena", "Kigali", "Rwanda");
        Outdoor eveningOutdoor = new Outdoor("Camping in Wyoming", "Camp by the firesite and eat waffles that have the shape of Wyoming", date1, "Fireside Muddy Camp", "Some Small City", "Wyoming", "Rainny");
        //Reception event
        Console.WriteLine("-----Reception Event Stanadrd Details-----");
        Console.WriteLine(reception.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("-----Reception Event Full Details-----");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine("-----Reception Event Short Description-----");
        Console.WriteLine(reception.ShortDercription());
        Console.WriteLine();
        //Lecture event
        Console.WriteLine("-----Lecture Event Stanadrd Details-----");
        Console.WriteLine(lecture.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("-----Lecture Event Full Details-----");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine("-----Lecture Event Short Description-----");
        Console.WriteLine(lecture.ShortDercription());
        Console.WriteLine();
        //Outdoor event
        Console.WriteLine("-----Outdoor Event Stanadrd Details-----");
        Console.WriteLine(eveningOutdoor.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("-----Outdoor Event Full Details-----");
        Console.WriteLine(eveningOutdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine("-----Outdoor Event Short Description-----");
        Console.WriteLine(eveningOutdoor.ShortDercription());
        Console.WriteLine();
    }
}