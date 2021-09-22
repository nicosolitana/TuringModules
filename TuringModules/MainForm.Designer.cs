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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.pnlRes = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbTestCase = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.txtProgram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProgram.Size = new System.Drawing.Size(353, 414);
            this.txtProgram.TabIndex = 8;
            this.txtProgram.WordWrap = false;
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
            this.label4.Location = new System.Drawing.Point(407, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Simulation ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 12F);
            this.label6.Location = new System.Drawing.Point(407, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Output: ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Product Sans", 12F);
            this.btnClear.Location = new System.Drawing.Point(199, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 41);
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
            this.btnExecute.Size = new System.Drawing.Size(172, 41);
            this.btnExecute.TabIndex = 17;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // pnlRes
            // 
            this.pnlRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRes.Location = new System.Drawing.Point(412, 54);
            this.pnlRes.Name = "pnlRes";
            this.pnlRes.Size = new System.Drawing.Size(541, 520);
            this.pnlRes.TabIndex = 20;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Product Sans", 12F);
            this.txtResult.Location = new System.Drawing.Point(412, 605);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResult.Size = new System.Drawing.Size(541, 66);
            this.txtResult.TabIndex = 21;
            this.txtResult.WordWrap = false;
            // 
            // cmbTestCase
            // 
            this.cmbTestCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestCase.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestCase.FormattingEnabled = true;
            this.cmbTestCase.Items.AddRange(new object[] {
            "Manual Swap (#5#4# to #4#5#)",
            "GCD (#6#3# to #3#)",
            "Square  (#3# to #9#)",
            "Count to n  (#n# to #1#2#..n#)"});
            this.cmbTestCase.Location = new System.Drawing.Point(21, 591);
            this.cmbTestCase.Name = "cmbTestCase";
            this.cmbTestCase.Size = new System.Drawing.Size(353, 33);
            this.cmbTestCase.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbTestCase, "Load Default Test Case");
            this.cmbTestCase.SelectedIndexChanged += new System.EventHandler(this.cmbTestCase_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 699);
            this.Controls.Add(this.cmbTestCase);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.pnlRes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Panel pnlRes;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbTestCase;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

