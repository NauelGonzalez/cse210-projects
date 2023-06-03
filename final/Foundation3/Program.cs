using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("------------------Lecture Object------------------ \n");

        Lecture l = new Lecture("The House of the BaskerVilles", "The Hound of the Baskervilles is the third of the four crime novels by the British writer Arthur Conan Doyle.", new DateTime(2023,6,2),new TimeSpan (20,52,00),"221b Baker Street, London", "Sherlock Holmes", 10);
        Console.WriteLine (l.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(l.GetFullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(l.GetShortDescription());


        Console.WriteLine("\n------------------Reception Object------------------ \n");

        Reception r = new Reception("75th Emmy Awards", "The 75th Primetime Emmy Awards will honor the best in American prime time television programming from June 1, 200 uintil May 2023 as chosen by the Academy of Television Arts & Sciences",  new DateTime(2023,9,18),new TimeSpan (21,00,00),"5220 Lankershim Blvd. North Hollywood, CA","freetickets@televisionacademy.com");
        
        Console.WriteLine (r.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(r.GetFullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(r.GetShortDescription());

        Console.WriteLine("\n------------------Reception Object------------------ \n");

        Outdoor o = new Outdoor("Sing under the rain event", "Sing under the rain is an event for movie lovers. Come and sing under the rain with fellow movie-lovers",  new DateTime(2027,10,2),new TimeSpan (04,00,00),"Metro-Goldwyn Studios, CA","Rainy");
        
        Console.WriteLine (o.StandardDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(o.GetFullDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine(o.GetShortDescription());



    }
}