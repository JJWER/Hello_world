namespace GPAxCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(871, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = "GPAx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPA_input.Location = new System.Drawing.Point(649, 71);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(216, 74);
            this.textBoxGPA_input.TabIndex = 1;
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPAx.Location = new System.Drawing.Point(619, 26);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.ReadOnly = true;
            this.textBoxGPAx.Size = new System.Drawing.Size(216, 74);
            this.textBoxGPAx.TabIndex = 5;
            this.textBoxGPAx.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 318);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinName.Location = new System.Drawing.Point(290, 220);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.Size = new System.Drawing.Size(323, 74);
            this.textBoxMinName.TabIndex = 11;
            this.textBoxMinName.TabStop = false;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxName.Location = new System.Drawing.Point(290, 131);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.Size = new System.Drawing.Size(323, 74);
            this.textBoxMaxName.TabIndex = 10;
            this.textBoxMaxName.TabStop = false;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinGPA.Location = new System.Drawing.Point(619, 220);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.ReadOnly = true;
            this.textBoxMinGPA.Size = new System.Drawing.Size(216, 74);
            this.textBoxMinGPA.TabIndex = 9;
            this.textBoxMinGPA.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 67);
            this.label5.TabIndex = 8;
            this.label5.Text = "MIN GPAx";
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxGPA.Location = new System.Drawing.Point(619, 131);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.ReadOnly = true;
            this.textBoxMaxGPA.Size = new System.Drawing.Size(216, 74);
            this.textBoxMaxGPA.TabIndex = 7;
            this.textBoxMaxGPA.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 67);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAX GPAx";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(871, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 74);
            this.button2.TabIndex = 7;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameInput.Location = new System.Drawing.Point(320, 70);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(323, 74);
            this.textBoxNameInput.TabIndex = 0;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAllData.Location = new System.Drawing.Point(30, 529);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.ReadOnly = true;
            this.textBoxAllData.Size = new System.Drawing.Size(1067, 340);
            this.textBoxAllData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 898);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxGPA_input;
        private TextBox textBoxGPAx;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBoxMinGPA;
        private Label label5;
        private TextBox textBoxMaxGPA;
        private Label label4;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private TextBox textBoxNameInput;
        private TextBox textBoxAllData;
    }
}