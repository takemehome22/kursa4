namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бахаев_АвтомастерскаяDataSet = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSet();
            this.кассаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочникТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.страныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорииПоставщиковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видыОперацийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видыОперацийTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.ВидыОперацийTableAdapter();
            this.заказыTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.ЗаказыTableAdapter();
            this.кассаTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.КассаTableAdapter();
            this.категорииПоставщиковTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.КатегорииПоставщиковTableAdapter();
            this.покупателиTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.ПокупателиTableAdapter();
            this.поставщикиTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.ПоставщикиTableAdapter();
            this.складTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.СкладTableAdapter();
            this.справочникТоваровTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.СправочникТоваровTableAdapter();
            this.страныTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.СтраныTableAdapter();
            this.страныBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПоставщиковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыОперацийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // бахаев_АвтомастерскаяDataSet
            // 
            this.бахаев_АвтомастерскаяDataSet.DataSetName = "Бахаев_АвтомастерскаяDataSet";
            this.бахаев_АвтомастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кассаBindingSource
            // 
            this.кассаBindingSource.DataMember = "Касса";
            this.кассаBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // справочникТоваровBindingSource
            // 
            this.справочникТоваровBindingSource.DataMember = "СправочникТоваров";
            this.справочникТоваровBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // страныBindingSource
            // 
            this.страныBindingSource.DataMember = "Страны";
            this.страныBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // категорииПоставщиковBindingSource
            // 
            this.категорииПоставщиковBindingSource.DataMember = "КатегорииПоставщиков";
            this.категорииПоставщиковBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // видыОперацийBindingSource
            // 
            this.видыОперацийBindingSource.DataMember = "ВидыОпераций";
            this.видыОперацийBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // видыОперацийTableAdapter
            // 
            this.видыОперацийTableAdapter.ClearBeforeFill = true;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // кассаTableAdapter
            // 
            this.кассаTableAdapter.ClearBeforeFill = true;
            // 
            // категорииПоставщиковTableAdapter
            // 
            this.категорииПоставщиковTableAdapter.ClearBeforeFill = true;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // справочникТоваровTableAdapter
            // 
            this.справочникТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // страныTableAdapter
            // 
            this.страныTableAdapter.ClearBeforeFill = true;
            // 
            // страныBindingSource1
            // 
            this.страныBindingSource1.DataMember = "Страны";
            this.страныBindingSource1.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(122, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(122, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "👁";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "☓";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(348, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПоставщиковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыОперацийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Бахаев_АвтомастерскаяDataSet бахаев_АвтомастерскаяDataSet;
        private System.Windows.Forms.BindingSource видыОперацийBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.ВидыОперацийTableAdapter видыОперацийTableAdapter;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource кассаBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.КассаTableAdapter кассаTableAdapter;
        private System.Windows.Forms.BindingSource категорииПоставщиковBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.КатегорииПоставщиковTableAdapter категорииПоставщиковTableAdapter;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource складBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.BindingSource справочникТоваровBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.СправочникТоваровTableAdapter справочникТоваровTableAdapter;
        private System.Windows.Forms.BindingSource страныBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.СтраныTableAdapter страныTableAdapter;
        private System.Windows.Forms.BindingSource страныBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

