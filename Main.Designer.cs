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
            lbAttrsCount = new Label();
            comboxSetAttrsCount = new ComboBox();
            numUDOffspingCount = new NumericUpDown();
            FlpControlMother = new FlowLayoutPanel();
            LbOffspring = new Label();
            FlpControlFather = new FlowLayoutPanel();
            BtSetSettings = new Button();
            LbSetMother = new Label();
            LbSetFather = new Label();
            TimerInvalidate = new System.Windows.Forms.Timer(components);
            PnlChildInformation = new Panel();
            lbChildAttr = new Label();
            gbFilter = new GroupBox();
            rbSortNone = new RadioButton();
            rbSortFemale = new RadioButton();
            rbSortMale = new RadioButton();
            chbSortName = new CheckBox();
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
            LblFather.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblFather.AutoSize = true;
            LblFather.Location = new Point(134, 25);
            LblFather.Name = "LblFather";
            LblFather.Size = new Size(49, 20);
            LblFather.TabIndex = 2;
            LblFather.Text = "Father";
            // 
            // LblFathername
            // 
            LblFathername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblFathername.AutoSize = true;
            LblFathername.Location = new Point(134, 58);
            LblFathername.Name = "LblFathername";
            LblFathername.Size = new Size(106, 20);
            LblFathername.TabIndex = 3;
            LblFathername.Text = "Father's name: ";
            // 
            // LblMother
            // 
            LblMother.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblMother.AutoSize = true;
            LblMother.Location = new Point(572, 25);
            LblMother.Name = "LblMother";
            LblMother.Size = new Size(57, 20);
            LblMother.TabIndex = 5;
            LblMother.Text = "Mother";
            // 
            // LblMothername
            // 
            LblMothername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblMothername.AutoSize = true;
            LblMothername.Location = new Point(572, 58);
            LblMothername.Name = "LblMothername";
            LblMothername.Size = new Size(114, 20);
            LblMothername.TabIndex = 6;
            LblMothername.Text = "Mother's name: ";
            // 
            // PnMain
            // 
            PnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            pnlChildren.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            PbImagesOfChildren.MouseClick += PbImagesOfChildren_MouseClick;
            // 
            // PbFatherIcon
            // 
            PbFatherIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PbFatherIcon.Location = new Point(330, 18);
            PbFatherIcon.Name = "PbFatherIcon";
            PbFatherIcon.Size = new Size(135, 96);
            PbFatherIcon.TabIndex = 10;
            PbFatherIcon.TabStop = false;
            // 
            // PbMotherIcon
            // 
            PbMotherIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PbMotherIcon.Location = new Point(760, 18);
            PbMotherIcon.Name = "PbMotherIcon";
            PbMotherIcon.Size = new Size(135, 96);
            PbMotherIcon.TabIndex = 9;
            PbMotherIcon.TabStop = false;
            // 
            // PnlSettings
            // 
            PnlSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlSettings.Controls.Add(lbAttrsCount);
            PnlSettings.Controls.Add(comboxSetAttrsCount);
            PnlSettings.Controls.Add(numUDOffspingCount);
            PnlSettings.Controls.Add(FlpControlMother);
            PnlSettings.Controls.Add(LbOffspring);
            PnlSettings.Controls.Add(FlpControlFather);
            PnlSettings.Controls.Add(BtSetSettings);
            PnlSettings.Controls.Add(LbSetMother);
            PnlSettings.Controls.Add(LbSetFather);
            PnlSettings.Location = new Point(0, 0);
            PnlSettings.Name = "PnlSettings";
            PnlSettings.Size = new Size(999, 549);
            PnlSettings.TabIndex = 8;
            PnlSettings.Visible = false;
            // 
            // lbAttrsCount
            // 
            lbAttrsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbAttrsCount.AutoSize = true;
            lbAttrsCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAttrsCount.Location = new Point(471, 113);
            lbAttrsCount.Name = "lbAttrsCount";
            lbAttrsCount.Size = new Size(145, 28);
            lbAttrsCount.TabIndex = 31;
            lbAttrsCount.Text = "Set Attrs Count";
            // 
            // comboxSetAttrsCount
            // 
            comboxSetAttrsCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboxSetAttrsCount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxSetAttrsCount.FormattingEnabled = true;
            comboxSetAttrsCount.Items.AddRange(new object[] { "LineWidth", "LineWidth, FillColor", "LineWidth, FillColor, LineColor" });
            comboxSetAttrsCount.Location = new Point(471, 157);
            comboxSetAttrsCount.Name = "comboxSetAttrsCount";
            comboxSetAttrsCount.Size = new Size(215, 28);
            comboxSetAttrsCount.TabIndex = 30;
            comboxSetAttrsCount.SelectedIndexChanged += comboxSetAttrsCount_SelectedIndexChanged;
            // 
            // numUDOffspingCount
            // 
            numUDOffspingCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numUDOffspingCount.Location = new Point(472, 59);
            numUDOffspingCount.Name = "numUDOffspingCount";
            numUDOffspingCount.Size = new Size(327, 27);
            numUDOffspingCount.TabIndex = 29;
            numUDOffspingCount.ValueChanged += nUDChildrenCount_ValueChanged;
            // 
            // FlpControlMother
            // 
            FlpControlMother.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlpControlMother.AutoScroll = true;
            FlpControlMother.Location = new Point(12, 319);
            FlpControlMother.Name = "FlpControlMother";
            FlpControlMother.Size = new Size(437, 218);
            FlpControlMother.TabIndex = 10;
            // 
            // LbOffspring
            // 
            LbOffspring.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbOffspring.Location = new Point(471, 17);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(194, 28);
            LbOffspring.TabIndex = 21;
            LbOffspring.Text = "Set offsping Number";
            // 
            // FlpControlFather
            // 
            FlpControlFather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlpControlFather.Location = new Point(9, 59);
            FlpControlFather.Name = "FlpControlFather";
            FlpControlFather.Size = new Size(440, 214);
            FlpControlFather.TabIndex = 9;
            // 
            // BtSetSettings
            // 
            BtSetSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtSetSettings.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            BtSetSettings.Location = new Point(499, 437);
            BtSetSettings.Name = "BtSetSettings";
            BtSetSettings.Size = new Size(223, 74);
            BtSetSettings.TabIndex = 14;
            BtSetSettings.Text = "OK";
            BtSetSettings.UseVisualStyleBackColor = true;
            BtSetSettings.Click += BtSetSettings_Click;
            // 
            // LbSetMother
            // 
            LbSetMother.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LbSetMother.AutoSize = true;
            LbSetMother.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbSetMother.Location = new Point(12, 276);
            LbSetMother.Name = "LbSetMother";
            LbSetMother.Size = new Size(77, 28);
            LbSetMother.TabIndex = 9;
            LbSetMother.Text = "Mother";
            // 
            // LbSetFather
            // 
            LbSetFather.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            PnlChildInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PnlChildInformation.Controls.Add(lbChildAttr);
            PnlChildInformation.Controls.Add(gbFilter);
            PnlChildInformation.Controls.Add(chbSortName);
            PnlChildInformation.Controls.Add(ListboxChildren);
            PnlChildInformation.Controls.Add(lblChildSex);
            PnlChildInformation.Controls.Add(lblChildName);
            PnlChildInformation.Controls.Add(PbChildIcon);
            PnlChildInformation.Location = new Point(1016, 0);
            PnlChildInformation.Name = "PnlChildInformation";
            PnlChildInformation.Size = new Size(377, 549);
            PnlChildInformation.TabIndex = 9;
            // 
            // lbChildAttr
            // 
            lbChildAttr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbChildAttr.AutoSize = true;
            lbChildAttr.Location = new Point(31, 188);
            lbChildAttr.Name = "lbChildAttr";
            lbChildAttr.Size = new Size(0, 20);
            lbChildAttr.TabIndex = 18;
            // 
            // gbFilter
            // 
            gbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            chbSortName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chbSortName.AutoSize = true;
            chbSortName.Location = new Point(0, 347);
            chbSortName.Name = "chbSortName";
            chbSortName.Size = new Size(119, 24);
            chbSortName.TabIndex = 16;
            chbSortName.Text = "Sort by name";
            chbSortName.UseVisualStyleBackColor = true;
            chbSortName.CheckedChanged += chbSortName_CheckedChanged;
            // 
            // ListboxChildren
            // 
            ListboxChildren.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            lblChildSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblChildSex.AutoSize = true;
            lblChildSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChildSex.Location = new Point(26, 82);
            lblChildSex.Name = "lblChildSex";
            lblChildSex.Size = new Size(0, 28);
            lblChildSex.TabIndex = 2;
            // 
            // lblChildName
            // 
            lblChildName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblChildName.AutoSize = true;
            lblChildName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChildName.Location = new Point(26, 21);
            lblChildName.Name = "lblChildName";
            lblChildName.Size = new Size(0, 28);
            lblChildName.TabIndex = 1;
            // 
            // PbChildIcon
            // 
            PbChildIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            ClientSize = new Size(1393, 549);
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
        private CheckBox chbSortName;
        private GroupBox gbFilter;
        private RadioButton rbSortFemale;
        private RadioButton rbSortMale;
        private RadioButton rbSortNone;
        private Label lbAttrsCount;
        private ComboBox comboxSetAttrsCount;
        private Label lbChildAttr;
    }
}