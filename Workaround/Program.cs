using Business.Concrete;
using Entities.Concrete;
using System;
using System.Runtime.InteropServices;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas = new Vatandas(); //instance Büyük-küçük harf duyarlılığı

            SayHi("Ceyhun");
            SayHi("Engin");
            SayHi();

            int total = Topla(4,5);
            Console.WriteLine(total);

            //Diziler-Arrays

            string ogrenci1 = "Ceyhun";
            string ogrenci2 = "Abuzer";
            string ogrenci3 = "Engin";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Ceyhun";
            students[2] = "Abuzer";
            students = new string[4]; //Sayı 4e çıkarıldı.
            students[3] = "Mahmut";

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] cities1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] cities2 = new[] {"Bursa","Antalya","Diyarbakır"};

            cities2 = cities1;
            cities1[0] = "Adana";
            Console.WriteLine(cities2[0]);

            Console.WriteLine("---------------------------");

            Person person1 = new Person();
            person1.FirstName="CEYHUN";
            person1.LastName = "ONAÇ";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Abuzer";

            foreach(var  city in cities1) // city-> alias(takma ad)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("-------------------------");

            List<string> newCities1 = new List<string>{"Ankara", "İstanbul", "İzmir" };
            newCities1.Add("Tekirdağ");

            foreach (var newcity in newCities1)
            {
                Console.WriteLine(newcity);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SayHi(string name= " no name - nessun nome - isimsiz ") //Default parametre
        {
            Console.WriteLine(" Hello - Ciao - Merhaba "+name);
        }


        static int Topla(int number1=6,int number2=5) //default paramertreler en sonda yazılır
        {
            int total = number1 + number2;
            Console.WriteLine("Total: " + total);
            return total;
        }



        private static void Degiskenler()
        {
            //Console.WriteLine("Selam");

            //string mesaj = "Hello World";
            //string message = "Ciao il mondo"; //Mutlaka noktalı virgülle bitir.
            //double amount = 100000; //dbden gelir
            //int number = 100;
            //bool isTrue = true;


            //Console.WriteLine(message);

            //Console.WriteLine("-------------------------------");

            //string name = "Ceyhun";
            //string surname = "Onaç";
            //int dogumYili = 2003;
            //string tcNo = "11111111111";
        }
    }
    //public class Vatandas
    //{
    //    public string Name { get; set; } //Get ve Set değişken özellikleri değişebilir.
    //    public string Surname { get; set; }
    //    public int Yearofbirth { get; set; }
    //    public long TCNo { get; set; }
    //}
}




