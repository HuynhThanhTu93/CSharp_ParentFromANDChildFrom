namespace CSharp_ParentFromANDChildFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chidlFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChidlForm1 cf1 = new ChidlForm1();
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
