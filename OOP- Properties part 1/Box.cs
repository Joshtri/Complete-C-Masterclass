using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__Properties_part_1
{
    internal class Box
    {
        //member variable. 
        private int length;
        private int height;
        public int volume;
        public int Width { get; set; }

        //properties. 
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }


        //fundamentals of properties on OOP. 
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }


        public static void DisplayInfo()
        {

        }
    }
}
