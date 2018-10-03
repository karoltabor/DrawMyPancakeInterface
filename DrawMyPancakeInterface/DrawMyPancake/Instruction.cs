using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMyPancake {
    public class Instruction {
        ArrayList coordinateList = new ArrayList();
        public string instructionString = "";

        public void AddCoordinate(int x, int y)
        {
            Point p = new Point(x, y);
            coordinateList.Add(p);
        }

        public void OptimizePath()
        {
            // remove unnecessary coordinates
        }

        public string ToInstructionString()
        {
            foreach (Point coordinate in coordinateList)
            {
                instructionString += coordinate.X.ToString("D4") + coordinate.Y.ToString("D4") + "T";
            }
            return instructionString;
        }
    }
}
