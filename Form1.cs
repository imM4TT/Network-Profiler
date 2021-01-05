using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTest
{
    public partial class Form1 : Form
    {
        #region class's var
        private TestPing pingManager;
        private DrawGraph drawManager;
        private Bandwidth bwManager;
        private int stepX; // en px
        public static int posX_0;
        public static int posY_0;

        public static int mainPosX_Max;
        public static int mainPosY_Max;

        private Point point_AxeY;

        private Graphics axeY, axeX;

        public static Pen pen = new Pen(Color.DarkBlue); // black pen
        public static Pen pen2 = new Pen(Color.FromArgb(64, Color.SkyBlue));

        public static bool start = false;
        private bool isLoading = false;
        private int current_index = 0; // 0: nothing, 1: test bw, 2: test latency

        private Graphics graph_main;
        public static int value_max_Y = 50;

        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        #endregion

        public Form1()
        {
            InitializeComponent();
            graph_main = panel_graph.CreateGraphics();
        }

        #region mains buttons listener
        private void button_menu_Click(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }
            current_index = 0;
            SetContent();
            SetBackground((Button)sender);
        }
        private void OnStartLatencyTest(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }

            current_index = 2;
            isLoading = true;
            OnStart();
            pingManager = new TestPing();
            drawManager = new DrawGraph(graph_main, current_index);
            SetBackground((Button)sender);
            Task.Factory.StartNew(Main, tokenSource.Token);
        }

        private void OnStartBandwidthTest(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }

            current_index = 1;
            isLoading = true;
            OnStart();
            bwManager = new Bandwidth();
            drawManager = new DrawGraph(graph_main, current_index);
            SetBackground((Button)sender);
            Task.Factory.StartNew(Main, tokenSource.Token);
        }
        #endregion



        private void Main()
        {
            if (current_index == 2)
            {
                drawManager.time_pause = 1;
                isLoading = false;
                SetPannels();
                SetAxis();
                while (drawManager.count < 41 && start && current_index == 2)
                {
                    if (pingManager.Ping() && start)
                    {
                        drawManager.DrawSetup(pingManager.listValue);
                    }
                    Thread.Sleep(20);
                }
            }
            else if(current_index == 1)
            {
                drawManager.time_pause = 2;
                while (drawManager.count < 11 && start && current_index == 1)
                {
                    Thread.Sleep(bwManager.waitTime);
                    bwManager.SetStats();
                    if (bwManager.index_bw < 9)
                    {
                        continue;
                    }
                    else if (bwManager.index_bw == 9)
                    {
                        isLoading = false;
                        if(bwManager.avrg < 1048576f)
                        {
                            if(bwManager.avrg < (bwManager.avrg / 2))
                            {
                                value_max_Y = 1;
                            }
                            else
                                value_max_Y = 2;
                            bwManager.unity = "(KB/s)";
                            bwManager.unity_factor = 1024;
                        }
                        else
                        {
                            value_max_Y = RoundUp((int)(bwManager.avrg / 1048576f) * 2);
                            bwManager.unity = "(MB/s)";
                            bwManager.unity_factor = 1048576;
                        }
                        label_download_unity.Text = bwManager.unity;
                        drawManager.height_factor = 450 / value_max_Y;
                        bwManager.ResetStats();
                        SetPannels();
                        SetAxis();
                        continue;
                    }
                    else
                    {
                        drawManager.DrawSetup(bwManager.listValue);
                    }
                }
            }
            OnEnd();
        }

        #region privates methodes

        private void OnStart()
        {
            if (current_index == 0)
            {
                SetContent();
                return;
            }

            SetContent();
            start = true;
        }

        private void SetContent()
        {
            ResetResult();
            SetPannels();;
            SetLabels();
            SetGraphs();
            SetPositions();
            SetPens();
            SetAxis();
            SetTimers();
        }

        private void ResetResult()
        {
            label_averageValue.Text = "";
            label_currentValue.Text = "";
            label_maxValue.Text = "";
            label_minValue.Text = "";
            label_latency_loss_value.Text = "";
        }

        private void SetPannels()
        {
            bool state = true;
            bool state2 = true;
            if (current_index == 0)
            {
                state = true;
                state2 = false;
            }
            else if ((current_index == 1 || current_index == 2) && isLoading)
            {
                state = true;
                state2 = true;
            }
            else if ((current_index == 1 || current_index == 2) && !isLoading)
            {
                state = false;
                state2 = false;

            }
            Invoke((MethodInvoker)delegate 
            {
                panel_graph_hide.Visible = state;
                panel_footer_hide.Visible = state;
                image_load.Visible = state2;
            });
        }

        private void SetLabels()
        {
            if(current_index == 0)
            {
                label_count.Visible = false;
                return;
            }
            label_count.Visible = true;
            if (current_index == 1)
            {
                if(isLoading)
                    label_count.Text = "";
                else
                    label_count.Text = "t(0)";
                label_download.Visible = true;
                label_download_unity.Visible = true;
                label_latency.Visible = false;
                label_latency_unity.Visible = false;

            }
            else if(current_index == 2)
            {
                if (isLoading)
                    label_count.Text = "";
                else
                    label_count.Text = "n(0)";
                label_latency.Visible = true;
                label_latency_unity.Visible = true;
                label_download.Visible = false;
                label_download_unity.Visible = false;

            }
        }

        private void SetGraphs()
        {
            if (current_index == 0)
                return;
            axeY = panel_content.CreateGraphics();
            axeX = panel_axeY.CreateGraphics();
        }

        private void SetPositions()
        {
            if (current_index == 0)
            {
                return;
            }

            posX_0 = panel_graph.Bounds.Left;
            posY_0 = panel_graph.Bounds.Height - 2;

            mainPosX_Max = MainP.Bounds.Width - 2;
            mainPosY_Max = MainP.Bounds.Height - 2;


            point_AxeY = new Point(20, 15);
        }

        private void SetPens()
        {
            pen.Width = 1f;
            pen.LineJoin = LineJoin.Round;
            pen.DashCap = DashCap.Round;
            pen.DashStyle = DashStyle.DashDotDot;
            pen.Alignment = PenAlignment.Right;
            pen.StartCap = LineCap.Round;
            pen2.Width = 2f;
            pen2.LineJoin = LineJoin.MiterClipped;
            pen2.DashCap = DashCap.Flat;
        }

        private void SetAxis()
        {
            ClearAxis();
            if (current_index == 0 || isLoading)
            {
                return;
            }

            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 191, 0));
            Font fontTitle = new Font("Arial", 16);
            Font fontAxis = new Font("Arial", 8);

            string titleAxisY;

            int value_max_y;//valeur max sur l'axe Y
            int step_y = 0;

            if (current_index == 2)
            {
                titleAxisY = "Latency (ms)";
                value_max_y = 150;
                stepX = 20; // 20px
                step_y = (450 / value_max_y) * 10;
            }
            else
            {
                titleAxisY = "Download Speed (Mbytes)";
                value_max_y = value_max_Y;
                stepX = 80;
                int x = (int)Char.GetNumericValue(value_max_y.ToString().Substring(0)[0]);
                if (value_max_y < 100 && value_max_y >= 10)
                {
                    step_y = 450 / x;
                }
                else if (value_max_y == 2)
                {
                    step_y = (450 / 4);
                }
                else if (value_max_y == 1)
                {
                    step_y = (450 / 10);
                }

            }

            axeY.DrawString(titleAxisY, fontTitle, drawBrush, point_AxeY);
           

            int posX = panel_graph.Bounds.Left - 10;
            float v = value_max_y;

            for (int i = 0; i < panel_axeY.Height; i += step_y) // Axe Y
            {
                axeX.DrawString("-", fontTitle, drawBrush, new Point(posX, i - 10)); // creation de chaque step
                if (value_max_y < 100)
                {
                    axeX.DrawString(v.ToString(), fontAxis, drawBrush, new Point(posX - 15, i));
                }
                else
                {
                    axeX.DrawString(v.ToString(), fontAxis, drawBrush, new Point(posX - 20, i));
                }

                if(value_max_y != 2 && value_max_y != 1)
                    v -= 10;
                else
                {
                    if (value_max_y == 2)
                    {
                        v -= 1f/2f;
                    }
                    else if (value_max_y == 1)
                    {
                        v -= 1f/10f;
                    }
                }
            }
            for (int i = 0; i < panel_graph.Width; i += stepX) // Axe X
            {
                if (i % stepX == 0)
                {
                    axeY.DrawString("|", fontAxis, drawBrush, new Point(i + 37, 495)); // creation de chaque step
                }
                if (i % (stepX * 10) == 0 && current_index == 2 && i != 0 )
                {
                    axeY.DrawString(((i) / stepX).ToString(), fontAxis, drawBrush, new Point(i - stepX + 37, 505)); // creation de chaque step
                }
                if (i % (stepX * 5) == 0 && current_index == 1)
                {
                    axeY.DrawString((i / stepX).ToString(), fontAxis, drawBrush, new Point(i + 37, 505)); // creation de chaque step
                }
            }

            if (current_index == 2)
            {
                axeY.DrawString("1", fontAxis, drawBrush, new Point(37, 505)); // creation de chaque step
            }
        }

        private void SetTimers()
        {
            if (current_index == 2)
            {
                timer.Enabled = true;
                timer.Interval = 220;

            }
            else if(current_index == 1)
            {
                timer.Enabled = true;
                timer.Interval = 200;

            }
            else
            {
                timer.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start && current_index == 2 && !isLoading)
            {
                label_currentValue.Text = pingManager.p_currentValue.ToString();
                label_averageValue.Text = pingManager.p_averageValue.ToString();
                label_maxValue.Text = pingManager.p_maxValue.ToString();
                label_minValue.Text = pingManager.p_minValue.ToString();
                label_latency_loss_value.Text = pingManager.percentage_packetLoss.ToString();
                label_count.Text = "n("+drawManager.count.ToString()+")";
            }
            else if (start && current_index == 1 && !isLoading)
            {
                label_currentValue.Text = bwManager.ToXBytes(bwManager.current);
                //label_averageValue.Text = bwManager.ToXBytes(bwManager.avrg);
                label_maxValue.Text = bwManager.ToXBytes(bwManager.max);
                label_minValue.Text = bwManager.ToXBytes(bwManager.min);
                label_count.Text = "t(" + drawManager.count.ToString() + "s)";
            }
        }

        private void OnEnd()
        {
            isLoading = false;
            drawManager.stop = true;

            if (current_index == 1)
            {
                try
                {
                    bwManager.StopDownload();
                }
                catch (Exception)
                {

                    throw;
                }

            }

            start = false;
            current_index = 0;
        }

        private void ClearAxis()
        {
            if(axeY == null)
            {
                return;
            }
            axeX.Clear(Color.FromArgb(24, 26, 27));
            axeY.Clear(Color.FromArgb(24, 26, 27));
        }

        private int RoundUp(int toRound)
        {
            if (toRound % 10 == 0) return toRound;
            return (10 - toRound % 10) + toRound;
        }

        #endregion

        #region methods buttons background
        private void button_latency_MouseEnter(object sender, EventArgs e)
        {
            button_latency.BackgroundImage = Properties.Resources.bg_title_hover;
        }
        private void button_latency_MouseLeave(object sender, EventArgs e)
        {
            if(current_index == 2)
            {
                button_latency.BackgroundImage = Properties.Resources.bg_title_sel;
            }
            else
            {
                button_latency.BackgroundImage = Properties.Resources.bg_title1;
            }
        }
        private void button_latency_MouseDown(object sender, MouseEventArgs e)
        {
            button_latency.BackgroundImage = Properties.Resources.bg_title_down;
        }

        private void button_bw_MouseEnter(object sender, EventArgs e)
        {
            button_bw.BackgroundImage = Properties.Resources.bg_title_hover;
        }
        private void button_bw_MouseLeave(object sender, EventArgs e)
        {
            if (current_index == 1)
            {
                button_bw.BackgroundImage = Properties.Resources.bg_title_sel;
            }
            else
            {
                button_bw.BackgroundImage = Properties.Resources.bg_title1;
            }

        }
        private void button_bw_MouseDown(object sender, MouseEventArgs e)
        {
            button_bw.BackgroundImage = Properties.Resources.bg_title_down;
        }



        private void SetBackground(Button b)
        {

            if (b.Name == button_bw.Name)
            {
                b.BackgroundImage = Properties.Resources.bg_title_sel;
                button_latency.BackgroundImage = Properties.Resources.bg_title1;
                button_menu.FlatAppearance.BorderSize = 0;
            }
            else if (b.Name == button_latency.Name)
            {
                b.BackgroundImage = Properties.Resources.bg_title_sel;
                button_bw.BackgroundImage = Properties.Resources.bg_title1;
                button_menu.FlatAppearance.BorderSize = 0;
            }
            else if (b.Name == button_menu.Name)
            {
                button_latency.BackgroundImage = Properties.Resources.bg_title1;
                button_bw.BackgroundImage = Properties.Resources.bg_title1;
                button_menu.FlatAppearance.BorderSize = 3;
            }
        }
        #endregion

        #region static method
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
        #endregion
    }
}
