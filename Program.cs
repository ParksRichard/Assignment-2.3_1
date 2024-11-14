
using System.IO;

namespace Assignment_2._3_1

{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             Write a console application to create a text file and save your 
            basic details like name, age, address. Read the details from same
            file and print on console. 
            */

            string filePath = @"C:\Users\Richard\Desktop\test.txt";
            //Programming development needs file location to not be localized?
            //

            //Ensure that tabs are linked under same solution thing
            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            {
                //Console.WriteLine();
            }
            ////make dummy notepad txt file
            //lines.Add("");

            //File.WriteAllLines(filePath, lines);

            /////////////////////////////////////////////

            List<Person> people = new List<Person>();
            //need to link the variable to other tab
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                //variables defined for string purposes
                //name, first
                //name, last
                //newPerson.Age = entries{2};
                //newPerson.Address = entries{3};

                people.Add(newPerson);
            }
            Console.WriteLine("Read from text file");
            Console.WriteLine("");
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName }: { person.Url }");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test.com" });
           
            List<string> output = new List<string>();

            foreach (var person in people) 
                {
                output.Add($"{ person.FirstName }, { person.LastName } ,{person.Url}");
                }

            //print variables
            //name, first
            //name, last
            //age
            //address

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");
            //fluff
            ///flufff;
            Console.ReadLine();
        }
    }
}