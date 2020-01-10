namespace t1_DatabaseConn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.open_Conn = new System.Windows.Forms.Button();
            this.empty_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // open_Conn
            // 
            this.open_Conn.Location = new System.Drawing.Point(30, 38);
            this.open_Conn.Name = "open_Conn";
            this.open_Conn.Size = new System.Drawing.Size(75, 45);
            this.open_Conn.TabIndex = 4;
            this.open_Conn.Text = "Open connection";
            this.open_Conn.UseVisualStyleBackColor = true;
            this.open_Conn.Click += new System.EventHandler(this.open_Conn_Click);
            // 
            // empty_btn
            // 
            this.empty_btn.Location = new System.Drawing.Point(111, 374);
            this.empty_btn.Name = "empty_btn";
            this.empty_btn.Size = new System.Drawing.Size(75, 64);
            this.empty_btn.TabIndex = 5;
            this.empty_btn.Text = "Empty list";
            this.empty_btn.UseVisualStyleBackColor = true;
            this.empty_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(276, 374);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 64);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove selected object";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.empty_btn);
            this.Controls.Add(this.open_Conn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button open_Conn;
        private System.Windows.Forms.Button empty_btn;
        private System.Windows.Forms.Button remove_btn;
    }
}

