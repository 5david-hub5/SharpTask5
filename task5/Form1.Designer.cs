namespace task5
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.numShelvesTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(216, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(226, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // l
            // 
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 16;
            this.l.Location = new System.Drawing.Point(12, 46);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(430, 116);
            this.l.TabIndex = 3;
            this.l.SelectedIndexChanged += new System.EventHandler(this.furnitureListBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(12, 168);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(672, 284);
            this.propertyGrid.TabIndex = 4;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(468, 47);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(95, 22);
            this.heightTextBox.TabIndex = 5;
            // 
            // numShelvesTextBox
            // 
            this.numShelvesTextBox.Location = new System.Drawing.Point(468, 103);
            this.numShelvesTextBox.Name = "numShelvesTextBox";
            this.numShelvesTextBox.Size = new System.Drawing.Size(95, 22);
            this.numShelvesTextBox.TabIndex = 6;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(468, 131);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(95, 22);
            this.colorTextBox.TabIndex = 7;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(468, 75);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(95, 22);
            this.weightTextBox.TabIndex = 8;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(468, 159);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(95, 22);
            this.materialTextBox.TabIndex = 9;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(583, 48);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 20);
            this.height.TabIndex = 10;
            this.height.Text = "Высота";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(583, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(583, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Кол-во полок";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(583, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(583, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Материал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.numShelvesTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.l);
            this.Controls.Add(this.propertyGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox materialTextBox;

        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox numShelvesTextBox;
        private System.Windows.Forms.TextBox colorTextBox;

        // Кнопка для добавления нового объекта
        private System.Windows.Forms.Button addButton;

// Кнопка для удаления выбранного объекта
        private System.Windows.Forms.Button removeButton;

// Кнопка для изменения цвета выбранного объекта

// Место для отображения списка объектов
        private System.Windows.Forms.ListBox l;

// Место для отображения свойств выбранного объекта
        private System.Windows.Forms.PropertyGrid propertyGrid;

        #endregion
    }
}