namespace CustomerBenefits
{
    partial class CustomerBenefits
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
            this.btnocb = new System.Windows.Forms.Button();
            this.btnncb = new System.Windows.Forms.Button();
            this.btn_Call = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnocb
            // 
            this.btnocb.Location = new System.Drawing.Point(254, 116);
            this.btnocb.Name = "btnocb";
            this.btnocb.Size = new System.Drawing.Size(399, 141);
            this.btnocb.TabIndex = 0;
            this.btnocb.Text = "Old CB";
            this.btnocb.UseVisualStyleBackColor = true;
            this.btnocb.Click += new System.EventHandler(this.btnocb_Click);
            // 
            // btnncb
            // 
            this.btnncb.Location = new System.Drawing.Point(254, 354);
            this.btnncb.Name = "btnncb";
            this.btnncb.Size = new System.Drawing.Size(399, 121);
            this.btnncb.TabIndex = 1;
            this.btnncb.Text = "New CB";
            this.btnncb.UseVisualStyleBackColor = true;
            this.btnncb.Click += new System.EventHandler(this.btnncb_Click);
            // 
            // btn_Call
            // 
            this.btn_Call.Location = new System.Drawing.Point(254, 580);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(399, 118);
            this.btn_Call.TabIndex = 2;
            this.btn_Call.Text = "Call";
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 955);
            this.Controls.Add(this.btn_Call);
            this.Controls.Add(this.btnncb);
            this.Controls.Add(this.btnocb);
            this.Name = "CustomerBenefits";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnocb;
        private System.Windows.Forms.Button btnncb;
        private System.Windows.Forms.Button btn_Call;
    }
}

