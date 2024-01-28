namespace Calculator
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.numBtn0 = new System.Windows.Forms.Button();
            this.btnMinusConversion = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.numBtn3 = new System.Windows.Forms.Button();
            this.numBtn2 = new System.Windows.Forms.Button();
            this.numBtn1 = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.numBtn6 = new System.Windows.Forms.Button();
            this.numBtn5 = new System.Windows.Forms.Button();
            this.numBtn4 = new System.Windows.Forms.Button();
            this.btnMultipy = new System.Windows.Forms.Button();
            this.numBtn9 = new System.Windows.Forms.Button();
            this.numBtn8 = new System.Windows.Forms.Button();
            this.numBtn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearError = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numBtn0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMinusConversion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAddition, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBtn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtraction, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBtn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultipy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBtn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackspace, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearError, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEquals
            // 
            this.btnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquals.Location = new System.Drawing.Point(177, 163);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(52, 34);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecimal.Location = new System.Drawing.Point(119, 163);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(52, 34);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // numBtn0
            // 
            this.numBtn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn0.Location = new System.Drawing.Point(61, 163);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(52, 34);
            this.numBtn0.TabIndex = 17;
            this.numBtn0.Text = "0";
            this.numBtn0.UseVisualStyleBackColor = true;
            this.numBtn0.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnMinusConversion
            // 
            this.btnMinusConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinusConversion.Location = new System.Drawing.Point(3, 163);
            this.btnMinusConversion.Name = "btnMinusConversion";
            this.btnMinusConversion.Size = new System.Drawing.Size(52, 34);
            this.btnMinusConversion.TabIndex = 16;
            this.btnMinusConversion.Text = "+/-";
            this.btnMinusConversion.UseVisualStyleBackColor = true;
            this.btnMinusConversion.Click += new System.EventHandler(this.btnMinusConversion_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddition.Location = new System.Drawing.Point(177, 123);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(52, 34);
            this.btnAddition.TabIndex = 15;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // numBtn3
            // 
            this.numBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn3.Location = new System.Drawing.Point(119, 123);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(52, 34);
            this.numBtn3.TabIndex = 14;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = true;
            this.numBtn3.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn2
            // 
            this.numBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn2.Location = new System.Drawing.Point(61, 123);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(52, 34);
            this.numBtn2.TabIndex = 13;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = true;
            this.numBtn2.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn1
            // 
            this.numBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn1.Location = new System.Drawing.Point(3, 123);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(52, 34);
            this.numBtn1.TabIndex = 12;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = true;
            this.numBtn1.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtraction.Location = new System.Drawing.Point(177, 83);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(52, 34);
            this.btnSubtraction.TabIndex = 11;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // numBtn6
            // 
            this.numBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn6.Location = new System.Drawing.Point(119, 83);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(52, 34);
            this.numBtn6.TabIndex = 10;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = true;
            this.numBtn6.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn5
            // 
            this.numBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn5.Location = new System.Drawing.Point(61, 83);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(52, 34);
            this.numBtn5.TabIndex = 9;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = true;
            this.numBtn5.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn4
            // 
            this.numBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn4.Location = new System.Drawing.Point(3, 83);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(52, 34);
            this.numBtn4.TabIndex = 8;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = true;
            this.numBtn4.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnMultipy
            // 
            this.btnMultipy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultipy.Location = new System.Drawing.Point(177, 43);
            this.btnMultipy.Name = "btnMultipy";
            this.btnMultipy.Size = new System.Drawing.Size(52, 34);
            this.btnMultipy.TabIndex = 7;
            this.btnMultipy.Text = "x";
            this.btnMultipy.UseVisualStyleBackColor = true;
            this.btnMultipy.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // numBtn9
            // 
            this.numBtn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn9.Location = new System.Drawing.Point(119, 43);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(52, 34);
            this.numBtn9.TabIndex = 6;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = true;
            this.numBtn9.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn8
            // 
            this.numBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn8.Location = new System.Drawing.Point(61, 43);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(52, 34);
            this.numBtn8.TabIndex = 5;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = true;
            this.numBtn8.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numBtn7
            // 
            this.numBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn7.Location = new System.Drawing.Point(3, 43);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(52, 34);
            this.numBtn7.TabIndex = 4;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = true;
            this.numBtn7.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivide.Location = new System.Drawing.Point(177, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 34);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperand_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackspace.Location = new System.Drawing.Point(119, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(52, 34);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(61, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearError
            // 
            this.btnClearError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearError.Location = new System.Drawing.Point(3, 3);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(52, 34);
            this.btnClearError.TabIndex = 0;
            this.btnClearError.Text = "CE";
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.MaxLength = 5;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(232, 39);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.WordWrap = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 239);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button numBtn8;
        private System.Windows.Forms.Button numBtn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button numBtn0;
        private System.Windows.Forms.Button btnMinusConversion;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button numBtn3;
        private System.Windows.Forms.Button numBtn2;
        private System.Windows.Forms.Button numBtn1;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button numBtn6;
        private System.Windows.Forms.Button numBtn5;
        private System.Windows.Forms.Button numBtn4;
        private System.Windows.Forms.Button btnMultipy;
        private System.Windows.Forms.Button numBtn9;
    }
}

