namespace Guessing_Game
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
            this.Guessingbutton = new System.Windows.Forms.Button();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guesslabel = new System.Windows.Forms.Label();
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guessingbutton
            // 
            this.Guessingbutton.Location = new System.Drawing.Point(417, 330);
            this.Guessingbutton.Name = "Guessingbutton";
            this.Guessingbutton.Size = new System.Drawing.Size(97, 36);
            this.Guessingbutton.TabIndex = 0;
            this.Guessingbutton.Text = "Guess";
            this.Guessingbutton.UseVisualStyleBackColor = true;
            this.Guessingbutton.Click += new System.EventHandler(this.Guessingbutton_Click);
            // 
            // Outputlabel
            // 
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outputlabel.Location = new System.Drawing.Point(89, 161);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(425, 147);
            this.Outputlabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a number [1-100]";
            // 
            // guesslabel
            // 
            this.guesslabel.AutoSize = true;
            this.guesslabel.Location = new System.Drawing.Point(85, 338);
            this.guesslabel.Name = "guesslabel";
            this.guesslabel.Size = new System.Drawing.Size(201, 20);
            this.guesslabel.TabIndex = 3;
            this.guesslabel.Text = "You guessed the number 0";
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(300, 69);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(214, 26);
            this.InputtextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.guesslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Outputlabel);
            this.Controls.Add(this.Guessingbutton);
            this.Name = "Form1";
            this.Text = "The Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guessingbutton;
        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guesslabel;
        private System.Windows.Forms.TextBox InputtextBox;
    }
}

