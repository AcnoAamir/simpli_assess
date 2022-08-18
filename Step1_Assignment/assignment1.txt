/*
The following fields will be stored for a teacher:
ID
Name
Class and section
*/
using System;
using System.Collections.Generic;
using System.Collections;

namespace assignement
{
    class driver
    {
        static public ArrayList records = new ArrayList();
        public static ArrayList id_list = new ArrayList();
        public struct Record
        {
            public int IDS;
            public string name;
            public string class_sec;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rainbow School student database ");
            int choice = 0;
            do
            {
                Console.Write("----------------Menu----------------\nPress 1. Insert new record 2. See records 3. Update record 4. Delete record : ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1) { new_rec(); }
                else if (option == 2) { view(); }
                else if (option == 3) { update(); }
                else if (option == 4) { delete(); }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect Option ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Press 1 to exit ");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 1);
        }
        public static void new_rec()
        {
            Random rnd = new Random();
            var input = new Record();
            int id;
            // do
            // {
            id = rnd.Next(0, 10000);
            // } while (id_list.IndexOf(id)==-1);
            input.IDS = id;
            id_list.Add(id);
            Console.WriteLine("The randomly generated id of stsudent is " + id);
            Console.Write("Enter name of student : ");
            input.name = Console.ReadLine();
            Console.Write("Enter class and sec of student in form of (10-A): ");
            input.class_sec = Console.ReadLine();
            records.Add(input);
        }
        public static void view()
        {
            Console.WriteLine("Id\tName\t\tClass-Section  ");
            foreach (Record input in records)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}", input.IDS, input.name, input.class_sec);
            }
        }
        public static void update()
        {
            Console.Write("Enter id of student you wanna edit : ");
            int id = int.Parse(Console.ReadLine());
            int index = id_list.IndexOf(id);
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Id not found ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Record stud = new Record();
                stud = (Record)records[index];
                Console.WriteLine("Name : {0} and class-section : {1}", stud.name, stud.class_sec);
                Console.Write("Press 1 to edit Name, 2 to edit class-section and 3 to go back to main menu : ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter name of student : ");
                    stud.name = Console.ReadLine();
                    records.RemoveAt(index);
                    records.Add(stud);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter class and sec of student in form of (10-A): ");
                    stud.class_sec = Console.ReadLine();
                    records.RemoveAt(index);
                    records.Add(stud);
                }
                else if (choice == 3)
                {
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect Option ");
                    Console.ForegroundColor = ConsoleColor.White;

                }

            }

        }

    public static void delete() { 
                    Console.Write("Enter id of student you wanna delete : ");
            int id = int.Parse(Console.ReadLine());
            int index = id_list.IndexOf(id);
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Id not found ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Record stud = new Record();
                stud = (Record)records[index];
                Console.WriteLine("Name : {0} and class-section : {1}", stud.name, stud.class_sec);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Press 1 if you are sure you want to delete this student's data ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int choice=int.Parse(Console.ReadLine());
                    if(choice==1){
                        records.RemoveAt(index);
                    }
            }
    }

}
}