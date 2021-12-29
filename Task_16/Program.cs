using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;


namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {

            const int n = 5;
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите зарплату");
                int summa = Convert.ToInt32(Console.ReadLine());

                employees[i] = new Employee() { Num = num, Name = name, Summa = summa };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string JsonString = JsonSerializer.Serialize(employees, options);
            using (StreamWriter sw = new StreamWriter("../../../Employees.json"))
            {
                sw.WriteLine(JsonString);
            
            }


        }
    }

}
