using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System;
using System.Reflection;


namespace Homework3_ToDoList
{
    partial class Program
    {
        public static Todo todo1 = new Todo();
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Введите номер дня недели для назначени задачи: \n1 - Mondаy\n2 - Tuesday\n3 - Wednesday\n4 - Thursday\n5 - Friday\n6 - Saturday\n7 - Sunday ");
                int.TryParse(Console.ReadLine(), out int input);


                switch (input)
                {
                    case 1:
                        {
                            Week week = Week.Monday;
                            menu(week);
                        }
                        break;
                    case 2:
                        {
                            Week week = Week.Tuesday;
                            menu(week);
                        }
                        break;
                    case 3:
                        {
                            Week week = Week.Wednesday;
                            menu(week);
                        }
                        break;
                    case 4:
                        {
                            Week week = Week.Thursday;
                            menu(week);
                        }
                        break;
                    case 5:
                        {
                            Week week = Week.Friday;
                            menu(week);
                        }
                        break;
                    case 6:
                        {
                            Week week = Week.Saturday;
                            menu(week);
                        }
                        break;
                    case 7:
                        {
                            Week week = Week.Sunday;
                            menu(week);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("\nНе верная команда");
                        }
                        break;
                }

            }
            
        }

        public static void menu(Week dayselect)
        {
            bool close = true;
            while (close)
            {
                Console.WriteLine($"\nТекущий день: {dayselect}  \nВыберете команду: \n1 - Добавить задачу для {dayselect} \n2 - Просмотр дел запланированных на {dayselect} \n3 - Изменить день");
                int.TryParse(Console.ReadLine(), out int input);


                switch (input)
                {
                    
                    case 1:
                        {
                            Console.WriteLine($"\nВведите дела на {dayselect} ");
                            var taskday = Console.ReadLine();
                            todo1.AddTask(dayselect, taskday);

                        }
                        break;

                    case 2:
                        {
                          
                            Console.WriteLine($"\nДела на {dayselect}:");
                            todo1.Show(dayselect);
                            

                        }
                        break;
                    case 3:
                        {
                            close = false;

                        }
                        break;
                   


                }
            }
        }
    }
}