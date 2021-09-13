
namespace AluGames
{
    partial class Jogos
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label consoleLabel;
            System.Windows.Forms.Label classificação_IndicativaLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label observaçõesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogos));
            this.gameTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.gameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogosBDDataSet = new AluGames.JogosBDDataSet();
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
            this.gameTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.classificação_IndicativaTextBox = new System.Windows.Forms.TextBox();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.observaçõesTextBox = new System.Windows.Forms.TextBox();
            this.gameTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTableTableAdapter = new AluGames.JogosBDDataSetTableAdapters.GameTableTableAdapter();
            this.tableAdapterManager = new AluGames.JogosBDDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            consoleLabel = new System.Windows.Forms.Label();
            classificação_IndicativaLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            observaçõesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingNavigator)).BeginInit();
            this.gameTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(281, 43);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(35, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // consoleLabel
            // 
            consoleLabel.AutoSize = true;
            consoleLabel.Location = new System.Drawing.Point(330, 43);
            consoleLabel.Name = "consoleLabel";
            consoleLabel.Size = new System.Drawing.Size(48, 13);
            consoleLabel.TabIndex = 5;
            consoleLabel.Text = "Console:";
            // 
            // classificação_IndicativaLabel
            // 
            classificação_IndicativaLabel.AutoSize = true;
            classificação_IndicativaLabel.Location = new System.Drawing.Point(399, 43);
            classificação_IndicativaLabel.Name = "classificação_IndicativaLabel";
            classificação_IndicativaLabel.Size = new System.Drawing.Size(118, 13);
            classificação_IndicativaLabel.TabIndex = 7;
            classificação_IndicativaLabel.Text = "Classificação Indicativa";
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(35, 87);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel.TabIndex = 9;
            descriçãoLabel.Text = "Descrição:";
            // 
            // observaçõesLabel
            // 
            observaçõesLabel.AutoSize = true;
            observaçõesLabel.Location = new System.Drawing.Point(281, 87);
            observaçõesLabel.Name = "observaçõesLabel";
            observaçõesLabel.Size = new System.Drawing.Size(73, 13);
            observaçõesLabel.TabIndex = 11;
            observaçõesLabel.Text = "Observações:";
            // 
            // gameTableBindingNavigator
            // 
            this.gameTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gameTableBindingNavigator.BindingSource = this.gameTableBindingSource;
            this.gameTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gameTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gameTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.gameTableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.gameTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gameTableBindingNavigatorSaveItem});
            this.gameTableBindingNavigator.Location = new System.Drawing.Point(31, 174);
            this.gameTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gameTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gameTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gameTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gameTableBindingNavigator.Name = "gameTableBindingNavigator";
            this.gameTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gameTableBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.gameTableBindingNavigator.Size = new System.Drawing.Size(491, 25);
            this.gameTableBindingNavigator.TabIndex = 0;
            this.gameTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // gameTableBindingSource
            // 
            this.gameTableBindingSource.DataMember = "GameTable";
            this.gameTableBindingSource.DataSource = this.jogosBDDataSet;
            // 
            // jogosBDDataSet
            // 
            this.jogosBDDataSet.DataSetName = "JogosBDDataSet";
            this.jogosBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(75, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // gameTableBindingNavigatorSaveItem
            // 
            this.gameTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gameTableBindingNavigatorSaveItem.Image")));
            this.gameTableBindingNavigatorSaveItem.Name = "gameTableBindingNavigatorSaveItem";
            this.gameTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(94, 22);
            this.gameTableBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.gameTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.gameTableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(284, 59);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(36, 20);
            this.iDTextBox.TabIndex = 20;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(38, 59);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(233, 20);
            this.nomeTextBox.TabIndex = 4;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "Console", true));
            this.consoleTextBox.Location = new System.Drawing.Point(333, 59);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(60, 20);
            this.consoleTextBox.TabIndex = 6;
            // 
            // classificação_IndicativaTextBox
            // 
            this.classificação_IndicativaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "Classificação Indicativa", true));
            this.classificação_IndicativaTextBox.Location = new System.Drawing.Point(402, 59);
            this.classificação_IndicativaTextBox.Name = "classificação_IndicativaTextBox";
            this.classificação_IndicativaTextBox.Size = new System.Drawing.Size(115, 20);
            this.classificação_IndicativaTextBox.TabIndex = 8;
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "Descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(38, 103);
            this.descriçãoTextBox.Multiline = true;
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(233, 65);
            this.descriçãoTextBox.TabIndex = 10;
            // 
            // observaçõesTextBox
            // 
            this.observaçõesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameTableBindingSource, "Observações", true));
            this.observaçõesTextBox.Location = new System.Drawing.Point(284, 103);
            this.observaçõesTextBox.Multiline = true;
            this.observaçõesTextBox.Name = "observaçõesTextBox";
            this.observaçõesTextBox.Size = new System.Drawing.Size(233, 65);
            this.observaçõesTextBox.TabIndex = 12;
            this.observaçõesTextBox.TextChanged += new System.EventHandler(this.observaçõesTextBox_TextChanged);
            // 
            // gameTableDataGridView
            // 
            this.gameTableDataGridView.AutoGenerateColumns = false;
            this.gameTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gameTableDataGridView.DataSource = this.gameTableBindingSource;
            this.gameTableDataGridView.Location = new System.Drawing.Point(12, 206);
            this.gameTableDataGridView.Name = "gameTableDataGridView";
            this.gameTableDataGridView.Size = new System.Drawing.Size(535, 238);
            this.gameTableDataGridView.TabIndex = 13;
            this.gameTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameTableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Console";
            this.dataGridViewTextBoxColumn3.HeaderText = "Console";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Classificação Indicativa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Classificação Indicativa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observações";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastrar Jogo";
            // 
            // gameTableTableAdapter
            // 
            this.gameTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableTableAdapter = null;
            this.tableAdapterManager.GameTableTableAdapter = this.gameTableTableAdapter;
            this.tableAdapterManager.LocacaoTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AluGames.JogosBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameTableDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(consoleLabel);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(classificação_IndicativaLabel);
            this.Controls.Add(this.classificação_IndicativaTextBox);
            this.Controls.Add(descriçãoLabel);
            this.Controls.Add(this.descriçãoTextBox);
            this.Controls.Add(observaçõesLabel);
            this.Controls.Add(this.observaçõesTextBox);
            this.Controls.Add(this.gameTableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingNavigator)).EndInit();
            this.gameTableBindingNavigator.ResumeLayout(false);
            this.gameTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JogosBDDataSet jogosBDDataSet;
        private System.Windows.Forms.BindingSource gameTableBindingSource;
        private JogosBDDataSetTableAdapters.GameTableTableAdapter gameTableTableAdapter;
        private JogosBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gameTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gameTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.TextBox classificação_IndicativaTextBox;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.TextBox observaçõesTextBox;
        private System.Windows.Forms.DataGridView gameTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}