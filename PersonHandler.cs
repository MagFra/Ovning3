using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal static class PersonHandler
    {
        public static void SetAge(Person pers, uint age) => pers.Age = age;
        public static uint GetAge(Person pers) => pers.Age;
        public static void SetFName(Person pers, string fName) => pers.FName = fName;
        public static string GetFName(Person pers) => pers.FName;
        public static void SetLName(Person pers, string lName) => pers.LName = lName;
        public static string GetLName(Person pers) => pers.LName; 
        public static void SetHeight(Person pers, float height) => pers.Height = height;
        public static float GetHeight(Person pers) => pers.Height;
        public static void SetWeight(Person pers, float weight) => pers.Weight = weight;
        public static float GetWeight(Person pers) => pers.Weight;


        public static Person CreatePerson(uint age, string fname, string lname, float height, float weight)
        {
            var person = new Person()
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return person;
        }


    }
}
