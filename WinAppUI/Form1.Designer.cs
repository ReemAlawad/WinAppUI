namespace WinAppUI
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFirstRn = new System.Windows.Forms.TextBox();
            this.txtSecondRn = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculatSub = new System.Windows.Forms.Button();
            this.btnCalculateDiv = new System.Windows.Forms.Button();
            this.btnCalculateMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 50);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "CalculateAdd";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFirstRn
            // 
            this.txtFirstRn.Location = new System.Drawing.Point(155, 107);
            this.txtFirstRn.Name = "txtFirstRn";
            this.txtFirstRn.Size = new System.Drawing.Size(174, 26);
            this.txtFirstRn.TabIndex = 1;
            // 
            // txtSecondRn
            // 
            this.txtSecondRn.Location = new System.Drawing.Point(454, 107);
            this.txtSecondRn.Name = "txtSecondRn";
            this.txtSecondRn.Size = new System.Drawing.Size(142, 26);
            this.txtSecondRn.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(336, 281);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 36);
            this.lblResult.TabIndex = 3;
            // 
            // btnCalculatSub
            // 
            this.btnCalculatSub.Location = new System.Drawing.Point(262, 175);
            this.btnCalculatSub.Name = "btnCalculatSub";
            this.btnCalculatSub.Size = new System.Drawing.Size(101, 50);
            this.btnCalculatSub.TabIndex = 4;
            this.btnCalculatSub.Text = "CalculateSub";
            this.btnCalculatSub.UseVisualStyleBackColor = true;
            this.btnCalculatSub.Click += new System.EventHandler(this.btnCalculatSub_Click);
            // 
            // btnCalculateDiv
            // 
            this.btnCalculateDiv.Location = new System.Drawing.Point(473, 205);
            this.btnCalculateDiv.Name = "btnCalculateDiv";
            this.btnCalculateDiv.Size = new System.Drawing.Size(101, 50);
            this.btnCalculateDiv.TabIndex = 5;
            this.btnCalculateDiv.Text = "CalculateDiv";
            this.btnCalculateDiv.UseVisualStyleBackColor = true;
            this.btnCalculateDiv.Click += new System.EventHandler(this.btnCalculateDiv_Click);
            // 
            // btnCalculateMult
            // 
            this.btnCalculateMult.Location = new System.Drawing.Point(651, 193);
            this.btnCalculateMult.Name = "btnCalculateMult";
            this.btnCalculateMult.Size = new System.Drawing.Size(101, 50);
            this.btnCalculateMult.TabIndex = 6;
            this.btnCalculateMult.Text = "CalculateMult";
            this.btnCalculateMult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateMult);
            this.Controls.Add(this.btnCalculateDiv);
            this.Controls.Add(this.btnCalculatSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecondRn);
            this.Controls.Add(this.txtFirstRn);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFirstRn;
        private System.Windows.Forms.TextBox txtSecondRn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculatSub;
        private System.Windows.Forms.Button btnCalculateDiv;
        private System.Windows.Forms.Button btnCalculateMult;
    }
}

