using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Essenses_crossing.Main;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;

namespace Essenses_crossing
{
    public partial class Main : Form
    {
        public Essence Father;
        public Essence Mother;
        public int Offspringnumber;
        public int AttrsNamesCount = 2;

        public List<Essence> offspring;
        public List<Essence> filteredList;
        public List<GroupBoxList> GroupBoxListsFather = new List<GroupBoxList>();
        public List<GroupBoxList> GroupBoxListsMother = new List<GroupBoxList>();

        public readonly List<string> attrNames = new List<string>() { "LineWidth", "FillColor", "LineColor" };
        public readonly List<string> AlleleNames = new List<string>() { "Allele 1", "Allele 2" };

        private Point _CurrentPositionPoint;

        public Main()
        {
            InitializeComponent();

            CreateGenesControls(FlpControlFather);
            UpdateFather();
            CreateGenesControls(FlpControlMother);
            UpdateMother();

            Offspringnumber = 10;
            SetLabelValues();

            numUDOffspingCount.Value = Offspringnumber;

            _CurrentPositionPoint = new Point(2, 2);

            PbImagesOfChildren.Parent = pnlChildren;

            ListboxChildren.DisplayMember = "Name";

            comboxSetAttrsCount.SelectedIndex = AttrsNamesCount;

            EnumHandler.MaleNamesList = FillListOfNames("C:/Users/Максим/Desktop/Essenses_crossing/male_names_rus.txt");
            EnumHandler.FemaleNamesList = FillListOfNames("C:/Users/Максим/Desktop/Essenses_crossing/female_names_rus.txt");
        }

        private List<string> FillListOfNames(string filename)
        {
            string filePath = filename;
            List<string> names = new List<string>();

            try
            {
                StreamReader reader = new StreamReader(filePath);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Произошла ошибка чтения файла: " + e.Message);
            }
            return names;
        }

        private void UpdateFather()
        {
            // PbFatherIcon.Refresh();
            Father = CreateParent(FlpControlFather, Sex.Male, GroupBoxListsFather);
            Father.Draw(PbFatherIcon, new Point(4, 4), Essence.size);
        }
        private void UpdateMother()
        {
            // PbFatherIcon.Refresh();
            Mother = CreateParent(FlpControlMother, Sex.Female, GroupBoxListsMother);
            Mother.Draw(PbMotherIcon, new Point(4, 4), Essence.size);
        }

        Essence CreateParent(FlowLayoutPanel flpanel, Sex sex, List<GroupBoxList> groupBoxLists)
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

                if (groupBoxList.Chekboxes[1].Checked)
                    allele2 = Allele.Dominant;
                else
                    allele2 = Allele.Recessive;

                geneList.Add(new Gene(allele1, allele2, groupBoxList.GroupBox.Text));
            }

            Essence parent = null;

