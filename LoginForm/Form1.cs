namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Flogin f = new Flogin();
            f.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dlg = f.ShowDialog();
            if (dlg ==System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("�α��� ����");
            }
            else
            {
                MessageBox.Show("�α��� ����");
            }
        }
    }
}