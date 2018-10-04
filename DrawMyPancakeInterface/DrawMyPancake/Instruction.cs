using System;
using System.Collections;
using System.Drawing;

namespace DrawMyPancake {
    public class Instruction {
        ArrayList coordinateList = new ArrayList();
        public string instructionString = "";

        public void AddCoordinate(int x, int y, int canvasWidth)
        {
            Point p = new Point(Math.Abs(x-canvasWidth), y);
            coordinateList.Add(p);
        }

        public void OptimizePath()
        {
            // remove unnecessary coordinates
        }

        public string ToInstructionString()
        {
            OptimizePath();
            foreach (Point coordinate in coordinateList)
            {
                instructionString += coordinate.X.ToString("D4") + coordinate.Y.ToString("D4") + "T";
            }
            return instructionString;
        }
    }
}
