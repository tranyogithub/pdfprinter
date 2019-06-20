namespace pdfprinter
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
            this.textBox_pdffolder_orig = new System.Windows.Forms.TextBox();
            this.button_folderbrowse_origfiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_printall = new System.Windows.Forms.Button();
            this.comboBox_printer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_folderbrowse_destination = new System.Windows.Forms.Button();
            this.textBox_pdffolder_dest = new System.Windows.Forms.TextBox();
            this.checkBox_print = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_pdffolder_orig
            // 
            this.textBox_pdffolder_orig.Location = new System.Drawing.Point(17, 80);
            this.textBox_pdffolder_orig.Name = "textBox_pdffolder_orig";
            this.textBox_pdffolder_orig.Size = new System.Drawing.Size(378, 20);
            this.textBox_pdffolder_orig.TabIndex = 0;
            // 
            // button_folderbrowse_origfiles
            // 
            this.button_folderbrowse_origfiles.Location = new System.Drawing.Point(401, 78);
            this.button_folderbrowse_origfiles.Name = "button_folderbrowse_origfiles";
            this.button_folderbrowse_origfiles.Size = new System.Drawing.Size(92, 23);
            this.button_folderbrowse_origfiles.TabIndex = 1;
            this.button_folderbrowse_origfiles.Text = "mappa tallózása";
            this.button_folderbrowse_origfiles.UseVisualStyleBackColor = true;
            this.button_folderbrowse_origfiles.Click += new System.EventHandler(this.button_folderbrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "eredeti pdf file-ok mappája:";
            // 
            // button_printall
            // 
            this.button_printall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_printall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_printall.Location = new System.Drawing.Point(107, 169);
            this.button_printall.Name = "button_printall";
            this.button_printall.Size = new System.Drawing.Size(271, 55);
            this.button_printall.TabIndex = 4;
            this.button_printall.Text = "Start";
            this.button_printall.UseVisualStyleBackColor = true;
            this.button_printall.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_printer
            // 
            this.comboBox_printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_printer.FormattingEnabled = true;
            this.comboBox_printer.Location = new System.Drawing.Point(17, 24);
            this.comboBox_printer.Name = "comboBox_printer";
            this.comboBox_printer.Size = new System.Drawing.Size(378, 21);
            this.comboBox_printer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nyomtatáshoz használandó printer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "hova mentsük a módosított file-okat?";
            // 
            // button_folderbrowse_destination
            // 
            this.button_folderbrowse_destination.Location = new System.Drawing.Point(402, 127);
            this.button_folderbrowse_destination.Name = "button_folderbrowse_destination";
            this.button_folderbrowse_destination.Size = new System.Drawing.Size(91, 23);
            this.button_folderbrowse_destination.TabIndex = 8;
            this.button_folderbrowse_destination.Text = "mappa tallózása";
            this.button_folderbrowse_destination.UseVisualStyleBackColor = true;
            this.button_folderbrowse_destination.Click += new System.EventHandler(this.button_folderbrowse_destination_Click);
            // 
            // textBox_pdffolder_dest
            // 
            this.textBox_pdffolder_dest.Location = new System.Drawing.Point(18, 129);
            this.textBox_pdffolder_dest.Name = "textBox_pdffolder_dest";
            this.textBox_pdffolder_dest.Size = new System.Drawing.Size(378, 20);
            this.textBox_pdffolder_dest.TabIndex = 7;
            // 
            // checkBox_print
            // 
            this.checkBox_print.AutoSize = true;
            this.checkBox_print.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_print.Location = new System.Drawing.Point(401, 26);
            this.checkBox_print.Name = "checkBox_print";
            this.checkBox_print.Size = new System.Drawing.Size(92, 17);
            this.checkBox_print.TabIndex = 10;
            this.checkBox_print.Text = "Nyomtatás is?";
            this.checkBox_print.UseVisualStyleBackColor = false;
            this.checkBox_print.CheckedChanged += new System.EventHandler(this.checkBox_print_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pdfprinter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(508, 237);
            this.Controls.Add(this.checkBox_print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_folderbrowse_destination);
            this.Controls.Add(this.textBox_pdffolder_dest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_printer);
            this.Controls.Add(this.button_printall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_folderbrowse_origfiles);
            this.Controls.Add(this.textBox_pdffolder_orig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "mass pdf changer v2";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pdffolder_orig;
        private System.Windows.Forms.Button button_folderbrowse_origfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_printall;
        private System.Windows.Forms.ComboBox comboBox_printer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_folderbrowse_destination;
        private System.Windows.Forms.TextBox textBox_pdffolder_dest;
        private System.Windows.Forms.CheckBox checkBox_print;
    }
}

