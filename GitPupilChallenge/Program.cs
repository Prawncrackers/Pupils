using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil_Challenge
{
    class Program
    {
        public enum Gender
        {
            Male = 1,
            Female,
            Mayonnaise,
            Genderfluid,
            Agender
        }
        public enum House
        {
            Compton = 1,
            Winterbourne,
            Bassett,
            Berwick,
            Whittle
        }

        struct Pupil
        {
            public string name;
            public int age;
            public Gender gender; // m or f or u
            public House house;

            public Pupil(string name, int age, Gender gender, House house)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.house = house;
            }
            public override string ToString()
            {
                return "Name: " + name + "\n" +
                    " Age: " + age + "\n" +
                    " Gender: " + gender + "\n" +
                    " House: " + house + ".";
            }
        }

        static void Main(string[] args)
        {
            Pupil[] pupils = new Pupil[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter your name: ");
                String name = Console.ReadLine();

                Console.Write("Please enter your age: ");
                String age = Console.ReadLine();
                Console.Write("Please enter your gender (M/F/A/G/MAYO: ");
                String gender = Console.ReadLine();
                gender = gender.ToUpper();
                Console.Write("Please enter your house (WH/CO/WI/BE/BA): ");
                String house = Console.ReadLine();
                house = house.ToUpper();
                pupils[i].name = name;
                int ageInt;
                if (Int32.TryParse(age, out ageInt))
                { }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
                pupils[i].age = ageInt;

                switch (gender)
                {
                    case "M": { pupils[i].gender = Gender.Male; break; }
                    case "MAYO": { pupils[i].gender = Gender.Mayonnaise; break; }
                    case "F": { pupils[i].gender = Gender.Female; break; }
                    case "A": { pupils[i].gender = Gender.Agender; break; }
                    case "G": { pupils[i].gender = Gender.Genderfluid; break; }
                }
                switch (house)
                {
                    case "WH": { pupils[i].house = House.Whittle; break; }
                    case "CO": { pupils[i].house = House.Compton; break; }
                    case "WI": { pupils[i].house = House.Winterbourne; break; }
                    case "BE": { pupils[i].house = House.Berwick; break; }
                    case "BA": { pupils[i].house = House.Bassett; break; }
                }
            }

            foreach (Pupil g in pupils)
            {
                Console.WriteLine(g);
            }

            Console.ReadLine();
        }
    }
}

