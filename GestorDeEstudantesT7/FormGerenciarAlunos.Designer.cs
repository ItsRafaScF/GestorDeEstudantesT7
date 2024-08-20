namespace GestorDeEstudantesT7
{
    partial class FormGerenciarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarAlunos));
            this.buttonBaixarFoto = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBuscarID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBuscarDado = new System.Windows.Forms.TextBox();
            this.buttonBuscarDado = new System.Windows.Forms.Button();
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.buttonRedefinir = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.labelTotaldeAlunos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBaixarFoto
            // 
            this.buttonBaixarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaixarFoto.Location = new System.Drawing.Point(218, 488);
            this.buttonBaixarFoto.Name = "buttonBaixarFoto";
            this.buttonBaixarFoto.Size = new System.Drawing.Size(78, 40);
            this.buttonBaixarFoto.TabIndex = 49;
            this.buttonBaixarFoto.Text = "Baixar Foto";
            this.buttonBaixarFoto.UseVisualStyleBackColor = true;
            this.buttonBaixarFoto.Click += new System.EventHandler(this.buttonBaixarFoto_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(198, 544);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(118, 40);
            this.buttonSalvar.TabIndex = 48;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncluir.Location = new System.Drawing.Point(74, 544);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(118, 40);
            this.buttonIncluir.TabIndex = 47;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(124, 57);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(97, 20);
            this.textBoxID.TabIndex = 45;
            // 
            // buttonBuscarID
            // 
            this.buttonBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarID.Location = new System.Drawing.Point(226, 48);
            this.buttonBuscarID.Name = "buttonBuscarID";
            this.buttonBuscarID.Size = new System.Drawing.Size(90, 35);
            this.buttonBuscarID.TabIndex = 44;
            this.buttonBuscarID.Text = "Buscar";
            this.buttonBuscarID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(116, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(113, 18);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(19, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Foto";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(138, 324);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(158, 158);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 42;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(124, 258);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(192, 48);
            this.textBoxEndereco.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Telefone";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(124, 232);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(192, 20);
            this.textBoxTelefone.TabIndex = 38;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(124, 145);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerNascimento.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(124, 115);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(192, 20);
            this.textBoxSobrenome.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(124, 89);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(192, 20);
            this.textBoxNome.TabIndex = 30;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(352, 544);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(405, 86);
            this.buttonAtualizar.TabIndex = 51;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaDeAlunos
            // 
            this.dataGridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeAlunos.Location = new System.Drawing.Point(352, 89);
            this.dataGridViewListaDeAlunos.Name = "dataGridViewListaDeAlunos";
            this.dataGridViewListaDeAlunos.Size = new System.Drawing.Size(776, 439);
            this.dataGridViewListaDeAlunos.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Inserir dado para busca:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxBuscarDado
            // 
            this.textBoxBuscarDado.Location = new System.Drawing.Point(763, 47);
            this.textBoxBuscarDado.Name = "textBoxBuscarDado";
            this.textBoxBuscarDado.Size = new System.Drawing.Size(87, 20);
            this.textBoxBuscarDado.TabIndex = 53;
            this.textBoxBuscarDado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscarDado
            // 
            this.buttonBuscarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDado.Location = new System.Drawing.Point(858, 38);
            this.buttonBuscarDado.Name = "buttonBuscarDado";
            this.buttonBuscarDado.Size = new System.Drawing.Size(90, 35);
            this.buttonBuscarDado.TabIndex = 52;
            this.buttonBuscarDado.Text = "Buscar";
            this.buttonBuscarDado.UseVisualStyleBackColor = true;
            this.buttonBuscarDado.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviarFoto.Location = new System.Drawing.Point(138, 488);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(78, 40);
            this.buttonEnviarFoto.TabIndex = 55;
            this.buttonEnviarFoto.Text = "Enviar Foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = true;
            this.buttonEnviarFoto.Click += new System.EventHandler(this.buttonEnviarFoto_Click);
            // 
            // buttonRedefinir
            // 
            this.buttonRedefinir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedefinir.Location = new System.Drawing.Point(74, 590);
            this.buttonRedefinir.Name = "buttonRedefinir";
            this.buttonRedefinir.Size = new System.Drawing.Size(118, 40);
            this.buttonRedefinir.TabIndex = 56;
            this.buttonRedefinir.Text = "Redefinir";
            this.buttonRedefinir.UseVisualStyleBackColor = true;
            this.buttonRedefinir.Click += new System.EventHandler(this.buttonRedefinir_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(198, 590);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(118, 40);
            this.buttonRemover.TabIndex = 57;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // labelTotaldeAlunos
            // 
            this.labelTotaldeAlunos.AutoSize = true;
            this.labelTotaldeAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaldeAlunos.Location = new System.Drawing.Point(882, 583);
            this.labelTotaldeAlunos.Name = "labelTotaldeAlunos";
            this.labelTotaldeAlunos.Size = new System.Drawing.Size(159, 17);
            this.labelTotaldeAlunos.TabIndex = 58;
            this.labelTotaldeAlunos.Text = "Total de Alunos: 999";
            // 
            // FormGerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 639);
            this.Controls.Add(this.labelTotaldeAlunos);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonRedefinir);
            this.Controls.Add(this.buttonEnviarFoto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxBuscarDado);
            this.Controls.Add(this.buttonBuscarDado);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridViewListaDeAlunos);
            this.Controls.Add(this.buttonBaixarFoto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonBuscarID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormGerenciarAlunos";
            this.Text = "SGA - Gerenciar Alunos";
            this.Load += new System.EventHandler(this.FormGerenciarAlunos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBaixarFoto;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBuscarID;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton radioButtonFeminino;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBoxTelefone;
        internal System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridViewListaDeAlunos;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox textBoxBuscarDado;
        private System.Windows.Forms.Button buttonBuscarDado;
        private System.Windows.Forms.Button buttonEnviarFoto;
        private System.Windows.Forms.Button buttonRedefinir;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label labelTotaldeAlunos;
    }
}