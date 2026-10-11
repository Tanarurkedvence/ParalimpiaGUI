namespace ParalimpiaGUI
{
    public partial class Form1 : Form
    {
        List<Paralimpia> paralimpias = new List<Paralimpia>();
        int currentrow = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            textBox1.TextChanged += TextBox1_TextChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            modositasijavaslat.Click += Modositasijavaslat_Click;
        }

        private void Modositasijavaslat_Click(object? sender, EventArgs e)
        {
            var gabby = MessageBox.Show(
                text: $"Valóban javaslatot tesz a(z) {kijeloltev_lb.Text}. évi paralimpia éremszámaira?",
                caption: $"Megerősítés",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning);


            if (gabby == DialogResult.Yes)
            {
                currentrow = dataGridView1.CurrentCell.RowIndex;
                using (StreamWriter sw = new StreamWriter("../../../forras/javastlat.txt" ,true))
                {
                    sw.WriteLine($"{DateTime.Now}\t {currentrow++}\t Érmek: {textBox2.Text}\t {textBox3.Text}\t {textBox4.Text}");

                }
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            kijeloltev_lb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            var filter = paralimpias.Where(x => x.Orszag.ToLower().Contains(textBox1.Text.ToLower()) || x.Varos.ToLower().Contains(textBox1.Text.ToLower()));
            dataGridView1.Rows.Clear();
            foreach (var par in filter)
            {
                dataGridView1.Rows.Add(par.Id, par.Orszag, par.Varos, par.Ev, par.Arany, par.Ezust, par.Bronz);
            }

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Read();
            Write();

        }

        private void Write()
        {
            foreach (var par in paralimpias)
            {
                dataGridView1.Rows.Add(par.Id, par.Orszag, par.Varos, par.Ev, par.Arany, par.Ezust, par.Bronz);
            }
        }

        private void Read()
        {
            using (StreamReader olvaso = new StreamReader("../../../forras/ermek.txt"))
            {
                while (!olvaso.EndOfStream)
                {
                    paralimpias.Add(new Paralimpia(olvaso.ReadLine()));
                }
            }
        }
    }
}
