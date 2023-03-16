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
            this.included = new System.Windows.Forms.RadioButton();
            this.categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nation = new System.Windows.Forms.ComboBox();
            this.loading = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(12, 32);
            this.amount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(121, 20);
            this.amount.TabIndex = 0;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // included
            // 
            this.included.AutoSize = true;
            this.included.Location = new System.Drawing.Point(12, 220);
            this.included.Name = "included";
            this.included.Size = new System.Drawing.Size(166, 30);
            this.included.TabIndex = 2;
            this.included.TabStop = true;
            this.included.Text = "Check this button to calculate\r\nthe originalprice";
            this.included.UseVisualStyleBackColor = true;
            // 
            // categories
            // 
            this.categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories.FormattingEnabled = true;
            this.categories.ItemHeight = 13;
            this.categories.Location = new System.Drawing.Point(12, 168);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(295, 21);
            this.categories.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categories";
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(13, 279);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 13);
            this.ans.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nation
            // 
            this.nation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.nation.Location = new System.Drawing.Point(12, 95);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(121, 21);
            this.nation.TabIndex = 9;
            this.nation.SelectedIndexChanged += new System.EventHandler(this.nation_SelectedIndexChanged);
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Location = new System.Drawing.Point(12, 168);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(190, 26);
            this.loading.TabIndex = 10;
            this.loading.Text = "Select a nation to visualise the product\r\nwith a special VAT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.included);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.loading);
            this.MaximumSize = new System.Drawing.Size(351, 489);
            this.MinimumSize = new System.Drawing.Size(351, 489);
            this.Name = "calc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.RadioButton included;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nation;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Button button2;
    }
}