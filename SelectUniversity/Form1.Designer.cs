namespace SelectUniversity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectCityBox = new ComboBox();
            UniversitiesTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nm = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name_label = new Label();
            city_label = new Label();
            label4 = new Label();
            photobox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UniversitiesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photobox).BeginInit();
            SuspendLayout();
            // 
            // SelectCityBox
            // 
            SelectCityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectCityBox.FormattingEnabled = true;
            SelectCityBox.Location = new Point(22, 12);
            SelectCityBox.Name = "SelectCityBox";
            SelectCityBox.Size = new Size(121, 23);
            SelectCityBox.TabIndex = 0;
            SelectCityBox.SelectedIndexChanged += SelectCityBox_SelectedIndexChanged;
            // 
            // UniversitiesTable
            // 
            UniversitiesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UniversitiesTable.Columns.AddRange(new DataGridViewColumn[] { ID, nm, City });
            UniversitiesTable.Location = new Point(111, 80);
            UniversitiesTable.Name = "UniversitiesTable";
            UniversitiesTable.Size = new Size(539, 321);
            UniversitiesTable.TabIndex = 1;
            UniversitiesTable.CellContentClick += UniversitiesTable_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // nm
            // 
            nm.HeaderText = "Название";
            nm.Name = "nm";
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.Name = "City";
            City.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(839, 12);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 2;
            label1.Text = "Университет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(770, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(770, 189);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Город";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.BackColor = Color.White;
            name_label.BorderStyle = BorderStyle.FixedSingle;
            name_label.Location = new Point(839, 108);
            name_label.Name = "name_label";
            name_label.Size = new Size(72, 17);
            name_label.TabIndex = 5;
            name_label.Text = "                     ";
            // 
            // city_label
            // 
            city_label.AutoSize = true;
            city_label.BackColor = Color.White;
            city_label.BorderStyle = BorderStyle.FixedSingle;
            city_label.Location = new Point(839, 189);
            city_label.Name = "city_label";
            city_label.Size = new Size(72, 17);
            city_label.TabIndex = 6;
            city_label.Text = "                     ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(770, 279);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Фото";
            // 
            // photobox
            // 
            photobox.Location = new Point(824, 279);
            photobox.Name = "photobox";
            photobox.Size = new Size(517, 347);
            photobox.TabIndex = 8;
            photobox.TabStop = false;
            photobox.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 638);
            Controls.Add(photobox);
            Controls.Add(label4);
            Controls.Add(city_label);
            Controls.Add(name_label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UniversitiesTable);
            Controls.Add(SelectCityBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)UniversitiesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)photobox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SelectCityBox;
        private DataGridView UniversitiesTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nm;
        private DataGridViewTextBoxColumn City;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label name_label;
        private Label city_label;
        private Label label4;
        private PictureBox photobox;
    }
}
