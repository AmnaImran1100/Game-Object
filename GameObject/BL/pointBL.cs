﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class pointBL
    {
        private int x;
        private int y;

        public pointBL()
        {

        }

        public pointBL(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
