namespace Laba5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "װאיכû pdf|*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);
        }

        private void axAcroPDF1_OnConnecting(object sender, EventArgs e)
        {

        }

        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
