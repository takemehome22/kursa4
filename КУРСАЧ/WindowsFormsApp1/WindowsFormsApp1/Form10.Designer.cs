namespace WindowsFormsApp1
{
    partial class Form10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.справочникТоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бахаев_АвтомастерскаяDataSet = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSet();
            this.справочникТоваровTableAdapter = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSetTableAdapters.СправочникТоваровTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.бахаев_АвтомастерскаяDataSet1 = new WindowsFormsApp1.Бахаев_АвтомастерскаяDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.объемDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.справочникТоваровBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеТовара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "НаименованиеТовара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            // 
            // объемDataGridViewTextBoxColumn
            // 
            this.объемDataGridViewTextBoxColumn.DataPropertyName = "Объем";
            this.объемDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.объемDataGridViewTextBoxColumn.Name = "объемDataGridViewTextBoxColumn";
            // 
            // справочникТоваровBindingSource
            // 
            this.справочникТоваровBindingSource.DataMember = "СправочникТоваров";
            this.справочникТоваровBindingSource.DataSource = this.бахаев_АвтомастерскаяDataSet;
            // 
            // бахаев_АвтомастерскаяDataSet
            // 
            this.бахаев_АвтомастерскаяDataSet.DataSetName = "Бахаев_АвтомастерскаяDataSet";
            this.бахаев_АвтомастерскаяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочникТоваровTableAdapter
            // 
            this.справочникТоваровTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(752, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(752, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(752, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(687, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 43);
            this.button5.TabIndex = 17;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(687, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label1.Location = new System.Drawing.Point(615, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите данные в строку для поиска по товарам";
            // 
            // бахаев_АвтомастерскаяDataSet1
            // 
            this.бахаев_АвтомастерскаяDataSet1.DataSetName = "Бахаев_АвтомастерскаяDataSet";
            this.бахаев_АвтомастерскаяDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вакуумный усилитель тормозов",
            "Втулка стабилизатора СПУ",
            "Датчик расхода воздуха",
            "Датчик давления масла",
            "Клапан электромагнитный L8011",
            "Датчик положения коленвала",
            "Датчик положения дроссельной заслонки",
            "Реле поворотников",
            "Датчик скорости вращения",
            "Колодки тормозные",
            "Фильтр воздушный",
            "Свеча зажигания",
            "Патрубок радиатора",
            "Усилитель бампера",
            "Ремень ГРМ",
            "Сайлентблок задней балки",
            "Планка задней двери",
            "Пружины подвески передние",
            "Пружины подвески задние"});
            this.comboBox1.Location = new System.Drawing.Point(27, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label2.Location = new System.Drawing.Point(24, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Наименование товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Код товара";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(27, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.Location = new System.Drawing.Point(27, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label4.Location = new System.Drawing.Point(24, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Вес";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox4.Location = new System.Drawing.Point(27, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Обьем";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(750, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 43);
            this.button6.TabIndex = 26;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(13, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 49);
            this.button7.TabIndex = 27;
            this.button7.Text = "🡸";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник товаров";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бахаев_АвтомастерскаяDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Бахаев_АвтомастерскаяDataSet бахаев_АвтомастерскаяDataSet;
        private System.Windows.Forms.BindingSource справочникТоваровBindingSource;
        private Бахаев_АвтомастерскаяDataSetTableAdapters.СправочникТоваровTableAdapter справочникТоваровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Бахаев_АвтомастерскаяDataSet бахаев_АвтомастерскаяDataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}