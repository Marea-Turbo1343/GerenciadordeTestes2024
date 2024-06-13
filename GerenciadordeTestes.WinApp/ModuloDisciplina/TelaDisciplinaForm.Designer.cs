namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            txtNome = new TextBox();
            lblNome = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(72, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 13;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(72, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 12;
            lblId.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(280, 142);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 36);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(175, 142);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 36);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 190);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDisciplinaForm";
            ShowIcon = false;
            Text = "Cadastro de Disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtId;
        private Label lblId;
        private Button btnCancelar;
        private Button btnGravar;
    }
}