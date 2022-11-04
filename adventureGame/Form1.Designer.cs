namespace adventureGame
{
    partial class form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.optionLabel1 = new System.Windows.Forms.Label();
            this.optionLabel2 = new System.Windows.Forms.Label();
            this.optionLabel3 = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(11, 20);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(558, 122);
            this.outputLabel.TabIndex = 0;
            // 
            // optionLabel1
            // 
            this.optionLabel1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel1.Location = new System.Drawing.Point(214, 315);
            this.optionLabel1.Name = "optionLabel1";
            this.optionLabel1.Size = new System.Drawing.Size(355, 21);
            this.optionLabel1.TabIndex = 1;
            this.optionLabel1.Text = "outputLabel";
            // 
            // optionLabel2
            // 
            this.optionLabel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel2.Location = new System.Drawing.Point(214, 365);
            this.optionLabel2.Name = "optionLabel2";
            this.optionLabel2.Size = new System.Drawing.Size(341, 21);
            this.optionLabel2.TabIndex = 2;
            // 
            // optionLabel3
            // 
            this.optionLabel3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel3.Location = new System.Drawing.Point(214, 411);
            this.optionLabel3.Name = "optionLabel3";
            this.optionLabel3.Size = new System.Drawing.Size(268, 21);
            this.optionLabel3.TabIndex = 3;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.DarkCyan;
            this.option1Button.Location = new System.Drawing.Point(104, 311);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(91, 31);
            this.option1Button.TabIndex = 4;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.DarkCyan;
            this.option2Button.Location = new System.Drawing.Point(104, 361);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(91, 31);
            this.option2Button.TabIndex = 5;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.DarkCyan;
            this.option3Button.Location = new System.Drawing.Point(104, 407);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(91, 31);
            this.option3Button.TabIndex = 6;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(581, 475);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.optionLabel3);
            this.Controls.Add(this.optionLabel2);
            this.Controls.Add(this.optionLabel1);
            this.Controls.Add(this.outputLabel);
            this.Name = "form1";
            this.ShowIcon = false;
            this.Text = "dating game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label optionLabel1;
        private System.Windows.Forms.Label optionLabel2;
        private System.Windows.Forms.Label optionLabel3;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
    }
}

