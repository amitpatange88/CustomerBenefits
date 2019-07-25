namespace CustomerBenefits
{
    partial class OldCB
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
            this.cmbBenefit = new System.Windows.Forms.ComboBox();
            this.lblBene = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnremo = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBenefit
            // 
            this.cmbBenefit.FormattingEnabled = true;
            this.cmbBenefit.Items.AddRange(new object[] {
            "Green"});
            this.cmbBenefit.Location = new System.Drawing.Point(268, 110);
            this.cmbBenefit.Name = "cmbBenefit";
            this.cmbBenefit.Size = new System.Drawing.Size(248, 28);
            this.cmbBenefit.TabIndex = 0;
            this.cmbBenefit.SelectedIndexChanged += new System.EventHandler(this.cmbBenefit_SelectedIndexChanged);
            // 
            // lblBene
            // 
            this.lblBene.AutoSize = true;
            this.lblBene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBene.Location = new System.Drawing.Point(52, 113);
            this.lblBene.Name = "lblBene";
            this.lblBene.Size = new System.Drawing.Size(141, 25);
            this.lblBene.TabIndex = 1;
            this.lblBene.Text = "Benefit Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(52, 156);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(268, 156);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(248, 26);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Today";
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(57, 243);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(98, 42);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(106, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(385, 32);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "OLD CUSTOMER BENEFIT";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(57, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnremo
            // 
            this.btnremo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremo.Location = new System.Drawing.Point(57, 243);
            this.btnremo.Name = "btnremo";
            this.btnremo.Size = new System.Drawing.Size(115, 41);
            this.btnremo.TabIndex = 7;
            this.btnremo.Text = "Remove";
            this.btnremo.UseVisualStyleBackColor = true;
            this.btnremo.Click += new System.EventHandler(this.btnremo_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(235, 243);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 41);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // OldCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 634);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnremo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBene);
            this.Controls.Add(this.cmbBenefit);
            this.Name = "OldCB";
            this.Text = "OldCB";
            this.Load += new System.EventHandler(this.OldCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBenefit;
        private System.Windows.Forms.Label lblBene;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnremo;
        private System.Windows.Forms.Button btn_back;
    }
}