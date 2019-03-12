using System.Drawing;
using Microsoft.Win32;

namespace GDI__Game
{
    class StarVar
    {
        private Point Location;
        private int StarColour;
        private int Starsize;

        public StarVar(Point pt, int colour, int size)
        {
            Location = pt;
            StarColour = colour;
            Starsize = size;
        }

        public Point Point()
        {
            return Location;
        }
        public int Colour()
        {
            return StarColour;
        }
        public int Size()
        {
            return Starsize;
        }

        public void SetPoint(Point pt)
        {
            Location = pt;
        }
    }
}
