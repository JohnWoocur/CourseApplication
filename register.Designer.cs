namespace acadamy
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
            label1 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnum = new TextBox();
            txtmail = new TextBox();
            txtpwd = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 95);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(244, 88);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 1;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 150);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 206);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 3;
            label3.Text = "phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 267);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "password:";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(244, 199);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(125, 27);
            txtnum.TabIndex = 5;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(244, 143);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(125, 27);
            txtmail.TabIndex = 6;
            // 
            // txtpwd
            // 
            txtpwd.Location = new Point(244, 260);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(125, 27);
            txtpwd.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(216, 32);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 8;
            label5.Text = "Register";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(142, 334);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(275, 334);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtpwd);
            Controls.Add(txtmail);
            Controls.Add(txtnum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "register form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtnum;
        private TextBox txtmail;
        private TextBox txtpwd;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}
