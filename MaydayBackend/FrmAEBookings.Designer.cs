namespace MaydayBackend
{
    partial class FrmAEBookings
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPayType = new System.Windows.Forms.TextBox();
            this.txtDateBo = new System.Windows.Forms.TextBox();
            this.txtBookRef = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblBookRef = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaytype = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(351, 365);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPayType
            // 
            this.txtPayType.Location = new System.Drawing.Point(454, 271);
            this.txtPayType.Name = "txtPayType";
            this.txtPayType.Size = new System.Drawing.Size(100, 20);
            this.txtPayType.TabIndex = 1;
            // 
            // txtDateBo
            // 
            this.txtDateBo.Location = new System.Drawing.Point(454, 216);
            this.txtDateBo.Name = "txtDateBo";
            this.txtDateBo.Size = new System.Drawing.Size(100, 20);
            this.txtDateBo.TabIndex = 2;
            // 
            // txtBookRef
            // 
            this.txtBookRef.Location = new System.Drawing.Point(454, 93);
            this.txtBookRef.Name = "txtBookRef";
            this.txtBookRef.Size = new System.Drawing.Size(100, 20);
            this.txtBookRef.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(454, 157);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // lblBookRef
            // 
            this.lblBookRef.AutoSize = true;
            this.lblBookRef.Location = new System.Drawing.Point(240, 100);
            this.lblBookRef.Name = "lblBookRef";
            this.lblBookRef.Size = new System.Drawing.Size(96, 13);
            this.lblBookRef.TabIndex = 5;
            this.lblBookRef.Text = "Booking Refernce:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(240, 157);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Booked";
            // 
            // lblPaytype
            // 
            this.lblPaytype.AutoSize = true;
            this.lblPaytype.Location = new System.Drawing.Point(240, 278);
            this.lblPaytype.Name = "lblPaytype";
            this.lblPaytype.Size = new System.Drawing.Size(75, 13);
            this.lblPaytype.TabIndex = 8;
            this.lblPaytype.Text = "Payment Type";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(378, 319);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // FrmAEBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPaytype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBookRef);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBookRef);
            this.Controls.Add(this.txtDateBo);
            this.Controls.Add(this.txtPayType);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmAEBookings";
            this.Text = "FrmAEBookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPayType;
        private System.Windows.Forms.TextBox txtDateBo;
        private System.Windows.Forms.TextBox txtBookRef;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblBookRef;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaytype;
        private System.Windows.Forms.Label lblError;
    }
}