namespace GUI_Test
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
            this.buttonverbinden = new System.Windows.Forms.Button();
            this.buttonsenden = new System.Windows.Forms.Button();
            this.textBoxsenden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttondatenwoerterempf = new System.Windows.Forms.Button();
            this.listBoxdatenwoerter = new System.Windows.Forms.ListBox();
            this.textBoxanzahl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsetcommand = new System.Windows.Forms.TextBox();
            this.buttonsetcommand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxsetargument = new System.Windows.Forms.TextBox();
            this.buttonsetargument = new System.Windows.Forms.Button();
            this.textBoxgetcommand = new System.Windows.Forms.TextBox();
            this.listBoxcommand = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttongetcommand = new System.Windows.Forms.Button();
            this.textBoxgetargument = new System.Windows.Forms.TextBox();
            this.listBoxargument = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttongetargument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonverbinden
            // 
            this.buttonverbinden.Location = new System.Drawing.Point(19, 12);
            this.buttonverbinden.Name = "buttonverbinden";
            this.buttonverbinden.Size = new System.Drawing.Size(75, 23);
            this.buttonverbinden.TabIndex = 0;
            this.buttonverbinden.Text = "Verbinden";
            this.buttonverbinden.UseVisualStyleBackColor = true;
            this.buttonverbinden.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsenden
            // 
            this.buttonsenden.Location = new System.Drawing.Point(118, 75);
            this.buttonsenden.Name = "buttonsenden";
            this.buttonsenden.Size = new System.Drawing.Size(75, 23);
            this.buttonsenden.TabIndex = 1;
            this.buttonsenden.Text = "Senden";
            this.buttonsenden.UseVisualStyleBackColor = true;
            this.buttonsenden.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxsenden
            // 
            this.textBoxsenden.Location = new System.Drawing.Point(12, 75);
            this.textBoxsenden.Name = "textBoxsenden";
            this.textBoxsenden.Size = new System.Drawing.Size(100, 20);
            this.textBoxsenden.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datenwort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(106, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nicht Verbunden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Anzahl Datenwörter zum Empfangen";
            // 
            // buttondatenwoerterempf
            // 
            this.buttondatenwoerterempf.Location = new System.Drawing.Point(341, 76);
            this.buttondatenwoerterempf.Name = "buttondatenwoerterempf";
            this.buttondatenwoerterempf.Size = new System.Drawing.Size(75, 23);
            this.buttondatenwoerterempf.TabIndex = 8;
            this.buttondatenwoerterempf.Text = "Empfangen";
            this.buttondatenwoerterempf.UseVisualStyleBackColor = true;
            this.buttondatenwoerterempf.Click += new System.EventHandler(this.buttondatenwoerterempf_Click);
            // 
            // listBoxdatenwoerter
            // 
            this.listBoxdatenwoerter.FormattingEnabled = true;
            this.listBoxdatenwoerter.Location = new System.Drawing.Point(235, 104);
            this.listBoxdatenwoerter.Name = "listBoxdatenwoerter";
            this.listBoxdatenwoerter.Size = new System.Drawing.Size(181, 95);
            this.listBoxdatenwoerter.TabIndex = 11;
            // 
            // textBoxanzahl
            // 
            this.textBoxanzahl.Location = new System.Drawing.Point(235, 78);
            this.textBoxanzahl.Name = "textBoxanzahl";
            this.textBoxanzahl.Size = new System.Drawing.Size(100, 20);
            this.textBoxanzahl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Command";
            // 
            // textBoxsetcommand
            // 
            this.textBoxsetcommand.Location = new System.Drawing.Point(12, 127);
            this.textBoxsetcommand.Name = "textBoxsetcommand";
            this.textBoxsetcommand.Size = new System.Drawing.Size(100, 20);
            this.textBoxsetcommand.TabIndex = 14;
            // 
            // buttonsetcommand
            // 
            this.buttonsetcommand.Location = new System.Drawing.Point(118, 127);
            this.buttonsetcommand.Name = "buttonsetcommand";
            this.buttonsetcommand.Size = new System.Drawing.Size(75, 23);
            this.buttonsetcommand.TabIndex = 13;
            this.buttonsetcommand.Text = "Senden";
            this.buttonsetcommand.UseVisualStyleBackColor = true;
            this.buttonsetcommand.Click += new System.EventHandler(this.buttonsendcommand_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Argument";
            // 
            // textBoxsetargument
            // 
            this.textBoxsetargument.Location = new System.Drawing.Point(12, 173);
            this.textBoxsetargument.Name = "textBoxsetargument";
            this.textBoxsetargument.Size = new System.Drawing.Size(100, 20);
            this.textBoxsetargument.TabIndex = 17;
            // 
            // buttonsetargument
            // 
            this.buttonsetargument.Location = new System.Drawing.Point(118, 173);
            this.buttonsetargument.Name = "buttonsetargument";
            this.buttonsetargument.Size = new System.Drawing.Size(75, 23);
            this.buttonsetargument.TabIndex = 16;
            this.buttonsetargument.Text = "Senden";
            this.buttonsetargument.UseVisualStyleBackColor = true;
            this.buttonsetargument.Click += new System.EventHandler(this.buttonsetargument_Click);
            // 
            // textBoxgetcommand
            // 
            this.textBoxgetcommand.Location = new System.Drawing.Point(461, 78);
            this.textBoxgetcommand.Name = "textBoxgetcommand";
            this.textBoxgetcommand.Size = new System.Drawing.Size(100, 20);
            this.textBoxgetcommand.TabIndex = 22;
            // 
            // listBoxcommand
            // 
            this.listBoxcommand.FormattingEnabled = true;
            this.listBoxcommand.Location = new System.Drawing.Point(461, 104);
            this.listBoxcommand.Name = "listBoxcommand";
            this.listBoxcommand.Size = new System.Drawing.Size(181, 95);
            this.listBoxcommand.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Anzahl der Durchläufe";
            // 
            // buttongetcommand
            // 
            this.buttongetcommand.Location = new System.Drawing.Point(567, 76);
            this.buttongetcommand.Name = "buttongetcommand";
            this.buttongetcommand.Size = new System.Drawing.Size(75, 23);
            this.buttongetcommand.TabIndex = 19;
            this.buttongetcommand.Text = "Empfangen";
            this.buttongetcommand.UseVisualStyleBackColor = true;
            this.buttongetcommand.Click += new System.EventHandler(this.buttongetcommand_Click);
            // 
            // textBoxgetargument
            // 
            this.textBoxgetargument.Location = new System.Drawing.Point(679, 78);
            this.textBoxgetargument.Name = "textBoxgetargument";
            this.textBoxgetargument.Size = new System.Drawing.Size(100, 20);
            this.textBoxgetargument.TabIndex = 26;
            // 
            // listBoxargument
            // 
            this.listBoxargument.FormattingEnabled = true;
            this.listBoxargument.Location = new System.Drawing.Point(679, 104);
            this.listBoxargument.Name = "listBoxargument";
            this.listBoxargument.Size = new System.Drawing.Size(181, 95);
            this.listBoxargument.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Anzahl der Durchläufe";
            // 
            // buttongetargument
            // 
            this.buttongetargument.Location = new System.Drawing.Point(785, 76);
            this.buttongetargument.Name = "buttongetargument";
            this.buttongetargument.Size = new System.Drawing.Size(75, 23);
            this.buttongetargument.TabIndex = 23;
            this.buttongetargument.Text = "Empfangen";
            this.buttongetargument.UseVisualStyleBackColor = true;
            this.buttongetargument.Click += new System.EventHandler(this.buttongetargument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 205);
            this.Controls.Add(this.textBoxgetargument);
            this.Controls.Add(this.listBoxargument);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttongetargument);
            this.Controls.Add(this.textBoxgetcommand);
            this.Controls.Add(this.listBoxcommand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttongetcommand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxsetargument);
            this.Controls.Add(this.buttonsetargument);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsetcommand);
            this.Controls.Add(this.buttonsetcommand);
            this.Controls.Add(this.textBoxanzahl);
            this.Controls.Add(this.listBoxdatenwoerter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttondatenwoerterempf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsenden);
            this.Controls.Add(this.buttonsenden);
            this.Controls.Add(this.buttonverbinden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonverbinden;
        private System.Windows.Forms.Button buttonsenden;
        private System.Windows.Forms.TextBox textBoxsenden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttondatenwoerterempf;
        private System.Windows.Forms.ListBox listBoxdatenwoerter;
        private System.Windows.Forms.TextBox textBoxanzahl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsetcommand;
        private System.Windows.Forms.Button buttonsetcommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxsetargument;
        private System.Windows.Forms.Button buttonsetargument;
        private System.Windows.Forms.TextBox textBoxgetcommand;
        private System.Windows.Forms.ListBox listBoxcommand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttongetcommand;
        private System.Windows.Forms.TextBox textBoxgetargument;
        private System.Windows.Forms.ListBox listBoxargument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttongetargument;
    }
}

