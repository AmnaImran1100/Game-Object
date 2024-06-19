using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class boundaryBL
    {
        private pointBL topLeft;
        private pointBL topRight;
        private pointBL bottomLeft;
        private pointBL bottomRight;

        public boundaryBL() // Default Constructor
        {
            topLeft = new pointBL(0, 0);
            topRight = new pointBL(90, 0);
            bottomLeft = new pointBL(0, 90);
            bottomRight = new pointBL(90, 90);
        }

        public boundaryBL(pointBL topLeft, pointBL topRight, pointBL bottomLeft, pointBL bottomRight) // Parameterized Constructor to set boundaryBL in which Shape can Move
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }

        public void settopLeft(pointBL topLeft)
        {
            this.topLeft = topLeft;
        }

        public void settopRight(pointBL topRight)
        {
            this.topRight = topRight;
        }

        public void setbottomLeft(pointBL bottomLeft)
        {
            this.bottomLeft = bottomLeft;
        }

        public void setbottomRight(pointBL bottomRight)
        {
            this.bottomRight = bottomRight;
        }

        public pointBL gettopLeft()
        {
            return topLeft;
        }

        public pointBL gettopRight()
        {
            return topRight;
        }

        public pointBL getbottomLeft()
        {
            return bottomLeft;
        }

        public pointBL getbottomRight()
        {
            return bottomRight;
        }
    }
}
