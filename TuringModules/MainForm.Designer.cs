namespace TuringModules
{
    partial class MainForm
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
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSimulation = new System.Windows.Forms.DataGridView();
            this.lblOuputString = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtSimResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turing Modules";
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtProgram.Location = new System.Drawing.Point(21, 171);
            this.txtProgram.Multiline = true;
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(353, 433);
            this.txtProgram.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Program:";
            // 
            // txtInputStr
            // 
            this.txtInputStr.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtInputStr.Location = new System.Drawing.Point(21, 95);
            this.txtInputStr.Name = "txtInputStr";
            this.txtInputStr.Size = new System.Drawing.Size(353, 32);
            this.txtInputStr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input string:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label4.Location = new System.Drawing.Point(407, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Simulation";
            // 
            // dgvSimulation
            // 
            this.dgvSimulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulation.Location = new System.Drawing.Point(412, 95);
            this.dgvSimulation.Name = "dgvSimulation";
            this.dgvSimulation.RowHeadersWidth = 51;
            this.dgvSimulation.RowTemplate.Height = 24;
            this.dgvSimulation.Size = new System.Drawing.Size(541, 220);
            this.dgvSimulation.TabIndex = 10;
            // 
            // lblOuputString
            // 
            this.lblOuputString.AutoSize = true;
            this.lblOuputString.Font = new System.Drawing.Font("Product Sans", 12F);
            this.lblOuputString.Location = new System.Drawing.Point(497, 630);
            this.lblOuputString.Name = "lblOuputString";
            this.lblOuputString.Size = new System.Drawing.Size(16, 25);
            this.lblOuputString.TabIndex = 16;
            this.lblOuputString.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label6.Location = new System.Drawing.Point(407, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Output: ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnClear.Location = new System.Drawing.Point(200, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 41);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnExecute.Location = new System.Drawing.Point(21, 630);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 41);
            this.btnExecute.TabIndex = 17;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtSimResult
            // 
            this.txtSimResult.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtSimResult.Location = new System.Drawing.Point(412, 334);
            this.txtSimResult.Multiline = true;
            this.txtSimResult.Name = "txtSimResult";
            this.txtSimResult.Size = new System.Drawing.Size(541, 270);
            this.txtSimResult.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 699);
            this.Controls.Add(this.txtSimResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblOuputString);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1001, 746);
            this.MinimumSize = new System.Drawing.Size(1001, 746);
            this.Name = "MainForm";
            this.Text = "Turing Modules";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSimulation;
        private System.Windows.Forms.Label lblOuputString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtSimResult;
    }
}

