
namespace MainScreen
{
    partial class Recursion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackLvlNum = new System.Windows.Forms.TrackBar();
            this.groupBoxArea = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxIterations = new System.Windows.Forms.GroupBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackLvlNum)).BeginInit();
            this.groupBoxArea.SuspendLayout();
            this.groupBoxIterations.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(155)))), ((int)(((byte)(205)))));
            this.button1.Location = new System.Drawing.Point(85, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackLvlNum
            // 
            this.trackLvlNum.Location = new System.Drawing.Point(18, 43);
            this.trackLvlNum.Minimum = 1;
            this.trackLvlNum.Name = "trackLvlNum";
            this.trackLvlNum.Size = new System.Drawing.Size(161, 56);
            this.trackLvlNum.TabIndex = 2;
            this.trackLvlNum.Value = 1;
            this.trackLvlNum.Scroll += new System.EventHandler(this.trackLvlNum_Scroll);
            // 
            // groupBoxArea
            // 
            this.groupBoxArea.Controls.Add(this.textBox1);
            this.groupBoxArea.Controls.Add(this.button1);
            this.groupBoxArea.Enabled = false;
            this.groupBoxArea.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxArea.ForeColor = System.Drawing.Color.White;
            this.groupBoxArea.Location = new System.Drawing.Point(514, 70);
            this.groupBoxArea.Name = "groupBoxArea";
            this.groupBoxArea.Size = new System.Drawing.Size(295, 113);
            this.groupBoxArea.TabIndex = 3;
            this.groupBoxArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(535, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "[pixel^2] - defaul value is 100";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(535, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(256, 28);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Minimum area of a triangle";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxIterations
            // 
            this.groupBoxIterations.Controls.Add(this.lblIterations);
            this.groupBoxIterations.Controls.Add(this.trackLvlNum);
            this.groupBoxIterations.Enabled = false;
            this.groupBoxIterations.Location = new System.Drawing.Point(514, 219);
            this.groupBoxIterations.Name = "groupBoxIterations";
            this.groupBoxIterations.Size = new System.Drawing.Size(295, 116);
            this.groupBoxIterations.TabIndex = 4;
            this.groupBoxIterations.TabStop = false;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIterations.ForeColor = System.Drawing.Color.White;
            this.lblIterations.Location = new System.Drawing.Point(219, 43);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(32, 37);
            this.lblIterations.TabIndex = 6;
            this.lblIterations.Text = "1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(555, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(206, 28);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Number of iterations";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(155)))), ((int)(((byte)(205)))));
            this.closeBtn.Location = new System.Drawing.Point(599, 352);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(129, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Recursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(155)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(813, 452);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBoxIterations);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBoxArea);
            this.Name = "Recursion";
            this.Text = "Recursion";
            this.ResizeEnd += new System.EventHandler(this.Recursion_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.trackLvlNum)).EndInit();
            this.groupBoxArea.ResumeLayout(false);
            this.groupBoxArea.PerformLayout();
            this.groupBoxIterations.ResumeLayout(false);
            this.groupBoxIterations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackLvlNum;
        private System.Windows.Forms.GroupBox groupBoxArea;
        private System.Windows.Forms.GroupBox groupBoxIterations;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Button closeBtn;
    }
}