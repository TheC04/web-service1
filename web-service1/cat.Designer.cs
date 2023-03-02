namespace web_service1
{
    partial class cat
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
            this.label1 = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(776, 328);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci la nazione";
            // 
            // nation
            // 
            this.nation.FormattingEnabled = true;
            this.nation.Items.AddRange(new object[] {
            "AT(Austria)",
            "BE(Belgium)",
            "BG(Bulgaria)",
            "CY(Cyprus)",
            "CZ(Czech Republic)",
            "DE(Germany)",
            "DK(Denmark)",
            "EE(Estonia)",
            "EL(Greece)",
            "ES(Spain)",
            "FI(Finland)",
            "FR(France)",
            "HR(Croatia)",
            "HU(Hungary)",
            "IR(Ireland)",
            "IT(Italy)",
            "LT(Lithuania)",
            "LU(Luxembourg)",
            "LV(Latva)",
            "MT(Malta)",
            "NL(The Netherlands)",
            "PL(Poland)",
            "PT(Portugal)",
            "RO(Romania)",
            "SE(Sweden)",
            "SI(Slovenia)",
            "SK(Slovakia)",
            "XI(Northern Ireland)"});
            this.nation.Location = new System.Drawing.Point(12, 58);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(121, 21);
            this.nation.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "cat";
            this.Text = "Categorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nation;
        private System.Windows.Forms.Button button1;
    }
}