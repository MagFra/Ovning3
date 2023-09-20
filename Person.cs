using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Person
    {
		private uint age;

		public uint Age
		{
			get { return age; }
			set 
			{ 
				if (value == 0) { throw new ArgumentException("Age can not be zero!", nameof(value)); }
				age = value; 
			}
		}
		private string fName = string.Empty;

		public string FName
		{
			get { return fName; }
			set
			{ 
				if ( string.IsNullOrWhiteSpace( value ) || value.Length < 3 || value.Length > 10 ) 
				{ 
					fName = string.Empty;
					throw new ArgumentException("FNamn is mandatory and must be between 3 and 10 characters long!", nameof(value)); 
				}
				fName = value; 
			}
		}
		private string lName = string.Empty;

		public string LName
		{
			get { return lName; }
			set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                {
					lName = string.Empty;
                    throw new ArgumentException("LNamn is mandatory and must be between 3 and 15 characters long!", nameof(value));
                }
                lName = value; 
			}
		}
		private float height;

		public float Height
        {
			get { return height; }
			set
            {
                if (value < (float)0.15 || value > (float)3.5) { throw new ArgumentException("Height must be between 0.15 and 3.5 meters!", nameof(value)); }
                height = value;
			}
		}
		private float weight;

		public float Weight
        {
			get { return weight; }
			set
            {
                if (value < (float)0.1 || value > (float)305) { throw new ArgumentException("Weight must be between 0.100 and 305 kg!", nameof(value)); }
                weight = value; 
			}
		}



    }
}
