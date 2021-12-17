﻿using System.Drawing;

namespace task_paint
{
    class MyRectangle : Figure
    {

        int height, width;
        public MyRectangle(int PointStartX, int PointStartY, int height, int width)
        {

            x = PointStartX;
            y = PointStartY;
            this.height = height;
            this.width = width;

        }
        public override void Draw(Graphics gr)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Height = height;
            rectangle.Width = width;
            gr.DrawRectangle(new Pen(Color.Black, 5), rectangle);
        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new MyRectangle(x, y, height, width);

            if ((pointX <= x + width) && (pointX >= x) && ((pointY <= y + height) && (pointY >= y)))
            {
                IsPointsInside1 = true;
            }
            else
            {
                IsPointsInside1 = false;
            }
            if (IsPointsInside1 == true)
            {
                return figure;

            }
            else
            {
                return null;
            }




        }
    }
}
