namespace ssi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private NumericUpDown numericUpDownMinAlphabets;
        private NumericUpDown numericUpDownMaxAlphabets;
        private NumericUpDown numericUpDownMinNumbers;
        private NumericUpDown numericUpDownMaxNumbers;
        private NumericUpDown numericUpDownMinSpecials;
        private NumericUpDown numericUpDownMaxSpecials;
        private NumericUpDown numericUpDownTotalLength;
        private NumericUpDown numericUpDownNumPasswords;
        private NumericUpDown numericUpDownSeparatorInterval;
        private Button generateButton;
        private ListBox listBoxPasswords;
        private Label labelMinAlphabets;
        private Label labelMaxAlphabets;
        private Label labelMinNumbers;
        private Label labelMaxNumbers;
        private Label labelMinSpecials;
        private Label labelMaxSpecials;
        private Label labelTotalLength;
        private Label labelNumPasswords;
        private Label labelSeparatorInterval;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.numericUpDownMinAlphabets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxAlphabets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinNumbers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxNumbers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinSpecials = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpecials = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumPasswords = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeparatorInterval = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.listBoxPasswords = new System.Windows.Forms.ListBox();
            this.labelMinAlphabets = new System.Windows.Forms.Label();
            this.labelMaxAlphabets = new System.Windows.Forms.Label();
            this.labelMinNumbers = new System.Windows.Forms.Label();
            this.labelMaxNumbers = new System.Windows.Forms.Label();
            this.labelMinSpecials = new System.Windows.Forms.Label();
            this.labelMaxSpecials = new System.Windows.Forms.Label();
            this.labelTotalLength = new System.Windows.Forms.Label();
            this.labelNumPasswords = new System.Windows.Forms.Label();
            this.labelSeparatorInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAlphabets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlphabets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSpecials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpecials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeparatorInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // numarul minim de litere
            // 
            this.numericUpDownMinAlphabets.Location = new System.Drawing.Point(240, 12);
            this.numericUpDownMinAlphabets.Name = "numericUpDownMinAlphabets";
            this.numericUpDownMinAlphabets.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinAlphabets.TabIndex = 0;
            // 
            // numarul maxim de litere
            // 
            this.numericUpDownMaxAlphabets.Location = new System.Drawing.Point(240, 38);
            this.numericUpDownMaxAlphabets.Name = "numericUpDownMaxAlphabets";
            this.numericUpDownMaxAlphabets.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxAlphabets.TabIndex = 1;
            // 
            // numarul minim de numere
            // 
            this.numericUpDownMinNumbers.Location = new System.Drawing.Point(240, 64);
            this.numericUpDownMinNumbers.Name = "numericUpDownMinNumbers";
            this.numericUpDownMinNumbers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinNumbers.TabIndex = 2;
            // 
            // numarul minim de numere
            // 
            this.numericUpDownMaxNumbers.Location = new System.Drawing.Point(240, 90);
            this.numericUpDownMaxNumbers.Name = "numericUpDownMaxNumbers";
            this.numericUpDownMaxNumbers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxNumbers.TabIndex = 3;
            // 
            // numarul minim de caractere speciale
            // 
            this.numericUpDownMinSpecials.Location = new System.Drawing.Point(240, 116);
            this.numericUpDownMinSpecials.Name = "numericUpDownMinSpecials";
            this.numericUpDownMinSpecials.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinSpecials.TabIndex = 4;
            // 
            // numarul maxim de caractere speciale
            // 
            this.numericUpDownMaxSpecials.Location = new System.Drawing.Point(240, 142);
            this.numericUpDownMaxSpecials.Name = "numericUpDownMaxSpecials";
            this.numericUpDownMaxSpecials.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpecials.TabIndex = 5;
            // 
            // lungimea parolei
            // 
            this.numericUpDownTotalLength.Location = new System.Drawing.Point(240, 168);
            this.numericUpDownTotalLength.Name = "numericUpDownTotalLength";
            this.numericUpDownTotalLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTotalLength.TabIndex = 6;
            // 
            // numarul de parole
            // 
            this.numericUpDownNumPasswords.Location = new System.Drawing.Point(240, 194);
            this.numericUpDownNumPasswords.Name = "numericUpDownNumPasswords";
            this.numericUpDownNumPasswords.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumPasswords.TabIndex = 7;
            // 
            // interval pentru separator
            // 
            this.numericUpDownSeparatorInterval.Location = new System.Drawing.Point(240, 220);
            this.numericUpDownSeparatorInterval.Name = "numericUpDownSeparatorInterval";
            this.numericUpDownSeparatorInterval.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSeparatorInterval.TabIndex = 8;
            // 
            // buton de generare
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 246);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(258, 23);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate Passwords";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // list box-ul pentru listarea parolelor
            // 
            this.listBoxPasswords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPasswords_MouseDoubleClick);
            this.listBoxPasswords.FormattingEnabled = true;
            this.listBoxPasswords.Location = new System.Drawing.Point(400, 8);
            this.listBoxPasswords.Name = "listBoxPasswords";
            this.listBoxPasswords.Size = new System.Drawing.Size(300, 238);
            this.listBoxPasswords.TabIndex = 10;


            this.labelMinAlphabets.AutoSize = true;
            this.labelMinAlphabets.Location = new System.Drawing.Point(12, 14);
            this.labelMinAlphabets.Name = "labelMinAlphabets";
            this.labelMinAlphabets.Size = new System.Drawing.Size(118, 13);
            this.labelMinAlphabets.TabIndex = 11;
            this.labelMinAlphabets.Text = "Min nr litere din alfabet:";


            this.labelMaxAlphabets.AutoSize = true;
            this.labelMaxAlphabets.Location = new System.Drawing.Point(12, 40);
            this.labelMaxAlphabets.Name = "labelMaxAlphabets";
            this.labelMaxAlphabets.Size = new System.Drawing.Size(121, 13);
            this.labelMaxAlphabets.TabIndex = 12;
            this.labelMaxAlphabets.Text = "Max nr litere din alfabet::";


            this.labelMinNumbers.AutoSize = true;
            this.labelMinNumbers.Location = new System.Drawing.Point(12, 66);
            this.labelMinNumbers.Name = "labelMinNumbers";
            this.labelMinNumbers.Size = new System.Drawing.Size(111, 13);
            this.labelMinNumbers.TabIndex = 13;
            this.labelMinNumbers.Text = "Min de numere:";


            this.labelMaxNumbers.AutoSize = true;
            this.labelMaxNumbers.Location = new System.Drawing.Point(12, 92);
            this.labelMaxNumbers.Name = "labelMaxNumbers";
            this.labelMaxNumbers.Size = new System.Drawing.Size(114, 13);
            this.labelMaxNumbers.TabIndex = 14;
            this.labelMaxNumbers.Text = "Max de numere:";


            this.labelMinSpecials.AutoSize = true;
            this.labelMinSpecials.Location = new System.Drawing.Point(12, 118);
            this.labelMinSpecials.Name = "labelMinSpecials";
            this.labelMinSpecials.Size = new System.Drawing.Size(108, 13);
            this.labelMinSpecials.TabIndex = 15;
            this.labelMinSpecials.Text = "Min caractere speciale:";


            this.labelMaxSpecials.AutoSize = true;
            this.labelMaxSpecials.Location = new System.Drawing.Point(12, 144);
            this.labelMaxSpecials.Name = "labelMaxSpecials";
            this.labelMaxSpecials.Size = new System.Drawing.Size(111, 13);
            this.labelMaxSpecials.TabIndex = 16;
            this.labelMaxSpecials.Text = "Max caractere speciale:";


            this.labelTotalLength.AutoSize = true;
            this.labelTotalLength.Location = new System.Drawing.Point(12, 170);
            this.labelTotalLength.Name = "labelTotalLength";
            this.labelTotalLength.Size = new System.Drawing.Size(75, 13);
            this.labelTotalLength.TabIndex = 17;
            this.labelTotalLength.Text = "Lungimea parolelor:";


            this.labelNumPasswords.AutoSize = true;
            this.labelNumPasswords.Location = new System.Drawing.Point(12, 196);
            this.labelNumPasswords.Name = "labelNumPasswords";
            this.labelNumPasswords.Size = new System.Drawing.Size(112, 13);
            this.labelNumPasswords.TabIndex = 18;
            this.labelNumPasswords.Text = "Numar de parole:";


            this.labelSeparatorInterval.AutoSize = true;
            this.labelSeparatorInterval.Location = new System.Drawing.Point(12, 222);
            this.labelSeparatorInterval.Name = "labelSeparatorInterval";
            this.labelSeparatorInterval.Size = new System.Drawing.Size(100, 13);
            this.labelSeparatorInterval.TabIndex = 19;
            this.labelSeparatorInterval.Text = "Nr de caractere dupa care apare separator:";


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 281);
            this.Controls.Add(this.labelSeparatorInterval);
            this.Controls.Add(this.labelNumPasswords);
            this.Controls.Add(this.labelTotalLength);
            this.Controls.Add(this.labelMaxSpecials);
            this.Controls.Add(this.labelMinSpecials);
            this.Controls.Add(this.labelMaxNumbers);
            this.Controls.Add(this.labelMinNumbers);
            this.Controls.Add(this.labelMaxAlphabets);
            this.Controls.Add(this.labelMinAlphabets);
            this.Controls.Add(this.listBoxPasswords);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numericUpDownSeparatorInterval);
            this.Controls.Add(this.numericUpDownNumPasswords);
            this.Controls.Add(this.numericUpDownTotalLength);
            this.Controls.Add(this.numericUpDownMaxSpecials);
            this.Controls.Add(this.numericUpDownMinSpecials);
            this.Controls.Add(this.numericUpDownMaxNumbers);
            this.Controls.Add(this.numericUpDownMinNumbers);
            this.Controls.Add(this.numericUpDownMaxAlphabets);
            this.Controls.Add(this.numericUpDownMinAlphabets);
            this.Name = "Form1";
            this.Text = "Generator de parole";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAlphabets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlphabets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSpecials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpecials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeparatorInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
