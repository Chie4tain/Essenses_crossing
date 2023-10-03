namespace Essenses_crossing
{
    public enum Sex { Male, Female };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Dominant, Recessive };

    public partial class Main : Form
    {
        public string[] Male_names = { "Barsick", "Tuzik", "Zhuzhik", "Pup", "GigaChad", "sharp", "shults", "garik", "bulgum" };
        public string[] Female_names = { "Misca", "Phimka", "Busa", "Pupa", "Omega", "princess", "Murka", "Zhuchka", "Kapa" };

        public Animal father;
        public Animal mother;

        List<Animal> offspring;

        public int Offspringnumber;
        public Main()
        {
            InitializeComponent();

            father = new Animal("Murzik", Sex.Male);
            mother = new Animal("Buska", Sex.Female);

            Offspringnumber = 10;
            SetLabelValues();
        }

        private void SetLabelValues()
        {
            LblMothername.Text = $"Name: {mother.Name}";
            LblMothergen.Text += $"{mother.Genotype.ToString(mother.Genotype.allele1)} ";
            LblMothergen.Text += $" {mother.Genotype.ToString(mother.Genotype.allele2)}";

            LblFathername.Text = $"Name: {father.Name}";
            LblFathergen.Text += $"{father.Genotype.ToString(father.Genotype.allele1)} ";
            LblFathergen.Text += $" {father.Genotype.ToString(father.Genotype.allele2)}";
        }

        private List<Animal> GenerateOffspring()
        {
            offspring = new List<Animal>();

            Random random = new();
            string name = "";
            Sex sex = new();

            for (int i = 1; i <= Offspringnumber; ++i)
            {
                sex = EnumHandler.GetRandomValue<Sex>();
                if (sex == Sex.Male)
                {
                    name = Male_names[random.Next(Male_names.Length)];
                }
                else
                {
                    name = Female_names[random.Next(Male_names.Length)];
                }
                Animal animal = new(name, sex);
                offspring.Add(animal);
            }

            return offspring;
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
                    father.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RbFatherAllele2"))
                {
                    father.Genotype.allele2 = allele;
                }
                else if (radioButton.Name.StartsWith("RbMotherAllele1"))
                {
                    mother.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RbMotherAllele2"))
                {
                    mother.Genotype.allele2 = allele;
                }
            }
        }

        private void BtOffspringSetNumber_Click(object sender, EventArgs e)
        {
            setNumberOffspring((Button)sender);
        }

        private void setNumberOffspring(Button btn)
        {
            Offspringnumber = Convert.ToInt32(btn.Tag);
        }

        private void DrawOffspring()
        {
            PbImagesOfChildren.Controls.Clear();

            int x = 20;
            int y = 20;

            foreach (Animal child in offspring)
            {
                child.EssensePhenotype.Draw(PbImagesOfChildren.CreateGraphics(), new Point(x, y), 30);

                Label nameLabel = new();
                nameLabel.Text = child.Name;
                nameLabel.Location = new Point(x, y + 35);
                nameLabel.AutoSize = true;

                PbImagesOfChildren.Controls.Add(nameLabel);

                x += 60;
                if (x > PbImagesOfChildren.Width - 40)
                {
                    x = 20;
                    y += 70;
                }
            }
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            GenerateOffspring();

            DrawOffspring();
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            PnlSettings.Visible = true;
            PnMain.Visible = false;

            SetRadioButtons(RbFatherAllele1Dominant, RbFatherAllele1Recessive, father.Genotype.allele1);
            SetRadioButtons(RbFatherAllele2Dominant, RbFatherAllele2Recessive, father.Genotype.allele2);

            SetRadioButtons(RbMotherAllele1Dominant, RbMotherAllele1Recessive, mother.Genotype.allele1);
            SetRadioButtons(RbMotherAllele2Dominant, RbMotherAllele2Recessive, mother.Genotype.allele2);
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

        public static readonly int alleleSize = EnumHandler.GetSize<Allele>();

        private string _name;

        bool Dominant
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

    public abstract class Essense
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = (value != string.Empty) ? value : "Barsick"; }
        }
        public Sex sex { get; set; }
        public Phenotype EssensePhenotype { get; set; }

        public Essense(string name, Sex p_sex)
        {
            Name = name;
            sex = p_sex;
            EssensePhenotype = new Phenotype((sex == Sex.Male) ? Shapes.Triangle : Shapes.Circle);
        }
    }

    public class Animal : Essense
    {
        public Gene Genotype { get; set; }

        public Animal(string name, Sex sex) : base(name, sex)
        {
            Random random = new();

            Allele allele1 = EnumHandler.GetRandomValue<Allele>();
            Allele allele2 = EnumHandler.GetRandomValue<Allele>();

            Genotype = new Gene(allele1, allele2, name);
        }

        public Animal(string name, Sex sex, Allele allele1) : base(name, sex)
        {
            Genotype = new Gene(allele1, allele1, name);
        }

        public Animal(string name, Sex sex, Allele allele1, Allele allele2) : base(name, sex)
        {
            Genotype = new Gene(allele1, allele2, name);
        }
    }
}