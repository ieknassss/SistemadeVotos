using SistemadeVotaciones.Data;
using System;
using System.Windows.Forms;

namespace SistemadeVotaciones.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnectionFactory factory = new DbConnectionFactory();

                using (var connection = factory.CreateConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Conexión exitosa con SQL Server",
                        "Sistema de Votaciones",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}