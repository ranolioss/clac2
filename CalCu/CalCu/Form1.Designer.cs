
namespace CalCu
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
            this.Clear = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Divi = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.Fact = new System.Windows.Forms.Label();
            this.Perc = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Multi = new System.Windows.Forms.Label();
            this.Ex = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ntwo = new System.Windows.Forms.TextBox();
            this.NOne = new System.Windows.Forms.TextBox();
            this.NumTwo = new System.Windows.Forms.Label();
            this.NumOne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(269, 474);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(151, 31);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Res
            // 
            this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res.Location = new System.Drawing.Point(118, 42);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(205, 79);
            this.Res.TabIndex = 14;
            this.Res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Divi);
            this.groupBox2.Controls.Add(this.Power);
            this.groupBox2.Controls.Add(this.Fact);
            this.groupBox2.Controls.Add(this.Perc);
            this.groupBox2.Controls.Add(this.Min);
            this.groupBox2.Controls.Add(this.Sum);
            this.groupBox2.Controls.Add(this.Multi);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 186);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // Divi
            // 
            this.Divi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Divi.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divi.Location = new System.Drawing.Point(179, 73);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(65, 47);
            this.Divi.TabIndex = 12;
            this.Divi.Text = "/";
            this.Divi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // Power
            // 
            this.Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Power.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power.Location = new System.Drawing.Point(250, 73);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(65, 47);
            this.Power.TabIndex = 11;
            this.Power.Text = "^";
            this.Power.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Fact
            // 
            this.Fact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fact.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fact.Location = new System.Drawing.Point(179, 130);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(65, 47);
            this.Fact.TabIndex = 10;
            this.Fact.Text = "!";
            this.Fact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Fact.Click += new System.EventHandler(this.Fact_Click);
            // 
            // Perc
            // 
            this.Perc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Perc.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perc.Location = new System.Drawing.Point(108, 73);
            this.Perc.Name = "Perc";
            this.Perc.Size = new System.Drawing.Size(65, 47);
            this.Perc.TabIndex = 9;
            this.Perc.Text = "%";
            this.Perc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Perc.Click += new System.EventHandler(this.Perc_Click);
            // 
            // Min
            // 
            this.Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Min.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(250, 16);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(65, 47);
            this.Min.TabIndex = 8;
            this.Min.Text = "-";
            this.Min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Sum
            // 
            this.Sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sum.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(179, 16);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(65, 47);
            this.Sum.TabIndex = 7;
            this.Sum.Text = "+";
            this.Sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Multi
            // 
            this.Multi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Multi.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.Location = new System.Drawing.Point(108, 16);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(65, 47);
            this.Multi.TabIndex = 6;
            this.Multi.Text = "x";
            this.Multi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Ex
            // 
            this.Ex.Location = new System.Drawing.Point(45, 474);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(151, 31);
            this.Ex.TabIndex = 22;
            this.Ex.Text = "Exist";
            this.Ex.UseVisualStyleBackColor = true;
            this.Ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ntwo);
            this.groupBox1.Controls.Add(this.NOne);
            this.groupBox1.Controls.Add(this.NumTwo);
            this.groupBox1.Controls.Add(this.NumOne);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers";
            // 
            // Ntwo
            // 
            this.Ntwo.Location = new System.Drawing.Point(287, 47);
            this.Ntwo.Name = "Ntwo";
            this.Ntwo.Size = new System.Drawing.Size(130, 20);
            this.Ntwo.TabIndex = 4;
            // 
            // NOne
            // 
            this.NOne.Location = new System.Drawing.Point(21, 47);
            this.NOne.Name = "NOne";
            this.NOne.Size = new System.Drawing.Size(125, 20);
            this.NOne.TabIndex = 3;
            // 
            // NumTwo
            // 
            this.NumTwo.AutoSize = true;
            this.NumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTwo.Location = new System.Drawing.Point(302, 26);
            this.NumTwo.Name = "NumTwo";
            this.NumTwo.Size = new System.Drawing.Size(104, 18);
            this.NumTwo.TabIndex = 2;
            this.NumTwo.Text = "Number Two";
            // 
            // NumOne
            // 
            this.NumOne.AutoSize = true;
            this.NumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOne.Location = new System.Drawing.Point(30, 26);
            this.NumOne.Name = "NumOne";
            this.NumOne.Size = new System.Drawing.Size(103, 18);
            this.NumOne.TabIndex = 1;
            this.NumOne.Text = "Number One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Simple Calculator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Res);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(11, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 132);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 519);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Divi;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Fact;
        private System.Windows.Forms.Label Perc;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Multi;
        private System.Windows.Forms.Button Ex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Ntwo;
        private System.Windows.Forms.TextBox NOne;
        private System.Windows.Forms.Label NumTwo;
        private System.Windows.Forms.Label NumOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

