
namespace AluGames
{
    partial class Alugar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDlocacaoLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label jogoEscolhidoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataRetiradaLabel;
            System.Windows.Forms.Label dataDevolucaoLabel;
            System.Windows.Forms.Label oBSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alugar));
            this.jogosBDDataSet = new AluGames.JogosBDDataSet();
            this.locacaoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableTableAdapter = new AluGames.JogosBDDataSetTableAdapters.LocacaoTableTableAdapter();
            this.tableAdapterManager = new AluGames.JogosBDDataSetTableAdapters.TableAdapterManager();
            this.locacaoTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locacaoTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDlocacaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataRetiradaTextBox = new System.Windows.Forms.TextBox();
            this.dataDevolucaoTextBox = new System.Windows.Forms.TextBox();
            this.oBSTextBox = new System.Windows.Forms.TextBox();
            this.locacaoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogosBDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogosBDDataSet1 = new AluGames.JogosBDDataSet();
            this.gameTableTableAdapter = new AluGames.JogosBDDataSetTableAdapters.GameTableTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableTableAdapter = new AluGames.JogosBDDataSetTableAdapters.ClientTableTableAdapter();
            iDlocacaoLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            jogoEscolhidoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataRetiradaLabel = new System.Windows.Forms.Label();
            dataDevolucaoLabel = new System.Windows.Forms.Label();
            oBSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableBindingNavigator)).BeginInit();
            this.locacaoTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDlocacaoLabel
            // 
            iDlocacaoLabel.AutoSize = true;
            iDlocacaoLabel.Location = new System.Drawing.Point(39, 46);
            iDlocacaoLabel.Name = "iDlocacaoLabel";
            iDlocacaoLabel.Size = new System.Drawing.Size(59, 13);
            iDlocacaoLabel.TabIndex = 1;
            iDlocacaoLabel.Text = "IDlocacao:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(25, 72);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(73, 13);
            nomeClienteLabel.TabIndex = 3;
            nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // jogoEscolhidoLabel
            // 
            jogoEscolhidoLabel.AutoSize = true;
            jogoEscolhidoLabel.Location = new System.Drawing.Point(407, 72);
            jogoEscolhidoLabel.Name = "jogoEscolhidoLabel";
            jogoEscolhidoLabel.Size = new System.Drawing.Size(82, 13);
            jogoEscolhidoLabel.TabIndex = 5;
            jogoEscolhidoLabel.Text = "Jogo Escolhido:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(64, 96);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.Location = new System.Drawing.Point(187, 96);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(76, 13);
            dataRetiradaLabel.TabIndex = 9;
            dataRetiradaLabel.Text = "Data Retirada:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.Location = new System.Drawing.Point(344, 96);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(88, 13);
            dataDevolucaoLabel.TabIndex = 11;
            dataDevolucaoLabel.Text = "Data Devolucao:";
            // 
            // oBSLabel
            // 
            oBSLabel.AutoSize = true;
            oBSLabel.Location = new System.Drawing.Point(525, 96);
            oBSLabel.Name = "oBSLabel";
            oBSLabel.Size = new System.Drawing.Size(32, 13);
            oBSLabel.TabIndex = 13;
            oBSLabel.Text = "OBS:";
            // 
            // jogosBDDataSet
            // 
            this.jogosBDDataSet.DataSetName = "JogosBDDataSet";
            this.jogosBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoTableBindingSource
            // 
            this.locacaoTableBindingSource.DataMember = "LocacaoTable";
            this.locacaoTableBindingSource.DataSource = this.jogosBDDataSet;
            // 
            // locacaoTableTableAdapter
            // 
            this.locacaoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableTableAdapter = null;
            this.tableAdapterManager.GameTableTableAdapter = null;
            this.tableAdapterManager.LocacaoTableTableAdapter = this.locacaoTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = AluGames.JogosBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locacaoTableBindingNavigator
            // 
            this.locacaoTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoTableBindingNavigator.BindingSource = this.locacaoTableBindingSource;
            this.locacaoTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.locacaoTableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.locacaoTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.locacaoTableBindingNavigatorSaveItem});
            this.locacaoTableBindingNavigator.Location = new System.Drawing.Point(63, 140);
            this.locacaoTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoTableBindingNavigator.Name = "locacaoTableBindingNavigator";
            this.locacaoTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoTableBindingNavigator.Size = new System.Drawing.Size(466, 25);
            this.locacaoTableBindingNavigator.TabIndex = 0;
            this.locacaoTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locacaoTableBindingNavigatorSaveItem
            // 
            this.locacaoTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoTableBindingNavigatorSaveItem.Image")));
            this.locacaoTableBindingNavigatorSaveItem.Name = "locacaoTableBindingNavigatorSaveItem";
            this.locacaoTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(94, 22);
            this.locacaoTableBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locacaoTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoTableBindingNavigatorSaveItem_Click);
            // 
            // iDlocacaoTextBox
            // 
            this.iDlocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoTableBindingSource, "IDlocacao", true));
            this.iDlocacaoTextBox.Location = new System.Drawing.Point(104, 43);
            this.iDlocacaoTextBox.Name = "iDlocacaoTextBox";
            this.iDlocacaoTextBox.ReadOnly = true;
            this.iDlocacaoTextBox.Size = new System.Drawing.Size(32, 20);
            this.iDlocacaoTextBox.TabIndex = 2;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoTableBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(104, 93);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(77, 20);
            this.valorTextBox.TabIndex = 8;
            this.valorTextBox.TextChanged += new System.EventHandler(this.valorTextBox_TextChanged);
            // 
            // dataRetiradaTextBox
            // 
            this.dataRetiradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoTableBindingSource, "DataRetirada", true));
            this.dataRetiradaTextBox.Location = new System.Drawing.Point(267, 93);
            this.dataRetiradaTextBox.Name = "dataRetiradaTextBox";
            this.dataRetiradaTextBox.Size = new System.Drawing.Size(71, 20);
            this.dataRetiradaTextBox.TabIndex = 10;
            // 
            // dataDevolucaoTextBox
            // 
            this.dataDevolucaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoTableBindingSource, "DataDevolucao", true));
            this.dataDevolucaoTextBox.Location = new System.Drawing.Point(438, 93);
            this.dataDevolucaoTextBox.Name = "dataDevolucaoTextBox";
            this.dataDevolucaoTextBox.Size = new System.Drawing.Size(81, 20);
            this.dataDevolucaoTextBox.TabIndex = 12;
            // 
            // oBSTextBox
            // 
            this.oBSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoTableBindingSource, "OBS", true));
            this.oBSTextBox.Location = new System.Drawing.Point(567, 93);
            this.oBSTextBox.Multiline = true;
            this.oBSTextBox.Name = "oBSTextBox";
            this.oBSTextBox.Size = new System.Drawing.Size(216, 74);
            this.oBSTextBox.TabIndex = 14;
            // 
            // locacaoTableDataGridView
            // 
            this.locacaoTableDataGridView.AutoGenerateColumns = false;
            this.locacaoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locacaoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.locacaoTableDataGridView.DataSource = this.locacaoTableBindingSource;
            this.locacaoTableDataGridView.Location = new System.Drawing.Point(20, 173);
            this.locacaoTableDataGridView.Name = "locacaoTableDataGridView";
            this.locacaoTableDataGridView.Size = new System.Drawing.Size(768, 224);
            this.locacaoTableDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDlocacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDlocacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JogoEscolhido";
            this.dataGridViewTextBoxColumn3.HeaderText = "JogoEscolhido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataRetirada";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataRetirada";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn6.HeaderText = "DataDevolucao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OBS";
            this.dataGridViewTextBoxColumn7.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Locação";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoTableBindingSource, "JogoEscolhido", true));
            this.comboBox1.DataSource = this.gameTableBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(495, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gameTableBindingSource
            // 
            this.gameTableBindingSource.DataMember = "GameTable";
            this.gameTableBindingSource.DataSource = this.jogosBDDataSet1BindingSource;
            // 
            // jogosBDDataSet1BindingSource
            // 
            this.jogosBDDataSet1BindingSource.DataSource = this.jogosBDDataSet1;
            this.jogosBDDataSet1BindingSource.Position = 0;
            // 
            // jogosBDDataSet1
            // 
            this.jogosBDDataSet1.DataSetName = "JogosBDDataSet";
            this.jogosBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableTableAdapter
            // 
            this.gameTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoTableBindingSource, "NomeCliente", true));
            this.comboBox2.DataSource = this.clientTableBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(297, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "Nome";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // clientTableBindingSource
            // 
            this.clientTableBindingSource.DataMember = "ClientTable";
            this.clientTableBindingSource.DataSource = this.jogosBDDataSet1BindingSource;
            // 
            // clientTableTableAdapter
            // 
            this.clientTableTableAdapter.ClearBeforeFill = true;
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locacaoTableDataGridView);
            this.Controls.Add(iDlocacaoLabel);
            this.Controls.Add(this.iDlocacaoTextBox);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(jogoEscolhidoLabel);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(dataRetiradaLabel);
            this.Controls.Add(this.dataRetiradaTextBox);
            this.Controls.Add(dataDevolucaoLabel);
            this.Controls.Add(this.dataDevolucaoTextBox);
            this.Controls.Add(oBSLabel);
            this.Controls.Add(this.oBSTextBox);
            this.Controls.Add(this.locacaoTableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alugar";
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.Alugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableBindingNavigator)).EndInit();
            this.locacaoTableBindingNavigator.ResumeLayout(false);
            this.locacaoTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JogosBDDataSet jogosBDDataSet;
        private System.Windows.Forms.BindingSource locacaoTableBindingSource;
        private JogosBDDataSetTableAdapters.LocacaoTableTableAdapter locacaoTableTableAdapter;
        private JogosBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton locacaoTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDlocacaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox dataRetiradaTextBox;
        private System.Windows.Forms.TextBox dataDevolucaoTextBox;
        private System.Windows.Forms.TextBox oBSTextBox;
        private System.Windows.Forms.DataGridView locacaoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource jogosBDDataSet1BindingSource;
        private JogosBDDataSet jogosBDDataSet1;
        private System.Windows.Forms.BindingSource gameTableBindingSource;
        private JogosBDDataSetTableAdapters.GameTableTableAdapter gameTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private JogosBDDataSetTableAdapters.ClientTableTableAdapter clientTableTableAdapter;
    }
}