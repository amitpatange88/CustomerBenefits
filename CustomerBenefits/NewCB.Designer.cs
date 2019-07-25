namespace CustomerBenefits
{
    partial class NewCB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNEW = new System.Windows.Forms.Label();
            this.lblNEWBenefit = new System.Windows.Forms.Label();
            this.lblNEWDate = new System.Windows.Forms.Label();
            this.cmbNEWBENEFITCOLL = new System.Windows.Forms.ComboBox();
            this.txtNEWDate = new System.Windows.Forms.TextBox();
            this.btnNEWAdd = new System.Windows.Forms.Button();
            this.btnNEWSave = new System.Windows.Forms.Button();
            this.btnNEWRemove = new System.Windows.Forms.Button();
            this.dgCustomerBenefit = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtICENumber = new System.Windows.Forms.TextBox();
            this.lblICE = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BenefitInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBenefit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNEW
            // 
            this.lblNEW.AutoSize = true;
            this.lblNEW.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNEW.Location = new System.Drawing.Point(232, 58);
            this.lblNEW.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNEW.Name = "lblNEW";
            this.lblNEW.Size = new System.Drawing.Size(352, 37);
            this.lblNEW.TabIndex = 0;
            this.lblNEW.Text = "NEW Customer BENEFIt";
            this.lblNEW.Click += new System.EventHandler(this.lblNEW_Click);
            // 
            // lblNEWBenefit
            // 
            this.lblNEWBenefit.AutoSize = true;
            this.lblNEWBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNEWBenefit.Location = new System.Drawing.Point(110, 168);
            this.lblNEWBenefit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNEWBenefit.Name = "lblNEWBenefit";
            this.lblNEWBenefit.Size = new System.Drawing.Size(157, 26);
            this.lblNEWBenefit.TabIndex = 1;
            this.lblNEWBenefit.Text = "Benefit Name";
            this.lblNEWBenefit.Click += new System.EventHandler(this.lblNEWBenefit_Click);
            // 
            // lblNEWDate
            // 
            this.lblNEWDate.AutoSize = true;
            this.lblNEWDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNEWDate.Location = new System.Drawing.Point(110, 245);
            this.lblNEWDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNEWDate.Name = "lblNEWDate";
            this.lblNEWDate.Size = new System.Drawing.Size(162, 26);
            this.lblNEWDate.TabIndex = 2;
            this.lblNEWDate.Text = "Effective Date";
            this.lblNEWDate.Click += new System.EventHandler(this.lblNEWDate_Click);
            // 
            // cmbNEWBENEFITCOLL
            // 
            this.cmbNEWBENEFITCOLL.FormattingEnabled = true;
            this.cmbNEWBENEFITCOLL.Location = new System.Drawing.Point(289, 168);
            this.cmbNEWBENEFITCOLL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbNEWBENEFITCOLL.Name = "cmbNEWBENEFITCOLL";
            this.cmbNEWBENEFITCOLL.Size = new System.Drawing.Size(186, 34);
            this.cmbNEWBENEFITCOLL.TabIndex = 3;
            this.cmbNEWBENEFITCOLL.SelectedIndexChanged += new System.EventHandler(this.cmbNEWBENEFITCOLL_SelectedIndexChanged);
            // 
            // txtNEWDate
            // 
            this.txtNEWDate.Location = new System.Drawing.Point(289, 235);
            this.txtNEWDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNEWDate.Name = "txtNEWDate";
            this.txtNEWDate.Size = new System.Drawing.Size(186, 32);
            this.txtNEWDate.TabIndex = 4;
            this.txtNEWDate.Text = "Today";
            // 
            // btnNEWAdd
            // 
            this.btnNEWAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEWAdd.Location = new System.Drawing.Point(83, 356);
            this.btnNEWAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNEWAdd.Name = "btnNEWAdd";
            this.btnNEWAdd.Size = new System.Drawing.Size(208, 49);
            this.btnNEWAdd.TabIndex = 5;
            this.btnNEWAdd.Text = "ADD";
            this.btnNEWAdd.UseVisualStyleBackColor = true;
            this.btnNEWAdd.Click += new System.EventHandler(this.btnNEWAdd_Click);
            // 
            // btnNEWSave
            // 
            this.btnNEWSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEWSave.Location = new System.Drawing.Point(83, 356);
            this.btnNEWSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNEWSave.Name = "btnNEWSave";
            this.btnNEWSave.Size = new System.Drawing.Size(205, 49);
            this.btnNEWSave.TabIndex = 6;
            this.btnNEWSave.Text = "SAVE";
            this.btnNEWSave.UseVisualStyleBackColor = true;
            this.btnNEWSave.Click += new System.EventHandler(this.btnNEWSave_Click);
            // 
            // btnNEWRemove
            // 
            this.btnNEWRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEWRemove.Location = new System.Drawing.Point(83, 719);
            this.btnNEWRemove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNEWRemove.Name = "btnNEWRemove";
            this.btnNEWRemove.Size = new System.Drawing.Size(241, 62);
            this.btnNEWRemove.TabIndex = 7;
            this.btnNEWRemove.Text = "REMOVE";
            this.btnNEWRemove.UseVisualStyleBackColor = true;
            this.btnNEWRemove.Click += new System.EventHandler(this.btnNEWRemove_Click);
            // 
            // dgCustomerBenefit
            // 
            this.dgCustomerBenefit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerBenefit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.No,
            this.BenefitInformation,
            this.EffectiveDate,
            this.Details});
            this.dgCustomerBenefit.Location = new System.Drawing.Point(63, 433);
            this.dgCustomerBenefit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgCustomerBenefit.Name = "dgCustomerBenefit";
            this.dgCustomerBenefit.RowTemplate.Height = 28;
            this.dgCustomerBenefit.Size = new System.Drawing.Size(895, 251);
            this.dgCustomerBenefit.TabIndex = 8;
            this.dgCustomerBenefit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(503, 719);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 62);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtICENumber
            // 
            this.txtICENumber.Location = new System.Drawing.Point(289, 300);
            this.txtICENumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtICENumber.Name = "txtICENumber";
            this.txtICENumber.Size = new System.Drawing.Size(186, 32);
            this.txtICENumber.TabIndex = 11;
            // 
            // lblICE
            // 
            this.lblICE.AutoSize = true;
            this.lblICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICE.Location = new System.Drawing.Point(110, 310);
            this.lblICE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblICE.Name = "lblICE";
            this.lblICE.Size = new System.Drawing.Size(143, 26);
            this.lblICE.TabIndex = 10;
            this.lblICE.Text = "ICE Number";
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // No
            // 
            this.No.HeaderText = "Number";
            this.No.Name = "No";
            // 
            // BenefitInformation
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenefitInformation.DefaultCellStyle = dataGridViewCellStyle1;
            this.BenefitInformation.HeaderText = "Benefit Information";
            this.BenefitInformation.Name = "BenefitInformation";
            this.BenefitInformation.ReadOnly = true;
            this.BenefitInformation.Width = 300;
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.HeaderText = "Effective Date";
            this.EffectiveDate.Name = "EffectiveDate";
            this.EffectiveDate.ReadOnly = true;
            this.EffectiveDate.Width = 200;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 150;
            // 
            // NewCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 959);
            this.Controls.Add(this.txtICENumber);
            this.Controls.Add(this.lblICE);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgCustomerBenefit);
            this.Controls.Add(this.btnNEWRemove);
            this.Controls.Add(this.btnNEWSave);
            this.Controls.Add(this.btnNEWAdd);
            this.Controls.Add(this.txtNEWDate);
            this.Controls.Add(this.cmbNEWBENEFITCOLL);
            this.Controls.Add(this.lblNEWDate);
            this.Controls.Add(this.lblNEWBenefit);
            this.Controls.Add(this.lblNEW);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewCB";
            this.Text = "NewCB";
            this.Load += new System.EventHandler(this.NewCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBenefit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNEW;
        private System.Windows.Forms.Label lblNEWBenefit;
        private System.Windows.Forms.Label lblNEWDate;
        private System.Windows.Forms.ComboBox cmbNEWBENEFITCOLL;
        private System.Windows.Forms.TextBox txtNEWDate;
        private System.Windows.Forms.Button btnNEWAdd;
        private System.Windows.Forms.Button btnNEWSave;
        private System.Windows.Forms.Button btnNEWRemove;
        private System.Windows.Forms.DataGridView dgCustomerBenefit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtICENumber;
        private System.Windows.Forms.Label lblICE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn BenefitInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
    }
}