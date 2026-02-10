namespace CALC
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
            this.button_One = new System.Windows.Forms.Button();
            this.display_Box = new System.Windows.Forms.TextBox();
            this.clicker_Auto = new System.Windows.Forms.Button();
            this.upgrade_Label = new System.Windows.Forms.TextBox();
            this.one_Hundread_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_One
            // 
            this.button_One.Location = new System.Drawing.Point(51, 85);
            this.button_One.Name = "button_One";
            this.button_One.Size = new System.Drawing.Size(124, 44);
            this.button_One.TabIndex = 0;
            this.button_One.Text = "Click Me!";
            this.button_One.UseVisualStyleBackColor = true;
            this.button_One.Click += new System.EventHandler(this.button_One_Click);
            // 
            // display_Box
            // 
            this.display_Box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.display_Box.Location = new System.Drawing.Point(51, 32);
            this.display_Box.Name = "display_Box";
            this.display_Box.ReadOnly = true;
            this.display_Box.Size = new System.Drawing.Size(124, 22);
            this.display_Box.TabIndex = 1;
            this.display_Box.TextChanged += new System.EventHandler(this.display_Box_TextChanged);
            // 
            // clicker_Auto
            // 
            this.clicker_Auto.Location = new System.Drawing.Point(205, 85);
            this.clicker_Auto.Name = "clicker_Auto";
            this.clicker_Auto.Size = new System.Drawing.Size(109, 44);
            this.clicker_Auto.TabIndex = 3;
            this.clicker_Auto.Text = "Click Multipler";
            this.clicker_Auto.UseVisualStyleBackColor = true;
            this.clicker_Auto.Click += new System.EventHandler(this.clicker_Auto_Click);
            // 
            // upgrade_Label
            // 
            this.upgrade_Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upgrade_Label.Location = new System.Drawing.Point(205, 32);
            this.upgrade_Label.Name = "upgrade_Label";
            this.upgrade_Label.ReadOnly = true;
            this.upgrade_Label.Size = new System.Drawing.Size(67, 15);
            this.upgrade_Label.TabIndex = 4;
            this.upgrade_Label.Text = "Upgrades";
            // 
            // one_Hundread_Button
            // 
            this.one_Hundread_Button.Location = new System.Drawing.Point(206, 148);
            this.one_Hundread_Button.Name = "one_Hundread_Button";
            this.one_Hundread_Button.Size = new System.Drawing.Size(107, 43);
            this.one_Hundread_Button.TabIndex = 5;
            this.one_Hundread_Button.Text = "100 Clicks";
            this.one_Hundread_Button.UseVisualStyleBackColor = true;
            this.one_Hundread_Button.Click += new System.EventHandler(this.one_Hundread_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.one_Hundread_Button);
            this.Controls.Add(this.upgrade_Label);
            this.Controls.Add(this.clicker_Auto);
            this.Controls.Add(this.display_Box);
            this.Controls.Add(this.button_One);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_One;
        private System.Windows.Forms.TextBox display_Box;
        private System.Windows.Forms.Button clicker_Auto;
        private System.Windows.Forms.TextBox upgrade_Label;
        private System.Windows.Forms.Button one_Hundread_Button;
    }
}

