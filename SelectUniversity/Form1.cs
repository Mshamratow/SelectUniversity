namespace SelectUniversity
{
    public partial class Form1 : Form
    {
        const int MAXUNIV = 100;
        int univ_count;
        string[,] universities = new string[MAXUNIV, 4];
        List<string> cities = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string line;
            UniversitiesTable.ColumnCount = 3;
            using (var fs = File.OpenText("City.txt"))
            {
                while ((line = fs.ReadLine()) != null)
                {
                    string city = line.Split(' ')[1];
                    SelectCityBox.Items.Add(city);
                    cities.Add(city);
                }
            }
            SelectCityBox.SelectedItem = cities[0];
            using (var fs = File.OpenText("Universities.txt"))
            {
                int ID = 1;
                while ((line = fs.ReadLine()) != null)
                {
                    string[] row = line.Split(' ');
                    universities[ID - 1, 0] = ID.ToString();
                    universities[ID - 1, 1] = row[1].Substring(0, row[1].Length - 1);
                    universities[ID - 1, 2] = row[2].Substring(0, row[2].Length - 1);
                    universities[ID - 1, 3] = row[3];
                    ID++;
                }
                univ_count = ID - 1;
            }
        }

        private void SelectCityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversitiesTable.Rows.Clear();
            string city = SelectCityBox.SelectedItem.ToString();
            for (int i = 0; i < univ_count; i++)
            {
                if (cities[int.Parse(universities[i, 2]) - 1] == city)
                {
                    UniversitiesTable.Rows.Add(universities[i, 0], universities[i, 1], city);
                }
            }
        }

        private void UniversitiesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = UniversitiesTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            for (int i = 0; i < univ_count; i++)
            {
                if (universities[i, 0] == ID)
                {
                    name_label.Text = universities[i, 1];
                    city_label.Text = cities[int.Parse(universities[i, 2])-1];
                    photobox.Image = Image.FromFile("Images/" + ID + " " + universities[i, 1] + ".jpg");
                    break;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
