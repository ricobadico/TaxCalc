namespace TaxCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(46, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your annual income:";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(286, 139);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(219, 22);
            this.txtIncome.TabIndex = 1;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Location = new System.Drawing.Point(286, 294);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(219, 22);
            this.txtTotalTax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(177, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total tax owed:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(532, 129);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(115, 43);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculate Your Taxes";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TaxCalc.Properties.Resources.jason_leung_SAYzxuS1O3M_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
    }
}

