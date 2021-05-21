namespace Bridge1
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
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.cbClothes = new System.Windows.Forms.ComboBox();
            this.startb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labFabric = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.labR = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.labK = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.restartb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbColour
            // 
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Items.AddRange(new object[] {
            "Белый",
            "Черный",
            "Красный",
            "Зеленый"});
            this.cbColour.Location = new System.Drawing.Point(66, 76);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(121, 24);
            this.cbColour.TabIndex = 0;
            this.cbColour.Text = "Белый";
            // 
            // cbClothes
            // 
            this.cbClothes.FormattingEnabled = true;
            this.cbClothes.Items.AddRange(new object[] {
            "Футболка",
            "Брюки",
            "Платье"});
            this.cbClothes.Location = new System.Drawing.Point(66, 123);
            this.cbClothes.Name = "cbClothes";
            this.cbClothes.Size = new System.Drawing.Size(121, 24);
            this.cbClothes.TabIndex = 1;
            this.cbClothes.Text = "Футболка";
            // 
            // startb
            // 
            this.startb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startb.Location = new System.Drawing.Point(43, 214);
            this.startb.Name = "startb";
            this.startb.Size = new System.Drawing.Size(130, 61);
            this.startb.TabIndex = 2;
            this.startb.Text = "В производство";
            this.startb.UseVisualStyleBackColor = false;
            this.startb.Click += new System.EventHandler(this.startb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вещь";
            // 
            // labFabric
            // 
            this.labFabric.AutoSize = true;
            this.labFabric.Location = new System.Drawing.Point(230, 57);
            this.labFabric.Name = "labFabric";
            this.labFabric.Size = new System.Drawing.Size(128, 17);
            this.labFabric.TabIndex = 5;
            this.labFabric.Text = "Ткань (кв.м): 1000";
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Location = new System.Drawing.Point(230, 100);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(172, 17);
            this.labB.TabIndex = 6;
            this.labB.Text = "Синий краситель (г): 100";
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.Location = new System.Drawing.Point(230, 78);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(189, 17);
            this.labR.TabIndex = 7;
            this.labR.Text = "Красный краситель (г): 100";
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.Location = new System.Drawing.Point(230, 121);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(185, 17);
            this.labY.TabIndex = 8;
            this.labY.Text = "Желтый краситель (г): 100";
            // 
            // labK
            // 
            this.labK.AutoSize = true;
            this.labK.Location = new System.Drawing.Point(230, 143);
            this.labK.Name = "labK";
            this.labK.Size = new System.Drawing.Size(183, 17);
            this.labK.TabIndex = 9;
            this.labK.Text = "Черный краситель (г): 100";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(109, 168);
            this.nudAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(78, 22);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bridge1.Properties.Resources.file_20190607_52780_sqgpem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-17, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 519);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(233, 167);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(427, 114);
            this.logBox.TabIndex = 13;
            // 
            // restartb
            // 
            this.restartb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.restartb.Location = new System.Drawing.Point(461, 79);
            this.restartb.Name = "restartb";
            this.restartb.Size = new System.Drawing.Size(130, 61);
            this.restartb.TabIndex = 14;
            this.restartb.Text = "Обновить сырье";
            this.restartb.UseVisualStyleBackColor = false;
            this.restartb.Click += new System.EventHandler(this.restartb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(229, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Швейное производство";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restartb);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.labK);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labR);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labFabric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startb);
            this.Controls.Add(this.cbClothes);
            this.Controls.Add(this.cbColour);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.ComboBox cbClothes;
        private System.Windows.Forms.Button startb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labFabric;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label labR;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Label labK;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button restartb;
        private System.Windows.Forms.Label label4;
    }
}

