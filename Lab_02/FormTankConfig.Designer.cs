namespace Lab_02
{
    partial class FormTankConfig
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHeavyTank = new System.Windows.Forms.Label();
            this.labelLightTank = new System.Windows.Forms.Label();
            this.panelTank = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTank.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(27, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 98);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTank_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTank_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHeavyTank);
            this.groupBox1.Controls.Add(this.labelLightTank);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип транспорта";
            // 
            // labelHeavyTank
            // 
            this.labelHeavyTank.AllowDrop = true;
            this.labelHeavyTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeavyTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeavyTank.Location = new System.Drawing.Point(19, 82);
            this.labelHeavyTank.Name = "labelHeavyTank";
            this.labelHeavyTank.Size = new System.Drawing.Size(154, 36);
            this.labelHeavyTank.TabIndex = 1;
            this.labelHeavyTank.Text = "Танк";
            this.labelHeavyTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeavyTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHeavyTank_MouseDown);
            // 
            // labelLightTank
            // 
            this.labelLightTank.AllowDrop = true;
            this.labelLightTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLightTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLightTank.Location = new System.Drawing.Point(19, 30);
            this.labelLightTank.Name = "labelLightTank";
            this.labelLightTank.Size = new System.Drawing.Size(154, 41);
            this.labelLightTank.TabIndex = 0;
            this.labelLightTank.Text = "Бронированная машина";
            this.labelLightTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLightTank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLightTank_MouseDown);
            // 
            // panelTank
            // 
            this.panelTank.AllowDrop = true;
            this.panelTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTank.Controls.Add(this.labelDopColor);
            this.panelTank.Controls.Add(this.labelBaseColor);
            this.panelTank.Controls.Add(this.pictureBox);
            this.panelTank.Location = new System.Drawing.Point(235, 12);
            this.panelTank.Name = "panelTank";
            this.panelTank.Size = new System.Drawing.Size(183, 208);
            this.panelTank.TabIndex = 2;
            this.panelTank.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTank_DragDrop);
            this.panelTank.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTank_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(12, 170);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(158, 23);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(12, 136);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(158, 23);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGold);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(445, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(109, 208);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.Location = new System.Drawing.Point(62, 146);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(37, 36);
            this.panelGold.TabIndex = 4;
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(9, 146);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(37, 36);
            this.panelGray.TabIndex = 4;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(62, 104);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(37, 36);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(9, 104);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(37, 36);
            this.panelRed.TabIndex = 4;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Purple;
            this.panelBlue.Location = new System.Drawing.Point(62, 62);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(37, 36);
            this.panelBlue.TabIndex = 3;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(9, 62);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(37, 36);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(62, 20);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(37, 36);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(9, 20);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(37, 36);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(31, 158);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(85, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(100, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 236);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTank);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTankConfig";
            this.Text = "Выбор транспорта";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTank.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHeavyTank;
        private System.Windows.Forms.Label labelLightTank;
        private System.Windows.Forms.Panel panelTank;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}