namespace EPMImageCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createExhibitButton = new System.Windows.Forms.Button();
            this.item123HelpButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputCodeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DnDTargetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DnDTargetHelpButton = new System.Windows.Forms.Button();
            this.createDnDImageButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputDnDCodeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateOptionImagesButton = new System.Windows.Forms.Button();
            this.option3TextBox = new System.Windows.Forms.TextBox();
            this.option5TextBox = new System.Windows.Forms.TextBox();
            this.option2TextBox = new System.Windows.Forms.TextBox();
            this.option4TextBox = new System.Windows.Forms.TextBox();
            this.option1TextBox = new System.Windows.Forms.TextBox();
            this.selectOutputFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createExhibitButton);
            this.tabPage1.Controls.Add(this.item123HelpButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1103, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stem Exhibit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createExhibitButton
            // 
            this.createExhibitButton.Location = new System.Drawing.Point(997, 219);
            this.createExhibitButton.Margin = new System.Windows.Forms.Padding(2);
            this.createExhibitButton.Name = "createExhibitButton";
            this.createExhibitButton.Size = new System.Drawing.Size(68, 51);
            this.createExhibitButton.TabIndex = 3;
            this.createExhibitButton.Text = "Create Exhibit";
            this.createExhibitButton.UseVisualStyleBackColor = true;
            this.createExhibitButton.Click += new System.EventHandler(this.createExhibitButton_Click);
            // 
            // item123HelpButton
            // 
            this.item123HelpButton.Location = new System.Drawing.Point(997, 39);
            this.item123HelpButton.Margin = new System.Windows.Forms.Padding(2);
            this.item123HelpButton.Name = "item123HelpButton";
            this.item123HelpButton.Size = new System.Drawing.Size(62, 71);
            this.item123HelpButton.TabIndex = 2;
            this.item123HelpButton.Text = "item 1, item 2, etc. help";
            this.item123HelpButton.UseVisualStyleBackColor = true;
            this.item123HelpButton.Click += new System.EventHandler(this.item123HelpButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputCodeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(988, 649);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exhibit code";
            // 
            // inputCodeTextBox
            // 
            this.inputCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCodeTextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.inputCodeTextBox.Location = new System.Drawing.Point(4, 17);
            this.inputCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputCodeTextBox.Multiline = true;
            this.inputCodeTextBox.Name = "inputCodeTextBox";
            this.inputCodeTextBox.Size = new System.Drawing.Size(975, 623);
            this.inputCodeTextBox.TabIndex = 0;
            this.inputCodeTextBox.TextChanged += new System.EventHandler(this.inputCodeTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DnDTargetTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DnDTargetHelpButton);
            this.tabPage2.Controls.Add(this.createDnDImageButton);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1103, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DnD exhibit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DnDTargetTextBox
            // 
            this.DnDTargetTextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.DnDTargetTextBox.Location = new System.Drawing.Point(155, 645);
            this.DnDTargetTextBox.Name = "DnDTargetTextBox";
            this.DnDTargetTextBox.Size = new System.Drawing.Size(550, 24);
            this.DnDTargetTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longest Token Text:";
            // 
            // DnDTargetHelpButton
            // 
            this.DnDTargetHelpButton.Location = new System.Drawing.Point(910, 84);
            this.DnDTargetHelpButton.Name = "DnDTargetHelpButton";
            this.DnDTargetHelpButton.Size = new System.Drawing.Size(75, 55);
            this.DnDTargetHelpButton.TabIndex = 2;
            this.DnDTargetHelpButton.Text = "DnD Target Help";
            this.DnDTargetHelpButton.UseVisualStyleBackColor = true;
            this.DnDTargetHelpButton.Click += new System.EventHandler(this.DnDTargetHelpButton_Click);
            // 
            // createDnDImageButton
            // 
            this.createDnDImageButton.Location = new System.Drawing.Point(910, 266);
            this.createDnDImageButton.Name = "createDnDImageButton";
            this.createDnDImageButton.Size = new System.Drawing.Size(75, 51);
            this.createDnDImageButton.TabIndex = 1;
            this.createDnDImageButton.Text = "Create DnD Image";
            this.createDnDImageButton.UseVisualStyleBackColor = true;
            this.createDnDImageButton.Click += new System.EventHandler(this.createDnDImageButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputDnDCodeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(821, 620);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DnD Image Code";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // inputDnDCodeTextBox
            // 
            this.inputDnDCodeTextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.inputDnDCodeTextBox.Location = new System.Drawing.Point(4, 17);
            this.inputDnDCodeTextBox.Multiline = true;
            this.inputDnDCodeTextBox.Name = "inputDnDCodeTextBox";
            this.inputDnDCodeTextBox.Size = new System.Drawing.Size(803, 592);
            this.inputDnDCodeTextBox.TabIndex = 0;
            this.inputDnDCodeTextBox.TextChanged += new System.EventHandler(this.inputDnDCodeTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.CreateOptionImagesButton);
            this.tabPage3.Controls.Add(this.option3TextBox);
            this.tabPage3.Controls.Add(this.option5TextBox);
            this.tabPage3.Controls.Add(this.option2TextBox);
            this.tabPage3.Controls.Add(this.option4TextBox);
            this.tabPage3.Controls.Add(this.option1TextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1103, 704);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Option Images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "1";
            // 
            // CreateOptionImagesButton
            // 
            this.CreateOptionImagesButton.Location = new System.Drawing.Point(663, 492);
            this.CreateOptionImagesButton.Name = "CreateOptionImagesButton";
            this.CreateOptionImagesButton.Size = new System.Drawing.Size(200, 74);
            this.CreateOptionImagesButton.TabIndex = 5;
            this.CreateOptionImagesButton.Text = "Create Option Images";
            this.CreateOptionImagesButton.UseVisualStyleBackColor = true;
            this.CreateOptionImagesButton.Click += new System.EventHandler(this.CreateOptionImagesButton_Click);
            // 
            // option3TextBox
            // 
            this.option3TextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.option3TextBox.Location = new System.Drawing.Point(37, 472);
            this.option3TextBox.Multiline = true;
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(508, 230);
            this.option3TextBox.TabIndex = 4;
            // 
            // option5TextBox
            // 
            this.option5TextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.option5TextBox.Location = new System.Drawing.Point(579, 236);
            this.option5TextBox.Multiline = true;
            this.option5TextBox.Name = "option5TextBox";
            this.option5TextBox.Size = new System.Drawing.Size(508, 230);
            this.option5TextBox.TabIndex = 3;
            // 
            // option2TextBox
            // 
            this.option2TextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.option2TextBox.Location = new System.Drawing.Point(37, 236);
            this.option2TextBox.Multiline = true;
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(508, 230);
            this.option2TextBox.TabIndex = 2;
            // 
            // option4TextBox
            // 
            this.option4TextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.option4TextBox.Location = new System.Drawing.Point(579, 0);
            this.option4TextBox.Multiline = true;
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(508, 230);
            this.option4TextBox.TabIndex = 1;
            // 
            // option1TextBox
            // 
            this.option1TextBox.Font = new System.Drawing.Font("Courier New", 11F);
            this.option1TextBox.Location = new System.Drawing.Point(37, 0);
            this.option1TextBox.Multiline = true;
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(508, 230);
            this.option1TextBox.TabIndex = 0;
            // 
            // selectOutputFileButton
            // 
            this.selectOutputFileButton.Location = new System.Drawing.Point(4, 15);
            this.selectOutputFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectOutputFileButton.Name = "selectOutputFileButton";
            this.selectOutputFileButton.Size = new System.Drawing.Size(107, 27);
            this.selectOutputFileButton.TabIndex = 1;
            this.selectOutputFileButton.Text = "Select Output File";
            this.selectOutputFileButton.UseVisualStyleBackColor = true;
            this.selectOutputFileButton.Click += new System.EventHandler(this.selectOutputFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filename: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputFileTextBox);
            this.groupBox2.Controls.Add(this.selectOutputFileButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(51, 745);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(722, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output file";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(198, 19);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.ReadOnly = true;
            this.outputFileTextBox.Size = new System.Drawing.Size(442, 20);
            this.outputFileTextBox.TabIndex = 3;
            this.outputFileTextBox.TextChanged += new System.EventHandler(this.outputFileTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 791);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox inputCodeTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button createExhibitButton;
        private System.Windows.Forms.Button item123HelpButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectOutputFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox inputDnDCodeTextBox;
        private System.Windows.Forms.Button createDnDImageButton;
        private System.Windows.Forms.TextBox DnDTargetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DnDTargetHelpButton;
        private System.Windows.Forms.TextBox option3TextBox;
        private System.Windows.Forms.TextBox option5TextBox;
        private System.Windows.Forms.TextBox option2TextBox;
        private System.Windows.Forms.TextBox option4TextBox;
        private System.Windows.Forms.TextBox option1TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateOptionImagesButton;
    }
}

