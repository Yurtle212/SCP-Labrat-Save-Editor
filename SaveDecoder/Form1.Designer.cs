
namespace SaveDecoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveSelector = new System.Windows.Forms.ComboBox();
            this.SaveText = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SavedText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.SavedText1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveSelector
            // 
            this.SaveSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaveSelector.FormattingEnabled = true;
            this.SaveSelector.Location = new System.Drawing.Point(22, 53);
            this.SaveSelector.Name = "SaveSelector";
            this.SaveSelector.Size = new System.Drawing.Size(121, 23);
            this.SaveSelector.TabIndex = 0;
            this.SaveSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SaveText
            // 
            this.SaveText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveText.BackColor = System.Drawing.SystemColors.Window;
            this.SaveText.Location = new System.Drawing.Point(12, 82);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(602, 502);
            this.SaveText.TabIndex = 5;
            this.SaveText.Text = "";
            this.SaveText.TextChanged += new System.EventHandler(this.SaveText_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(539, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SavedText
            // 
            this.SavedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedText.AutoSize = true;
            this.SavedText.ForeColor = System.Drawing.Color.Black;
            this.SavedText.Location = new System.Drawing.Point(554, 35);
            this.SavedText.Name = "SavedText";
            this.SavedText.Size = new System.Drawing.Size(47, 15);
            this.SavedText.TabIndex = 4;
            this.SavedText.Text = "Saved...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path To Save:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLocation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveLocation.Location = new System.Drawing.Point(25, 31);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.ReadOnly = true;
            this.saveLocation.Size = new System.Drawing.Size(592, 16);
            this.saveLocation.TabIndex = 7;
            this.saveLocation.TabStop = false;
            this.saveLocation.Text = "SavePath";
            // 
            // SavedText1
            // 
            this.SavedText1.AutoSize = true;
            this.SavedText1.Location = new System.Drawing.Point(554, 32);
            this.SavedText1.Name = "SavedText1";
            this.SavedText1.Size = new System.Drawing.Size(47, 15);
            this.SavedText1.TabIndex = 9;
            this.SavedText1.Text = "Saved...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(245, 57);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(0, 15);
            this.PathLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(626, 596);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SavedText1);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavedText);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.SaveSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(642, 285);
            this.Name = "Form1";
            this.Text = "SCP: Labrat Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SaveSelector;
        private System.Windows.Forms.RichTextBox SaveText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label SavedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Label SavedText1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PathLabel;
    }
}

