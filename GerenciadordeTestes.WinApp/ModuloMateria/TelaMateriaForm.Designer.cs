namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblDisciplina = new Label();
            cmbDisciplinas = new ComboBox();
            lblSerie = new Label();
            rdbPrimeira = new RadioButton();
            rdbSegunda = new RadioButton();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(286, 166);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 36);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(181, 166);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 36);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 19;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(29, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 17;
            lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(78, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 20;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(52, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 18;
            lblId.Text = "Id:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(11, 85);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(61, 15);
            lblDisciplina.TabIndex = 17;
            lblDisciplina.Text = "Disciplina:";
            // 
            // cmbDisciplinas
            // 
            cmbDisciplinas.FormattingEnabled = true;
            cmbDisciplinas.Location = new Point(78, 82);
            cmbDisciplinas.Name = "cmbDisciplinas";
            cmbDisciplinas.Size = new Size(121, 23);
            cmbDisciplinas.TabIndex = 23;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(37, 111);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(35, 15);
            lblSerie.TabIndex = 17;
            lblSerie.Text = "Série:";
            // 
            // rdbPrimeira
            // 
            rdbPrimeira.AutoSize = true;
            rdbPrimeira.Checked = true;
            rdbPrimeira.Location = new Point(78, 111);
            rdbPrimeira.Name = "rdbPrimeira";
            rdbPrimeira.Size = new Size(36, 19);
            rdbPrimeira.TabIndex = 24;
            rdbPrimeira.TabStop = true;
            rdbPrimeira.Text = "1ª";
            rdbPrimeira.UseVisualStyleBackColor = true;
            rdbPrimeira.CheckedChanged += rdbPrimeira_CheckedChanged;
            // 
            // rdbSegunda
            // 
            rdbSegunda.AutoSize = true;
            rdbSegunda.Location = new Point(120, 111);
            rdbSegunda.Name = "rdbSegunda";
            rdbSegunda.Size = new Size(36, 19);
            rdbSegunda.TabIndex = 24;
            rdbSegunda.Text = "2ª";
            rdbSegunda.UseVisualStyleBackColor = true;
            rdbSegunda.CheckedChanged += rdbSegunda_CheckedChanged;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 214);
            Controls.Add(rdbSegunda);
            Controls.Add(rdbPrimeira);
            Controls.Add(cmbDisciplinas);
            Controls.Add(btnCancelar);
            Controls.Add(lblSerie);
            Controls.Add(btnGravar);
            Controls.Add(lblDisciplina);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Matérias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtId;
        private Label lblId;
        private Label lblDisciplina;
        private ComboBox cmbDisciplinas;
        private Label lblSerie;
        private RadioButton rdbPrimeira;
        private RadioButton rdbSegunda;
    }
}