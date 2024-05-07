using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean.DTOs;
using SaveTheOcean.Persistence.Mapping;
using SaveTheOcean.Persistence.DAO;
using SaveTheOcean.Persistence.Utils;

namespace SaveTheOcean
{
    public partial class FormRescues : Form
    {
        public FormRescues()
        {
            InitializeComponent();
        }

        private void FormRescues_Load(object sender, EventArgs e)
        {

            // Muestra los datos de los rescates en la base de datos en el datagrid

            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());

            List<RescueDTO> rescues = rescueDAO.GetAllRescues().ToList();

            // Se agregan las columnas a Rescates

            dgvRescues.Columns.Add("ID", "ID");
            dgvRescues.Columns.Add("NRescue", "Número de rescate");
            dgvRescues.Columns.Add("Date", "Fecha");
            dgvRescues.Columns.Add("Species", "Especie");
            dgvRescues.Columns.Add("GA", "Grado de afectación");
            dgvRescues.Columns.Add("Location", "Localización");


            foreach (RescueDTO rescue in rescues)
            {
                dgvRescues.Rows.Add(rescue.ID, rescue.NRescue, rescue.Date, rescue.Species, rescue.GA, rescue.Location);
            }

        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {
            // Busca un rescate por ID

            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduce un ID");
                return;
            }else if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Introduce un número válido");
                return;
            }

            RescueDTO rescue = rescueDAO.GetRescueById(int.Parse(textBox1.Text));

            if (rescue == null)
            {
                MessageBox.Show("No se ha encontrado ningún rescate con ese ID");
                return;
            }

            dgvRescues.Rows.Clear();
            dgvRescues.Rows.Add(rescue.ID, rescue.NRescue, rescue.Date, rescue.Species, rescue.GA, rescue.Location);

            

        }
    }
}

