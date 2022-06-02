namespace Kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButt = new System.Windows.Forms.Button();
            this.FinddButt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gryppa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(394, 435);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(155, 46);
            this.AddButt.TabIndex = 1;
            this.AddButt.Text = "Добавить";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // FinddButt
            // 
            this.FinddButt.Location = new System.Drawing.Point(203, 435);
            this.FinddButt.Name = "FinddButt";
            this.FinddButt.Size = new System.Drawing.Size(155, 46);
            this.FinddButt.TabIndex = 4;
            this.FinddButt.Text = "Поиск";
            this.FinddButt.UseVisualStyleBackColor = true;
            this.FinddButt.Click += new System.EventHandler(this.FinddButt_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.surname,
            this.name,
            this.gryppa,
            this.phone,
            this.email});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1169, 395);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 76;
            // 
            // surname
            // 
            this.surname.Text = "surname";
            this.surname.Width = 220;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 168;
            // 
            // gryppa
            // 
            this.gryppa.Text = "gryppa";
            this.gryppa.Width = 156;
            // 
            // phone
            // 
            this.phone.Text = "phone";
            this.phone.Width = 199;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 285;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 435);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(155, 46);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Вывод";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1178, 544);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FinddButt);
            this.Controls.Add(this.AddButt);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }


        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button FinddButt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader gryppa;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Button OpenButton;
    }
}

