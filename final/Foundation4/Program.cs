using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> list = new List<Activity>();

        //passing diff values get same results
        list.Add(new Run(30,DateTime.Now,3.775));
        list.Add(new Bicycle(30,DateTime.Now,7.55));
        list.Add(new Swim(30,DateTime.Now,75.5));

        //trying random values
        list.Add(new Run(50,DateTime.Now,5));
        list.Add(new Bicycle(20,DateTime.Now,8.6));
        list.Add(new Swim(10,DateTime.Now,80));
       
       
        foreach(Activity a in list){
            Console.WriteLine(a.GetSummary());
        }
      
    }
}