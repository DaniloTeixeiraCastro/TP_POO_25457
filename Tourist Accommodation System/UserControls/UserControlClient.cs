using Tourist_Accommodation_System.Forms;
using System.Windows.Forms;

namespace Tourist_Accommodation_System
{
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (this.Parent is Forms1 mainForm)
            {
                mainForm.MainPanel.Controls.Clear(); // Limpa o painel para retornar ao Form1
            }

        }

        private void button_addclient_Click(object sender, EventArgs e)
        {
            FormAddEditClient addClientForm = new FormAddEditClient();
            addClientForm.ShowDialog();

        }

        private void button_editclient_Click(object sender, EventArgs e)
        {


        }

        private void button_removeclient_Click(object sender, EventArgs e)
        {


        }

        private void button_listclient_Click(object sender, EventArgs e)
        {

        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {

        }
    }


}
