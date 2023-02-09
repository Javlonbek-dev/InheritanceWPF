namespace Worslik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbTriangleType = new System.Windows.Forms.ComboBox();
            this.sal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "x3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "y3";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(105, 47);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(125, 27);
            this.txtX1.TabIndex = 6;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(105, 94);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(125, 27);
            this.txtY1.TabIndex = 7;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(105, 150);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(125, 27);
            this.txtX2.TabIndex = 8;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(105, 208);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(125, 27);
            this.txtY2.TabIndex = 9;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(105, 260);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(125, 27);
            this.txtX3.TabIndex = 10;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(105, 324);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(125, 27);
            this.txtY3.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(311, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Bosing";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbTriangleType
            // 
            this.cmbTriangleType.FormattingEnabled = true;
            this.cmbTriangleType.Items.AddRange(new object[] {
            "T_UTCHANG",
            "TT_TRIANGLE",
            "TY_TRIANGLE"});
            this.cmbTriangleType.Location = new System.Drawing.Point(311, 42);
            this.cmbTriangleType.Name = "cmbTriangleType";
            this.cmbTriangleType.Size = new System.Drawing.Size(151, 28);
            this.cmbTriangleType.TabIndex = 13;
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Location = new System.Drawing.Point(293, 355);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(72, 20);
            this.sal.TabIndex = 14;
            this.sal.Text = "Parametri";
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Uchburchak turi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yuzi";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(447, 305);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 17;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(433, 400);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 20);
            this.lblArea.TabIndex = 18;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(447, 355);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 20);
            this.lblPerimeter.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 574);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.cmbTriangleType);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtX1;
        private TextBox txtY1;
        private TextBox txtX2;
        private TextBox txtY2;
        private TextBox txtX3;
        private TextBox txtY3;
        private Button btnCalculate;
        private ComboBox cmbTriangleType;
        private Label sal;
        private Label label8;
        private Label label9;
        private Label lblType;
        private Label lblArea;
        private Label lblPerimeter;
    }
}