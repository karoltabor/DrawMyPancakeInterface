using System;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace DrawMyPancake {
    public class Instruction {
        private ArrayList coordinateList = new ArrayList();
        private ArrayList coordinateStringList = new ArrayList();
        public string instructionString = "";
        private const int unprecision = 50;

        public void AddCoordinate(int x, int y, int canvasWidth) {
            Point p = new Point(Math.Abs(x - canvasWidth), y);
            coordinateList.Add(p);
        }

        public void OptimizePath() {
            ArrayList optimizedList = new ArrayList();

            for(int i = 0; i < coordinateList.Count-2; i++) {

                Point startPoint = (Point) coordinateList[i];
                Point middlePoint = (Point) coordinateList[i + 1];
                Point endPoint = (Point) coordinateList[i + 2];

                while(IsOneLine(startPoint, middlePoint, endPoint)) {
                    i++;
                    middlePoint = (Point) coordinateList[i + 1];
                    if(i + 2 >= coordinateList.Count) break;
                    endPoint = (Point) coordinateList[i + 2];
                }

                optimizedList.Add(startPoint);
                optimizedList.Add(endPoint);
            }

            coordinateList = optimizedList;
        }

        private Boolean IsOneLine(Point start, Point middle, Point end) {

            int triangleSurface = start.X * (middle.Y - end.Y) +
                    middle.X * (end.Y - start.Y) +
                    end.X * (start.Y - middle.Y);

            if(triangleSurface < unprecision) return true;

            return false;
        }

        public ArrayList InstructionStrings() {
            OptimizePath();
            for(int i = 0; i < coordinateList.Count; i++) {
                Point coordinate = (Point) coordinateList[i];
                if(i == 0 || i == (coordinateList.Count - 1)) {
                    coordinateStringList.Add(coordinate.X.ToString("D4") + coordinate.Y.ToString("D4") + "F");
                } else {
                    coordinateStringList.Add(coordinate.X.ToString("D4") + coordinate.Y.ToString("D4") + "T");
                }
            }
            return coordinateStringList;
        }
    }
}
