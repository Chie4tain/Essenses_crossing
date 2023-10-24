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
            numUDOffspingCount = new NumericUpDown();
            FlpControlMother = new FlowLayoutPanel();
            LbOffspring = new Label();
            FlpControlFather = new FlowLayoutPanel();
            BtSetSettings = new Button();
            LbSetMother = new Label();
            LbSetFather = new Label();
            TimerInvalidate = new System.Windows.Forms.Timer(components);
            PnlChildInformation = new Panel();
            gbFilter = new GroupBox();
            rbSortNone = new RadioButton();
            rbSortFemale = new RadioButton();
            rbSortMale = new RadioButton();
            chbSortName = new CheckBox();
            lblGeneName = new Label();
            lblAllele2name = new Label();
            lblAllele1name = new Label();
            lblGene3Allele2 = new Label();
            lblGene3Allele1 = new Label();
            lblGene2Allele2 = new Label();
            lblGene2Allele1 = new Label();
            lblGene1Allele2 = new Label();
            lblGene1Allele1 = new Label();
            lblGene3Name = new Label();
            lblGene2Name = new Label();
            lblGene1Name = new Label();
            ListboxChildren = new ListBox();
            lblChildSex = new Label();
            lblChildName = new Label();
            PbChildIcon = new PictureBox();
            PnMain.SuspendLayout();
            pnlChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbFatherIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbMotherIcon).BeginInit();
            PnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUDOffspingCount).BeginInit();
            PnlChildInformation.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbChildIcon).BeginInit();
            SuspendLayout();
            // 
            // BtStart
            // 
            BtStart.Location = new Point(134, 145);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(179, 50);
            BtStart.TabIndex = 0;
            BtStart.Text = "Start Crossing";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // BtSettings
            // 
            BtSettings.Location = new Point(620, 145);
            BtSettings.Name = "BtSettings";
            BtSettings.Size = new Size(179, 50);
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
            PnMain.Location = new Point(0, 0);
            PnMain.Name = "PnMain";
            PnMain.Size = new Size(999, 530);
            PnMain.TabIndex = 8;
            // 
            // pnlChildren
            // 
            pnlChildren.AutoScroll = true;
            pnlChildren.Controls.Add(PbImagesOfChildren);
            pnlChildren.Location = new Point(0, 225);
            pnlChildren.Name = "pnlChildren";
            pnlChildren.Size = new Size(999, 305);
            pnlChildren.TabIndex = 11;
            // 
            // PbImagesOfChildren
            // 
            PbImagesOfChildren.Location = new Point(0, 20);
            PbImagesOfChildren.Name = "PbImagesOfChildren";
            PbImagesOfChildren.Size = new Size(999, 285);
            PbImagesOfChildren.TabIndex = 8;
            PbImagesOfChildren.TabStop = false;
            PbImagesOfChildren.Paint += Main_Paint;
            // 
            // PbFatherIcon
            // 
            PbFatherIcon.Location = new Point(330, 18);
            PbFatherIcon.Name = "PbFatherIcon";
            PbFatherIcon.Size = new Size(135, 96);
            PbFatherIcon.TabIndex = 10;
            PbFatherIcon.TabStop = false;
            // 
            // PbMotherIcon
            // 
            PbMotherIcon.Location = new Point(760, 18);
            PbMotherIcon.Name = "PbMotherIcon";
            PbMotherIcon.Size = new Size(135, 96);
            PbMotherIcon.TabIndex = 9;
            PbMotherIcon.TabStop = false;
            // 
            // PnlSettings
            // 
            PnlSettings.Controls.Add(numUDOffspingCount);
            PnlSettings.Controls.Add(FlpControlMother);
            PnlSettings.Controls.Add(LbOffspring);
            PnlSettings.Controls.Add(FlpControlFather);
            PnlSettings.Controls.Add(BtSetSettings);
            PnlSettings.Controls.Add(LbSetMother);
            PnlSettings.Controls.Add(LbSetFather);
            PnlSettings.Location = new Point(0, 0);
            PnlSettings.Name = "PnlSettings";
            PnlSettings.Size = new Size(999, 530);
            PnlSettings.TabIndex = 8;
            PnlSettings.Visible = false;
            // 
            // numUDOffspingCount
            // 
            numUDOffspingCount.Location = new Point(237, 344);
            numUDOffspingCount.Name = "numUDOffspingCount";
            numUDOffspingCount.Size = new Size(535, 27);
            numUDOffspingCount.TabIndex = 29;
            numUDOffspingCount.ValueChanged += nUDChildrenCount_ValueChanged;
            // 
            // FlpControlMother
            // 
            FlpControlMother.AutoScroll = true;
            FlpControlMother.Location = new Point(507, 59);
            FlpControlMother.Name = "FlpControlMother";
            FlpControlMother.Size = new Size(486, 237);
            FlpControlMother.TabIndex = 10;
            // 
            // LbOffspring
            // 
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOffspring.Location = new Point(237, 299);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(194, 28);
            LbOffspring.TabIndex = 21;
            LbOffspring.Text = "Set offsping Number";
            // 
            // FlpControlFather
            // 
            FlpControlFather.Location = new Point(9, 59);
            FlpControlFather.Name = "FlpControlFather";
            FlpControlFather.Size = new Size(486, 237);
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
            // PnlChildInformation
            // 
            PnlChildInformation.Controls.Add(gbFilter);
            PnlChildInformation.Controls.Add(chbSortName);
            PnlChildInformation.Controls.Add(lblGeneName);
            PnlChildInformation.Controls.Add(lblAllele2name);
            PnlChildInformation.Controls.Add(lblAllele1name);
            PnlChildInformation.Controls.Add(lblGene3Allele2);
            PnlChildInformation.Controls.Add(lblGene3Allele1);
            PnlChildInformation.Controls.Add(lblGene2Allele2);
            PnlChildInformation.Controls.Add(lblGene2Allele1);
            PnlChildInformation.Controls.Add(lblGene1Allele2);
            PnlChildInformation.Controls.Add(lblGene1Allele1);
            PnlChildInformation.Controls.Add(lblGene3Name);
            PnlChildInformation.Controls.Add(lblGene2Name);
            PnlChildInformation.Controls.Add(lblGene1Name);
            PnlChildInformation.Controls.Add(ListboxChildren);
            PnlChildInformation.Controls.Add(lblChildSex);
            PnlChildInformation.Controls.Add(lblChildName);
            PnlChildInformation.Controls.Add(PbChildIcon);
            PnlChildInformation.Dock = DockStyle.Right;
            PnlChildInformation.Location = new Point(1016, 0);
            PnlChildInformation.Name = "PnlChildInformation";
            PnlChildInformation.Size = new Size(377, 530);
            PnlChildInformation.TabIndex = 9;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(rbSortNone);
            gbFilter.Controls.Add(rbSortFemale);
            gbFilter.Controls.Add(rbSortMale);
            gbFilter.Location = new Point(2, 379);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(117, 102);
            gbFilter.TabIndex = 17;
            gbFilter.TabStop = false;
            // 
            // rbSortNone
            // 
            rbSortNone.AutoSize = true;
            rbSortNone.Location = new Point(0, 58);
            rbSortNone.Name = "rbSortNone";
            rbSortNone.Size = new Size(117, 24);
            rbSortNone.TabIndex = 2;
            rbSortNone.TabStop = true;
            rbSortNone.Text = "View m and f";
            rbSortNone.UseVisualStyleBackColor = true;
            // 
            // rbSortFemale
            // 
            rbSortFemale.AutoSize = true;
            rbSortFemale.Location = new Point(0, 28);
            rbSortFemale.Name = "rbSortFemale";
            rbSortFemale.Size = new Size(112, 24);
            rbSortFemale.TabIndex = 1;
            rbSortFemale.TabStop = true;
            rbSortFemale.Text = "View female";
            rbSortFemale.UseVisualStyleBackColor = true;
            rbSortFemale.CheckedChanged += rbSortFemale_CheckedChanged;
            // 
            // rbSortMale
            // 
            rbSortMale.AutoSize = true;
            rbSortMale.Location = new Point(-1, -2);
            rbSortMale.Name = "rbSortMale";
            rbSortMale.Size = new Size(99, 24);
            rbSortMale.TabIndex = 0;
            rbSortMale.TabStop = true;
            rbSortMale.Text = "View male";
            rbSortMale.UseVisualStyleBackColor = true;
            rbSortMale.CheckedChanged += rbSortMale_CheckedChanged;
            // 
            // chbSortName
            // 
            chbSortName.AutoSize = true;
            chbSortName.Location = new Point(0, 347);
            chbSortName.Name = "chbSortName";
            chbSortName.Size = new Size(119, 24);
            chbSortName.TabIndex = 16;
            chbSortName.Text = "Sort by name";
            chbSortName.UseVisualStyleBackColor = true;
            chbSortName.CheckedChanged += chbSortName_CheckedChanged;
            // 
            // lblGeneName
            // 
            lblGeneName.AutoSize = true;
            lblGeneName.Location = new Point(12, 195);
            lblGeneName.Name = "lblGeneName";
            lblGeneName.Size = new Size(43, 20);
            lblGeneName.TabIndex = 15;
            lblGeneName.Text = "Gene";
            // 
            // lblAllele2name
            // 
            lblAllele2name.AutoSize = true;
            lblAllele2name.Location = new Point(12, 272);
            lblAllele2name.Name = "lblAllele2name";
            lblAllele2name.Size = new Size(59, 20);
            lblAllele2name.TabIndex = 14;
            lblAllele2name.Text = "Allele 2";
            // 
            // lblAllele1name
            // 
            lblAllele1name.AutoSize = true;
            lblAllele1name.Location = new Point(12, 232);
            lblAllele1name.Name = "lblAllele1name";
            lblAllele1name.Size = new Size(59, 20);
            lblAllele1name.TabIndex = 13;
            lblAllele1name.Text = "Allele 1";
            // 
            // lblGene3Allele2
            // 
            lblGene3Allele2.AutoSize = true;
            lblGene3Allele2.Location = new Point(278, 272);
            lblGene3Allele2.Name = "lblGene3Allele2";
            lblGene3Allele2.Size = new Size(0, 20);
            lblGene3Allele2.TabIndex = 12;
            // 
            // lblGene3Allele1
            // 
            lblGene3Allele1.AutoSize = true;
            lblGene3Allele1.Location = new Point(278, 232);
            lblGene3Allele1.Name = "lblGene3Allele1";
            lblGene3Allele1.Size = new Size(0, 20);
            lblGene3Allele1.TabIndex = 11;
            // 
            // lblGene2Allele2
            // 
            lblGene2Allele2.AutoSize = true;
            lblGene2Allele2.Location = new Point(205, 272);
            lblGene2Allele2.Name = "lblGene2Allele2";
            lblGene2Allele2.Size = new Size(0, 20);
            lblGene2Allele2.TabIndex = 10;
            // 
            // lblGene2Allele1
            // 
            lblGene2Allele1.AutoSize = true;
            lblGene2Allele1.Location = new Point(205, 232);
            lblGene2Allele1.Name = "lblGene2Allele1";
            lblGene2Allele1.Size = new Size(0, 20);
            lblGene2Allele1.TabIndex = 9;
            // 
            // lblGene1Allele2
            // 
            lblGene1Allele2.AutoSize = true;
            lblGene1Allele2.Location = new Point(118, 272);
            lblGene1Allele2.Name = "lblGene1Allele2";
            lblGene1Allele2.Size = new Size(0, 20);
            lblGene1Allele2.TabIndex = 8;
            // 
            // lblGene1Allele1
            // 
            lblGene1Allele1.AutoSize = true;
            lblGene1Allele1.Location = new Point(118, 232);
            lblGene1Allele1.Name = "lblGene1Allele1";
            lblGene1Allele1.Size = new Size(0, 20);
            lblGene1Allele1.TabIndex = 7;
            // 
            // lblGene3Name
            // 
            lblGene3Name.AutoSize = true;
            lblGene3Name.Location = new Point(278, 195);
            lblGene3Name.Name = "lblGene3Name";
            lblGene3Name.Size = new Size(0, 20);
            lblGene3Name.TabIndex = 6;
            // 
            // lblGene2Name
            // 
            lblGene2Name.AutoSize = true;
            lblGene2Name.Location = new Point(205, 195);
            lblGene2Name.Name = "lblGene2Name";
            lblGene2Name.Size = new Size(0, 20);
            lblGene2Name.TabIndex = 5;
            // 
            // lblGene1Name
            // 
            lblGene1Name.AutoSize = true;
            lblGene1Name.Location = new Point(118, 195);
            lblGene1Name.Name = "lblGene1Name";
            lblGene1Name.Size = new Size(0, 20);
            lblGene1Name.TabIndex = 4;
            // 
            // ListboxChildren
            // 
            ListboxChildren.FormattingEnabled = true;
            ListboxChildren.ItemHeight = 20;
            ListboxChildren.Location = new Point(118, 344);
            ListboxChildren.Name = "ListboxChildren";
            ListboxChildren.Size = new Size(256, 144);
            ListboxChildren.TabIndex = 3;
            ListboxChildren.SelectedIndexChanged += ListboxChildren_SelectedIndexChanged;
            // 
            // lblChildSex
            // 
            lblChildSex.AutoSize = true;
            lblChildSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChildSex.Location = new Point(26, 82);
            lblChildSex.Name = "lblChildSex";
            lblChildSex.Size = new Size(0, 28);
            lblChildSex.TabIndex = 2;
            // 
            // lblChildName
            // 
            lblChildName.AutoSize = true;
            lblChildName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChildName.Location = new Point(26, 21);
            lblChildName.Name = "lblChildName";
            lblChildName.Size = new Size(0, 28);
            lblChildName.TabIndex = 1;
            // 
            // PbChildIcon
            // 
            PbChildIcon.Location = new Point(228, 21);
            PbChildIcon.Name = "PbChildIcon";
            PbChildIcon.Size = new Size(137, 143);
            PbChildIcon.TabIndex = 0;
            PbChildIcon.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(700, 500);
            ClientSize = new Size(1393, 530);
            Controls.Add(PnlChildInformation);
            Controls.Add(PnlSettings);
            Controls.Add(PnMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crossing";
            Resize += Main_Resize;
            PnMain.ResumeLayout(false);
            PnMain.PerformLayout();
            pnlChildren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbImagesOfChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbFatherIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbMotherIcon).EndInit();
            PnlSettings.ResumeLayout(false);
            PnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUDOffspingCount).EndInit();
            PnlChildInformation.ResumeLayout(false);
            PnlChildInformation.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbChildIcon).EndInit();
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
        private System.Windows.Forms.Timer TimerInvalidate;
        private Panel pnlChildren;
        private NumericUpDown numUDOffspingCount;
        private Panel PnlChildInformation;
        private ListBox ListboxChildren;
        private Label lblChildSex;
        private Label lblChildName;
        private PictureBox PbChildIcon;
        private Label lblGeneName;
        private Label lblAllele2name;
        private Label lblAllele1name;
        private Label lblGene3Allele2;
        private Label lblGene3Allele1;
        private Label lblGene2Allele2;
        private Label lblGene2Allele1;
        private Label lblGene1Allele2;
        private Label lblGene1Allele1;
        private Label lblGene3Name;
        private Label lblGene2Name;
        private Label lblGene1Name;
        private CheckBox chbSortName;
        private GroupBox gbFilter;
        private RadioButton rbSortFemale;
        private RadioButton rbSortMale;
        private RadioButton rbSortNone;
    }
}