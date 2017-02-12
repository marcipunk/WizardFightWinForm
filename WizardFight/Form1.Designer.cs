namespace WizardFight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.gwNeve = new System.Windows.Forms.Label();
            this.gwlabel = new System.Windows.Forms.Label();
            this.ewlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gwLifeLabel = new System.Windows.Forms.Label();
            this.ewLifeLabel = new System.Windows.Forms.Label();
            this.gwLife = new System.Windows.Forms.Label();
            this.ewLife = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.beer = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fightBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.beer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fussatok bolondok!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gwNeve
            // 
            this.gwNeve.AutoSize = true;
            this.gwNeve.Location = new System.Drawing.Point(12, 374);
            this.gwNeve.Name = "gwNeve";
            this.gwNeve.Size = new System.Drawing.Size(36, 13);
            this.gwNeve.TabIndex = 5;
            this.gwNeve.Text = "Neve:";
            // 
            // gwlabel
            // 
            this.gwlabel.AutoSize = true;
            this.gwlabel.Location = new System.Drawing.Point(49, 374);
            this.gwlabel.Name = "gwlabel";
            this.gwlabel.Size = new System.Drawing.Size(0, 13);
            this.gwlabel.TabIndex = 6;
            // 
            // ewlabel
            // 
            this.ewlabel.AutoSize = true;
            this.ewlabel.Location = new System.Drawing.Point(345, 374);
            this.ewlabel.Name = "ewlabel";
            this.ewlabel.Size = new System.Drawing.Size(0, 13);
            this.ewlabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Neve:";
            // 
            // gwLifeLabel
            // 
            this.gwLifeLabel.AutoSize = true;
            this.gwLifeLabel.Location = new System.Drawing.Point(12, 391);
            this.gwLifeLabel.Name = "gwLifeLabel";
            this.gwLifeLabel.Size = new System.Drawing.Size(28, 13);
            this.gwLifeLabel.TabIndex = 9;
            this.gwLifeLabel.Text = "Élet:";
            // 
            // ewLifeLabel
            // 
            this.ewLifeLabel.AutoSize = true;
            this.ewLifeLabel.Location = new System.Drawing.Point(309, 391);
            this.ewLifeLabel.Name = "ewLifeLabel";
            this.ewLifeLabel.Size = new System.Drawing.Size(28, 13);
            this.ewLifeLabel.TabIndex = 10;
            this.ewLifeLabel.Text = "Élet:";
            // 
            // gwLife
            // 
            this.gwLife.AutoSize = true;
            this.gwLife.Location = new System.Drawing.Point(49, 391);
            this.gwLife.Name = "gwLife";
            this.gwLife.Size = new System.Drawing.Size(0, 13);
            this.gwLife.TabIndex = 11;
            // 
            // ewLife
            // 
            this.ewLife.AutoSize = true;
            this.ewLife.Location = new System.Drawing.Point(345, 391);
            this.ewLife.Name = "ewLife";
            this.ewLife.Size = new System.Drawing.Size(0, 13);
            this.ewLife.TabIndex = 12;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.winnerLabel.Location = new System.Drawing.Point(12, 456);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 16);
            this.winnerLabel.TabIndex = 13;
            // 
            // beer
            // 
            this.beer.BackColor = System.Drawing.Color.Transparent;
            this.beer.ErrorImage = global::WizardFight.Properties.Resources.beer;
            this.beer.Image = global::WizardFight.Properties.Resources.beer;
            this.beer.InitialImage = global::WizardFight.Properties.Resources.beer;
            this.beer.Location = new System.Drawing.Point(115, 315);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(53, 50);
            this.beer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beer.TabIndex = 14;
            this.beer.TabStop = false;
            this.beer.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WizardFight.Properties.Resources.ewizard_cr;
            this.pictureBox3.Location = new System.Drawing.Point(312, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WizardFight.Properties.Resources.gandalf;
            this.pictureBox2.Location = new System.Drawing.Point(12, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WizardFight.Properties.Resources.head;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fightBox
            // 
            this.fightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fightBox.Location = new System.Drawing.Point(472, 12);
            this.fightBox.Multiline = true;
            this.fightBox.Name = "fightBox";
            this.fightBox.ReadOnly = true;
            this.fightBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fightBox.Size = new System.Drawing.Size(327, 454);
            this.fightBox.TabIndex = 15;
            this.fightBox.TextChanged += new System.EventHandler(this.fightBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fightBox);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.ewLife);
            this.Controls.Add(this.gwLife);
            this.Controls.Add(this.ewLifeLabel);
            this.Controls.Add(this.gwLifeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ewlabel);
            this.Controls.Add(this.gwlabel);
            this.Controls.Add(this.gwNeve);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WizardFight";
            ((System.ComponentModel.ISupportInitialize)(this.beer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label gwNeve;
        private System.Windows.Forms.Label gwlabel;
        private System.Windows.Forms.Label ewlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gwLifeLabel;
        private System.Windows.Forms.Label ewLifeLabel;
        private System.Windows.Forms.Label gwLife;
        private System.Windows.Forms.Label ewLife;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.PictureBox beer;
        private System.Windows.Forms.TextBox fightBox;
    }
}