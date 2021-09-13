
namespace AluGames
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_menu_jogos = new System.Windows.Forms.Button();
            this.btn_menu_locacao = new System.Windows.Forms.Button();
            this.btn_menu_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu_jogos
            // 
            this.btn_menu_jogos.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu_jogos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_menu_jogos.FlatAppearance.BorderSize = 0;
            this.btn_menu_jogos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_menu_jogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_menu_jogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_jogos.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_jogos.Image")));
            this.btn_menu_jogos.Location = new System.Drawing.Point(105, 135);
            this.btn_menu_jogos.Name = "btn_menu_jogos";
            this.btn_menu_jogos.Size = new System.Drawing.Size(81, 43);
            this.btn_menu_jogos.TabIndex = 0;
            this.btn_menu_jogos.UseVisualStyleBackColor = false;
            this.btn_menu_jogos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_menu_locacao
            // 
            this.btn_menu_locacao.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu_locacao.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_menu_locacao.FlatAppearance.BorderSize = 0;
            this.btn_menu_locacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_menu_locacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_menu_locacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_locacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_locacao.Image")));
            this.btn_menu_locacao.Location = new System.Drawing.Point(189, 135);
            this.btn_menu_locacao.Name = "btn_menu_locacao";
            this.btn_menu_locacao.Size = new System.Drawing.Size(81, 43);
            this.btn_menu_locacao.TabIndex = 1;
            this.btn_menu_locacao.UseVisualStyleBackColor = false;
            this.btn_menu_locacao.Click += new System.EventHandler(this.btn_menu_locacao_Click);
            // 
            // btn_menu_cliente
            // 
            this.btn_menu_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu_cliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_menu_cliente.FlatAppearance.BorderSize = 0;
            this.btn_menu_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_menu_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_menu_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_cliente.Image")));
            this.btn_menu_cliente.Location = new System.Drawing.Point(271, 135);
            this.btn_menu_cliente.Name = "btn_menu_cliente";
            this.btn_menu_cliente.Size = new System.Drawing.Size(81, 43);
            this.btn_menu_cliente.TabIndex = 2;
            this.btn_menu_cliente.UseVisualStyleBackColor = false;
            this.btn_menu_cliente.Click += new System.EventHandler(this.btn_menu_cliente_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(468, 324);
            this.Controls.Add(this.btn_menu_cliente);
            this.Controls.Add(this.btn_menu_locacao);
            this.Controls.Add(this.btn_menu_jogos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 363);
            this.MinimumSize = new System.Drawing.Size(484, 363);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AluGames";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_jogos;
        private System.Windows.Forms.Button btn_menu_locacao;
        private System.Windows.Forms.Button btn_menu_cliente;
    }
}

