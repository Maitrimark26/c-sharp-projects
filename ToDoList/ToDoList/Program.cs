using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> TaskList= new Dictionary<int,string>(); 


            int enter = 1;
            while (true)
            {
                Console.WriteLine("Welcome to TODO list");
                Console.WriteLine("Press 1 to add a task");
                Console.WriteLine("Press 2 to delete a task");
                Console.WriteLine("Press 3 to view taskList");
                Console.WriteLine("Press 4 to edit task");
                int input= int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Enter your task number and task");
                    int tnum=int.Parse(Console.ReadLine());
                    string Task= Console.ReadLine();
                    TaskList.Add(tnum,Task);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter your task number you want to delete");
                    int tnum = int.Parse(Console.ReadLine());
                    TaskList.Remove(tnum);
                }
                else if (input == 3)
                {
                    foreach (var task in TaskList)
                    {
                        Console.WriteLine($"Task number : {task.Key} is to {task.Value}");
                    }
                }
                else if (input == 4)
                {
                    Console.WriteLine("Enter your task number you want to edit");
                    int tnum = int.Parse(Console.ReadLine());
                    string change = Console.ReadLine();
                    TaskList[tnum]=change;
                    Console.WriteLine("Task updated");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("Do you want to continue(1) or exit(0)");
                enter=int.Parse(Console.ReadLine());
                if (enter == 0)
                {
                    break;
                }
            }

        }
    }
}
