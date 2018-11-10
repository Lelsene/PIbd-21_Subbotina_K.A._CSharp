namespace Lab_02
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.pictureBoxPlace = new System.Windows.Forms.PictureBox();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetTank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(849, 482);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxParking.Controls.Add(this.pictureBoxPlace);
            this.groupBoxParking.Controls.Add(this.buttonPlace);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxParking.Controls.Add(this.labelPlace);
            this.groupBoxParking.Location = new System.Drawing.Point(849, 283);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(144, 196);
            this.groupBoxParking.TabIndex = 5;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать танк";
            // 
            // pictureBoxPlace
            // 
            this.pictureBoxPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlace.Location = new System.Drawing.Point(8, 81);
            this.pictureBoxPlace.Name = "pictureBoxPlace";
            this.pictureBoxPlace.Size = new System.Drawing.Size(124, 104);
            this.pictureBoxPlace.TabIndex = 3;
            this.pictureBoxPlace.TabStop = false;
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(34, 52);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(84, 23);
            this.buttonPlace.TabIndex = 2;
            this.buttonPlace.Text = "Забрать";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(79, 26);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(31, 29);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(900, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(45, 13);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "Уровни";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(857, 19);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(125, 108);
            this.listBoxLevels.TabIndex = 7;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonSetTank
            // 
            this.buttonSetTank.Location = new System.Drawing.Point(857, 184);
            this.buttonSetTank.Name = "buttonSetTank";
            this.buttonSetTank.Size = new System.Drawing.Size(125, 29);
            this.buttonSetTank.TabIndex = 8;
            this.buttonSetTank.Text = "Заказать танк";
            this.buttonSetTank.UseVisualStyleBackColor = true;
            this.buttonSetTank.Click += new System.EventHandler(this.buttonSetTank_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 481);
            this.Controls.Add(this.buttonSetTank);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Garage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxPlace;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetTank;
    }
}