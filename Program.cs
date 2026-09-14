namespace Study_Planer
{
    internal class Study_Planer
    {
        static void Main(string[] args)
        {

            string task = "";
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
            int taskChoice = Convert.ToInt32(Console.ReadLine());
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
                                task += add + "\n";
                                Console.WriteLine("\nYour tasks are: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING TASK:");
                                Console.WriteLine("Task: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Task to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Task: ");
                                string upd = Console.ReadLine();
                                task = task.Replace(old, upd);

                                Console.WriteLine("\nTask: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING TASK:");
                                Console.WriteLine("Task: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Task to Remove: ");
                                string remove = Console.ReadLine();
                                task = task.Replace(remove, "");

                                Console.WriteLine("\nTask: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL TASKS: ");
                                Console.WriteLine(task);
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
                                task += add + "\n";
                                Console.WriteLine("\nYour Projects are: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING PROJECT:");
                                Console.WriteLine("Project: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Project to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Project: ");
                                string upd = Console.ReadLine();
                                task = task.Replace(old, upd);

                                Console.WriteLine("\nProjects: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING PROJECT:");
                                Console.WriteLine("Project: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Project to Remove: ");
                                string remove = Console.ReadLine();
                                task = task.Replace(remove, "");

                                Console.WriteLine("\nProjects: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL PROJECTS: ");
                                Console.WriteLine(task);
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
                        Console.WriteLine("4. View Project");
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
                                task += add + "\n";
                                Console.WriteLine("\nYour Activities are: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Activity to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Activity: ");
                                string upd = Console.ReadLine();
                                task = task.Replace(old, upd);

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Activity to Remove: ");
                                string remove = Console.ReadLine();
                                task = task.Replace(remove, "");

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL ACTIVITIES: ");
                                Console.WriteLine(task);
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
                        Console.WriteLine("1. Add Activity");
                        Console.WriteLine("2. Update Activity");
                        Console.WriteLine("3. Remove Activity");
                        Console.WriteLine("4. View Project");
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
                                task += add + "\n";
                                Console.WriteLine("\nYour Activities are: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 2:
                                Console.WriteLine("===========================");
                                Console.WriteLine("UPDATING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Activity to Update: ");
                                string old = Console.ReadLine();

                                Console.Write("\nUpdate Activity: ");
                                string upd = Console.ReadLine();
                                task = task.Replace(old, upd);

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 3:
                                Console.WriteLine("===========================");
                                Console.WriteLine("REMOVING ACTIVITY:");
                                Console.WriteLine("Activity: ");
                                Console.WriteLine(task);

                                Console.Write("Enter a Activity to Remove: ");
                                string remove = Console.ReadLine();
                                task = task.Replace(remove, "");

                                Console.WriteLine("\nActivities: ");
                                Console.WriteLine(task);
                                Console.WriteLine("=========================== \n");
                                break;

                            case 4:
                                Console.WriteLine("===========================");
                                Console.WriteLine("ALL ACTIVITIES: ");
                                Console.WriteLine(task);
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
