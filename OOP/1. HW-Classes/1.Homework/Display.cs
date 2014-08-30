using System;

namespace Homework
{
    class Display
    {
        //Fields
        public string displaySize;
        public int displayColors;

        //Constructor
        public Display(string size, int colors)
        {
            this.displaySize = size;
            this.displayColors = colors;
        }

        //Properties
        public string diplSize
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }

        public int diplColors
        {
            get { return this.displayColors; }
            set { this.displayColors = value; }
        }
    }
}
