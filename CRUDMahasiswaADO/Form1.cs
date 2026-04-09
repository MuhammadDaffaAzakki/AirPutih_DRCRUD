using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class FormMahasiswa : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DaffaAzakki\\DAFFA_AZAKKI;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }


