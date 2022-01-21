
using MyApp;
using System2 = System;

namespace MyApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            
            
          

            var todos = new List<ToDo>();
            var Untodos = new List<ToDo>();
            
            var nextTodo = new ToDo();
            Console.WriteLine("Welcome to the List Management App!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option");
            Console.WriteLine(" ");
            Console.WriteLine("1.   CREATE A TASK");
            Console.WriteLine("2.   DELETE A TASK");
            Console.WriteLine("3.   EDIT A TASK");
            Console.WriteLine("4.   COMPLETE A TASK");
            Console.WriteLine("5.   LIST ALL INCOMPLETE TASKS");
            Console.WriteLine("6.   LIST ALL COMPLETED TASKS ");
            Console.WriteLine("7.   EXIT");

            int input = -1;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < 1 || input > 7)
                {
                    Console.WriteLine("User did not specify a valid int!");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine(" ");
                   
                }
                else
                {
                    while (input < 8 || input > 0)
                    {


                        nextTodo = new ToDo();

                        if (input == 1)             //Step 1: Create a new task
                        {
                            Console.WriteLine("Please enter a name: ");
                            nextTodo.Name = Console.ReadLine();
                           

                            Console.WriteLine("Please enter a description: ");
                            nextTodo.Description = Console.ReadLine();

                            Console.WriteLine("Please enter a deadline (mm/dd/yyyy): ");
                            nextTodo.Deadline = DateTime.Parse(Console.ReadLine());

                            Untodos.Add(nextTodo);

                            Console.WriteLine("Task has been created and info has been saved!");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine(" ");
                            input = -1;


                        }
                        else if (input == 2)        //Step 2: Delete a task
                        {
                            Console.WriteLine("Enter an Index to be Deleted: ");
                            var strIndx = int.Parse(Console.ReadLine());
                                if (todos.Count == 0)
                                    Untodos.RemoveAt(strIndx - 1);
                                else 
                                    todos.RemoveAt(strIndx - 1);
                            Console.WriteLine("Your Task has been Deleted!");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine(" ");
                            input = -1;

                        }
                        else if (input == 3)       //Step 3: Edit a task
                        {
                            Console.WriteLine("Would you like to edit the Name, Description, or Deadline? ");
                            Console.WriteLine("1 - Name");
                            Console.WriteLine("2 - Description");
                            Console.WriteLine("3 - Deadline");
                            var ans = int.Parse(Console.ReadLine());

                            if (ans == 1)
                            {
                                Console.WriteLine("Please enter a task index to be edited");
                                var strIndx = int.Parse(Console.ReadLine());
                                Console.WriteLine("The current Name associated with that number is:");
                                var idxName = Untodos[strIndx - 1].Name;
                                Console.WriteLine(idxName);
                                Console.WriteLine("What would you like to change the name to?");
                                nextTodo.Name = Console.ReadLine();
                                nextTodo.Deadline = Untodos[strIndx - 1].Deadline;
                                nextTodo.Description = Untodos[strIndx - 1].Description;
                                Untodos.RemoveAt(strIndx - 1);
                                Untodos.Add(nextTodo);
                                Console.WriteLine("The new name has been saved in the system!");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine(" ");
                                input = -1;
                            }
                            else if (ans == 2)
                            {
                                Console.WriteLine("Please enter a task index to be edited");
                                var strIndx = int.Parse(Console.ReadLine());
                                Console.WriteLine("The current Description associated with that number is:");
                                var idxDesc = Untodos[strIndx - 1].Description;
                                Console.WriteLine(idxDesc);
                                Console.WriteLine("What would you like to change the Description to?");
                                nextTodo.Description = Console.ReadLine();
                                nextTodo.Name = Untodos[strIndx - 1].Name;
                                nextTodo.Deadline = Untodos[strIndx - 1].Deadline;
                                Untodos.RemoveAt(strIndx - 1);
                                Untodos.Add(nextTodo);
                                Console.WriteLine("The new description has been saved in the system!");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine(" ");
                                input = -1;
                            }
                            else if (ans == 3)
                            {
                                Console.WriteLine("Please enter a task index to be edited");
                                var strIndx = int.Parse(Console.ReadLine());
                                Console.WriteLine("The current Deadline associated with that number is:");
                                var idxDead = Untodos[strIndx - 1].Deadline;
                                Console.WriteLine(idxDead);
                                Console.WriteLine("What would you like to change the Deadline (mm/dd/yyyy) to?");
                                nextTodo.Deadline = DateTime.Parse(Console.ReadLine());
                                nextTodo.Description = Untodos[strIndx - 1].Description;
                                nextTodo.Name = Untodos[strIndx - 1].Name;
                                Untodos.RemoveAt(strIndx - 1);
                                Untodos.Add(nextTodo);
                                Console.WriteLine("The new deadline has been saved in the system!");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine(" ");
                                input = -1;
                            }

                        }
                        else if (input == 4)       //Step 4: Complete a task
                        {
                            Console.WriteLine("Enter a task number you wish to mark as complete: ");
                            var strIndx = int.Parse(Console.ReadLine());
                            if (Untodos[strIndx - 1] != null )
                            {
                                todos.Add(Untodos[strIndx - 1]);
                                Untodos.RemoveAt((int)strIndx - 1);
                            }
                            else
                            {
                                Console.WriteLine("Sorry! Your index does not exist. Please try again!");
                            }
                            Console.WriteLine("Your Task Has Been Marked as Complete!");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine(" ");


                            input = -1;
                        }
                        else if (input == 5)       //Step 5: List all incomplete tasks
                        {
                            if (Untodos.Count == 0)
                            {
                                Console.WriteLine("Sorry. There are no incomplete tasks at the moment.");
                                Console.WriteLine("Look at completed tasks by selecting 6!");
                                input = -1;
                            }
                            else
                            {
                                Console.WriteLine("Incomplete Tasks: ");
                                foreach (var todo in Untodos)
                                    Console.WriteLine("  || Name: " + todo.Name + "  ||  Description: " + todo.Description + "  ||  Deadline: " + todo.Deadline);
                                Console.WriteLine("----------------- ");
                                Console.WriteLine(" ");
                                Console.WriteLine("Returning back to main menu");
                                input = -1;
                            }



                        }
                        else if (input == 6)      //Step 6: List all tasks
                        {
                            if (todos.Count == 0)
                            {
                                Console.WriteLine("Sorry. There are no completed tasks at the moment.");
                                Console.WriteLine("Look at uncompleted tasks by selecting 5!");
                                input = -1;
                            }
                            else
                            {
                                Console.WriteLine("Completed Tasks: ");
                                foreach (var todo in todos)
                                    Console.WriteLine("  || Name: " + todo.Name + "  ||  Description: " + todo.Description + "  ||  Deadline: " + todo.Deadline);
                                Console.WriteLine("----------------- ");
                                Console.WriteLine(" ");
                                Console.WriteLine("Returning back to main menu");
                                input = -1;
                            }

                        }
                        else if (input == 7)
                        {
                            Console.WriteLine("Exiting program");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Welcome to the List Management App!");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine(" ");
                            Console.WriteLine("Please select an option");
                            Console.WriteLine(" ");
                            Console.WriteLine("1.   CREATE A TASK");
                            Console.WriteLine("2.   DELETE A TASK");
                            Console.WriteLine("3.   EDIT A TASK");
                            Console.WriteLine("4.   COMPLETE A TASK");
                            Console.WriteLine("5.   LIST ALL INCOMPLETE TASKS");
                            Console.WriteLine("6.   LIST ALL COMPLETED TASKS ");
                            Console.WriteLine("7.   EXIT");
                            input = int.Parse(Console.ReadLine());
                        }
                    }
                }

               
                
            }
            
        }
    }

}