using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Essenses_crossing.Main;

namespace Essenses_crossing
{
    public enum Sex { Male, Female };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Dominant, Recessive };

    public partial class Main : Form
    {
        public Animal Father;
        public Animal Mother;
        public int Offspringnumber;

        public List<Essence> offspring;
        public List<GroupBoxList> GroupBoxListsFather = new List<GroupBoxList>();
        public List<GroupBoxList> GroupBoxListsMother = new List<GroupBoxList>();

        public readonly List<string> attrNames = new List<string>() { "LineWidth", "LineColor", "FillColor" };
        public readonly List<string> AlleleNames = new List<string>() { "Allele 1", "Allele 2" };

        private Point _CurrentPositionPoint;

        //private GroupBox[] groupBoxes = new GroupBox[3];
        //private CheckBox[] CheckBoxes = new CheckBox[3];

        //private Bitmap PictureBoxBuffer;

        private int scrollPosition = 0;

        public Main()
        {
            InitializeComponent();

            CreateGenesControls(FlpControlFather);
            UpdateFather();
            CreateGenesControls(FlpControlMother);
            UpddateMother();

            Offspringnumber = 10;
            SetLabelValues();

            Vsbar.Size = new Size(Vsbar.Width, this.Height);

            _CurrentPositionPoint = new Point(2, 2);
        }


        private void UpdateFather()
        {
            Father = CreateParent(FlpControlFather, Sex.Male, GroupBoxListsFather);
            Father.Draw(PbFatherIcon, new Point(4, 4), Essence.size);
            Invalidate();
        }
        private void UpddateMother()
        {
            Mother = CreateParent(FlpControlMother, Sex.Female, GroupBoxListsMother);
            Mother.Draw(PbMotherIcon, new Point(4, 4), Essence.size);
            Invalidate();
        }

        Animal CreateParent(FlowLayoutPanel flpanel, Sex sex, List<GroupBoxList> groupBoxLists)
        {
            string name = (sex == Sex.Female) ? "Buska" : "Murzik";

            List<Gene> geneList = new();
            foreach (GroupBoxList groupBoxList in groupBoxLists)
            {
                Allele allele1;
                Allele allele2;

                if (groupBoxList.Chekboxes[0].Checked)
                    allele1 = Allele.Dominant;
                else
                    allele1 = Allele.Recessive;

                if (groupBoxList.Chekboxes[0].Checked)
                    allele2 = Allele.Dominant;
                else
                    allele2 = Allele.Recessive;

                geneList.Add(new Gene(allele1, allele2, groupBoxList.GroupBox.Text));
            }
            //for (int i = 0; i < attrNames.Count; ++i)
            //{
            //GroupBox groupBox = flpanel.Controls[i] as GroupBox;
            //Allele allele1;
            //Allele allele2;
            ////Allele allele3;
            //if (CheckBoxes[0].Checked)
            //{
            //    allele1 = Allele.Dominant;
            //}
            //else
            //{
            //    allele1 = Allele.Recessive;

            //}
            //if (CheckBoxes[1].Checked)
            //{
            //    allele2 = Allele.Dominant;
            //}
            //else
            //{
            //    allele2 = Allele.Recessive;

            //}
            //if (CheckBoxes[2].Checked)
            //{
            //    allele3 = Allele.Dominant;
            //}
            //else
            //{
            //    allele3 = Allele.Recessive;

            //}
            //    geneList.Add(new Gene(allele1, allele2, attrNames[i]));
            //}

            return new Animal_tertiary(name, sex, geneList[0], geneList[1], geneList[2]);
        }

        private void SetLabelValues()
        {
            LblMothername.Text = $"Name: {Mother.Name}";

            LblFathername.Text = $"Name: {Father.Name}";
        }

        public class GroupBoxList
        {
            public GroupBox GroupBox;
            public List<CheckBox> Chekboxes;

            public GroupBoxList(GroupBox groupBox)
            {
                GroupBox = groupBox;
                Chekboxes = new List<CheckBox>();
            }

            public void AddToGroupCheckBoxes(CheckBox checkBox)
            {
                GroupBox.Controls.Add(checkBox);
                Chekboxes.Add(checkBox);
            }
        }

        void CreateGenesControls(FlowLayoutPanel flppanel)
        {
            if (flppanel != null)
                flppanel.Controls.Clear();
            Point locPoint = new Point(10, 20);
            for (int i = 0; i < attrNames.Count; ++i)
            {
                Random random = new();
                GroupBox grbox = new GroupBox();
                grbox.Text = attrNames[i];
                GroupBoxList groupBox = new GroupBoxList(grbox);
                if (flppanel.Name == "FlpControlFather")
                    GroupBoxListsFather.Add(groupBox);
                else if (flppanel.Name == "FlpControlMother")
                    GroupBoxListsMother.Add(groupBox);

                locPoint.X = 10;
                locPoint.Y = 20;

                for (int j = 0; j < 2; j++)
                {
                    CheckBox chek = new CheckBox();
                    chek.Text = AlleleNames[j];
                    chek.Checked = random.Next(2) == 0;
                    groupBox.AddToGroupCheckBoxes(chek);
                    groupBox.Chekboxes[j].Location = locPoint;
                    locPoint = new Point(10, 20 + groupBox.Chekboxes[j].Height);
                }

                groupBox.GroupBox.Parent = flppanel;
                //groupBoxes[i] = new();
                //groupBoxes[i].Text = attrNames[i];

                //for (int j = 0; j < 2; j++)
                //{
                //    CheckBoxes[j] = new();
                //    CheckBoxes[j].Text = attrNames[i];
                //    CheckBoxes[j].Checked = random.Next(2) == 0;

                //    groupBoxes[i].Controls.Add(CheckBoxes[j]);
                //}

                //groupBoxes[i].Parent = flppanel;
            }
        }

        private void OffsetCurrentPositionPoint(string Name)
        {
            _CurrentPositionPoint.X += Essence.size + 10 + Name.Length;
            if (_CurrentPositionPoint.X + Essence.size + Name.Length + (10 * Essence.size / 100) > PbImagesOfChildren.Width)
            {
                _CurrentPositionPoint.X = 4;
                _CurrentPositionPoint.Y += 2 * Essence.size - (10 * Essence.size / 100);

                if (_CurrentPositionPoint.Y + Essence.size + 20 + (10 * Essence.size / 100) > PbImagesOfChildren.Height)
                {
                    PnMain.Size = new Size(PnMain.Width,
                        PnMain.Height + 2 * Essence.size + 20 + (10 * Essence.size / 100));
                    PbImagesOfChildren.Size = new Size(PbImagesOfChildren.Width, PbImagesOfChildren.Height + 2 * Essence.size + 20 + (10 * Essence.size / 100));
                }
            }
        }

        private void ResetCurrentPositionPoint()
        {

            _CurrentPositionPoint.X = 4;
            _CurrentPositionPoint.Y = 4;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            PbImagesOfChildren.Refresh();
            PbImagesOfChildren.Controls.Clear();
            offspring = Father.Breed(Mother, Offspringnumber);

            for (int i = 0; i < Offspringnumber; i++)
            {
                offspring[i].Draw(PbImagesOfChildren, _CurrentPositionPoint, Essence.size);
                OffsetCurrentPositionPoint(offspring[i].Name);
            }
            ResetCurrentPositionPoint();
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            PnlSettings.Visible = true;
            PnMain.Visible = false;
        }

        private void BtSetSettings_Click(object sender, EventArgs e)
        {
            PnlSettings.Visible = false;
            PnMain.Visible = true;
            UpdateFather();
            UpddateMother();
            PbImagesOfChildren.Invalidate();
            SetLabelValues();
        }

        private void Vsbar_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrollPosition != Vsbar.Value)
            {
                scrollPosition = Vsbar.Value;
                PbImagesOfChildren.Invalidate();
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            int visibleTop = scrollPosition;
            int visibleBottom = scrollPosition + this.ClientSize.Height;

            //if (PictureBoxBuffer == null || PictureBoxBuffer.Size != PbImagesOfChildren.ClientSize)
            //{
            //    PictureBoxBuffer =
            //        new Bitmap(PbImagesOfChildren.ClientSize.Width, PbImagesOfChildren.ClientSize.Height);
            //}

            //using (Graphics g = Graphics.FromImage(PictureBoxBuffer))
            //{
            //    g.Clear(Color.White);

            if (offspring != null)
            {
                foreach (Essence child in offspring)
                {
                    child.Draw(PbImagesOfChildren, _CurrentPositionPoint, Essence.size);
                    OffsetCurrentPositionPoint(child.Name);
                }
                ResetCurrentPositionPoint();
            }
            //}

            //PbImagesOfChildren.Image = PictureBoxBuffer;
        }

        private void TimerInvalidate_Tick_1(object sender, EventArgs e)
        {
            PbImagesOfChildren.Invalidate();
        }

        private void TbarOffspringCount_ValueChanged(object sender, EventArgs e)
        {
            Offspringnumber = TbarOffspringCount.Value;
        }
    }


    public static class EnumHandler
    {
        public static string[] male_names = { "Barsick", "Tuzik", "Zhuzhik", "Pup", "GigaChad", "Sharp", "Shults", "Garik", "Bulgum" };
        public static string[] female_names = { "Misca", "Phimka", "Busa", "Pupa", "Omega", "Princess", "Murka", "Zhuchka", "Kapa" };
        public static int GetSize<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Length;
        }

        public static T GetRandomValue<T>() where T : Enum
        {
            Random random = new();

            T[] values = (T[])Enum.GetValues(typeof(T));
            int randomIndex = random.Next(values.Length);

            return values[randomIndex];
        }
    }

    public static class Extensions
    {
        public static void FillTriangle(this Graphics graphics, Brush brush, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.FillPolygon(brush, points);
        }

        public static void DrawTriangle(this Graphics graphics, Pen pen, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.DrawPolygon(pen, points);
        }
    }
    public class Gene
    {
        public Allele allele1;
        public Allele allele2;
        //public Allele allele3;

        private string _name;

        public bool Dominant
        {
            get { return allele1 == Allele.Dominant || allele2 == Allele.Dominant; }
        }

        public Gene(Allele allele1, Allele allele2, string name)
        {
            this.allele1 = allele1;
            this.allele2 = allele2;
            _name = name;
        }

        //public Gene(Allele allele1, Allele allele2, Allele allele3, string name)
        //{
        //    this.allele1 = allele1;
        //    this.allele2 = allele2;
        //    this.allele3 = allele3;
        //    _name = name;
        //}

        public string ToString(Allele allele)
        {
            return allele == Allele.Dominant ? "Dominant" : "Recessive";
        }

        public static Gene operator +(Gene gen1, Gene gen2)
        {
            Random random = new();
            Thread.Sleep(1);

            Allele allele1 = random.Next(2) == 0 ? gen1.allele1 : gen2.allele1;
            Allele allele2 = random.Next(2) == 0 ? gen1.allele2 : gen2.allele2;

            return new Gene(allele1, allele2, gen1._name);
        }
    }

    public class Phenotype
    {
        public Shapes Shape { get; set; }
        public Color LineColor { get; set; }
        public Color FillColor { get; set; }
        public float LineWidth { get; set; }

        public Phenotype()
        {
            Shape = Shapes.Circle;
            LineColor = Color.Purple;
            FillColor = Color.Empty;
            LineWidth = 1;
        }

        public Phenotype(Shapes shape) : this()
        {
            Shape = shape;
        }

        public Phenotype(Shapes shape, Color lineColor) : this(shape)
        {
            LineColor = lineColor;
        }

        public Phenotype(Shapes shape, Color lineColor, Color fillColor) : this(shape, lineColor)
        {
            FillColor = fillColor;
        }

        public Phenotype(Shapes shape, Color lineColor, Color fillColor, float lineWidth) : this(shape, lineColor, fillColor)
        {
            LineWidth = lineWidth;
        }

        public void Draw(Graphics graphics, Point point, int size)
        {
            Pen pen = new(LineColor, LineWidth);
            Brush brush = new SolidBrush(FillColor);

            Rectangle rectangle = new(point, new Size(size, size));

            switch (Shape)
            {
                case Shapes.Circle:
                    graphics.FillEllipse(brush, rectangle);
                    graphics.DrawEllipse(pen, rectangle);
                    break;
                case Shapes.Triangle:
                    graphics.FillTriangle(brush, rectangle);
                    graphics.DrawTriangle(pen, rectangle);
                    break;
            }
        }
    }

    public abstract class Essence
    {
        private string _name;

        public static int size = 45;
        public string Name
        {
            get { return _name; }
            set { _name = (value != string.Empty) ? value : "Barsick"; }
        }
        public Sex sex { get; set; }
        public Phenotype EssencePhenotype { get; set; }

        public Essence(string name, Sex pSex)
        {
            Name = name;
            sex = pSex;
            EssencePhenotype = new Phenotype((sex == Sex.Male) ? Shapes.Triangle : Shapes.Circle);
        }

        public void Draw(Control control, Point point, int size)
        {
            Graphics graphic = control.CreateGraphics();

            Label nameLabel = new();
            nameLabel.Text = Name;
            nameLabel.Location = new Point(point.X, point.Y + (size + (10 * size / 100)));
            nameLabel.AutoSize = true;

            control.Controls.Add(nameLabel);

            EssencePhenotype.Draw(graphic, point, size);
        }

        public List<Essence> Breed(Essence partner, int count)
        {
            List<Essence> Children = new List<Essence>();
            Random random = new();
            string name = "";
            Sex sex = new();
            for (int i = 0; i < count; i++)
            {
                sex = EnumHandler.GetRandomValue<Sex>();
                if (sex == Sex.Male)
                {
                    name = EnumHandler.male_names[random.Next(EnumHandler.male_names.Length)];
                }
                else
                {
                    name = EnumHandler.female_names[random.Next(EnumHandler.female_names.Length)];
                }
                Essence child = this.Child(partner, name, sex);
                Children.Add(child);
            }
            return Children;
        }
        protected abstract Essence Child(Essence partner, string name, Sex pSex);
    }

    public class Animal : Essence
    {
        public Gene Genotype { get; set; }

        public Animal(string name, Sex sex) : base(name, sex)
        {
            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
            EssencePhenotype.LineWidth = Genotype.Dominant ? 4 : 1;
        }

        public Animal(string name, Sex sex, Gene genotype) : base(name, sex)
        {
            Genotype = genotype;
            EssencePhenotype.LineWidth = Genotype.Dominant ? 4 : 1;
        }

        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal).Genotype;
            Essence child = new Animal(name, sex, childGen);
            return child;
        }
    }

    public class Animal_secondary : Animal
    {
        private Gene Genotype { get; set; }

        public Animal_secondary(string name, Sex sex) : base(name, sex)
        {
            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
            EssencePhenotype.FillColor = Genotype.Dominant ? Color.DarkOrchid : Color.Tomato;
        }
        public Animal_secondary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Genotype = genotype;
            EssencePhenotype.FillColor = Genotype.Dominant ? Color.DarkOrchid : Color.Tomato;
        }

        public Animal_secondary(string name, Sex sex, Gene gene1, Gene gene2) : base(name, sex, gene1)
        {
            Genotype = gene2;
            EssencePhenotype.FillColor = Genotype.Dominant ? Color.DarkOrchid : Color.Tomato;
        }

        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal_secondary).Genotype;
            Essence child = new Animal_secondary(name, sex, childGen);
            return child;
        }
    }

    public class Animal_tertiary : Animal_secondary
    {
        private Gene Genotype { get; set; }

        public Animal_tertiary(string name, Sex sex) : base(name, sex)
        {
            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
            EssencePhenotype.LineColor = Genotype.Dominant ? Color.SpringGreen : Color.Black;
        }
        public Animal_tertiary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Genotype = genotype;
            EssencePhenotype.LineColor = Genotype.Dominant ? Color.SpringGreen : Color.Black;
        }

        public Animal_tertiary(string name, Sex sex, Gene gene1, Gene gene2, Gene gene3) : base(name, sex, gene1, gene2)
        {
            Genotype = gene3;
            EssencePhenotype.LineColor = Genotype.Dominant ? Color.SpringGreen : Color.Black;
        }
        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal_tertiary).Genotype;
            Essence child = new Animal_tertiary(name, sex, childGen);
            return child;
        }
    }
}