            switch (AttrsNamesCount)
            {
                case 0:
                    {
                        parent = new Animal(name, sex, geneList[0]);
                    }
                    break;
                case 1:
                    {
                        parent = new Animal_secondary(name, sex, geneList[0], geneList[1]);
                    }
                    break;
                case 2:
                    {
                        parent = new Animal_tertiary(name, sex, geneList[0], geneList[1], geneList[2]);
                    }
                    break;
            }
            return parent;
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
            flppanel.Controls.Clear();
            if (flppanel != null)
                flppanel.Controls.Clear();
            for (int i = 0; i < AttrsNamesCount + 1; ++i)
            {
                Point locPoint = new Point(10, 20);
                Random random = new();
                GroupBox grbox = new GroupBox();
                grbox.Text = attrNames[i];
                GroupBoxList groupBox = new GroupBoxList(grbox);
                if (flppanel.Name == "FlpControlFather")
                    GroupBoxListsFather.Add(groupBox);
                else if (flppanel.Name == "FlpControlMother")
                    GroupBoxListsMother.Add(groupBox);

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
            }
        }

        private void UpdateListBox()
        {
            if (offspring != null)
            {

                if (rbSortMale.Checked)
                {
                    filteredList = offspring.Where(child => child.sex == Sex.Male).ToList();
                }
                else if (rbSortFemale.Checked)
                {
                    filteredList = offspring.Where(child => child.sex == Sex.Female).ToList();
                }
                else if (rbSortNone.Checked)
                {
                    filteredList = offspring.ToList();
                }
                else
                {
                    filteredList = offspring.ToList();
                }

                if (chbSortName.Checked)
                {
                    filteredList = filteredList.OrderBy(child => child.Name).ToList();
                }

                ListboxChildren.Items.Clear();

                PbImagesOfChildren.Refresh();
                PbImagesOfChildren.Controls.Clear();

                foreach (var child in filteredList)
                {
                    ListboxChildren.Items.Add(child);
                    child.Draw(PbImagesOfChildren, _CurrentPositionPoint, Essence.size);
                    OffsetCurrentPositionPoint(child.Name);
                }
                ResetCurrentPositionPoint();
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
            ListboxChildren.Items.Clear();
            offspring = Father.Breed(Mother, Offspringnumber);
            filteredList = offspring;
            for (int i = 0; i < Offspringnumber; i++)
            {
                filteredList[i].Draw(PbImagesOfChildren, _CurrentPositionPoint, Essence.size);
                ListboxChildren.Items.Add(filteredList[i]);
                OffsetCurrentPositionPoint(filteredList[i].Name);
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
            UpdateFather();
            UpdateMother();
            PnlSettings.Visible = false;
            PnMain.Visible = true;
            PbImagesOfChildren.Invalidate();
            SetLabelValues();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Father.Draw(PbFatherIcon, _CurrentPositionPoint, Essence.size);
            Mother.Draw(PbMotherIcon, _CurrentPositionPoint, Essence.size);
            ResetCurrentPositionPoint();

            if (filteredList != null)
            {
                foreach (Essence child in filteredList)
                {
                    child.Draw(PbImagesOfChildren, _CurrentPositionPoint, Essence.size);
                    OffsetCurrentPositionPoint(child.Name);
                }
                ResetCurrentPositionPoint();
            }
        }

        private void nUDChildrenCount_ValueChanged(object sender, EventArgs e)
        {
            Offspringnumber = (int)numUDOffspingCount.Value;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            PnMain.Size = this.ClientSize;
            PnlSettings.Size = this.ClientSize;
        }

        private void ListboxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            PbChildIcon.Image = filteredList[(int)ListboxChildren.SelectedIndex].EssenceIcon;
            if (filteredList[(int)ListboxChildren.SelectedIndex] != null)
            {
                lblChildName.Text = filteredList[(int)ListboxChildren.SelectedIndex].Name;
                lblChildSex.Text = filteredList[(int)ListboxChildren.SelectedIndex].ToStringSex();
            }
            lbChildAttr.Text = filteredList[ListboxChildren.SelectedIndex].ToString();
        }

        private void rbSortMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void rbSortFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void chbSortName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }


        private void comboxSetAttrsCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            AttrsNamesCount = comboxSetAttrsCount.SelectedIndex;
            GroupBoxListsFather.Clear();
            GroupBoxListsMother.Clear();
            CreateGenesControls(FlpControlFather);
            CreateGenesControls(FlpControlMother);
        }

        private void PbImagesOfChildren_MouseClick(object sender, MouseEventArgs e)
        {

            int xsum = 2 + Essence.size + 15;
            int ysum = 2 + Essence.size + 15;
            int X = e.Location.X;
            int Y = e.Location.Y;
            int i = 0;
            int j = 0;
            int multiplyer = PbImagesOfChildren.Width / (Essence.size + 15);
            while (xsum < X)
            {
                xsum += Essence.size + 15;
                i++;
            }
            while (ysum < Y)
            {
                ysum += Essence.size + 15;
                j++;
            }
            PbChildIcon.Refresh();
            filteredList[j * multiplyer + i].Draw(PbChildIcon, new Point(4, 4), Essence.size);
            PbChildIcon.Controls.Clear();
            lblChildName.Text = filteredList[j * multiplyer + i].Name;
            lblChildSex.Text = filteredList[j * multiplyer + i].ToStringSex();
            lbChildAttr.Text = filteredList[j * multiplyer + i].ToString();
            ListboxChildren.SelectedItem = filteredList[j * multiplyer + i];
        }
    }

    public static class EnumHandler
    {
        public static List<string> MaleNamesList = new List<string>();
        public static List<string> FemaleNamesList = new List<string>();
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
}