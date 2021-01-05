using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SpeedTest
{
    class DrawGraph
    {
        private List<Point> posXY = new List<Point>();   // position des points prinicipales
        private List<PointF> pointList = new List<PointF>();    // position de tous les points

        public int count = 0;
        private readonly int nb_pt_between_2point = 100;

        private readonly Pen pen;
        Graphics graph_panel_ping;

        public float height_factor;// scale the ping value with the panel size

        private readonly int stepX;
        public bool stop;
        private readonly int index;
        private readonly float unity_factor;
        public int time_pause = 1;
        public DrawGraph(Graphics Graph_panel_ping, int _index)
        {
            graph_panel_ping = Graph_panel_ping;
            graph_panel_ping.Clear(Color.DeepSkyBlue);
            pen = Form1.pen2;
            index = _index;
            if (index == 1)
            {
                stepX = 80;
                height_factor = 450 / 50;
                unity_factor = 1048576f;
                nb_pt_between_2point = 330;
            }
            else if (index == 2)
            {
                stepX = 20;
                height_factor = 450f / 150f;
                unity_factor = 1;
                nb_pt_between_2point = 150;
            }
        }


        public void DrawSetup(List<int> list)
        {
            posXY.Add(new Point(count * stepX, (int)(Form1.posY_0 - ((list[count]/unity_factor) * height_factor))));

            AddPoints();
            if (count != 0)
            {
                pointList.Add(posXY[count]);

                Draw(pointList);
            }
            if (index == 2 && count < 41 || index == 1 && count < 22)
                count++;
        }



        private PointF start, end, current;
        private void AddPoints()
        {
            if (count == 0)
            {
                pointList.Add(posXY[count]);
                return;
            }

            start = posXY[count - 1];
            end = posXY[count];

            float diff_X = end.X - start.X;
            float diff_Y = end.Y - start.Y;
            float interval_X = diff_X / (nb_pt_between_2point + 1);
            float interval_Y = diff_Y / (nb_pt_between_2point + 1);

            for (int y = 0; y < nb_pt_between_2point; y++)
            {
                current = new PointF(start.X + interval_X * y, start.Y + interval_Y * y);
                pointList.Add(current);
            }
        }

        private int y = 0;
        private readonly PointF[] aze = new PointF[4];
        private void Draw(List<PointF> pointList)
        {
            if (count > 1)
            {
                y = (pointList.Count - nb_pt_between_2point) - 1;
            }
            for (int i = y; i < pointList.Count; i++)
            {

                if (i % 2 == 0 && i != 0)
                {
                    aze[0] = new PointF(pointList[i - 2].X + 3, pointList[i - 2].Y + 4);
                    aze[1] = new PointF(pointList[i].X + 3, pointList[i].Y + 4);
                    aze[2] = new PointF(pointList[i - 2].X, Form1.posY_0);
                    aze[3] = new PointF(pointList[i].X, Form1.posY_0);
                    if (stop)
                    {
                        return;
                    }
                    try
                    {
                        graph_panel_ping.Flush(FlushIntention.Flush);
                        graph_panel_ping.DrawPolygon(pen, aze);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message + " ERROR");
                    }
                }
                Thread.Sleep(time_pause);
            }
        }
    }
}
