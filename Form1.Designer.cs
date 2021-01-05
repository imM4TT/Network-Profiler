using System.Drawing;
using System.Windows.Forms;

namespace SpeedTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form


        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_result = new System.Windows.Forms.TableLayoutPanel();
            this.label_average = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_latency_loss_value = new System.Windows.Forms.Label();
            this.label_currentValue = new System.Windows.Forms.Label();
            this.label_maxValue = new System.Windows.Forms.Label();
            this.label_averageValue = new System.Windows.Forms.Label();
            this.label_minValue = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            this.label_latency_loss = new System.Windows.Forms.Label();
            this.label_download_unity = new System.Windows.Forms.Label();
            this.label_download = new System.Windows.Forms.Label();
            this.label_latency_unity = new System.Windows.Forms.Label();
            this.label_latency = new System.Windows.Forms.Label();
            this.panel_footer_hide = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.label_count = new System.Windows.Forms.Label();
            this.panel_graph_hide = new System.Windows.Forms.Panel();
            this.panel_axeY = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_graph = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_bw = new System.Windows.Forms.Button();
            this.button_latency = new System.Windows.Forms.Button();
            this.image_load = new System.Windows.Forms.PictureBox();
            this.pannel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.nameApp = new System.Windows.Forms.PictureBox();
            this.panel_footer.SuspendLayout();
            this.panel_result.SuspendLayout();
            this.panel_content.SuspendLayout();
            this.panel_graph_hide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_load)).BeginInit();
            this.pannel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameApp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 220;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_footer.Controls.Add(this.panel_result);
            this.panel_footer.Controls.Add(this.label_download_unity);
            this.panel_footer.Controls.Add(this.label_download);
            this.panel_footer.Controls.Add(this.label_latency_unity);
            this.panel_footer.Controls.Add(this.label_latency);
            this.panel_footer.Controls.Add(this.pictureBox1);
            this.panel_footer.Location = new System.Drawing.Point(2, 643);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(890, 101);
            this.panel_footer.TabIndex = 6;
            // 
            // panel_result
            // 
            this.panel_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_result.ColumnCount = 5;
            this.panel_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.73529F));
            this.panel_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.26471F));
            this.panel_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.panel_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.panel_result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.panel_result.Controls.Add(this.label_average, 1, 0);
            this.panel_result.Controls.Add(this.label_max, 2, 0);
            this.panel_result.Controls.Add(this.label_min, 3, 0);
            this.panel_result.Controls.Add(this.label_latency_loss_value, 4, 1);
            this.panel_result.Controls.Add(this.label_currentValue, 0, 1);
            this.panel_result.Controls.Add(this.label_averageValue, 1, 1);
            this.panel_result.Controls.Add(this.label_minValue, 3, 1);
            this.panel_result.Controls.Add(this.label_current, 0, 0);
            this.panel_result.Controls.Add(this.label_latency_loss, 4, 0);
            this.panel_result.Controls.Add(this.label_maxValue, 2, 1);
            this.panel_result.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_result.Location = new System.Drawing.Point(255, 12);
            this.panel_result.Margin = new System.Windows.Forms.Padding(0);
            this.panel_result.Name = "panel_result";
            this.panel_result.RowCount = 2;
            this.panel_result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.panel_result.Size = new System.Drawing.Size(404, 77);
            this.panel_result.TabIndex = 29;
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_average.Location = new System.Drawing.Point(94, 5);
            this.label_average.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(59, 19);
            this.label_average.TabIndex = 4;
            this.label_average.Text = "Average";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_max.Location = new System.Drawing.Point(180, 5);
            this.label_max.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(35, 19);
            this.label_max.TabIndex = 6;
            this.label_max.Text = "Max";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_min.Location = new System.Drawing.Point(261, 5);
            this.label_min.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(33, 19);
            this.label_min.TabIndex = 5;
            this.label_min.Text = "Min";
            // 
            // label_latency_loss_value
            // 
            this.label_latency_loss_value.AutoSize = true;
            this.label_latency_loss_value.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_latency_loss_value.Location = new System.Drawing.Point(355, 40);
            this.label_latency_loss_value.Margin = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.label_latency_loss_value.Name = "label_latency_loss_value";
            this.label_latency_loss_value.Size = new System.Drawing.Size(13, 14);
            this.label_latency_loss_value.TabIndex = 26;
            this.label_latency_loss_value.Text = "0";
            // 
            // label_currentValue
            // 
            this.label_currentValue.AutoSize = true;
            this.label_currentValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentValue.Location = new System.Drawing.Point(10, 40);
            this.label_currentValue.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.label_currentValue.Name = "label_currentValue";
            this.label_currentValue.Size = new System.Drawing.Size(13, 14);
            this.label_currentValue.TabIndex = 18;
            this.label_currentValue.Text = "0";
            // 
            // label_maxValue
            // 
            this.label_maxValue.AutoSize = true;
            this.label_maxValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maxValue.Location = new System.Drawing.Point(190, 40);
            this.label_maxValue.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.label_maxValue.Name = "label_maxValue";
            this.label_maxValue.Size = new System.Drawing.Size(13, 14);
            this.label_maxValue.TabIndex = 20;
            this.label_maxValue.Text = "0";
            // 
            // label_averageValue
            // 
            this.label_averageValue.AutoSize = true;
            this.label_averageValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_averageValue.Location = new System.Drawing.Point(99, 40);
            this.label_averageValue.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.label_averageValue.Name = "label_averageValue";
            this.label_averageValue.Size = new System.Drawing.Size(13, 14);
            this.label_averageValue.TabIndex = 19;
            this.label_averageValue.Text = "0";
            // 
            // label_minValue
            // 
            this.label_minValue.AutoSize = true;
            this.label_minValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minValue.Location = new System.Drawing.Point(266, 40);
            this.label_minValue.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.label_minValue.Name = "label_minValue";
            this.label_minValue.Size = new System.Drawing.Size(13, 14);
            this.label_minValue.TabIndex = 21;
            this.label_minValue.Text = "0";
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_current.Location = new System.Drawing.Point(5, 5);
            this.label_current.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(56, 19);
            this.label_current.TabIndex = 7;
            this.label_current.Text = "Current";
            // 
            // label_latency_loss
            // 
            this.label_latency_loss.AutoSize = true;
            this.label_latency_loss.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_latency_loss.Location = new System.Drawing.Point(325, 5);
            this.label_latency_loss.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_latency_loss.Name = "label_latency_loss";
            this.label_latency_loss.Size = new System.Drawing.Size(76, 20);
            this.label_latency_loss.TabIndex = 25;
            this.label_latency_loss.Text = "PcktLoss(%)";
            // 
            // label_download_unity
            // 
            this.label_download_unity.AutoSize = true;
            this.label_download_unity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.label_download_unity.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_download_unity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label_download_unity.Location = new System.Drawing.Point(66, 25);
            this.label_download_unity.Margin = new System.Windows.Forms.Padding(0);
            this.label_download_unity.Name = "label_download_unity";
            this.label_download_unity.Size = new System.Drawing.Size(44, 19);
            this.label_download_unity.TabIndex = 28;
            this.label_download_unity.Text = "(KB/s)";
            this.label_download_unity.Visible = false;
            // 
            // label_download
            // 
            this.label_download.AutoSize = true;
            this.label_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.label_download.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label_download.Location = new System.Drawing.Point(12, 0);
            this.label_download.Margin = new System.Windows.Forms.Padding(0);
            this.label_download.Name = "label_download";
            this.label_download.Size = new System.Drawing.Size(104, 25);
            this.label_download.TabIndex = 13;
            this.label_download.Text = "Download";
            this.label_download.Visible = false;
            // 
            // label_latency_unity
            // 
            this.label_latency_unity.AutoSize = true;
            this.label_latency_unity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.label_latency_unity.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_latency_unity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label_latency_unity.Location = new System.Drawing.Point(13, 25);
            this.label_latency_unity.Margin = new System.Windows.Forms.Padding(0);
            this.label_latency_unity.Name = "label_latency_unity";
            this.label_latency_unity.Size = new System.Drawing.Size(35, 19);
            this.label_latency_unity.TabIndex = 27;
            this.label_latency_unity.Text = "(ms)";
            this.label_latency_unity.Visible = false;
            // 
            // label_latency
            // 
            this.label_latency.AutoSize = true;
            this.label_latency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.label_latency.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_latency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label_latency.Location = new System.Drawing.Point(12, 0);
            this.label_latency.Margin = new System.Windows.Forms.Padding(0);
            this.label_latency.Name = "label_latency";
            this.label_latency.Size = new System.Drawing.Size(80, 25);
            this.label_latency.TabIndex = 2;
            this.label_latency.Text = "Latency";
            this.label_latency.Visible = false;
            // 
            // panel_footer_hide
            // 
            this.panel_footer_hide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_footer_hide.Location = new System.Drawing.Point(1, 643);
            this.panel_footer_hide.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footer_hide.Name = "panel_footer_hide";
            this.panel_footer_hide.Size = new System.Drawing.Size(885, 103);
            this.panel_footer_hide.TabIndex = 22;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panel_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_content.Controls.Add(this.label_count);
            this.panel_content.Controls.Add(this.panel_graph_hide);
            this.panel_content.Controls.Add(this.panel_axeY);
            this.panel_content.Controls.Add(this.panel_graph);
            this.panel_content.Location = new System.Drawing.Point(1, 93);
            this.panel_content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(882, 550);
            this.panel_content.TabIndex = 4;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.label_count.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.label_count.Location = new System.Drawing.Point(805, 525);
            this.label_count.Margin = new System.Windows.Forms.Padding(0);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(33, 19);
            this.label_count.TabIndex = 29;
            this.label_count.Text = "n(0)";
            this.label_count.Visible = false;
            // 
            // panel_graph_hide
            // 
            this.panel_graph_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panel_graph_hide.Controls.Add(this.image_load);
            this.panel_graph_hide.Location = new System.Drawing.Point(40, 50);
            this.panel_graph_hide.Margin = new System.Windows.Forms.Padding(0);
            this.panel_graph_hide.Name = "panel_graph_hide";
            this.panel_graph_hide.Size = new System.Drawing.Size(801, 450);
            this.panel_graph_hide.TabIndex = 5;
            // 
            // panel_axeY
            // 
            this.panel_axeY.Location = new System.Drawing.Point(0, 50);
            this.panel_axeY.Margin = new System.Windows.Forms.Padding(0);
            this.panel_axeY.Name = "panel_axeY";
            this.panel_axeY.Size = new System.Drawing.Size(40, 450);
            this.panel_axeY.TabIndex = 3;
            // 
            // panel_graph
            // 
            this.panel_graph.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_graph.Location = new System.Drawing.Point(40, 50);
            this.panel_graph.Margin = new System.Windows.Forms.Padding(0);
            this.panel_graph.Name = "panel_graph";
            this.panel_graph.Size = new System.Drawing.Size(801, 450);
            this.panel_graph.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_bw);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Controls.Add(this.button_latency);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 26);
            this.panel1.TabIndex = 7;
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button_menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.button_menu.FlatAppearance.BorderSize = 4;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Location = new System.Drawing.Point(1, -10);
            this.button_menu.Margin = new System.Windows.Forms.Padding(0);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(115, 43);
            this.button_menu.TabIndex = 7;
            this.button_menu.Text = "Main Menu";
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeedTest.Properties.Resources.bg1;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 82);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button_bw
            // 
            this.button_bw.BackgroundImage = global::SpeedTest.Properties.Resources.bg_title1;
            this.button_bw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_bw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bw.FlatAppearance.BorderSize = 0;
            this.button_bw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_bw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_bw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bw.Location = new System.Drawing.Point(268, -1);
            this.button_bw.Margin = new System.Windows.Forms.Padding(0);
            this.button_bw.Name = "button_bw";
            this.button_bw.Size = new System.Drawing.Size(151, 26);
            this.button_bw.TabIndex = 8;
            this.button_bw.Text = "Bandwith Test";
            this.button_bw.UseVisualStyleBackColor = false;
            this.button_bw.Click += new System.EventHandler(this.OnStartBandwidthTest);
            this.button_bw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_bw_MouseDown);
            this.button_bw.MouseEnter += new System.EventHandler(this.button_bw_MouseEnter);
            this.button_bw.MouseLeave += new System.EventHandler(this.button_bw_MouseLeave);
            // 
            // button_latency
            // 
            this.button_latency.BackgroundImage = global::SpeedTest.Properties.Resources.bg_title1;
            this.button_latency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_latency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_latency.FlatAppearance.BorderSize = 0;
            this.button_latency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_latency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_latency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_latency.Location = new System.Drawing.Point(543, -1);
            this.button_latency.Margin = new System.Windows.Forms.Padding(0);
            this.button_latency.Name = "button_latency";
            this.button_latency.Size = new System.Drawing.Size(151, 26);
            this.button_latency.TabIndex = 0;
            this.button_latency.Text = "Latency Test";
            this.button_latency.UseVisualStyleBackColor = false;
            this.button_latency.Click += new System.EventHandler(this.OnStartLatencyTest);
            this.button_latency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_latency_MouseDown);
            this.button_latency.MouseEnter += new System.EventHandler(this.button_latency_MouseEnter);
            this.button_latency.MouseLeave += new System.EventHandler(this.button_latency_MouseLeave);
            // 
            // image_load
            // 
            this.image_load.BackColor = System.Drawing.Color.Transparent;
            this.image_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_load.Image = ((System.Drawing.Image)(resources.GetObject("image_load.Image")));
            this.image_load.Location = new System.Drawing.Point(316, 150);
            this.image_load.Name = "image_load";
            this.image_load.Size = new System.Drawing.Size(160, 164);
            this.image_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_load.TabIndex = 0;
            this.image_load.TabStop = false;
            this.image_load.Visible = false;
            // 
            // pannel_header
            // 
            this.pannel_header.BackColor = System.Drawing.Color.Transparent;
            this.pannel_header.BackgroundImage = global::SpeedTest.Properties.Resources.bgheader3;
            this.pannel_header.Controls.Add(this.label1);
            this.pannel_header.Controls.Add(this.label_description);
            this.pannel_header.Controls.Add(this.nameApp);
            this.pannel_header.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pannel_header.Location = new System.Drawing.Point(0, 0);
            this.pannel_header.Margin = new System.Windows.Forms.Padding(0);
            this.pannel_header.Name = "pannel_header";
            this.pannel_header.Size = new System.Drawing.Size(890, 67);
            this.pannel_header.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(132, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Look for your maximum connexion speed.\r\n";
            // 
            // label_description
            // 
            this.label_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_description.Location = new System.Drawing.Point(517, 11);
            this.label_description.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(320, 21);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Check your latency with ICMP protocol.";
            // 
            // nameApp
            // 
            this.nameApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nameApp.Image = global::SpeedTest.Properties.Resources.title1;
            this.nameApp.Location = new System.Drawing.Point(0, 0);
            this.nameApp.Margin = new System.Windows.Forms.Padding(0);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(116, 67);
            this.nameApp.TabIndex = 3;
            this.nameApp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(884, 741);
            this.Controls.Add(this.panel_footer_hide);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.pannel_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 780);
            this.MinimumSize = new System.Drawing.Size(900, 780);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Test";
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_result.ResumeLayout(false);
            this.panel_result.PerformLayout();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.panel_graph_hide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_load)).EndInit();
            this.pannel_header.ResumeLayout(false);
            this.pannel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        public Panel MainP { get { return panel_content; } }
        private Panel pannel_header;
        private PictureBox nameApp;
        private Label label_description;
        private Timer timer;
        private Panel panel_footer;
        private Label label_latency;
        private Label label_average;
        private Label label_download;
        private Label label_current;
        private Label label_max;
        private Label label_min;
        private Label label_minValue;
        private Label label_maxValue;
        private Label label_averageValue;
        private Label label_currentValue;
        private Panel panel_footer_hide;
        private Panel panel_content;
        private FlowLayoutPanel panel_axeY;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label_latency_loss_value;
        private Label label_latency_loss;
        private Label label_download_unity;
        private Label label_latency_unity;
        private Panel panel_graph;
        private Panel panel_graph_hide;
        private Button button_latency;
        private Label label_count;
        private TableLayoutPanel panel_result;
        private Panel panel1;
        private Button button_menu;
        private Button button_bw;
        private PictureBox image_load;
    }
}



