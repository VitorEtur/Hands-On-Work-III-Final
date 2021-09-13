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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clientTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogosBDDataSet);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogosBDDataSet.ClientTable'. Você pode movê-la ou removê-la conforme necessário.
            this.clientTableTableAdapter.Fill(this.jogosBDDataSet.ClientTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogosBDDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void endereçoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
