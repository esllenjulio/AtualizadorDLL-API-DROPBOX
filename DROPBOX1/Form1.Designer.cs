namespace DROPBOX1
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
            this.btnBaixar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prgContador = new System.Windows.Forms.ProgressBar();
            this.selectNewDir = new System.Windows.Forms.Button();
            this.txtValueDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalExtracted = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDirectoryExtratorsFiles = new System.Windows.Forms.TextBox();
            this.btnSelectFolderExtractAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileExtracted = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(359, 36);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(72, 23);
            this.btnBaixar.TabIndex = 1;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixarFile);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Descompactar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prgContador
            // 
            this.prgContador.Location = new System.Drawing.Point(6, 137);
            this.prgContador.Name = "prgContador";
            this.prgContador.Size = new System.Drawing.Size(431, 11);
            this.prgContador.TabIndex = 3;
            // 
            // selectNewDir
            // 
            this.selectNewDir.Location = new System.Drawing.Point(281, 36);
            this.selectNewDir.Name = "selectNewDir";
            this.selectNewDir.Size = new System.Drawing.Size(70, 23);
            this.selectNewDir.TabIndex = 7;
            this.selectNewDir.Text = "Pasta";
            this.selectNewDir.UseVisualStyleBackColor = true;
            this.selectNewDir.Click += new System.EventHandler(this.selectNewDirectory);
            // 
            // txtValueDirectory
            // 
            this.txtValueDirectory.Location = new System.Drawing.Point(9, 39);
            this.txtValueDirectory.Name = "txtValueDirectory";
            this.txtValueDirectory.Size = new System.Drawing.Size(261, 20);
            this.txtValueDirectory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pasta destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Atualizador Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 82);
            this.listBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total:";
            // 
            // lblTotalExtracted
            // 
            this.lblTotalExtracted.AutoSize = true;
            this.lblTotalExtracted.Location = new System.Drawing.Point(42, 243);
            this.lblTotalExtracted.Name = "lblTotalExtracted";
            this.lblTotalExtracted.Size = new System.Drawing.Size(13, 13);
            this.lblTotalExtracted.TabIndex = 19;
            this.lblTotalExtracted.Text = "0";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(86, 23);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(345, 10);
            this.progressBar2.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.txtValueDirectory);
            this.groupBox2.Controls.Add(this.btnBaixar);
            this.groupBox2.Controls.Add(this.selectNewDir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 68);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baixar Arquivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDirectoryExtratorsFiles);
            this.groupBox3.Controls.Add(this.btnSelectFolderExtractAll);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFileExtracted);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblTotalExtracted);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.prgContador);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 260);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extrair Arquivos:";
            // 
            // txtDirectoryExtratorsFiles
            // 
            this.txtDirectoryExtratorsFiles.Location = new System.Drawing.Point(6, 75);
            this.txtDirectoryExtratorsFiles.Name = "txtDirectoryExtratorsFiles";
            this.txtDirectoryExtratorsFiles.Size = new System.Drawing.Size(345, 20);
            this.txtDirectoryExtratorsFiles.TabIndex = 22;
            // 
            // btnSelectFolderExtractAll
            // 
            this.btnSelectFolderExtractAll.Location = new System.Drawing.Point(361, 72);
            this.btnSelectFolderExtractAll.Name = "btnSelectFolderExtractAll";
            this.btnSelectFolderExtractAll.Size = new System.Drawing.Size(70, 23);
            this.btnSelectFolderExtractAll.TabIndex = 21;
            this.btnSelectFolderExtractAll.Text = "Pasta";
            this.btnSelectFolderExtractAll.UseVisualStyleBackColor = true;
            this.btnSelectFolderExtractAll.Click += new System.EventHandler(this.btnSelectFolderExtractAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Extrair arquivos para:";
            // 
            // txtFileExtracted
            // 
            this.txtFileExtracted.Location = new System.Drawing.Point(6, 36);
            this.txtFileExtracted.Name = "txtFileExtracted";
            this.txtFileExtracted.Size = new System.Drawing.Size(345, 20);
            this.txtFileExtracted.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Selecionar Arquivo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(465, 445);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar prgContador;
        private System.Windows.Forms.Button selectNewDir;
        private System.Windows.Forms.TextBox txtValueDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalExtracted;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFileExtracted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox txtDirectoryExtratorsFiles;
        private System.Windows.Forms.Button btnSelectFolderExtractAll;
        private System.Windows.Forms.Label label4;
    }
}

