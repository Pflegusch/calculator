namespace Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.zähler1 = new System.Windows.Forms.RichTextBox();
            this.nenner1 = new System.Windows.Forms.RichTextBox();
            this.zähler2 = new System.Windows.Forms.RichTextBox();
            this.nenner2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(13, 103);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(242, 123);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = "Result:\n";
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // zähler1
            // 
            this.zähler1.Location = new System.Drawing.Point(13, 13);
            this.zähler1.Name = "zähler1";
            this.zähler1.Size = new System.Drawing.Size(101, 23);
            this.zähler1.TabIndex = 15;
            this.zähler1.Text = "";
            // 
            // nenner1
            // 
            this.nenner1.Location = new System.Drawing.Point(14, 45);
            this.nenner1.Name = "nenner1";
            this.nenner1.Size = new System.Drawing.Size(100, 23);
            this.nenner1.TabIndex = 17;
            this.nenner1.Text = "";
            // 
            // zähler2
            // 
            this.zähler2.Location = new System.Drawing.Point(155, 13);
            this.zähler2.Name = "zähler2";
            this.zähler2.Size = new System.Drawing.Size(100, 23);
            this.zähler2.TabIndex = 18;
            this.zähler2.Text = "";
            // 
            // nenner2
            // 
            this.nenner2.Location = new System.Drawing.Point(155, 45);
            this.nenner2.Name = "nenner2";
            this.nenner2.Size = new System.Drawing.Size(100, 23);
            this.nenner2.TabIndex = 19;
            this.nenner2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "   +",
            "   -",
            "   /",
            "   x"});
            this.listBox1.Location = new System.Drawing.Point(120, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(29, 56);
            this.listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 239);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nenner2);
            this.Controls.Add(this.zähler2);
            this.Controls.Add(this.nenner1);
            this.Controls.Add(this.zähler1);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gebt das Hanf frei!!!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.RichTextBox zähler1;
        private System.Windows.Forms.RichTextBox nenner1;
        private System.Windows.Forms.RichTextBox zähler2;
        private System.Windows.Forms.RichTextBox nenner2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

