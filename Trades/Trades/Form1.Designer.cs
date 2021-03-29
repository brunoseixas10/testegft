
namespace Trades
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Setor:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(75, 48);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(121, 23);
            this.cmbSetor.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(23, 93);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(201, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar na lista de trades";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(23, 136);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(201, 23);
            this.btnListarCategorias.TabIndex = 5;
            this.btnListarCategorias.Text = "Listar Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(75, 10);
            this.txtValor.Mask = "999,999,999.00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 23);
            this.txtValor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 191);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 230);
            this.MinimumSize = new System.Drawing.Size(410, 230);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnListarCategorias;
        private System.Windows.Forms.MaskedTextBox txtValor;
    }
}

