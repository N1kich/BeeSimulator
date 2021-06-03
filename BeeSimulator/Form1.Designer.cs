
namespace BeeSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSimStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripbtn_StartSim = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSavebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSerializebtn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBees = new System.Windows.Forms.Label();
            this.labelFlowers = new System.Windows.Forms.Label();
            this.labelTotalHoney = new System.Windows.Forms.Label();
            this.labelTotalNectar = new System.Windows.Forms.Label();
            this.labelFramesRun = new System.Windows.Forms.Label();
            this.labelFramesRate = new System.Windows.Forms.Label();
            this.textBees = new System.Windows.Forms.TextBox();
            this.textFlowers = new System.Windows.Forms.TextBox();
            this.textTotalHoney = new System.Windows.Forms.TextBox();
            this.textTotalNectar = new System.Windows.Forms.TextBox();
            this.textFramesRun = new System.Windows.Forms.TextBox();
            this.textFrameRate = new System.Windows.Forms.TextBox();
            this.BeeStatistic = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSimStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSimStatus
            // 
            this.toolStripSimStatus.Name = "toolStripSimStatus";
            this.toolStripSimStatus.Size = new System.Drawing.Size(124, 20);
            this.toolStripSimStatus.Text = "Simulation Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtn_StartSim,
            this.toolStripbtn_Reset,
            this.toolStripOpenbtn,
            this.toolStripSavebtn,
            this.toolStripSerializebtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripbtn_StartSim
            // 
            this.toolStripbtn_StartSim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripbtn_StartSim.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_StartSim.Image")));
            this.toolStripbtn_StartSim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_StartSim.Name = "toolStripbtn_StartSim";
            this.toolStripbtn_StartSim.Size = new System.Drawing.Size(119, 28);
            this.toolStripbtn_StartSim.Text = "Start Simulation";
            this.toolStripbtn_StartSim.Click += new System.EventHandler(this.toolStripbtn_StartSim_Click);
            // 
            // toolStripbtn_Reset
            // 
            this.toolStripbtn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripbtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_Reset.Image")));
            this.toolStripbtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_Reset.Name = "toolStripbtn_Reset";
            this.toolStripbtn_Reset.Size = new System.Drawing.Size(49, 28);
            this.toolStripbtn_Reset.Text = "Reset";
            this.toolStripbtn_Reset.Click += new System.EventHandler(this.toolStripbtn_Reset_Click);
            // 
            // toolStripOpenbtn
            // 
            this.toolStripOpenbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenbtn.Image = global::BeeSimulator.Properties.Resources.kisspng_computer_icons_directory_open_open_5ac2eeab86f7a1_3390743415227245235528;
            this.toolStripOpenbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenbtn.Name = "toolStripOpenbtn";
            this.toolStripOpenbtn.Size = new System.Drawing.Size(29, 28);
            this.toolStripOpenbtn.Text = "toolStripOpenbtn";
            this.toolStripOpenbtn.Click += new System.EventHandler(this.toolStripOpenbtn_Click);
            // 
            // toolStripSavebtn
            // 
            this.toolStripSavebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSavebtn.Image = global::BeeSimulator.Properties.Resources.png_transparent_floppy_disc_computer_icons_iconfinder_desktop_floppy_save_icon_miscellaneous_blue_angle_thumbnail;
            this.toolStripSavebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSavebtn.Name = "toolStripSavebtn";
            this.toolStripSavebtn.Size = new System.Drawing.Size(29, 28);
            this.toolStripSavebtn.Text = "toolStripSavebtn";
            this.toolStripSavebtn.Click += new System.EventHandler(this.toolStripSavebtn_Click);
            // 
            // toolStripSerializebtn
            // 
            this.toolStripSerializebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSerializebtn.Image = global::BeeSimulator.Properties.Resources.kisspng_paper_printing_computer_icons_print_5abd8ef67d1835_5215254315223723425124;
            this.toolStripSerializebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSerializebtn.Name = "toolStripSerializebtn";
            this.toolStripSerializebtn.Size = new System.Drawing.Size(29, 28);
            this.toolStripSerializebtn.Text = "toolStripSerializebtn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelBees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFlowers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalHoney, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalNectar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelFramesRun, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelFramesRate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textFlowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textTotalHoney, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textTotalNectar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textFramesRun, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textFrameRate, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 245);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // labelBees
            // 
            this.labelBees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBees.AutoSize = true;
            this.labelBees.Location = new System.Drawing.Point(3, 11);
            this.labelBees.Name = "labelBees";
            this.labelBees.Size = new System.Drawing.Size(244, 17);
            this.labelBees.TabIndex = 0;
            this.labelBees.Text = "#Bees----------------->";
            this.labelBees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFlowers
            // 
            this.labelFlowers.AutoSize = true;
            this.labelFlowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFlowers.Location = new System.Drawing.Point(3, 39);
            this.labelFlowers.Name = "labelFlowers";
            this.labelFlowers.Size = new System.Drawing.Size(244, 39);
            this.labelFlowers.TabIndex = 1;
            this.labelFlowers.Text = "#Flowers--------------->";
            this.labelFlowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalHoney
            // 
            this.labelTotalHoney.AutoSize = true;
            this.labelTotalHoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalHoney.Location = new System.Drawing.Point(3, 78);
            this.labelTotalHoney.Name = "labelTotalHoney";
            this.labelTotalHoney.Size = new System.Drawing.Size(244, 39);
            this.labelTotalHoney.TabIndex = 2;
            this.labelTotalHoney.Text = "Total honey in the hive-->\r\n";
            this.labelTotalHoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalNectar
            // 
            this.labelTotalNectar.AutoSize = true;
            this.labelTotalNectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalNectar.Location = new System.Drawing.Point(3, 117);
            this.labelTotalNectar.Name = "labelTotalNectar";
            this.labelTotalNectar.Size = new System.Drawing.Size(244, 39);
            this.labelTotalNectar.TabIndex = 3;
            this.labelTotalNectar.Text = "Total nectar in the field-->";
            this.labelTotalNectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFramesRun
            // 
            this.labelFramesRun.AutoSize = true;
            this.labelFramesRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFramesRun.Location = new System.Drawing.Point(3, 156);
            this.labelFramesRun.Name = "labelFramesRun";
            this.labelFramesRun.Size = new System.Drawing.Size(244, 39);
            this.labelFramesRun.TabIndex = 4;
            this.labelFramesRun.Text = "Frames run------------->";
            this.labelFramesRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFramesRate
            // 
            this.labelFramesRate.AutoSize = true;
            this.labelFramesRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFramesRate.Location = new System.Drawing.Point(3, 195);
            this.labelFramesRate.Name = "labelFramesRate";
            this.labelFramesRate.Size = new System.Drawing.Size(244, 50);
            this.labelFramesRate.TabIndex = 5;
            this.labelFramesRate.Text = "Frame rate--------------->";
            this.labelFramesRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBees
            // 
            this.textBees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBees.Location = new System.Drawing.Point(253, 3);
            this.textBees.Multiline = true;
            this.textBees.Name = "textBees";
            this.textBees.Size = new System.Drawing.Size(244, 33);
            this.textBees.TabIndex = 6;
            this.textBees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFlowers
            // 
            this.textFlowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFlowers.Location = new System.Drawing.Point(253, 42);
            this.textFlowers.Multiline = true;
            this.textFlowers.Name = "textFlowers";
            this.textFlowers.Size = new System.Drawing.Size(244, 33);
            this.textFlowers.TabIndex = 7;
            this.textFlowers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTotalHoney
            // 
            this.textTotalHoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTotalHoney.Location = new System.Drawing.Point(253, 81);
            this.textTotalHoney.Multiline = true;
            this.textTotalHoney.Name = "textTotalHoney";
            this.textTotalHoney.Size = new System.Drawing.Size(244, 33);
            this.textTotalHoney.TabIndex = 8;
            this.textTotalHoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTotalNectar
            // 
            this.textTotalNectar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTotalNectar.Location = new System.Drawing.Point(253, 120);
            this.textTotalNectar.Multiline = true;
            this.textTotalNectar.Name = "textTotalNectar";
            this.textTotalNectar.Size = new System.Drawing.Size(244, 33);
            this.textTotalNectar.TabIndex = 9;
            this.textTotalNectar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFramesRun
            // 
            this.textFramesRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFramesRun.Location = new System.Drawing.Point(253, 159);
            this.textFramesRun.Multiline = true;
            this.textFramesRun.Name = "textFramesRun";
            this.textFramesRun.Size = new System.Drawing.Size(244, 33);
            this.textFramesRun.TabIndex = 10;
            this.textFramesRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFrameRate
            // 
            this.textFrameRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFrameRate.Location = new System.Drawing.Point(253, 198);
            this.textFrameRate.Multiline = true;
            this.textFrameRate.Name = "textFrameRate";
            this.textFrameRate.Size = new System.Drawing.Size(244, 44);
            this.textFrameRate.TabIndex = 11;
            this.textFrameRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BeeStatistic
            // 
            this.BeeStatistic.FormattingEnabled = true;
            this.BeeStatistic.ItemHeight = 16;
            this.BeeStatistic.Location = new System.Drawing.Point(6, 307);
            this.BeeStatistic.Name = "BeeStatistic";
            this.BeeStatistic.Size = new System.Drawing.Size(500, 148);
            this.BeeStatistic.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 484);
            this.Controls.Add(this.BeeStatistic);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BeeHive Simulator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSimStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripbtn_StartSim;
        private System.Windows.Forms.ToolStripButton toolStripbtn_Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBees;
        private System.Windows.Forms.Label labelFlowers;
        private System.Windows.Forms.Label labelTotalHoney;
        private System.Windows.Forms.Label labelTotalNectar;
        private System.Windows.Forms.Label labelFramesRun;
        private System.Windows.Forms.Label labelFramesRate;
        private System.Windows.Forms.TextBox textBees;
        private System.Windows.Forms.TextBox textFlowers;
        private System.Windows.Forms.TextBox textTotalHoney;
        private System.Windows.Forms.TextBox textTotalNectar;
        private System.Windows.Forms.TextBox textFramesRun;
        private System.Windows.Forms.TextBox textFrameRate;
        private System.Windows.Forms.ListBox BeeStatistic;
        private System.Windows.Forms.ToolStripButton toolStripSavebtn;
        private System.Windows.Forms.ToolStripButton toolStripOpenbtn;
        private System.Windows.Forms.ToolStripButton toolStripSerializebtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

