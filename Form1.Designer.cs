﻿namespace U3_P2_Practica_10
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 41);
            label1.Name = "label1";
            label1.Size = new Size(103, 36);
            label1.TabIndex = 0;
            label1.Text = "f(x) = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(323, 31);
            label2.Name = "label2";
            label2.Size = new Size(33, 36);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(257, 41);
            label3.Name = "label3";
            label3.Size = new Size(159, 36);
            label3.TabIndex = 2;
            label3.Text = "_________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(293, 77);
            label4.Name = "label4";
            label4.Size = new Size(87, 36);
            label4.TabIndex = 3;
            label4.Text = "1 + x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(372, 77);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 4;
            label5.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(82, 157);
            label6.Name = "label6";
            label6.Size = new Size(33, 36);
            label6.TabIndex = 5;
            label6.Text = "x";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(242, 157);
            label7.Name = "label7";
            label7.Size = new Size(66, 36);
            label7.TabIndex = 6;
            label7.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(25, 196);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(139, 229);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(204, 196);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(139, 229);
            listBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(389, 196);
            button1.Name = "button1";
            button1.Size = new Size(148, 34);
            button1.TabIndex = 9;
            button1.Text = "for";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(389, 254);
            button2.Name = "button2";
            button2.Size = new Size(148, 34);
            button2.TabIndex = 10;
            button2.Text = "while";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(389, 310);
            button3.Name = "button3";
            button3.Size = new Size(148, 34);
            button3.TabIndex = 11;
            button3.Text = "do..while";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(389, 365);
            button4.Name = "button4";
            button4.Size = new Size(148, 34);
            button4.TabIndex = 12;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}