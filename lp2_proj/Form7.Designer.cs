﻿namespace lp2_proj
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.profCadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fITFREEDBDataSet4 = new lp2_proj.FITFREEDBDataSet4();
            this.profCadastrosTableAdapter = new lp2_proj.FITFREEDBDataSet4TableAdapters.ProfCadastrosTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PROFnasc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PROFtel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PROFcpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PROFend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PROFnome = new System.Windows.Forms.TextBox();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profCadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITFREEDBDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 310);
            this.dataGridView1.TabIndex = 27;
            // 
            // profCadastrosBindingSource
            // 
            this.profCadastrosBindingSource.DataMember = "ProfCadastros";
            this.profCadastrosBindingSource.DataSource = this.fITFREEDBDataSet4;
            // 
            // fITFREEDBDataSet4
            // 
            this.fITFREEDBDataSet4.DataSetName = "FITFREEDBDataSet4";
            this.fITFREEDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profCadastrosTableAdapter
            // 
            this.profCadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(35, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(512, 42);
            this.label10.TabIndex = 31;
            this.label10.Text = "PROFESSORES CADASTRADOS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::lp2_proj.Properties.Resources.ab633fd0aa1fad4bc88a908c61003ea1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PROFnasc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PROFtel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PROFcpf);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PROFend);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PROFnome);
            this.panel1.Location = new System.Drawing.Point(572, -190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 802);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 49);
            this.label1.TabIndex = 63;
            this.label1.Text = "ATUALIZAR CADASTRO";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::lp2_proj.Properties.Resources.butt2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(301, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 58;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(102, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 56;
            this.button1.Text = "Salvar Alterações";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome Completo:";
            // 
            // PROFnasc
            // 
            this.PROFnasc.BackColor = System.Drawing.SystemColors.Window;
            this.PROFnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnasc.Location = new System.Drawing.Point(219, 504);
            this.PROFnasc.Mask = "00/00/0000";
            this.PROFnasc.Name = "PROFnasc";
            this.PROFnasc.Size = new System.Drawing.Size(71, 23);
            this.PROFnasc.TabIndex = 62;
            this.PROFnasc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(25, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Endereço:";
            // 
            // PROFtel
            // 
            this.PROFtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFtel.Location = new System.Drawing.Point(219, 458);
            this.PROFtel.Mask = "(99) 00000-0000";
            this.PROFtel.Name = "PROFtel";
            this.PROFtel.Size = new System.Drawing.Size(100, 23);
            this.PROFtel.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(25, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "CPF:";
            // 
            // PROFcpf
            // 
            this.PROFcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFcpf.Location = new System.Drawing.Point(219, 414);
            this.PROFcpf.Mask = "000000000-00";
            this.PROFcpf.Name = "PROFcpf";
            this.PROFcpf.Size = new System.Drawing.Size(100, 23);
            this.PROFcpf.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(25, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Telefone:";
            // 
            // PROFend
            // 
            this.PROFend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFend.Location = new System.Drawing.Point(219, 372);
            this.PROFend.Name = "PROFend";
            this.PROFend.Size = new System.Drawing.Size(300, 23);
            this.PROFend.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(25, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Data de Nascimento:";
            // 
            // PROFnome
            // 
            this.PROFnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PROFnome.Location = new System.Drawing.Point(219, 331);
            this.PROFnome.Name = "PROFnome";
            this.PROFnome.Size = new System.Drawing.Size(300, 23);
            this.PROFnome.TabIndex = 57;
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(203, 129);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(329, 20);
            this.TextSearch.TabIndex = 61;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(48, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Pesquisa por nome:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lp2_proj.Properties.Resources.pngtree_creative_synthesis_neon_gradient_image_41603;
            this.ClientSize = new System.Drawing.Size(1103, 598);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitFree";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profCadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fITFREEDBDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FITFREEDBDataSet4 fITFREEDBDataSet4;
        private System.Windows.Forms.BindingSource profCadastrosBindingSource;
        private FITFREEDBDataSet4TableAdapters.ProfCadastrosTableAdapter profCadastrosTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PROFnasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox PROFtel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PROFcpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PROFend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PROFnome;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Label label7;
    }
}