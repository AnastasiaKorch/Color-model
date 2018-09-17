namespace Color_models
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разложитьПоКаналамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преоюразоватьВHSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackbars = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hue = new System.Windows.Forms.TrackBar();
            this.val = new System.Windows.Forms.TrackBar();
            this.sat = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.trackbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.чернобелоеToolStripMenuItem,
            this.разложитьПоКаналамToolStripMenuItem,
            this.преоюразоватьВHSLToolStripMenuItem,
            this.сбросToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьtoolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьtoolStripMenuItem1
            // 
            this.сохранитьtoolStripMenuItem1.Name = "сохранитьtoolStripMenuItem1";
            this.сохранитьtoolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.сохранитьtoolStripMenuItem1.Text = "Сохранить";
            this.сохранитьtoolStripMenuItem1.Click += new System.EventHandler(this.сохранитьtoolStripMenuItem1_Click);
            // 
            // чернобелоеToolStripMenuItem
            // 
            this.чернобелоеToolStripMenuItem.Name = "чернобелоеToolStripMenuItem";
            this.чернобелоеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.чернобелоеToolStripMenuItem.Text = "Черно-белое";
            this.чернобелоеToolStripMenuItem.Click += new System.EventHandler(this.чернобелоеToolStripMenuItem_Click);
            // 
            // разложитьПоКаналамToolStripMenuItem
            // 
            this.разложитьПоКаналамToolStripMenuItem.Name = "разложитьПоКаналамToolStripMenuItem";
            this.разложитьПоКаналамToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.разложитьПоКаналамToolStripMenuItem.Text = "Разложить по каналам";
            this.разложитьПоКаналамToolStripMenuItem.Click += new System.EventHandler(this.разложитьПоКаналамToolStripMenuItem_Click);
            // 
            // преоюразоватьВHSLToolStripMenuItem
            // 
            this.преоюразоватьВHSLToolStripMenuItem.Name = "преоюразоватьВHSLToolStripMenuItem";
            this.преоюразоватьВHSLToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.преоюразоватьВHSLToolStripMenuItem.Text = "Преобразовать в HSV";
            this.преоюразоватьВHSLToolStripMenuItem.Click += new System.EventHandler(this.преобразоватьВHSVToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 572F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackbars, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 568);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(398, 307);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(389, 258);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 258);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(398, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(398, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Разность ч\\б / Blue";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ч\\б.2 / Green";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(398, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ч\\б.1 / Red / HSV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходник";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // trackbars
            // 
            this.trackbars.BackColor = System.Drawing.Color.White;
            this.trackbars.ColumnCount = 3;
            this.trackbars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.1671F));
            this.trackbars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.42416F));
            this.trackbars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.40874F));
            this.trackbars.Controls.Add(this.label7, 2, 0);
            this.trackbars.Controls.Add(this.label4, 1, 0);
            this.trackbars.Controls.Add(this.hue, 0, 1);
            this.trackbars.Controls.Add(this.val, 0, 1);
            this.trackbars.Controls.Add(this.sat, 0, 1);
            this.trackbars.Controls.Add(this.label3, 0, 0);
            this.trackbars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbars.Location = new System.Drawing.Point(793, 23);
            this.trackbars.Name = "trackbars";
            this.trackbars.RowCount = 2;
            this.trackbars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.trackbars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.trackbars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.trackbars.Size = new System.Drawing.Size(566, 258);
            this.trackbars.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(175, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Value";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(88, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satur.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hue
            // 
            this.hue.BackColor = System.Drawing.Color.White;
            this.hue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hue.Location = new System.Drawing.Point(3, 23);
            this.hue.Maximum = 50;
            this.hue.Minimum = -50;
            this.hue.Name = "hue";
            this.hue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.hue.Size = new System.Drawing.Size(79, 232);
            this.hue.TabIndex = 0;
            this.hue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessHSV);
            // 
            // val
            // 
            this.val.BackColor = System.Drawing.Color.White;
            this.val.Dock = System.Windows.Forms.DockStyle.Fill;
            this.val.Location = new System.Drawing.Point(175, 23);
            this.val.Maximum = 50;
            this.val.Minimum = -50;
            this.val.Name = "val";
            this.val.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.val.Size = new System.Drawing.Size(388, 232);
            this.val.TabIndex = 0;
            this.val.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessHSV);
            // 
            // sat
            // 
            this.sat.BackColor = System.Drawing.Color.White;
            this.sat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sat.Location = new System.Drawing.Point(88, 23);
            this.sat.Maximum = 50;
            this.sat.Minimum = -50;
            this.sat.Name = "sat";
            this.sat.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sat.Size = new System.Drawing.Size(81, 232);
            this.sat.TabIndex = 0;
            this.sat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcessHSV);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(793, 307);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            series3.ShadowColor = System.Drawing.Color.Navy;
            series4.BorderWidth = 6;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Gray;
            series4.Legend = "Legend1";
            series4.Name = "Интенсивность";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(563, 258);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1362, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.trackbars.ResumeLayout(false);
            this.trackbars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem чернобелоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разложитьПоКаналамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преоюразоватьВHSLToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel trackbars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar hue;
        private System.Windows.Forms.TrackBar val;
        private System.Windows.Forms.TrackBar sat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

