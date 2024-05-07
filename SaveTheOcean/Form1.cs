namespace SaveTheOcean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cierra la aplicaci�n
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Abre la ventana de creaci�n de personaje y cierra la del men� principal
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();


        }

        private void btnRescues_Click(object sender, EventArgs e)
        {
            FormRescues formRescues = new FormRescues();
            formRescues.ShowDialog();
            this.Close();
        }
    }
}
