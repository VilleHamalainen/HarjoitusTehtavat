namespace Autokauppa.view
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test_DBConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.test_functions = new System.Windows.Forms.ToolStripMenuItem();
            this.mittarilukema_text = new System.Windows.Forms.TextBox();
            this.tilavuus_text = new System.Windows.Forms.TextBox();
            this.hinta_text = new System.Windows.Forms.TextBox();
            this.Merkki_cBox = new System.Windows.Forms.ComboBox();
            this.Malli_cBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.uusiAuto_btn = new System.Windows.Forms.Button();
            this.Tallenna = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test_DBConnection,
            this.test_functions});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // test_DBConnection
            // 
            this.test_DBConnection.Name = "test_DBConnection";
            this.test_DBConnection.Size = new System.Drawing.Size(205, 22);
            this.test_DBConnection.Text = "Testaa tietokantayhteyttä";
            this.test_DBConnection.Click += new System.EventHandler(this.test_DBConnection_Click);
            // 
            // test_functions
            // 
            this.test_functions.Name = "test_functions";
            this.test_functions.Size = new System.Drawing.Size(205, 22);
            this.test_functions.Text = "Testaa aliohjelmia";
            this.test_functions.Click += new System.EventHandler(this.test_functions_Click);
            // 
            // mittarilukema_text
            // 
            this.mittarilukema_text.Location = new System.Drawing.Point(11, 57);
            this.mittarilukema_text.Name = "mittarilukema_text";
            this.mittarilukema_text.Size = new System.Drawing.Size(74, 20);
            this.mittarilukema_text.TabIndex = 1;
            // 
            // tilavuus_text
            // 
            this.tilavuus_text.Location = new System.Drawing.Point(103, 57);
            this.tilavuus_text.Name = "tilavuus_text";
            this.tilavuus_text.Size = new System.Drawing.Size(74, 20);
            this.tilavuus_text.TabIndex = 2;
            // 
            // hinta_text
            // 
            this.hinta_text.Location = new System.Drawing.Point(197, 57);
            this.hinta_text.Name = "hinta_text";
            this.hinta_text.Size = new System.Drawing.Size(74, 20);
            this.hinta_text.TabIndex = 3;
            // 
            // Merkki_cBox
            // 
            this.Merkki_cBox.FormattingEnabled = true;
            this.Merkki_cBox.Location = new System.Drawing.Point(11, 131);
            this.Merkki_cBox.Name = "Merkki_cBox";
            this.Merkki_cBox.Size = new System.Drawing.Size(121, 21);
            this.Merkki_cBox.TabIndex = 4;
            this.Merkki_cBox.SelectedIndexChanged += new System.EventHandler(this.Merkki_cBox_SelectedIndexChanged);
            // 
            // Malli_cBox
            // 
            this.Malli_cBox.FormattingEnabled = true;
            this.Malli_cBox.Location = new System.Drawing.Point(151, 131);
            this.Malli_cBox.Name = "Malli_cBox";
            this.Malli_cBox.Size = new System.Drawing.Size(120, 21);
            this.Malli_cBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mittarilukema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Moottorin tilavuus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hinta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Merkki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Malli";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rekisteröintipäivämäärä";
            // 
            // uusiAuto_btn
            // 
            this.uusiAuto_btn.Location = new System.Drawing.Point(44, 286);
            this.uusiAuto_btn.Name = "uusiAuto_btn";
            this.uusiAuto_btn.Size = new System.Drawing.Size(75, 23);
            this.uusiAuto_btn.TabIndex = 13;
            this.uusiAuto_btn.Text = "Uusi tietue";
            this.uusiAuto_btn.UseVisualStyleBackColor = true;
            // 
            // Tallenna
            // 
            this.Tallenna.Location = new System.Drawing.Point(169, 286);
            this.Tallenna.Name = "Tallenna";
            this.Tallenna.Size = new System.Drawing.Size(75, 23);
            this.Tallenna.TabIndex = 14;
            this.Tallenna.Text = "Tallenna";
            this.Tallenna.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Edellinen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Seuraava";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Polttoaine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Värit";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 432);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tallenna);
            this.Controls.Add(this.uusiAuto_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Malli_cBox);
            this.Controls.Add(this.Merkki_cBox);
            this.Controls.Add(this.hinta_text);
            this.Controls.Add(this.tilavuus_text);
            this.Controls.Add(this.mittarilukema_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test_DBConnection;
        private System.Windows.Forms.TextBox mittarilukema_text;
        private System.Windows.Forms.TextBox tilavuus_text;
        private System.Windows.Forms.TextBox hinta_text;
        private System.Windows.Forms.ComboBox Merkki_cBox;
        private System.Windows.Forms.ComboBox Malli_cBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uusiAuto_btn;
        private System.Windows.Forms.Button Tallenna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem test_functions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}