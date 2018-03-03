namespace MaydayBackend
{
    partial class frmBookingMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingMain));
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFRef = new System.Windows.Forms.Label();
            this.txtBookRef = new System.Windows.Forms.TextBox();
            this.lblFilterT = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.txtDate2 = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDFilter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(504, 24);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 39);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Show All Bookings";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(246, 338);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // lblFRef
            // 
            this.lblFRef.AutoSize = true;
            this.lblFRef.Location = new System.Drawing.Point(4, 19);
            this.lblFRef.Name = "lblFRef";
            this.lblFRef.Size = new System.Drawing.Size(63, 13);
            this.lblFRef.TabIndex = 4;
            this.lblFRef.Text = "Filter by Ref";
            // 
            // txtBookRef
            // 
            this.txtBookRef.Location = new System.Drawing.Point(4, 43);
            this.txtBookRef.Name = "txtBookRef";
            this.txtBookRef.Size = new System.Drawing.Size(100, 20);
            this.txtBookRef.TabIndex = 5;
            // 
            // lblFilterT
            // 
            this.lblFilterT.AutoSize = true;
            this.lblFilterT.Location = new System.Drawing.Point(188, 10);
            this.lblFilterT.Name = "lblFilterT";
            this.lblFilterT.Size = new System.Drawing.Size(104, 13);
            this.lblFilterT.TabIndex = 6;
            this.lblFilterT.Text = "Filter by Date Range";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(188, 26);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(27, 13);
            this.lblfrom.TabIndex = 7;
            this.lblfrom.Text = "from";
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(192, 39);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(100, 20);
            this.txtDate1.TabIndex = 8;
            // 
            // txtDate2
            // 
            this.txtDate2.Location = new System.Drawing.Point(316, 39);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(100, 20);
            this.txtDate2.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(298, 42);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "to";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(107, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(73, 21);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter By Ref";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDFilter
            // 
            this.btnDFilter.Location = new System.Drawing.Point(423, 26);
            this.btnDFilter.Name = "btnDFilter";
            this.btnDFilter.Size = new System.Drawing.Size(75, 38);
            this.btnDFilter.TabIndex = 12;
            this.btnDFilter.Text = "Filter by Date";
            this.btnDFilter.UseVisualStyleBackColor = true;
            this.btnDFilter.Click += new System.EventHandler(this.btnDFilter_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Booking";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstBookings
            // 
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.Location = new System.Drawing.Point(7, 70);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(572, 251);
            this.lstBookings.TabIndex = 0;
            // 
            // frmBookingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.lblFilterT);
            this.Controls.Add(this.txtBookRef);
            this.Controls.Add(this.lblFRef);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBookingMain";
            this.Text = "Display Bookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFRef;
        private System.Windows.Forms.TextBox txtBookRef;
        private System.Windows.Forms.Label lblFilterT;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.TextBox txtDate2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDFilter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstBookings;
    }
}