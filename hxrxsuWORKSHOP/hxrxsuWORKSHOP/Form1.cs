using System.Windows.Forms;

namespace hxrxsuWORKSHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 _form = new Form2();
            _form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция в разработке...", "WARNING");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ершов Алексей 26 группа", "Автор");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 _form = new Form3();
            _form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 _form = new Form5();
            _form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 _form = new Form4();
            _form.ShowDialog();
        }
    }
}