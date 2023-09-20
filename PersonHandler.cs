using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, uint age) { pers.Age = age; }
        public uint GetAge(Person pers) => pers.Age;
        public void SetFName(Person pers, string fName) { pers.FName = fName;}
        public string GetFName(Person pers) => pers.FName;  
        public void SetLName(Person pers, string lName) { pers.LName = lName;}
        public string GetLName(Person pers) => pers.LName; 
        public void SetHeight(Person pers, float height) {  pers.Height = height;}
        public float GetHeight(Person pers) => pers.Height;
        public void SetWeight(Person pers, float weight) { pers.Weight = weight;}
        public float GetWeight(Person pers) => pers.Weight;


        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            var person = new Person()
            {
                Age = (uint)age,
                FName = fname,
                LName = lname,
                Height = (float)height,
                Weight = (float)weight
            };
            return person;
        }


    }
}
