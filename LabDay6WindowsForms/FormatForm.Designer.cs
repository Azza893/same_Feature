
namespace LabDay6WindowsForms
{
    partial class FormatForm
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
            this.Fontlbl = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Sizelbl = new System.Windows.Forms.Label();
            this.Okbtn = new System.Windows.Forms.Button();
            this.ColorGbox = new System.Windows.Forms.GroupBox();
            this.BlueRadio = new System.Windows.Forms.RadioButton();
            this.GreenRadio = new System.Windows.Forms.RadioButton();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.FormatGBox = new System.Windows.Forms.GroupBox();
            this.UnderLineBtn = new System.Windows.Forms.CheckBox();
            this.ItalicBtn = new System.Windows.Forms.CheckBox();
            this.BoldCheck = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ColorGbox.SuspendLayout();
            this.FormatGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fontlbl
            // 
            this.Fontlbl.AutoSize = true;
            this.Fontlbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fontlbl.Location = new System.Drawing.Point(12, 12);
            this.Fontlbl.Name = "Fontlbl";
            this.Fontlbl.Size = new System.Drawing.Size(49, 24);
            this.Fontlbl.TabIndex = 0;
            this.Fontlbl.Text = "Font";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(97, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 1;
            // 
            // Sizelbl
            // 
            this.Sizelbl.AutoSize = true;
            this.Sizelbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sizelbl.Location = new System.Drawing.Point(16, 50);
            this.Sizelbl.Name = "Sizelbl";
            this.Sizelbl.Size = new System.Drawing.Size(45, 24);
            this.Sizelbl.TabIndex = 2;
            this.Sizelbl.Text = "Size";
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(198, 204);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(181, 42);
            this.Okbtn.TabIndex = 4;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // ColorGbox
            // 
            this.ColorGbox.Controls.Add(this.BlueRadio);
            this.ColorGbox.Controls.Add(this.GreenRadio);
            this.ColorGbox.Controls.Add(this.RedRadio);
            this.ColorGbox.Location = new System.Drawing.Point(275, 13);
            this.ColorGbox.Name = "ColorGbox";
            this.ColorGbox.Size = new System.Drawing.Size(104, 151);
            this.ColorGbox.TabIndex = 5;
            this.ColorGbox.TabStop = false;
            this.ColorGbox.Text = "Color";
            // 
            // BlueRadio
            // 
            this.BlueRadio.AutoSize = true;
            this.BlueRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRadio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlueRadio.Location = new System.Drawing.Point(7, 110);
            this.BlueRadio.Name = "BlueRadio";
            this.BlueRadio.Size = new System.Drawing.Size(59, 24);
            this.BlueRadio.TabIndex = 2;
            this.BlueRadio.TabStop = true;
            this.BlueRadio.Text = "Blue";
            this.BlueRadio.UseVisualStyleBackColor = true;
            this.BlueRadio.CheckedChanged += new System.EventHandler(this.BlueRadio_CheckedChanged);
            // 
            // GreenRadio
            // 
            this.GreenRadio.AutoSize = true;
            this.GreenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRadio.ForeColor = System.Drawing.Color.DarkGreen;
            this.GreenRadio.Location = new System.Drawing.Point(6, 64);
            this.GreenRadio.Name = "GreenRadio";
            this.GreenRadio.Size = new System.Drawing.Size(72, 24);
            this.GreenRadio.TabIndex = 1;
            this.GreenRadio.TabStop = true;
            this.GreenRadio.Text = "Green";
            this.GreenRadio.UseVisualStyleBackColor = true;
            this.GreenRadio.CheckedChanged += new System.EventHandler(this.GreenRadio_CheckedChanged);
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedRadio.ForeColor = System.Drawing.Color.Red;
            this.RedRadio.Location = new System.Drawing.Point(7, 20);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(53, 22);
            this.RedRadio.TabIndex = 0;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Red";
            this.RedRadio.UseVisualStyleBackColor = true;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.RedRadio_CheckedChanged);
            // 
            // FormatGBox
            // 
            this.FormatGBox.Controls.Add(this.UnderLineBtn);
            this.FormatGBox.Controls.Add(this.ItalicBtn);
            this.FormatGBox.Controls.Add(this.BoldCheck);
            this.FormatGBox.Location = new System.Drawing.Point(36, 94);
            this.FormatGBox.Name = "FormatGBox";
            this.FormatGBox.Size = new System.Drawing.Size(140, 152);
            this.FormatGBox.TabIndex = 6;
            this.FormatGBox.TabStop = false;
            this.FormatGBox.Text = "Format";
            // 
            // UnderLineBtn
            // 
            this.UnderLineBtn.AutoSize = true;
            this.UnderLineBtn.Location = new System.Drawing.Point(20, 129);
            this.UnderLineBtn.Name = "UnderLineBtn";
            this.UnderLineBtn.Size = new System.Drawing.Size(75, 17);
            this.UnderLineBtn.TabIndex = 0;
            this.UnderLineBtn.Text = "UnderLine";
            this.UnderLineBtn.UseVisualStyleBackColor = true;
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.AutoSize = true;
            this.ItalicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalicBtn.Location = new System.Drawing.Point(20, 72);
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(61, 24);
            this.ItalicBtn.TabIndex = 1;
            this.ItalicBtn.Text = "Italic";
            this.ItalicBtn.UseVisualStyleBackColor = true;
            // 
            // BoldCheck
            // 
            this.BoldCheck.AutoSize = true;
            this.BoldCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldCheck.Location = new System.Drawing.Point(20, 19);
            this.BoldCheck.Name = "BoldCheck";
            this.BoldCheck.Size = new System.Drawing.Size(64, 24);
            this.BoldCheck.TabIndex = 2;
            this.BoldCheck.Text = "Bold";
            this.BoldCheck.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(97, 56);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 269);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.FormatGBox);
            this.Controls.Add(this.ColorGbox);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Sizelbl);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Fontlbl);
            this.Name = "FormatForm";
            this.Text = "FormatForm";
            this.ColorGbox.ResumeLayout(false);
            this.ColorGbox.PerformLayout();
            this.FormatGBox.ResumeLayout(false);
            this.FormatGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fontlbl;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label Sizelbl;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.GroupBox ColorGbox;
        private System.Windows.Forms.GroupBox FormatGBox;
        private System.Windows.Forms.RadioButton BlueRadio;
        private System.Windows.Forms.RadioButton GreenRadio;
        private System.Windows.Forms.RadioButton RedRadio;
        private System.Windows.Forms.CheckBox UnderLineBtn;
        private System.Windows.Forms.CheckBox ItalicBtn;
        private System.Windows.Forms.CheckBox BoldCheck;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}