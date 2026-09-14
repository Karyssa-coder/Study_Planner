namespace Study_Planer
{
    internal class Study_Planer
    {
        static void Main(string[] args)
        {
            string a = "", b = "", c = "", d = "", e = "";

            string add = "";
            int UserChoice;
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("===========================");
            Console.WriteLine("Hello " + username + ", welcome to Study Planner! \n");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Assignment/Homework Task");
            Console.WriteLine("2. Project Task");
            Console.WriteLine("3. Activity Task");
            Console.WriteLine("4. Exam/Quiz Reviewer");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            int taskChoice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("=========================== \n");

            while (taskChoice != 5)
            {
                switch (taskChoice)
                {
                    case 1:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Assignment/Homework Task");
                        Console.WriteLine("1. Add Task");
                        Console.WriteLine("2. Update Task");
                        Console.WriteLine("3. Remove Task");
                        Console.WriteLine("4. View Task");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter choice: ");
                        
                        UserChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("=========================== \n");

                        switch (UserChoice)
                        {
                            case 1:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ADDING TASK:");
                                Console.Write("Write a new task: ");
                                add = Console.ReadLine();
                                a += add + "\n";
                                Console.WriteLine("\nYour tasks are: ");
                                Console.WriteLine(a);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING TASK:");
                                Console.WriteLine("Task: ");
                                Console.WriteLine(a);

                                Console.Write("Enter a Task to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Task: ");
                                string upd = Console.ReadLine();
                                a = a.Replace(old, upd);

                                Console.WriteLine("\nTask: ");
                                Console.WriteLine(a);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING TASK:");
                                Console.WriteLine("Task: ");
                                Console.WriteLine(a);

                                Console.Write("Enter a Task to Remove: ");
                                string remove = Console.ReadLine();
                                a = a.Replace(remove, "");

                                Console.WriteLine("\nTask: ");
                                Console.WriteLine(a);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL TASKS: ");
                                Console.WriteLine(a);
                                Console.WriteLine("=========================== \n");
                                break;

                            default:
                                Console.WriteLine("Invalid Input. Please choose a valid option.");
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Project Task");
                        Console.WriteLine("1. Add Project");
                        Console.WriteLine("2. Update Project");
                        Console.WriteLine("3. Remove Project");
                        Console.WriteLine("4. View Project");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter choice: ");

                        UserChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("=========================== \n");

                        switch (UserChoice)
                        {
                            case 1:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ADDING PROJECT:");
                                Console.Write("Write a new Project: ");
                                add = Console.ReadLine();
                                b += add + "\n";
                                Console.WriteLine("\nYour Projects are: ");
                                Console.WriteLine(b);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING PROJECT:");
                                Console.WriteLine("Project: ");
                                Console.WriteLine(b);

                                Console.Write("Enter a Project to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Project: ");
                                string upd = Console.ReadLine();
                                b = b.Replace(old, upd);

                                Console.WriteLine("\nProjects: ");
                                Console.WriteLine(b);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING PROJECT:");
                                Console.WriteLine("Project: ");
                                Console.WriteLine(b);

                                Console.Write("Enter a Project to Remove: ");
                                string remove = Console.ReadLine();
                                b = b.Replace(remove, "");

                                Console.WriteLine("\nProjects: ");
                                Console.WriteLine(b);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL PROJECTS: ");
                                Console.WriteLine(b);
                                Console.WriteLine("=========================== \n");
                                break;

                            default:
                                Console.WriteLine("Invalid Input. Please choose a valid option.");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Activity Task");
                        Console.WriteLine("1. Add Activity");
                        Console.WriteLine("2. Update Activity");
                        Console.WriteLine("3. Remove Activity");
                        Console.WriteLine("4. View Projects");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter choice: ");

                        UserChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("=========================== \n");

                        switch (UserChoice)
                        {
                            case 1:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ADDING ACTIVITY:");
                                Console.Write("Write a new Activity: ");
                                add = Console.ReadLine();
                                c += add + "\n";
                                Console.WriteLine("\nYour Activities are: ");
                                Console.WriteLine(c);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(c);

                                Console.Write("Enter a Activity to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Activity: ");
                                string upd = Console.ReadLine();
                                c = c.Replace(old, upd);

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(c);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(c);

                                Console.Write("Enter a Activity to Remove: ");
                                string remove = Console.ReadLine();
                                c = c.Replace(remove, "");

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(c);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL ACTIVITIES: ");
                                Console.WriteLine(c);
                                Console.WriteLine("=========================== \n");
                                break;

                            default:
                                Console.WriteLine("Invalid Input. Please choose a valid option.");
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Exam/Quiz Reviewer");
                        Console.WriteLine("1. Add Reviewer");
                        Console.WriteLine("2. Update Reviewer");
                        Console.WriteLine("3. Remove Reviewer");
                        Console.WriteLine("4. View Records of Exam/Quiz");
                        Console.WriteLine("5. Exit");
                        Console.Write("Enter choice: ");

                        UserChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("=========================== \n");

                        switch (UserChoice)
                        {
                            case 1:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ADDING REVIEWER:");
                                Console.WriteLine("1. For Quiz");
                                Console.WriteLine("2. For Exam");
                                Console.WriteLine("3. Exit");

                                Console.Write("Select an option: ");
                                int ReviewerChoice = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("=========================== \n");

                                while (ReviewerChoice != 3)
                                {

                                    if (ReviewerChoice == 1)
                                    {
                                        Console.Write("Write a new Reviewer for Quiz: ");
                                        string quiz = Console.ReadLine();
                                        d += quiz + "\n";
                                        Console.WriteLine("\nYour Reviewers for Quiz are: ");
                                        Console.WriteLine(d);
                                        Console.WriteLine("=========================== \n");
                                    }

                                    else if (ReviewerChoice == 2)
                                    {
                                        Console.Write("Write a new Reviewer for Exam: ");
                                        string exam = Console.ReadLine();
                                        e += exam + "\n";
                                        Console.WriteLine("\nYour Reviewers for Exam are: ");
                                        Console.WriteLine(e);
                                        Console.WriteLine("=========================== \n");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Invalid Input. Please choose a valid option.");
                                    }

                                    Console.WriteLine("===========================");
                                    Console.WriteLine("ADDING REVIEWER:");
                                    Console.WriteLine("1. For Quiz");
                                    Console.WriteLine("2. For Exam");
                                    Console.WriteLine("3. Exit");

                                    Console.Write("Select an option: ");
                                    ReviewerChoice = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("=========================== \n");
                                }

                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING REVIEWER:");
                                Console.WriteLine("Quiz Reviewer: ");
                                Console.WriteLine(d);

                                Console.WriteLine("\nExam Reviewer: ");
                                Console.WriteLine(e);

                                Console.Write("Enter a Reviewer to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Reviewer: ");
                                string upd = Console.ReadLine();
                                d = d.Replace(old, upd);
                                e = e.Replace(old, upd);

                                Console.WriteLine("\nReviewers: ");
                                Console.WriteLine(d);

                                Console.WriteLine("\nExam Reviewer: ");
                                Console.WriteLine(e);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING REVIEWER:");
                                Console.WriteLine("Quiz Reviewer: ");
                                Console.WriteLine(d);

                                Console.WriteLine("\nExam Reviewer: ");
                                Console.WriteLine(e);

                                Console.Write("Enter a Reviewer to Remove: ");
                                string remove = Console.ReadLine();
                                d = d.Replace(remove, "");
                                e = e.Replace(remove, "");

                                Console.WriteLine("\nReviewers: ");
                                Console.WriteLine(d);

                                Console.WriteLine("\nExam Reviewer: ");
                                Console.WriteLine(e);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL REVIEWERS");
                                Console.WriteLine("Quiz Reviewer: ");
                                Console.WriteLine(d);

                                Console.WriteLine("\nExam Reviewer: ");
                                Console.WriteLine(e);
                                Console.WriteLine("=========================== \n");
                                break;

                            default:
                                Console.WriteLine("Invalid Input. Please choose a valid option.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Please choose a valid option.");
                        break;
                }

                Console.WriteLine("===========================");
                Console.WriteLine("What would you like to do next? \n");
                Console.WriteLine("1. Assignment/Homework Task");
                Console.WriteLine("2. Project Task");
                Console.WriteLine("3. Activity Task");
                Console.WriteLine("4. Exam/Quiz Reviewer");
                Console.WriteLine("5. Exit");

                Console.Write("Select an option: ");
                taskChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=========================== \n");
            }



        }
    }
}
