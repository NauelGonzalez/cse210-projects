using System;




/*
For exceeding the requirements:
    -  I calculate the points earned based on the goals objectsm even if it is  loaded from a file.
    - Added a system of Due dates for the goals. If it is overdue it can't be completed anymore and gives negative points
    - Added colors based on due proximity for goals listing option

    -**** testing FILE ******* A file with 6 testing goals was added on diagram folder in case it helps testing. Can switch to use it on line 185 of program.cs

    Also couldnt find any reason on why to have a "simple goals" class, since all the attributes and methods will be the same as "goal" base class. 
    Decided to keep the classes limited to 1 base class and 2 subclasses. (hope this is ok :) )
*/

class Program
{
    static void Main(string[] args)
    {


        List<Goal> GoalList = new List<Goal>();
        bool ActiveMenu = true;
        double currentPoints = 0;
        while (ActiveMenu)
        {
            ActiveMenu = MainMenu();   //Found and used this way for managing menu. It looks interesting and clearer.
        }

        bool MainMenu()
        {
            currentPoints = 0;
            foreach (Goal g in GoalList){ //Instead of saving the total points in the file, it calculates all the points based on each goals rules and status with the CalculatePoints method
                currentPoints = currentPoints + g.CalculatePoints();
            }
            Console.Clear();
            Console.Write($"Currently you have ");
            if (currentPoints >= 0) 
                Console.ForegroundColor = ConsoleColor.Green;
            else 
                Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{currentPoints} ");
            Console.ResetColor();
            Console.Write($"points.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1- Create a new Goal");
            Console.WriteLine("2- List Goals");
            Console.WriteLine("3- Save Goals");
            Console.WriteLine("4- Load Goals");
            Console.WriteLine("5- Record Event");
            Console.WriteLine("6- Quit");
            Console.Write("Select a choice from the menu: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("What type of goal you want to create?:");
                    Console.WriteLine("1- Simple Goal");
                    Console.WriteLine("2- Eternal Goal");
                    Console.WriteLine("3- List Goal");
                    Console.WriteLine("Choose an option or press enter for default goal: ");
                    GoalList.Add(Addgoal(Console.ReadLine()));

                    return true;
                case "2":
                    ListGoals();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.Read();
                    return true;
                case "3":
                    SaveFile();
                    return true;
                case "4":
                    LoadFile();
                    return true;
                case "5":
                    ListGoals();
                    RecordEvent();
                    return true;
                case "6":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }


        Goal Addgoal(string choice)
        {

            string goalName;
            string goalDesc;
            int goalPoints;
            Console.Clear();
            Console.WriteLine("What is the name of your Goal?: ");
            goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it?: ");
            goalDesc = Console.ReadLine();
            Console.WriteLine("What is the ammount of points associated to it?: ");
            goalPoints = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    Console.WriteLine("How many days to complete it: ");
                    Goal goal = new Goal(goalName, goalDesc, goalPoints, DateTime.Now, DateTime.Now.AddDays(int.Parse(Console.ReadLine())), false, 0);
                    return goal;

                case "2":
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDesc, goalPoints, DateTime.Now, false, 0);
                    return eternalGoal;

                case "3":
                    Console.WriteLine("How many days to complete it: ");
                    DateTime dateExpected = DateTime.Now.AddDays(int.Parse(Console.ReadLine()));
                    Console.WriteLine("How many times does this goal need to be completed for a bonus?: ");
                    int timesToComplete = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus in points for accomplishing that many times?: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    CheckListGoal checkListGoal = new CheckListGoal(goalName, goalDesc, goalPoints, DateTime.Now, dateExpected, false, 0, timesToComplete, bonusPoints);
                    return checkListGoal;

                default:
                    Goal defaultGoal = new Goal(goalName, goalDesc, goalPoints); //Since i had to choose a case default when user inputs wrong option it creates a simple goal instead with default expected date of 7 days.
                    return defaultGoal;
            }


        }

        void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("The goals are:");
            Console.WriteLine();
            int counter = 1;
            if (GoalList.Count == 0)
            {
                Console.Write("There are no goals, please go back and create some.");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                foreach (Goal g in GoalList)
                {
                    Console.Write($"{counter.ToString()}. ");
                    g.PrintGoal();
                    counter++;
                }
            }


        }

        void SaveFile()
        {

            Console.Clear();
            Console.WriteLine("Enter the full path and filename");
            string fullPath = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Goal g in GoalList)
                {
                    writer.WriteLine(g.SaveLine());
                }
            }



        }

        void LoadFile()
        {
            Console.Clear();
            Console.WriteLine("Enter the full path and filename: ");
            string fullPath = Console.ReadLine();  //@".\diagram\goals.txt";
            int idx_type = 0;
            int idx_goalName = 1;
            int idx_goalDesc = 2;
            int idx_goalPoints = 3;
            int idx_dateCreated = 4;
            int idx_dateExpected = 5;
            int idx_completed = 6;
            int idx_timesCompleted = 7;
            int idx_timesToComplete = 8;
            int idx_bonusPoints = 9;

            int counter = 0;
            string[] lines = File.ReadAllLines(fullPath);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                string goalName = parts[idx_goalName];
                string goalDescription = parts[idx_goalDesc];
                int goalPoints = int.Parse(parts[idx_goalPoints]);
                DateTime goalCreated = DateTime.ParseExact(parts[idx_dateCreated], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime goalExpected = DateTime.ParseExact(parts[idx_dateExpected], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                bool completed = bool.Parse(parts[idx_completed] == "1" ? "true" : "false");
                int timesCompleted = int.Parse(parts[idx_timesCompleted]);


                switch (parts[idx_type])
                {
                    case "Goal":
                        Goal goal = new Goal(goalName, goalDescription, goalPoints, goalCreated, goalExpected, completed, timesCompleted);
                        GoalList.Add(goal);
                        counter++;
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, goalCreated, completed, timesCompleted);
                        GoalList.Add(eternalGoal);
                        counter++;
                        break;
                    case "CheckListGoal":
                        int timesToComplete = int.Parse(parts[idx_timesToComplete]);
                        int bonusPoints = int.Parse(parts[idx_bonusPoints]);
                        CheckListGoal chklistGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalCreated, goalExpected, completed, timesCompleted, timesToComplete, bonusPoints);
                        GoalList.Add(chklistGoal);
                        counter++;
                        break;
                }






            }
            Console.WriteLine($"Successfully loaded {counter} goals.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        void RecordEvent(){
            
            Console.WriteLine();
            Console.WriteLine("Which goal do you want to mark completed: ");
            int option = int.Parse(Console.ReadLine())-1;
            GoalList[option].MarkCompleted();
            Console.ReadLine();
        }
    }

}
