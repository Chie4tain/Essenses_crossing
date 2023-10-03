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
            BtStart = new Button();
            BtSettings = new Button();
            LblFather = new Label();
            LblFathername = new Label();
            LblFathergen = new Label();
            LblMother = new Label();
            LblMothername = new Label();
            LblMothergen = new Label();
            PnMain = new Panel();
            PbImagesOfChildren = new PictureBox();
            PnlSettings = new Panel();
            GbMAllele2 = new GroupBox();
            RbMotherAllele2Dominant = new RadioButton();
            RbMotherAllele2Recessive = new RadioButton();
            GbMAllele1 = new GroupBox();
            RbMotherAllele1Dominant = new RadioButton();
            RbMotherAllele1Recessive = new RadioButton();
            GbFAllele2 = new GroupBox();
            RbFatherAllele2Dominant = new RadioButton();
            RbFatherAllele2Recessive = new RadioButton();
            LblSetFAllele1 = new Label();
            GbFAllele1 = new GroupBox();
            RbFatherAllele1Dominant = new RadioButton();
            RbFatherAllele1Recessive = new RadioButton();
            btSetOffspringNumber100 = new Button();
            btSetOffspringNumber50 = new Button();
            btSetOffspringNumber10 = new Button();
            LbOffspring = new Label();
            BtSetSettings = new Button();
            LblSetMAllele2 = new Label();
            LblSetFAllele2 = new Label();
            LblSetMAllele1 = new Label();
            LbSetMother = new Label();
            LbSetFather = new Label();
            PnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).BeginInit();
            PnlSettings.SuspendLayout();
            GbMAllele2.SuspendLayout();
            GbMAllele1.SuspendLayout();
            GbFAllele2.SuspendLayout();
            GbFAllele1.SuspendLayout();
            SuspendLayout();
            // 
            // BtStart
            // 
            BtStart.Location = new Point(25, 146);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(184, 50);
            BtStart.TabIndex = 0;
            BtStart.Text = "Start Crossing";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // BtSettings
            // 
            BtSettings.Location = new Point(408, 146);
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
            LblFather.Location = new Point(25, 26);
            LblFather.Name = "LblFather";
            LblFather.Size = new Size(49, 20);
            LblFather.TabIndex = 2;
            LblFather.Text = "Father";
            // 
            // LblFathername
            // 
            LblFathername.AutoSize = true;
            LblFathername.Location = new Point(25, 59);
            LblFathername.Name = "LblFathername";
            LblFathername.Size = new Size(106, 20);
            LblFathername.TabIndex = 3;
            LblFathername.Text = "Father's name: ";
            // 
            // LblFathergen
            // 
            LblFathergen.AutoSize = true;
            LblFathergen.Location = new Point(25, 95);
            LblFathergen.Name = "LblFathergen";
            LblFathergen.Size = new Size(133, 20);
            LblFathergen.TabIndex = 4;
            LblFathergen.Text = "Father's Genotype: ";
            // 
            // LblMother
            // 
            LblMother.AutoSize = true;
            LblMother.Location = new Point(360, 26);
            LblMother.Name = "LblMother";
            LblMother.Size = new Size(57, 20);
            LblMother.TabIndex = 5;
            LblMother.Text = "Mother";
            // 
            // LblMothername
            // 
            LblMothername.AutoSize = true;
            LblMothername.Location = new Point(360, 59);
            LblMothername.Name = "LblMothername";
            LblMothername.Size = new Size(114, 20);
            LblMothername.TabIndex = 6;
            LblMothername.Text = "Mother's name: ";
            // 
            // LblMothergen
            // 
            LblMothergen.AutoSize = true;
            LblMothergen.Location = new Point(360, 95);
            LblMothergen.Name = "LblMothergen";
            LblMothergen.Size = new Size(141, 20);
            LblMothergen.TabIndex = 7;
            LblMothergen.Text = "Mother's Genotype: ";
            // 
            // PnMain
            // 
            PnMain.Controls.Add(LblMother);
            PnMain.Controls.Add(PbImagesOfChildren);
            PnMain.Controls.Add(LblMothergen);
            PnMain.Controls.Add(BtSettings);
            PnMain.Controls.Add(BtStart);
            PnMain.Controls.Add(LblMothername);
            PnMain.Controls.Add(LblFathergen);
            PnMain.Controls.Add(LblFathername);
            PnMain.Controls.Add(LblFather);
            PnMain.Location = new Point(3, 5);
            PnMain.Name = "PnMain";
            PnMain.Size = new Size(674, 497);
            PnMain.TabIndex = 8;
            // 
            // PbImagesOfChildren
            // 
            PbImagesOfChildren.Location = new Point(9, 223);
            PbImagesOfChildren.Name = "PbImagesOfChildren";
            PbImagesOfChildren.Size = new Size(656, 263);
            PbImagesOfChildren.TabIndex = 8;
            PbImagesOfChildren.TabStop = false;
            // 
            // PnlSettings
            // 
            PnlSettings.Controls.Add(GbMAllele2);
            PnlSettings.Controls.Add(GbMAllele1);
            PnlSettings.Controls.Add(GbFAllele2);
            PnlSettings.Controls.Add(LblSetFAllele1);
            PnlSettings.Controls.Add(GbFAllele1);
            PnlSettings.Controls.Add(btSetOffspringNumber100);
            PnlSettings.Controls.Add(btSetOffspringNumber50);
            PnlSettings.Controls.Add(btSetOffspringNumber10);
            PnlSettings.Controls.Add(LbOffspring);
            PnlSettings.Controls.Add(BtSetSettings);
            PnlSettings.Controls.Add(LblSetMAllele2);
            PnlSettings.Controls.Add(LblSetFAllele2);
            PnlSettings.Controls.Add(LblSetMAllele1);
            PnlSettings.Controls.Add(LbSetMother);
            PnlSettings.Controls.Add(LbSetFather);
            PnlSettings.Location = new Point(3, 5);
            PnlSettings.Name = "PnlSettings";
            PnlSettings.Size = new Size(674, 497);
            PnlSettings.TabIndex = 8;
            PnlSettings.Visible = false;
            // 
            // GbMAllele2
            // 
            GbMAllele2.Controls.Add(RbMotherAllele2Dominant);
            GbMAllele2.Controls.Add(RbMotherAllele2Recessive);
            GbMAllele2.Location = new Point(408, 146);
            GbMAllele2.Name = "GbMAllele2";
            GbMAllele2.Size = new Size(263, 38);
            GbMAllele2.TabIndex = 27;
            GbMAllele2.TabStop = false;
            // 
            // RbMotherAllele2Dominant
            // 
            RbMotherAllele2Dominant.AutoSize = true;
            RbMotherAllele2Dominant.Location = new Point(10, 8);
            RbMotherAllele2Dominant.Name = "RbMotherAllele2Dominant";
            RbMotherAllele2Dominant.Size = new Size(96, 24);
            RbMotherAllele2Dominant.TabIndex = 7;
            RbMotherAllele2Dominant.TabStop = true;
            RbMotherAllele2Dominant.Tag = "Dominant";
            RbMotherAllele2Dominant.Text = "Dominant";
            RbMotherAllele2Dominant.UseVisualStyleBackColor = true;
            RbMotherAllele2Dominant.Click += AlleleRadioButton_Click;
            // 
            // RbMotherAllele2Recessive
            // 
            RbMotherAllele2Recessive.AutoSize = true;
            RbMotherAllele2Recessive.Location = new Point(133, 8);
            RbMotherAllele2Recessive.Name = "RbMotherAllele2Recessive";
            RbMotherAllele2Recessive.Size = new Size(93, 24);
            RbMotherAllele2Recessive.TabIndex = 6;
            RbMotherAllele2Recessive.TabStop = true;
            RbMotherAllele2Recessive.Tag = "Recessive";
            RbMotherAllele2Recessive.Text = "Recessive";
            RbMotherAllele2Recessive.UseVisualStyleBackColor = true;
            RbMotherAllele2Recessive.Click += AlleleRadioButton_Click;
            // 
            // GbMAllele1
            // 
            GbMAllele1.Controls.Add(RbMotherAllele1Dominant);
            GbMAllele1.Controls.Add(RbMotherAllele1Recessive);
            GbMAllele1.Location = new Point(408, 87);
            GbMAllele1.Name = "GbMAllele1";
            GbMAllele1.Size = new Size(263, 38);
            GbMAllele1.TabIndex = 27;
            GbMAllele1.TabStop = false;
            // 
            // RbMotherAllele1Dominant
            // 
            RbMotherAllele1Dominant.AutoSize = true;
            RbMotherAllele1Dominant.Location = new Point(10, 9);
            RbMotherAllele1Dominant.Name = "RbMotherAllele1Dominant";
            RbMotherAllele1Dominant.Size = new Size(96, 24);
            RbMotherAllele1Dominant.TabIndex = 4;
            RbMotherAllele1Dominant.TabStop = true;
            RbMotherAllele1Dominant.Tag = "Dominant";
            RbMotherAllele1Dominant.Text = "Dominant";
            RbMotherAllele1Dominant.UseVisualStyleBackColor = true;
            RbMotherAllele1Dominant.Click += AlleleRadioButton_Click;
            // 
            // RbMotherAllele1Recessive
            // 
            RbMotherAllele1Recessive.AutoSize = true;
            RbMotherAllele1Recessive.Location = new Point(133, 9);
            RbMotherAllele1Recessive.Name = "RbMotherAllele1Recessive";
            RbMotherAllele1Recessive.Size = new Size(93, 24);
            RbMotherAllele1Recessive.TabIndex = 5;
            RbMotherAllele1Recessive.TabStop = true;
            RbMotherAllele1Recessive.Tag = "Recessive";
            RbMotherAllele1Recessive.Text = "Recessive";
            RbMotherAllele1Recessive.UseVisualStyleBackColor = true;
            RbMotherAllele1Recessive.Click += AlleleRadioButton_Click;
            // 
            // GbFAllele2
            // 
            GbFAllele2.Controls.Add(RbFatherAllele2Dominant);
            GbFAllele2.Controls.Add(RbFatherAllele2Recessive);
            GbFAllele2.Location = new Point(57, 146);
            GbFAllele2.Name = "GbFAllele2";
            GbFAllele2.Size = new Size(263, 38);
            GbFAllele2.TabIndex = 26;
            GbFAllele2.TabStop = false;
            // 
            // RbFatherAllele2Dominant
            // 
            RbFatherAllele2Dominant.AutoSize = true;
            RbFatherAllele2Dominant.Location = new Point(11, 8);
            RbFatherAllele2Dominant.Name = "RbFatherAllele2Dominant";
            RbFatherAllele2Dominant.Size = new Size(96, 24);
            RbFatherAllele2Dominant.TabIndex = 3;
            RbFatherAllele2Dominant.TabStop = true;
            RbFatherAllele2Dominant.Tag = "Dominant";
            RbFatherAllele2Dominant.Text = "Dominant";
            RbFatherAllele2Dominant.UseVisualStyleBackColor = true;
            RbFatherAllele2Dominant.Click += AlleleRadioButton_Click;
            // 
            // RbFatherAllele2Recessive
            // 
            RbFatherAllele2Recessive.AutoSize = true;
            RbFatherAllele2Recessive.Location = new Point(144, 8);
            RbFatherAllele2Recessive.Name = "RbFatherAllele2Recessive";
            RbFatherAllele2Recessive.Size = new Size(93, 24);
            RbFatherAllele2Recessive.TabIndex = 2;
            RbFatherAllele2Recessive.TabStop = true;
            RbFatherAllele2Recessive.Tag = "Recessive";
            RbFatherAllele2Recessive.Text = "Recessive";
            RbFatherAllele2Recessive.UseVisualStyleBackColor = true;
            RbFatherAllele2Recessive.Click += AlleleRadioButton_Click;
            // 
            // LblSetFAllele1
            // 
            LblSetFAllele1.AutoSize = true;
            LblSetFAllele1.Location = new Point(89, 64);
            LblSetFAllele1.Name = "LblSetFAllele1";
            LblSetFAllele1.Size = new Size(59, 20);
            LblSetFAllele1.TabIndex = 11;
            LblSetFAllele1.Text = "Allele 1";
            // 
            // GbFAllele1
            // 
            GbFAllele1.Controls.Add(RbFatherAllele1Dominant);
            GbFAllele1.Controls.Add(RbFatherAllele1Recessive);
            GbFAllele1.Location = new Point(57, 75);
            GbFAllele1.Name = "GbFAllele1";
            GbFAllele1.Size = new Size(263, 50);
            GbFAllele1.TabIndex = 25;
            GbFAllele1.TabStop = false;
            // 
            // RbFatherAllele1Dominant
            // 
            RbFatherAllele1Dominant.AutoSize = true;
            RbFatherAllele1Dominant.Location = new Point(11, 20);
            RbFatherAllele1Dominant.Name = "RbFatherAllele1Dominant";
            RbFatherAllele1Dominant.Size = new Size(96, 24);
            RbFatherAllele1Dominant.TabIndex = 0;
            RbFatherAllele1Dominant.TabStop = true;
            RbFatherAllele1Dominant.Tag = "Dominant";
            RbFatherAllele1Dominant.Text = "Dominant";
            RbFatherAllele1Dominant.UseVisualStyleBackColor = true;
            RbFatherAllele1Dominant.Click += AlleleRadioButton_Click;
            // 
            // RbFatherAllele1Recessive
            // 
            RbFatherAllele1Recessive.AutoSize = true;
            RbFatherAllele1Recessive.Location = new Point(144, 21);
            RbFatherAllele1Recessive.Name = "RbFatherAllele1Recessive";
            RbFatherAllele1Recessive.Size = new Size(93, 24);
            RbFatherAllele1Recessive.TabIndex = 1;
            RbFatherAllele1Recessive.TabStop = true;
            RbFatherAllele1Recessive.Tag = "Recessive";
            RbFatherAllele1Recessive.Text = "Recessive";
            RbFatherAllele1Recessive.UseVisualStyleBackColor = true;
            RbFatherAllele1Recessive.Click += AlleleRadioButton_Click;
            // 
            // btSetOffspringNumber100
            // 
            btSetOffspringNumber100.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btSetOffspringNumber100.Location = new Point(488, 256);
            btSetOffspringNumber100.Name = "btSetOffspringNumber100";
            btSetOffspringNumber100.Size = new Size(168, 74);
            btSetOffspringNumber100.TabIndex = 24;
            btSetOffspringNumber100.Tag = "100";
            btSetOffspringNumber100.Text = "100";
            btSetOffspringNumber100.UseVisualStyleBackColor = true;
            btSetOffspringNumber100.Click += BtOffspringSetNumber_Click;
            // 
            // btSetOffspringNumber50
            // 
            btSetOffspringNumber50.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btSetOffspringNumber50.Location = new Point(250, 256);
            btSetOffspringNumber50.Name = "btSetOffspringNumber50";
            btSetOffspringNumber50.Size = new Size(167, 74);
            btSetOffspringNumber50.TabIndex = 23;
            btSetOffspringNumber50.Tag = "50";
            btSetOffspringNumber50.Text = "50";
            btSetOffspringNumber50.UseVisualStyleBackColor = true;
            btSetOffspringNumber50.Click += BtOffspringSetNumber_Click;
            // 
            // btSetOffspringNumber10
            // 
            btSetOffspringNumber10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btSetOffspringNumber10.Location = new Point(25, 256);
            btSetOffspringNumber10.Name = "btSetOffspringNumber10";
            btSetOffspringNumber10.Size = new Size(167, 74);
            btSetOffspringNumber10.TabIndex = 22;
            btSetOffspringNumber10.Tag = "10";
            btSetOffspringNumber10.Text = "10";
            btSetOffspringNumber10.UseVisualStyleBackColor = true;
            btSetOffspringNumber10.Click += BtOffspringSetNumber_Click;
            // 
            // LbOffspring
            // 
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOffspring.Location = new Point(69, 178);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(194, 28);
            LbOffspring.TabIndex = 21;
            LbOffspring.Text = "Set offsping Number";
            // 
            // BtSetSettings
            // 
            BtSetSettings.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            BtSetSettings.Location = new Point(192, 383);
            BtSetSettings.Name = "BtSetSettings";
            BtSetSettings.Size = new Size(282, 74);
            BtSetSettings.TabIndex = 14;
            BtSetSettings.Text = "OK";
            BtSetSettings.UseVisualStyleBackColor = true;
            BtSetSettings.Click += BtSetSettings_Click;
            // 
            // LblSetMAllele2
            // 
            LblSetMAllele2.AutoSize = true;
            LblSetMAllele2.Location = new Point(460, 128);
            LblSetMAllele2.Name = "LblSetMAllele2";
            LblSetMAllele2.Size = new Size(59, 20);
            LblSetMAllele2.TabIndex = 13;
            LblSetMAllele2.Text = "Allele 2";
            // 
            // LblSetFAllele2
            // 
            LblSetFAllele2.AutoSize = true;
            LblSetFAllele2.Location = new Point(89, 128);
            LblSetFAllele2.Name = "LblSetFAllele2";
            LblSetFAllele2.Size = new Size(59, 20);
            LblSetFAllele2.TabIndex = 12;
            LblSetFAllele2.Text = "Allele 2";
            // 
            // LblSetMAllele1
            // 
            LblSetMAllele1.AutoSize = true;
            LblSetMAllele1.Location = new Point(460, 64);
            LblSetMAllele1.Name = "LblSetMAllele1";
            LblSetMAllele1.Size = new Size(59, 20);
            LblSetMAllele1.TabIndex = 10;
            LblSetMAllele1.Text = "Allele 1";
            // 
            // LbSetMother
            // 
            LbSetMother.AutoSize = true;
            LbSetMother.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSetMother.Location = new Point(440, 31);
            LbSetMother.Name = "LbSetMother";
            LbSetMother.Size = new Size(77, 28);
            LbSetMother.TabIndex = 9;
            LbSetMother.Text = "Mother";
            // 
            // LbSetFather
            // 
            LbSetFather.AutoSize = true;
            LbSetFather.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSetFather.Location = new Point(80, 31);
            LbSetFather.Name = "LbSetFather";
            LbSetFather.Size = new Size(66, 28);
            LbSetFather.TabIndex = 8;
            LbSetFather.Text = "Father";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 503);
            Controls.Add(PnMain);
            Controls.Add(PnlSettings);
            Name = "Main";
            Text = "Form1";
            PnMain.ResumeLayout(false);
            PnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).EndInit();
            PnlSettings.ResumeLayout(false);
            PnlSettings.PerformLayout();
            GbMAllele2.ResumeLayout(false);
            GbMAllele2.PerformLayout();
            GbMAllele1.ResumeLayout(false);
            GbMAllele1.PerformLayout();
            GbFAllele2.ResumeLayout(false);
            GbFAllele2.PerformLayout();
            GbFAllele1.ResumeLayout(false);
            GbFAllele1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtStart;
        private Button BtSettings;
        private Label LblFather;
        private Label LblFathername;
        private Label LblFathergen;
        private Label LblMother;
        private Label LblMothername;
        private Label LblMothergen;
        private Panel PnMain;
        private Panel PnlSettings;
        private Label LblSetMAllele2;
        private Label LblSetFAllele2;
        private Label LblSetFAllele1;
        private Label LblSetMAllele1;
        private Label LbSetMother;
        private Label LbSetFather;
        private RadioButton RbMotherAllele2Dominant;
        private RadioButton RbMotherAllele2Recessive;
        private RadioButton RbMotherAllele1Recessive;
        private RadioButton RbMotherAllele1Dominant;
        private RadioButton RbFatherAllele2Dominant;
        private RadioButton RbFatherAllele2Recessive;
        private RadioButton RbFatherAllele1Recessive;
        private RadioButton RbFatherAllele1Dominant;
        private PictureBox PbImagesOfChildren;
        private Button BtSetSettings;
        private Button btSetOffspringNumber100;
        private Button btSetOffspringNumber50;
        private Button btSetOffspringNumber10;
        private Label LbOffspring;
        private GroupBox GbMAllele2;
        private GroupBox GbMAllele1;
        private GroupBox GbFAllele2;
        private GroupBox GbFAllele1;
    }
}