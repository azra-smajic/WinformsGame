using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class frmRanking : Form
    {
        KonekcijaNaBazu kb = InstancaBaze.kb;
        public frmRanking()
        {
            InitializeComponent();
            dgvRank.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            dgvRank.DataSource = null;
            dgvRank.DataSource = new BindingSource()
            {
                DataSource = kb.Players.ToList()
            };
            CustomDGV();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void CustomDGV()
        {
            dgvRank.DefaultCellStyle.BackColor = Color.LightSteelBlue;
            Font f = new Font(dgvRank.DefaultCellStyle.Font, FontStyle.Italic);
            Font f1 = new Font(dgvRank.DefaultCellStyle.Font, FontStyle.Bold);
            dgvRank.DefaultCellStyle.Font = new Font("Showcard Gothic", 14, FontStyle.Regular);
           
            dgvRank.ColumnHeadersDefaultCellStyle.Font=new Font("Showcard Gothic", 18, FontStyle.Regular);
            
            dgvRank.EnableHeadersVisualStyles = false;
            dgvRank.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(145, 102, 106);
            dgvRank.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRank.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(145, 102, 106);

            dgvRank.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRank.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
