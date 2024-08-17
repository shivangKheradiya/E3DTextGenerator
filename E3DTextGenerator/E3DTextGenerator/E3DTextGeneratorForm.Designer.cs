namespace E3DTextGenerator
{
    partial class E3DTextGeneratorForm
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
            this.buGenerate = new System.Windows.Forms.Button();
            this.tbE3DText = new System.Windows.Forms.TextBox();
            this.E3DTextLable = new System.Windows.Forms.Label();
            this.buClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTextHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextWidthFactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExtrusionLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFontName = new System.Windows.Forms.ComboBox();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.chbUnderline = new System.Windows.Forms.CheckBox();
            this.chbStricktrhough = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buGenerate
            // 
            this.buGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buGenerate.Location = new System.Drawing.Point(13, 145);
            this.buGenerate.Name = "buGenerate";
            this.buGenerate.Size = new System.Drawing.Size(75, 23);
            this.buGenerate.TabIndex = 10;
            this.buGenerate.Text = "Generate";
            this.buGenerate.UseVisualStyleBackColor = true;
            this.buGenerate.Click += new System.EventHandler(this.buGenerate_Click);
            // 
            // tbE3DText
            // 
            this.tbE3DText.Location = new System.Drawing.Point(135, 12);
            this.tbE3DText.Name = "tbE3DText";
            this.tbE3DText.Size = new System.Drawing.Size(237, 20);
            this.tbE3DText.TabIndex = 1;
            // 
            // E3DTextLable
            // 
            this.E3DTextLable.AutoSize = true;
            this.E3DTextLable.Location = new System.Drawing.Point(10, 15);
            this.E3DTextLable.Name = "E3DTextLable";
            this.E3DTextLable.Size = new System.Drawing.Size(52, 13);
            this.E3DTextLable.TabIndex = 2;
            this.E3DTextLable.Text = "E3D Text";
            // 
            // buClear
            // 
            this.buClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buClear.Location = new System.Drawing.Point(135, 145);
            this.buClear.Name = "buClear";
            this.buClear.Size = new System.Drawing.Size(75, 23);
            this.buClear.TabIndex = 11;
            this.buClear.Text = "Clear";
            this.buClear.UseVisualStyleBackColor = true;
            this.buClear.Click += new System.EventHandler(this.buClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text Height (mm)";
            // 
            // tbTextHeight
            // 
            this.tbTextHeight.Location = new System.Drawing.Point(135, 38);
            this.tbTextHeight.Name = "tbTextHeight";
            this.tbTextHeight.Size = new System.Drawing.Size(129, 20);
            this.tbTextHeight.TabIndex = 2;
            this.tbTextHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTextHeight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text Width Factor";
            // 
            // tbTextWidthFactor
            // 
            this.tbTextWidthFactor.Location = new System.Drawing.Point(135, 64);
            this.tbTextWidthFactor.Name = "tbTextWidthFactor";
            this.tbTextWidthFactor.Size = new System.Drawing.Size(129, 20);
            this.tbTextWidthFactor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Extrusion Length (mm)";
            // 
            // tbExtrusionLength
            // 
            this.tbExtrusionLength.Location = new System.Drawing.Point(135, 90);
            this.tbExtrusionLength.Name = "tbExtrusionLength";
            this.tbExtrusionLength.Size = new System.Drawing.Size(129, 20);
            this.tbExtrusionLength.TabIndex = 4;
            this.tbExtrusionLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExtrusionLength_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Font";
            // 
            // cbFontName
            // 
            this.cbFontName.FormattingEnabled = true;
            this.cbFontName.Location = new System.Drawing.Point(135, 116);
            this.cbFontName.Name = "cbFontName";
            this.cbFontName.Size = new System.Drawing.Size(129, 21);
            this.cbFontName.TabIndex = 5;
            // 
            // chbBold
            // 
            this.chbBold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbBold.AutoSize = true;
            this.chbBold.Location = new System.Drawing.Point(282, 40);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(47, 17);
            this.chbBold.TabIndex = 6;
            this.chbBold.Text = "Bold";
            this.chbBold.UseVisualStyleBackColor = true;
            // 
            // chbItalic
            // 
            this.chbItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbItalic.AutoSize = true;
            this.chbItalic.Location = new System.Drawing.Point(282, 67);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(48, 17);
            this.chbItalic.TabIndex = 7;
            this.chbItalic.Text = "Italic";
            this.chbItalic.UseVisualStyleBackColor = true;
            // 
            // chbUnderline
            // 
            this.chbUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbUnderline.AutoSize = true;
            this.chbUnderline.Location = new System.Drawing.Point(282, 94);
            this.chbUnderline.Name = "chbUnderline";
            this.chbUnderline.Size = new System.Drawing.Size(71, 17);
            this.chbUnderline.TabIndex = 8;
            this.chbUnderline.Text = "Underline";
            this.chbUnderline.UseVisualStyleBackColor = true;
            // 
            // chbStricktrhough
            // 
            this.chbStricktrhough.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStricktrhough.AutoSize = true;
            this.chbStricktrhough.Location = new System.Drawing.Point(282, 120);
            this.chbStricktrhough.Name = "chbStricktrhough";
            this.chbStricktrhough.Size = new System.Drawing.Size(89, 17);
            this.chbStricktrhough.TabIndex = 9;
            this.chbStricktrhough.Text = "Strickthrough";
            this.chbStricktrhough.UseVisualStyleBackColor = true;
            // 
            // E3DTextGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.chbStricktrhough);
            this.Controls.Add(this.chbUnderline);
            this.Controls.Add(this.chbItalic);
            this.Controls.Add(this.chbBold);
            this.Controls.Add(this.cbFontName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExtrusionLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTextWidthFactor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTextHeight);
            this.Controls.Add(this.buClear);
            this.Controls.Add(this.E3DTextLable);
            this.Controls.Add(this.tbE3DText);
            this.Controls.Add(this.buGenerate);
            this.Name = "E3DTextGeneratorForm";
            this.Text = "E3D Text Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buGenerate;
        private System.Windows.Forms.TextBox tbE3DText;
        private System.Windows.Forms.Label E3DTextLable;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTextHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextWidthFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExtrusionLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFontName;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.CheckBox chbItalic;
        private System.Windows.Forms.CheckBox chbUnderline;
        private System.Windows.Forms.CheckBox chbStricktrhough;
    }
}