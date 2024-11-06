namespace Tourist_Accommodation_System
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();

        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadUserControl(UserControl control)
        {
            MainPanel.Controls.Clear(); // p/ remover controlador atual
            control.Dock = DockStyle.Fill; // Faz c q o controle ocupe todo o espaço
            MainPanel.Controls.Add(control); // Adiciona o novo controle ao painel
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void button_client_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlClient());
        }

        private void button_accommodation_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlAccommodation());
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlReservation());
        }

        private void button_reviews_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlReview());
        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlCheckin());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
