namespace Kurs
{
    partial class AddFOrm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmTB = new System.Windows.Forms.TextBox();
            this.GrTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.FumTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhTB = new System.Windows.Forms.TextBox();
            this.Add_Butt = new System.Windows.Forms.Button();
            this.ClButt = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmTB);
            this.groupBox2.Controls.Add(this.GrTB);
            this.groupBox2.Controls.Add(this.NameTB);
            this.groupBox2.Controls.Add(this.FumTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 282);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление";
            // 
            // EmTB
            // 
            this.EmTB.Location = new System.Drawing.Point(171, 213);
            this.EmTB.Name = "EmTB";
            this.EmTB.Size = new System.Drawing.Size(236, 26);
            this.EmTB.TabIndex = 7;
            // 
            // GrTB
            // 
            this.GrTB.Location = new System.Drawing.Point(171, 136);
            this.GrTB.Name = "GrTB";
            this.GrTB.Size = new System.Drawing.Size(236, 26);
            this.GrTB.TabIndex = 8;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(171, 91);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(236, 26);
            this.NameTB.TabIndex = 9;
            // 
            // FumTB
            // 
            this.FumTB.Location = new System.Drawing.Point(171, 44);
            this.FumTB.Name = "FumTB";
            this.FumTB.Size = new System.Drawing.Size(236, 26);
            this.FumTB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Эл.почта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Группа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Фамилия";
            // 
            // PhTB
            // 
            this.PhTB.Location = new System.Drawing.Point(183, 187);
            this.PhTB.Name = "PhTB";
            this.PhTB.Size = new System.Drawing.Size(236, 26);
            this.PhTB.TabIndex = 6;
            this.PhTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Add_Butt
            // 
            this.Add_Butt.Location = new System.Drawing.Point(45, 314);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(117, 53);
            this.Add_Butt.TabIndex = 7;
            this.Add_Butt.Text = "Добавить";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // ClButt
            // 
            this.ClButt.Location = new System.Drawing.Point(328, 314);
            this.ClButt.Name = "ClButt";
            this.ClButt.Size = new System.Drawing.Size(117, 53);
            this.ClButt.TabIndex = 8;
            this.ClButt.Text = "Закрыть";
            this.ClButt.UseVisualStyleBackColor = true;
            this.ClButt.Click += new System.EventHandler(this.ClButt_Click);
            // 
            // AddFOrm
            // 
            this.ClientSize = new System.Drawing.Size(589, 401);
            this.Controls.Add(this.ClButt);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.PhTB);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddFOrm";
            this.Load += new System.EventHandler(this.AddFOrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EmTB;
        private System.Windows.Forms.TextBox GrTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox FumTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhTB;
        private System.Windows.Forms.Button Add_Butt;
        private System.Windows.Forms.Button ClButt;
    }
}