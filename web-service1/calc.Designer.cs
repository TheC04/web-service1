namespace web_service1
{
    partial class calc
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
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.nation = new System.Windows.Forms.ComboBox();
            this.included = new System.Windows.Forms.RadioButton();
            this.categories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(84, 35);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 20);
            this.amount.TabIndex = 0;
            // 
            // nation
            // 
            this.nation.FormattingEnabled = true;
            this.nation.Location = new System.Drawing.Point(0, 0);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(121, 21);
            this.nation.TabIndex = 1;
            // 
            // included
            // 
            this.included.AutoSize = true;
            this.included.Location = new System.Drawing.Point(310, 137);
            this.included.Name = "included";
            this.included.Size = new System.Drawing.Size(233, 30);
            this.included.TabIndex = 2;
            this.included.TabStop = true;
            this.included.Text = "Selezionare questo bottone per calcolare\r\nil prezzo originale partendo da quello " +
    "tassato";
            this.included.UseVisualStyleBackColor = true;
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(480, 34);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(121, 21);
            this.categories.TabIndex = 3;
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.included);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.amount);
            this.Name = "calc";
            this.Text = "calc";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.ComboBox nation;
        private System.Windows.Forms.RadioButton included;
        private System.Windows.Forms.ComboBox categories;
    }
}