using System.Drawing.Text;

namespace Essenses_crossing
{
    public enum Sex { Male, Female };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Dominant, Recessive };

    public partial class Main : Form
    {
        public Animal_tertiary Father;
        public Animal_tertiary Mother;
        private Point _CurrentPositionPoint = new Point(2,2);
        private int size = 45;

        List<Essence> _offspring;

        public int Offspringnumber;
        public Main()
        {
            InitializeComponent();

            Father = new Animal_tertiary("Murzik", Sex.Male);
            Mother = new Animal_tertiary("Buska", Sex.Female);

            Offspringnumber = 10;
            SetLabelValues();
        }

        private void SetLabelValues()
        {
            LblMothername.Text = $"Name: {Mother.Name}";
            LblMothergen.Text += $"{Mother.Genotype.ToString(Mother.Genotype.allele1)} ";
            LblMothergen.Text += $" {Mother.Genotype.ToString(Mother.Genotype.allele2)}";

            LblFathername.Text = $"Name: {Father.Name}";
            LblFathergen.Text += $"{Father.Genotype.ToString(Father.Genotype.allele1)} ";
            LblFathergen.Text += $" {Father.Genotype.ToString(Father.Genotype.allele2)}";
        }

        private void SetRadioButtons(RadioButton dominantRadioButton, RadioButton recessiveRadioButton, Allele allele)
        {
            dominantRadioButton.Checked = (allele == Allele.Dominant);
            recessiveRadioButton.Checked = (allele == Allele.Recessive);
        }

        private void AlleleRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (Enum.TryParse(radioButton.Tag as string, out Allele allele))
            {
                if (radioButton.Name.StartsWith("RbFatherAllele1"))
                {
                    Father.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RbFatherAllele2"))
                {
                    Father.Genotype.allele2 = allele;
                }
                else if (radioButton.Name.StartsWith("RbMotherAllele1"))
                {
                    Mother.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RbMotherAllele2"))
                {
                    Mother.Genotype.allele2 = allele;
                }
            }
        }

        private void BtOffspringSetNumber_Click(object sender, EventArgs e)
        {
            SetNumberOffspring((Button)sender);
        }

        private void SetNumberOffspring(Button btn)
        {
            Offspringnumber = Convert.ToInt32(btn.Tag);
        }

        private void OffsetCurrentPositionPoint()
        {
            _CurrentPositionPoint.X += size + 10;
            if (_CurrentPositionPoint.X + size > PbImagesOfChildren.Width)
            {
                _CurrentPositionPoint.X = 10;
                _CurrentPositionPoint.Y += size + 10;
            }
        }

        private void ResetCurrentPositionPoint()
        {
            
            _CurrentPositionPoint.X = 4;
            _CurrentPositionPoint.Y = 4;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            _offspring = Father.Breed(Mother, Offspringnumber);

            Father.Draw(PbFatherIcon, new Point(4,4), size);
            Mother.Draw(PbMotherIcon, new Point(4, 4), size);

            foreach (var child in _offspring)
            {
                child.Draw(PbImagesOfChildren, _CurrentPositionPoint, size);
                OffsetCurrentPositionPoint();
            }
            ResetCurrentPositionPoint();
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            PnlSettings.Visible = true;
            PnMain.Visible = false;

            SetRadioButtons(RbFatherAllele1Dominant, RbFatherAllele1Recessive, Father.Genotype.allele1);
            SetRadioButtons(RbFatherAllele2Dominant, RbFatherAllele2Recessive, Father.Genotype.allele2);

            SetRadioButtons(RbMotherAllele1Dominant, RbMotherAllele1Recessive, Mother.Genotype.allele1);
            SetRadioButtons(RbMotherAllele2Dominant, RbMotherAllele2Recessive, Mother.Genotype.allele2);
        }

        private void BtSetSettings_Click(object sender, EventArgs e)
        {
            PnlSettings.Visible = false;
            PnMain.Visible = true;
            PbImagesOfChildren.Invalidate();
            LblFathergen.Text = "Father's Genotype: ";
            LblMothergen.Text = "Mother's Genotype: ";
            SetLabelValues();
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

        private Point _currentPositionPoint = new Point(10, 10);
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
            EssencePhenotype.Draw(graphic, point, size);
        }

        protected virtual Essence Child(Essence partner, string name, Sex pSex)
        {
            return null;
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
                    name = EnumHandler.female_names[random.Next(EnumHandler.male_names.Length)];
                }
                Essence child = this.Child(partner, name, sex);
                Children.Add(child);
            }
            return Children;
        }
    }

    public class Animal : Essence
    {
        public Gene Genotype { get; set; }

        public Animal(string name, Sex sex) : base(name, sex)
        {
            Random random = new();

            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
        }

        public Animal(string name, Sex sex, Gene genotype) : base(name, sex)
        {
            Genotype = genotype;
            EssencePhenotype.LineWidth = Genotype.Dominant ? 4 : 1;
        }

        protected virtual Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal).Genotype;
            Essence child = new Animal(name, sex, childGen);
            return child;
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
                    name = EnumHandler.female_names[random.Next(EnumHandler.male_names.Length)];
                }
                Essence child = this.Child(partner, name, sex);
                Children.Add(child);
            }
            return Children;
        }
    }

    public class Animal_secondary : Animal
    {
        private Gene Genotype { get; set; }

        public Animal_secondary(string name, Sex sex) : base(name, sex)
        {
            Random random = new();

            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
        }
        public Animal_secondary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Genotype = genotype;
            EssencePhenotype.FillColor = Genotype.Dominant ? Color.DarkOrchid : Color.Tomato;
        }

        protected virtual Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal_secondary).Genotype;
            Essence child = new Animal_secondary(name, sex, childGen);
            return child;
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
                    name = EnumHandler.female_names[random.Next(EnumHandler.male_names.Length)];
                }
                Essence child = this.Child(partner, name, sex);
                Children.Add(child);
            }
            return Children;
        }
    }

    public class Animal_tertiary : Animal_secondary
    {
        private Gene Genotype { get; set; }

        public Animal_tertiary(string name, Sex sex) : base(name, sex)
        {
            Random random = new();

            Genotype = new Gene(EnumHandler.GetRandomValue<Allele>(), EnumHandler.GetRandomValue<Allele>(), name);
        }
        public Animal_tertiary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Genotype = genotype;
            EssencePhenotype.LineColor = Genotype.Dominant ? Color.SpringGreen : Color.Gold;
        }
        protected virtual Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = this.Genotype + (partner as Animal_tertiary).Genotype;
            Essence child = new Animal_tertiary(name, sex, childGen);
            return child;
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
                    name = EnumHandler.female_names[random.Next(EnumHandler.male_names.Length)];
                }
                Essence child = this.Child(partner, name, sex);
                Children.Add(child);
            }
            return Children;
        }
    }
}