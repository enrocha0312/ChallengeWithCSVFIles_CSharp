namespace Projeto_CEPEL
{
    partial class Form1
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.textValidar = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnRepetidos = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExibir.Location = new System.Drawing.Point(12, 31);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(122, 91);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir dados dos arquivos";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValidar.Location = new System.Drawing.Point(12, 151);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(122, 91);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Verificar se arquivo é válido";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // textValidar
            // 
            this.textValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValidar.Location = new System.Drawing.Point(151, 204);
            this.textValidar.Name = "textValidar";
            this.textValidar.Size = new System.Drawing.Size(308, 26);
            this.textValidar.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(140, 166);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(333, 24);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Digite o arquivo que deseja validar";
            // 
            // btnRepetidos
            // 
            this.btnRepetidos.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRepetidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepetidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRepetidos.Location = new System.Drawing.Point(479, 151);
            this.btnRepetidos.Name = "btnRepetidos";
            this.btnRepetidos.Size = new System.Drawing.Size(195, 91);
            this.btnRepetidos.TabIndex = 5;
            this.btnRepetidos.Text = "Varificar invalidez do arquivo por elementos repetidos";
            this.btnRepetidos.UseVisualStyleBackColor = false;
            this.btnRepetidos.Click += new System.EventHandler(this.btnRepetidos_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConectar.Location = new System.Drawing.Point(261, 31);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(122, 91);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar-se ao banco de dados";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnRepetidos);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textValidar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnExibir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox textValidar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnRepetidos;
        private System.Windows.Forms.Button btnConectar;
    }
}

