
namespace CountriesFormsApp
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
            this.CurrentCountryRecordButton = new System.Windows.Forms.Button();
            this.CountryRecordListBox = new System.Windows.Forms.ListBox();
            this.CountryClassListBox = new System.Windows.Forms.ListBox();
            this.CountryClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentCountryRecordButton
            // 
            this.CurrentCountryRecordButton.Location = new System.Drawing.Point(34, 367);
            this.CurrentCountryRecordButton.Name = "CurrentCountryRecordButton";
            this.CurrentCountryRecordButton.Size = new System.Drawing.Size(223, 23);
            this.CurrentCountryRecordButton.TabIndex = 0;
            this.CurrentCountryRecordButton.Text = "Selected record item";
            this.CurrentCountryRecordButton.UseVisualStyleBackColor = true;
            this.CurrentCountryRecordButton.Click += new System.EventHandler(this.CurrentCountryRecordButton_Click);
            // 
            // CountryRecordListBox
            // 
            this.CountryRecordListBox.FormattingEnabled = true;
            this.CountryRecordListBox.ItemHeight = 15;
            this.CountryRecordListBox.Location = new System.Drawing.Point(34, 12);
            this.CountryRecordListBox.Name = "CountryRecordListBox";
            this.CountryRecordListBox.Size = new System.Drawing.Size(223, 349);
            this.CountryRecordListBox.TabIndex = 1;
            // 
            // CountryClassListBox
            // 
            this.CountryClassListBox.FormattingEnabled = true;
            this.CountryClassListBox.ItemHeight = 15;
            this.CountryClassListBox.Location = new System.Drawing.Point(275, 12);
            this.CountryClassListBox.Name = "CountryClassListBox";
            this.CountryClassListBox.Size = new System.Drawing.Size(223, 349);
            this.CountryClassListBox.TabIndex = 2;
            // 
            // CountryClassButton
            // 
            this.CountryClassButton.Location = new System.Drawing.Point(275, 367);
            this.CountryClassButton.Name = "CountryClassButton";
            this.CountryClassButton.Size = new System.Drawing.Size(223, 23);
            this.CountryClassButton.TabIndex = 3;
            this.CountryClassButton.Text = "Selected class item";
            this.CountryClassButton.UseVisualStyleBackColor = true;
            this.CountryClassButton.Click += new System.EventHandler(this.CountryClassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 410);
            this.Controls.Add(this.CountryClassButton);
            this.Controls.Add(this.CountryClassListBox);
            this.Controls.Add(this.CountryRecordListBox);
            this.Controls.Add(this.CurrentCountryRecordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CurrentCountryRecordButton;
        private System.Windows.Forms.ListBox CountryRecordListBox;
        private System.Windows.Forms.ListBox CountryClassListBox;
        private System.Windows.Forms.Button CountryClassButton;
    }
}

