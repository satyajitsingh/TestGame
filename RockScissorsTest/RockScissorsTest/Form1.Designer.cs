namespace RockScissorsTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.formPanel = new System.Windows.Forms.Panel();
            this.strButton = new System.Windows.Forms.Button();
            this.lblPlay1 = new System.Windows.Forms.Label();
            this.lblPlay2 = new System.Windows.Forms.Label();
            this.plyCombo = new System.Windows.Forms.ComboBox();
            this.compCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.GroupBox();
            this.formPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock Scissors Paper ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Player vs Computer";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Computer vs Computer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.Window;
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.radioButton2);
            this.formPanel.Controls.Add(this.radioButton1);
            this.formPanel.Location = new System.Drawing.Point(171, 50);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(184, 74);
            this.formPanel.TabIndex = 4;
            // 
            // strButton
            // 
            this.strButton.Location = new System.Drawing.Point(183, 224);
            this.strButton.Name = "strButton";
            this.strButton.Size = new System.Drawing.Size(75, 23);
            this.strButton.TabIndex = 5;
            this.strButton.Text = "Start Game";
            this.strButton.UseVisualStyleBackColor = true;
            this.strButton.Click += new System.EventHandler(this.strButton_Click);
            // 
            // lblPlay1
            // 
            this.lblPlay1.AutoSize = true;
            this.lblPlay1.Location = new System.Drawing.Point(11, 12);
            this.lblPlay1.Name = "lblPlay1";
            this.lblPlay1.Size = new System.Drawing.Size(45, 13);
            this.lblPlay1.TabIndex = 6;
            this.lblPlay1.Text = "Player 1";
            // 
            // lblPlay2
            // 
            this.lblPlay2.AutoSize = true;
            this.lblPlay2.Location = new System.Drawing.Point(11, 42);
            this.lblPlay2.Name = "lblPlay2";
            this.lblPlay2.Size = new System.Drawing.Size(52, 13);
            this.lblPlay2.TabIndex = 7;
            this.lblPlay2.Text = "Computer";
            // 
            // plyCombo
            // 
            this.plyCombo.FormattingEnabled = true;
            this.plyCombo.Location = new System.Drawing.Point(325, 9);
            this.plyCombo.Name = "plyCombo";
            this.plyCombo.Size = new System.Drawing.Size(121, 21);
            this.plyCombo.TabIndex = 8;
            this.plyCombo.SelectedIndexChanged += new System.EventHandler(this.plyCombo_SelectedIndexChanged);
            // 
            // compCombo
            // 
            this.compCombo.FormattingEnabled = true;
            this.compCombo.Location = new System.Drawing.Point(325, 39);
            this.compCombo.Name = "compCombo";
            this.compCombo.Size = new System.Drawing.Size(121, 21);
            this.compCombo.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(62, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(62, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.plyCombo);
            this.gamePanel.Controls.Add(this.compCombo);
            this.gamePanel.Controls.Add(this.textBox2);
            this.gamePanel.Controls.Add(this.textBox1);
            this.gamePanel.Controls.Add(this.lblPlay2);
            this.gamePanel.Controls.Add(this.lblPlay1);
            this.gamePanel.Location = new System.Drawing.Point(40, 79);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(452, 85);
            this.gamePanel.TabIndex = 12;
            this.gamePanel.TabStop = false;
            this.gamePanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 268);
            this.Controls.Add(this.strButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button strButton;
        private System.Windows.Forms.Label lblPlay1;
        private System.Windows.Forms.Label lblPlay2;
        private System.Windows.Forms.ComboBox plyCombo;
        private System.Windows.Forms.ComboBox compCombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gamePanel;
    }
}

