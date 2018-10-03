using System.Collections;
using System.Drawing;

namespace DrawMyPancake {
    public class Instruction {
        ArrayList coordinateList = new ArrayList();
        public string instructionString = "";

        public void AddCoordinate(int x, int y)
        {
            Point p = new Point(x, y);
            coordinateList.Add(p);
        }

        private void Reflect()
        {

        }

        public void OptimizePath()
        {
            // remove unnecessary coordinates
        }

        public string ToInstructionString()
        {
            OptimizePath();
            Reflect();
            foreach (Point coordinate in coordinateList)
            {
                instructionString += coordinate.X.ToString("D4") + coordinate.Y.ToString("D4") + "T";
            }
            return instructionString;
        }
    }
}
