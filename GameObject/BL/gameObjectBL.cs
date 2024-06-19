using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameObject.UI;

namespace GameObject.BL
{
    class gameObjectBL
    {
        private char[,] shape;
        private pointBL startingPoint;
        private boundaryBL premises;
        private string direction;

        public gameObjectBL()
        {
            shape = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            startingPoint = new pointBL();
            premises = new boundaryBL();
            direction = "LeftToRight";
        }

        public gameObjectBL(char[,] shape, pointBL startingPoint)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            premises = new boundaryBL();
            direction = "LeftToRight";
        }

        public gameObjectBL(char[,] shape, pointBL startingPoint, boundaryBL premises, string direction)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
        }

        public void erase()
        {
            Console.Clear();
        }

        public void draw() 
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(startingPoint.getX() + j, startingPoint.getY() + i);
                    GameUI.printOnConsole(shape[i, j]);
                }
            }
        }

        public void move()
        {
            int start = startingPoint.getX();

            if (direction == "LeftToRight")
            {
                while (start > premises.gettopRight().getX() && start < premises.getbottomRight().getX())
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start + j, startingPoint.getY() + i); 
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    start++; 
                }
            }

            else if (direction == "RightToLeft")
            {
                int start1 = startingPoint.getX();

                while (start1 > premises.gettopLeft().getX()) 
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start1 + j, startingPoint.getY() + i); 
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start1 + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    start1--; 
                }
            }

            else if (direction == "Patrol")
            {
                int start2 = startingPoint.getX();

                while (start2 > premises.gettopLeft().getX()) 
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start2 + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start2 + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    start2--; 
                }

                startingPoint.setX(1);
                start2 = startingPoint.getX();

                while (start2 > premises.gettopRight().getX() && start2 < premises.getbottomRight().getX()) 
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start2 + j, startingPoint.getY() + i); 
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(start2 + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    start2++; 
                }
            }

            else if (direction == "Projectile")
            {
                int s = startingPoint.getY();
                int control_movement = 0;
                while (control_movement < 5) 
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(startingPoint.getX() + j, s + i);
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(startingPoint.getX() + j, s + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    s--;
                    control_movement++;
                    startingPoint.setY(s - 1);
                }

                s = startingPoint.getX();
                control_movement = 0;
                while (control_movement < 3) 
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(s + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(s + j, startingPoint.getY() + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    s++;
                    control_movement++;
                    startingPoint.setX(s);
                }

                s = startingPoint.getY();
                control_movement = 0;
                while (control_movement < 4)
                {
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(startingPoint.getX() + j, s + i);
                            GameUI.printOnConsole(shape[i, j]);
                        }
                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < shape.GetLength(0); i++)
                    {
                        for (int j = 0; j < shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(startingPoint.getX() + j, s + i);
                            GameUI.printOnConsole(' ');
                        }
                    }
                    s++;
                    control_movement++;
                }
            }
        }
    }
}
