using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluGames
{
    public partial class Jogos : Form
    {
        public Jogos()
        {
            InitializeComponent();
        }

        private void gameTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gameTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogosBDDataSet);

        }

        private void Jogos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogosBDDataSet.GameTable'. Você pode movê-la ou removê-la conforme necessário.
            this.gameTableTableAdapter.Fill(this.jogosBDDataSet.GameTable);

        }

        private void observaçõesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gameTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = true;
            gameTableBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
