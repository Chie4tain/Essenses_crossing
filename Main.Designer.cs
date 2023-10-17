namespace Essenses_crossing
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BtStart = new Button();
            BtSettings = new Button();
            LblFather = new Label();
            LblFathername = new Label();
            LblMother = new Label();
            LblMothername = new Label();
            PnMain = new Panel();
            pnlChildren = new Panel();
            PbImagesOfChildren = new PictureBox();
            PbFatherIcon = new PictureBox();
            PbMotherIcon = new PictureBox();
            PnlSettings = new Panel();
            TbarOffspringCount = new TrackBar();
            FlpControlMother = new FlowLayoutPanel();
            LbOffspring = new Label();
            FlpControlFather = new FlowLayoutPanel();
            BtSetSettings = new Button();
            LbSetMother = new Label();
            LbSetFather = new Label();
            Vsbar = new VScrollBar();
            TimerInvalidate = new System.Windows.Forms.Timer(components);
            PnMain.SuspendLayout();
            pnlChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbFatherIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbMotherIcon).BeginInit();
            PnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TbarOffspringCount).BeginInit();
            SuspendLayout();
            // 
            // BtStart
            // 
            BtStart.Location = new Point(134, 145);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(184, 50);
            BtStart.TabIndex = 0;
            BtStart.Text = "Start Crossing";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // BtSettings
            // 
            BtSettings.Location = new Point(620, 145);
            BtSettings.Name = "BtSettings";
            BtSettings.Size = new Size(184, 50);
            BtSettings.TabIndex = 1;
            BtSettings.Text = "Settings";
            BtSettings.UseVisualStyleBackColor = true;
            BtSettings.Click += BtSettings_Click;
            // 
            // LblFather
            // 
            LblFather.AutoSize = true;
            LblFather.Location = new Point(134, 25);
            LblFather.Name = "LblFather";
            LblFather.Size = new Size(49, 20);
            LblFather.TabIndex = 2;
            LblFather.Text = "Father";
            // 
            // LblFathername
            // 
            LblFathername.AutoSize = true;
            LblFathername.Location = new Point(134, 58);
            LblFathername.Name = "LblFathername";
            LblFathername.Size = new Size(106, 20);
            LblFathername.TabIndex = 3;
            LblFathername.Text = "Father's name: ";
            // 
            // LblMother
            // 
            LblMother.AutoSize = true;
            LblMother.Location = new Point(572, 25);
            LblMother.Name = "LblMother";
            LblMother.Size = new Size(57, 20);
            LblMother.TabIndex = 5;
            LblMother.Text = "Mother";
            // 
            // LblMothername
            // 
            LblMothername.AutoSize = true;
            LblMothername.Location = new Point(572, 58);
            LblMothername.Name = "LblMothername";
            LblMothername.Size = new Size(114, 20);
            LblMothername.TabIndex = 6;
            LblMothername.Text = "Mother's name: ";
            // 
            // PnMain
            // 
            PnMain.Controls.Add(pnlChildren);
            PnMain.Controls.Add(PbFatherIcon);
            PnMain.Controls.Add(PbMotherIcon);
            PnMain.Controls.Add(LblMother);
            PnMain.Controls.Add(BtSettings);
            PnMain.Controls.Add(BtStart);
            PnMain.Controls.Add(LblMothername);
            PnMain.Controls.Add(LblFathername);
            PnMain.Controls.Add(LblFather);
            PnMain.Location = new Point(3, 5);
            PnMain.Name = "PnMain";
            PnMain.Size = new Size(977, 515);
            PnMain.TabIndex = 8;
            // 
            // pnlChildren
            // 
            pnlChildren.AutoScroll = true;
            pnlChildren.Controls.Add(PbImagesOfChildren);
            pnlChildren.Location = new Point(9, 224);
            pnlChildren.Name = "pnlChildren";
            pnlChildren.Size = new Size(968, 291);
            pnlChildren.TabIndex = 11;
            // 
            // PbImagesOfChildren
            // 
            PbImagesOfChildren.Location = new Point(3, 3);
            PbImagesOfChildren.Name = "PbImagesOfChildren";
            PbImagesOfChildren.Size = new Size(959, 285);
            PbImagesOfChildren.TabIndex = 8;
            PbImagesOfChildren.TabStop = false;
            PbImagesOfChildren.Paint += Main_Paint;
            // 
            // PbFatherIcon
            // 
            PbFatherIcon.Location = new Point(330, 18);
            PbFatherIcon.Name = "PbFatherIcon";
            PbFatherIcon.Size = new Size(140, 96);
            PbFatherIcon.TabIndex = 10;
            PbFatherIcon.TabStop = false;
            // 
            // PbMotherIcon
            // 
            PbMotherIcon.Location = new Point(760, 18);
            PbMotherIcon.Name = "PbMotherIcon";
            PbMotherIcon.Size = new Size(140, 96);
            PbMotherIcon.TabIndex = 9;
            PbMotherIcon.TabStop = false;
            // 
            // PnlSettings
            // 
            PnlSettings.Controls.Add(TbarOffspringCount);
            PnlSettings.Controls.Add(FlpControlMother);
            PnlSettings.Controls.Add(LbOffspring);
            PnlSettings.Controls.Add(FlpControlFather);
            PnlSettings.Controls.Add(BtSetSettings);
            PnlSettings.Controls.Add(LbSetMother);
            PnlSettings.Controls.Add(LbSetFather);
            PnlSettings.Location = new Point(3, 5);
            PnlSettings.Name = "PnlSettings";
            PnlSettings.Size = new Size(977, 497);
            PnlSettings.TabIndex = 8;
            PnlSettings.Visible = false;
            // 
            // TbarOffspringCount
            // 
            TbarOffspringCount.Location = new Point(237, 340);
            TbarOffspringCount.Maximum = 100;
            TbarOffspringCount.Minimum = 1;
            TbarOffspringCount.Name = "TbarOffspringCount";
            TbarOffspringCount.Size = new Size(535, 56);
            TbarOffspringCount.TabIndex = 28;
            TbarOffspringCount.TickStyle = TickStyle.Both;
            TbarOffspringCount.Value = 1;
            TbarOffspringCount.ValueChanged += TbarOffspringCount_ValueChanged;
            // 
            // FlpControlMother
            // 
            FlpControlMother.AutoScroll = true;
            FlpControlMother.Location = new Point(507, 59);
            FlpControlMother.Name = "FlpControlMother";
            FlpControlMother.Size = new Size(461, 224);
            FlpControlMother.TabIndex = 10;
            // 
            // LbOffspring
            // 
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOffspring.Location = new Point(9, 303);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(194, 28);
            LbOffspring.TabIndex = 21;
            LbOffspring.Text = "Set offsping Number";
            // 
            // FlpControlFather
            // 
            FlpControlFather.Location = new Point(9, 59);
            FlpControlFather.Name = "FlpControlFather";
            FlpControlFather.Size = new Size(461, 224);
            FlpControlFather.TabIndex = 9;
            // 
            // BtSetSettings
            // 
            BtSetSettings.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            BtSetSettings.Location = new Point(347, 402);
            BtSetSettings.Name = "BtSetSettings";
            BtSetSettings.Size = new Size(282, 74);
            BtSetSettings.TabIndex = 14;
            BtSetSettings.Text = "OK";
            BtSetSettings.UseVisualStyleBackColor = true;
            BtSetSettings.Click += BtSetSettings_Click;
            // 
            // LbSetMother
            // 
            LbSetMother.AutoSize = true;
            LbSetMother.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSetMother.Location = new Point(507, 18);
            LbSetMother.Name = "LbSetMother";
            LbSetMother.Size = new Size(77, 28);
            LbSetMother.TabIndex = 9;
            LbSetMother.Text = "Mother";
            // 
            // LbSetFather
            // 
            LbSetFather.AutoSize = true;
            LbSetFather.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSetFather.Location = new Point(25, 18);
            LbSetFather.Name = "LbSetFather";
            LbSetFather.Size = new Size(66, 28);
            LbSetFather.TabIndex = 8;
            LbSetFather.Text = "Father";
            // 
            // Vsbar
            // 
            Vsbar.Enabled = false;
            Vsbar.LargeChange = 100;
            Vsbar.Location = new Point(1184, 5);
            Vsbar.Maximum = 1000;
            Vsbar.Name = "Vsbar";
            Vsbar.Size = new Size(28, 606);
            Vsbar.SmallChange = 10;
            Vsbar.TabIndex = 11;
            Vsbar.Visible = false;
            // 
            // TimerInvalidate
            // 
            TimerInvalidate.Interval = 1000;
            TimerInvalidate.Tick += TimerInvalidate_Tick_1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(700, 500);
            ClientSize = new Size(999, 653);
            Controls.Add(Vsbar);
            Controls.Add(PnlSettings);
            Controls.Add(PnMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PnMain.ResumeLayout(false);
            PnMain.PerformLayout();
            pnlChildren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbFatherIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbMotherIcon).EndInit();
            PnlSettings.ResumeLayout(false);
            PnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TbarOffspringCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtStart;
        private Button BtSettings;
        private Label LblFather;
        private Label LblFathername;
        private Label LblMother;
        private Label LblMothername;
        private Panel PnMain;
        private Panel PnlSettings;
        private Label LbSetMother;
        private Label LbSetFather;
        private PictureBox PbImagesOfChildren;
        private Button BtSetSettings;
        private Label LbOffspring;
        private PictureBox PbFatherIcon;
        private PictureBox PbMotherIcon;
        private Panel PnControl;
        private FlowLayoutPanel FlpControlFather;
        private FlowLayoutPanel FlpControlMother;
        private GroupBox GbAllele1Father;
        private GroupBox GbAllele2Father;
        private GroupBox GbAllele3Father;
        private GroupBox GbAllele2Mother;
        private GroupBox GbAllele3Mother;
        private GroupBox GbAllele1Mother;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private VScrollBar Vsbar;
        private System.Windows.Forms.Timer TimerInvalidate;
        private TrackBar TbarOffspringCount;
        private Panel pnlChildren;
    }
}