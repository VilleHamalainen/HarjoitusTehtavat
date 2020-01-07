namespace Math_Game
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
            this.button1 = new System.Windows.Forms.Button();
            this.yesNegative = new System.Windows.Forms.RadioButton();
            this.noNegative = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.yesDivFraction = new System.Windows.Forms.RadioButton();
            this.noDivFraction = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yesFraction = new System.Windows.Forms.RadioButton();
            this.noFraction = new System.Windows.Forms.RadioButton();
            this.radioAddition = new System.Windows.Forms.RadioButton();
            this.radioSubtraction = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioDivision = new System.Windows.Forms.RadioButton();
            this.radioMultiplication = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.wrong_label = new System.Windows.Forms.Label();
            this.correct_label = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yesNegative
            // 
            this.yesNegative.AutoSize = true;
            this.yesNegative.Location = new System.Drawing.Point(20, 54);
            this.yesNegative.Name = "yesNegative";
            this.yesNegative.Size = new System.Drawing.Size(43, 17);
            this.yesNegative.TabIndex = 1;
            this.yesNegative.Text = "Yes";
            this.yesNegative.UseVisualStyleBackColor = true;
            // 
            // noNegative
            // 
            this.noNegative.AutoSize = true;
            this.noNegative.Location = new System.Drawing.Point(85, 54);
            this.noNegative.Name = "noNegative";
            this.noNegative.Size = new System.Drawing.Size(39, 17);
            this.noNegative.TabIndex = 2;
            this.noNegative.Text = "No";
            this.noNegative.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Allow Negative numbers?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtMax);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(336, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(159, 120);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(20, 74);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(124, 20);
            this.txtMax.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Max number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMin);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(171, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(159, 120);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(20, 74);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(124, 20);
            this.txtMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.noNegative);
            this.groupBox2.Controls.Add(this.yesNegative);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.yesDivFraction);
            this.groupBox4.Controls.Add(this.noDivFraction);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(194, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 120);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // yesDivFraction
            // 
            this.yesDivFraction.AutoSize = true;
            this.yesDivFraction.Location = new System.Drawing.Point(20, 54);
            this.yesDivFraction.Name = "yesDivFraction";
            this.yesDivFraction.Size = new System.Drawing.Size(43, 17);
            this.yesDivFraction.TabIndex = 2;
            this.yesDivFraction.Text = "Yes";
            this.yesDivFraction.UseVisualStyleBackColor = true;
            // 
            // noDivFraction
            // 
            this.noDivFraction.AutoSize = true;
            this.noDivFraction.Location = new System.Drawing.Point(91, 54);
            this.noDivFraction.Name = "noDivFraction";
            this.noDivFraction.Size = new System.Drawing.Size(39, 17);
            this.noDivFraction.TabIndex = 1;
            this.noDivFraction.Text = "No";
            this.noDivFraction.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allow fractions in division?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.yesFraction);
            this.groupBox3.Controls.Add(this.noFraction);
            this.groupBox3.Location = new System.Drawing.Point(29, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 120);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Allow fractions?";
            // 
            // yesFraction
            // 
            this.yesFraction.AutoSize = true;
            this.yesFraction.Location = new System.Drawing.Point(20, 54);
            this.yesFraction.Name = "yesFraction";
            this.yesFraction.Size = new System.Drawing.Size(43, 17);
            this.yesFraction.TabIndex = 9;
            this.yesFraction.Text = "Yes";
            this.yesFraction.UseVisualStyleBackColor = true;
            // 
            // noFraction
            // 
            this.noFraction.AutoSize = true;
            this.noFraction.Location = new System.Drawing.Point(84, 54);
            this.noFraction.Name = "noFraction";
            this.noFraction.Size = new System.Drawing.Size(39, 17);
            this.noFraction.TabIndex = 10;
            this.noFraction.Text = "No";
            this.noFraction.UseVisualStyleBackColor = true;
            // 
            // radioAddition
            // 
            this.radioAddition.AutoSize = true;
            this.radioAddition.Location = new System.Drawing.Point(20, 19);
            this.radioAddition.Name = "radioAddition";
            this.radioAddition.Size = new System.Drawing.Size(84, 17);
            this.radioAddition.TabIndex = 2;
            this.radioAddition.Text = "Addition ( + )";
            this.radioAddition.UseVisualStyleBackColor = true;
            // 
            // radioSubtraction
            // 
            this.radioSubtraction.AutoSize = true;
            this.radioSubtraction.Location = new System.Drawing.Point(20, 42);
            this.radioSubtraction.Name = "radioSubtraction";
            this.radioSubtraction.Size = new System.Drawing.Size(97, 17);
            this.radioSubtraction.TabIndex = 1;
            this.radioSubtraction.Text = "Subtraction ( - )";
            this.radioSubtraction.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioRandom);
            this.groupBox5.Controls.Add(this.radioDivision);
            this.groupBox5.Controls.Add(this.radioAddition);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.radioMultiplication);
            this.groupBox5.Controls.Add(this.radioSubtraction);
            this.groupBox5.Location = new System.Drawing.Point(28, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 158);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Launch options";
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(20, 111);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(112, 17);
            this.radioRandom.TabIndex = 13;
            this.radioRandom.Text = "Random operators";
            this.radioRandom.UseVisualStyleBackColor = true;
            // 
            // radioDivision
            // 
            this.radioDivision.AutoSize = true;
            this.radioDivision.Location = new System.Drawing.Point(20, 88);
            this.radioDivision.Name = "radioDivision";
            this.radioDivision.Size = new System.Drawing.Size(82, 17);
            this.radioDivision.TabIndex = 12;
            this.radioDivision.Text = "Division ( / )";
            this.radioDivision.UseVisualStyleBackColor = true;
            // 
            // radioMultiplication
            // 
            this.radioMultiplication.AutoSize = true;
            this.radioMultiplication.Location = new System.Drawing.Point(20, 65);
            this.radioMultiplication.Name = "radioMultiplication";
            this.radioMultiplication.Size = new System.Drawing.Size(105, 17);
            this.radioMultiplication.TabIndex = 11;
            this.radioMultiplication.Text = "Multiplication ( * )";
            this.radioMultiplication.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.wrong_label);
            this.groupBox8.Controls.Add(this.correct_label);
            this.groupBox8.Location = new System.Drawing.Point(358, 184);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(159, 161);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Awards";
            // 
            // wrong_label
            // 
            this.wrong_label.AutoSize = true;
            this.wrong_label.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrong_label.Location = new System.Drawing.Point(33, 102);
            this.wrong_label.Name = "wrong_label";
            this.wrong_label.Size = new System.Drawing.Size(83, 26);
            this.wrong_label.TabIndex = 1;
            this.wrong_label.Text = "Väärin: 0";
            // 
            // correct_label
            // 
            this.correct_label.AutoSize = true;
            this.correct_label.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct_label.Location = new System.Drawing.Point(33, 33);
            this.correct_label.Name = "correct_label";
            this.correct_label.Size = new System.Drawing.Size(82, 26);
            this.correct_label.TabIndex = 0;
            this.correct_label.Text = "Oikein: 0";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox4);
            this.groupBox9.Location = new System.Drawing.Point(179, 371);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(360, 166);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            this.groupBox9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton yesNegative;
        private System.Windows.Forms.RadioButton noNegative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAddition;
        private System.Windows.Forms.RadioButton radioSubtraction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton yesFraction;
        private System.Windows.Forms.RadioButton noFraction;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioDivision;
        private System.Windows.Forms.RadioButton radioMultiplication;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton yesDivFraction;
        private System.Windows.Forms.RadioButton noDivFraction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label wrong_label;
        private System.Windows.Forms.Label correct_label;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

