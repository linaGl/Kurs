namespace Kurs
{
    partial class FiltrFormcs
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
            this.listFind = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gryppa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.idButt = new System.Windows.Forms.Button();
            this.famButt = new System.Windows.Forms.Button();
            this.nameButt = new System.Windows.Forms.Button();
            this.grButtF = new System.Windows.Forms.Button();
            this.phButtf = new System.Windows.Forms.Button();
            this.emButtF = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listFind
            // 
            this.listFind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.surname,
            this.name,
            this.gryppa,
            this.phone,
            this.email});
            this.listFind.GridLines = true;
            this.listFind.HideSelection = false;
            this.listFind.Location = new System.Drawing.Point(12, 12);
            this.listFind.Name = "listFind";
            this.listFind.Size = new System.Drawing.Size(915, 294);
            this.listFind.TabIndex = 0;
            this.listFind.UseCompatibleStateImageBehavior = false;
            this.listFind.View = System.Windows.Forms.View.Details;
            this.listFind.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 64;
            // 
            // surname
            // 
            this.surname.Text = "surname";
            this.surname.Width = 130;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 127;
            // 
            // gryppa
            // 
            this.gryppa.Text = "gryppa";
            this.gryppa.Width = 86;
            // 
            // phone
            // 
            this.phone.Text = "phone";
            this.phone.Width = 153;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 212;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск ";
            // 
            // idButt
            // 
            this.idButt.Location = new System.Drawing.Point(16, 397);
            this.idButt.Name = "idButt";
            this.idButt.Size = new System.Drawing.Size(95, 37);
            this.idButt.TabIndex = 4;
            this.idButt.Text = "Id";
            this.idButt.UseVisualStyleBackColor = true;
            this.idButt.Click += new System.EventHandler(this.idButt_Click);
            // 
            // famButt
            // 
            this.famButt.Location = new System.Drawing.Point(137, 397);
            this.famButt.Name = "famButt";
            this.famButt.Size = new System.Drawing.Size(102, 37);
            this.famButt.TabIndex = 5;
            this.famButt.Text = "Фамилия";
            this.famButt.UseVisualStyleBackColor = true;
            this.famButt.Click += new System.EventHandler(this.famButt_Click);
            // 
            // nameButt
            // 
            this.nameButt.Location = new System.Drawing.Point(264, 397);
            this.nameButt.Name = "nameButt";
            this.nameButt.Size = new System.Drawing.Size(103, 37);
            this.nameButt.TabIndex = 6;
            this.nameButt.Text = "Имя";
            this.nameButt.UseVisualStyleBackColor = true;
            this.nameButt.Click += new System.EventHandler(this.nameButt_Click);
            // 
            // grButtF
            // 
            this.grButtF.Location = new System.Drawing.Point(398, 397);
            this.grButtF.Name = "grButtF";
            this.grButtF.Size = new System.Drawing.Size(96, 37);
            this.grButtF.TabIndex = 7;
            this.grButtF.Text = "Группа";
            this.grButtF.UseVisualStyleBackColor = true;
            this.grButtF.Click += new System.EventHandler(this.grButtF_Click);
            // 
            // phButtf
            // 
            this.phButtf.Location = new System.Drawing.Point(524, 397);
            this.phButtf.Name = "phButtf";
            this.phButtf.Size = new System.Drawing.Size(132, 37);
            this.phButtf.TabIndex = 8;
            this.phButtf.Text = "Моб.Телефон";
            this.phButtf.UseVisualStyleBackColor = true;
            this.phButtf.Click += new System.EventHandler(this.phButtf_Click);
            // 
            // emButtF
            // 
            this.emButtF.Location = new System.Drawing.Point(688, 397);
            this.emButtF.Name = "emButtF";
            this.emButtF.Size = new System.Drawing.Size(132, 37);
            this.emButtF.TabIndex = 9;
            this.emButtF.Text = "Эл.почта";
            this.emButtF.UseVisualStyleBackColor = true;
            this.emButtF.Click += new System.EventHandler(this.emButtF_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 10;
            // 
            // FiltrFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.emButtF);
            this.Controls.Add(this.phButtf);
            this.Controls.Add(this.grButtF);
            this.Controls.Add(this.nameButt);
            this.Controls.Add(this.famButt);
            this.Controls.Add(this.idButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFind);
            this.Name = "FiltrFormcs";
            this.Text = "FiltrFormcs";
            this.Load += new System.EventHandler(this.FiltrFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listFind;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader gryppa;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Button idButt;
        private System.Windows.Forms.Button famButt;
        private System.Windows.Forms.Button nameButt;
        private System.Windows.Forms.Button grButtF;
        private System.Windows.Forms.Button phButtf;
        private System.Windows.Forms.Button emButtF;
        private System.Windows.Forms.TextBox textBox1;
    }
}