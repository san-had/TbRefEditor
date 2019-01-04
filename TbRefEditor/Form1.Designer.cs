namespace TbRefEditor
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
            this.txtBibel = new System.Windows.Forms.TextBox();
            this.txtTextus = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPreacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReadingLong = new System.Windows.Forms.TextBox();
            this.lblReadingLong = new System.Windows.Forms.Label();
            this.btnCopyReadingLong = new System.Windows.Forms.Button();
            this.btnCopyReadingShort = new System.Windows.Forms.Button();
            this.lblReadingShort = new System.Windows.Forms.Label();
            this.txtReadingShort = new System.Windows.Forms.TextBox();
            this.btnCopyListenShort = new System.Windows.Forms.Button();
            this.lblListeningShort = new System.Windows.Forms.Label();
            this.txtListenShort = new System.Windows.Forms.TextBox();
            this.btnCopyListenLong = new System.Windows.Forms.Button();
            this.lblListeningLong = new System.Windows.Forms.Label();
            this.txtListenLong = new System.Windows.Forms.TextBox();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.dpPreachDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtBibel
            // 
            this.txtBibel.Location = new System.Drawing.Point(138, 88);
            this.txtBibel.Name = "txtBibel";
            this.txtBibel.Size = new System.Drawing.Size(206, 22);
            this.txtBibel.TabIndex = 1;
            // 
            // txtTextus
            // 
            this.txtTextus.Location = new System.Drawing.Point(138, 144);
            this.txtTextus.Name = "txtTextus";
            this.txtTextus.Size = new System.Drawing.Size(206, 22);
            this.txtTextus.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(138, 200);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(206, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtPreacher
            // 
            this.txtPreacher.Location = new System.Drawing.Point(138, 253);
            this.txtPreacher.Name = "txtPreacher";
            this.txtPreacher.Size = new System.Drawing.Size(206, 22);
            this.txtPreacher.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bibliaolvasás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Textus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cím: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Igehirdető:";
            // 
            // txtReadingLong
            // 
            this.txtReadingLong.Location = new System.Drawing.Point(676, 25);
            this.txtReadingLong.Multiline = true;
            this.txtReadingLong.Name = "txtReadingLong";
            this.txtReadingLong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadingLong.Size = new System.Drawing.Size(396, 141);
            this.txtReadingLong.TabIndex = 10;
            // 
            // lblReadingLong
            // 
            this.lblReadingLong.AutoSize = true;
            this.lblReadingLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadingLong.Location = new System.Drawing.Point(433, 28);
            this.lblReadingLong.Name = "lblReadingLong";
            this.lblReadingLong.Size = new System.Drawing.Size(227, 17);
            this.lblReadingLong.TabIndex = 11;
            this.lblReadingLong.Text = "Igehirdetések olvasása - 2019";
            // 
            // btnCopyReadingLong
            // 
            this.btnCopyReadingLong.Location = new System.Drawing.Point(442, 73);
            this.btnCopyReadingLong.Name = "btnCopyReadingLong";
            this.btnCopyReadingLong.Size = new System.Drawing.Size(95, 37);
            this.btnCopyReadingLong.TabIndex = 12;
            this.btnCopyReadingLong.Text = "Másol";
            this.btnCopyReadingLong.UseVisualStyleBackColor = true;
            this.btnCopyReadingLong.Click += new System.EventHandler(this.btnCopyReadingLong_Click);
            // 
            // btnCopyReadingShort
            // 
            this.btnCopyReadingShort.Location = new System.Drawing.Point(442, 253);
            this.btnCopyReadingShort.Name = "btnCopyReadingShort";
            this.btnCopyReadingShort.Size = new System.Drawing.Size(95, 37);
            this.btnCopyReadingShort.TabIndex = 15;
            this.btnCopyReadingShort.Text = "Másol";
            this.btnCopyReadingShort.UseVisualStyleBackColor = true;
            this.btnCopyReadingShort.Click += new System.EventHandler(this.btnCopyReadingShort_Click);
            // 
            // lblReadingShort
            // 
            this.lblReadingShort.AutoSize = true;
            this.lblReadingShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadingShort.Location = new System.Drawing.Point(433, 208);
            this.lblReadingShort.Name = "lblReadingShort";
            this.lblReadingShort.Size = new System.Drawing.Size(175, 17);
            this.lblReadingShort.TabIndex = 14;
            this.lblReadingShort.Text = "Igehirdetések olvasása";
            // 
            // txtReadingShort
            // 
            this.txtReadingShort.Location = new System.Drawing.Point(676, 202);
            this.txtReadingShort.Multiline = true;
            this.txtReadingShort.Name = "txtReadingShort";
            this.txtReadingShort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadingShort.Size = new System.Drawing.Size(396, 70);
            this.txtReadingShort.TabIndex = 13;
            // 
            // btnCopyListenShort
            // 
            this.btnCopyListenShort.Location = new System.Drawing.Point(442, 591);
            this.btnCopyListenShort.Name = "btnCopyListenShort";
            this.btnCopyListenShort.Size = new System.Drawing.Size(95, 37);
            this.btnCopyListenShort.TabIndex = 21;
            this.btnCopyListenShort.Text = "Másol";
            this.btnCopyListenShort.UseVisualStyleBackColor = true;
            this.btnCopyListenShort.Click += new System.EventHandler(this.btnCopyListenShort_Click);
            // 
            // lblListeningShort
            // 
            this.lblListeningShort.AutoSize = true;
            this.lblListeningShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeningShort.Location = new System.Drawing.Point(433, 546);
            this.lblListeningShort.Name = "lblListeningShort";
            this.lblListeningShort.Size = new System.Drawing.Size(227, 17);
            this.lblListeningShort.TabIndex = 20;
            this.lblListeningShort.Text = "Istentiszteletek meghallgatása";
            // 
            // txtListenShort
            // 
            this.txtListenShort.Location = new System.Drawing.Point(676, 546);
            this.txtListenShort.Multiline = true;
            this.txtListenShort.Name = "txtListenShort";
            this.txtListenShort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListenShort.Size = new System.Drawing.Size(396, 70);
            this.txtListenShort.TabIndex = 19;
            // 
            // btnCopyListenLong
            // 
            this.btnCopyListenLong.Location = new System.Drawing.Point(442, 411);
            this.btnCopyListenLong.Name = "btnCopyListenLong";
            this.btnCopyListenLong.Size = new System.Drawing.Size(95, 37);
            this.btnCopyListenLong.TabIndex = 18;
            this.btnCopyListenLong.Text = "Másol";
            this.btnCopyListenLong.UseVisualStyleBackColor = true;
            this.btnCopyListenLong.Click += new System.EventHandler(this.btnCopyListenLong_Click);
            // 
            // lblListeningLong
            // 
            this.lblListeningLong.AutoSize = true;
            this.lblListeningLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeningLong.Location = new System.Drawing.Point(433, 366);
            this.lblListeningLong.Name = "lblListeningLong";
            this.lblListeningLong.Size = new System.Drawing.Size(169, 17);
            this.lblListeningLong.TabIndex = 17;
            this.lblListeningLong.Text = "Istentiszteletek - 2019";
            // 
            // txtListenLong
            // 
            this.txtListenLong.Location = new System.Drawing.Point(676, 363);
            this.txtListenLong.Multiline = true;
            this.txtListenLong.Name = "txtListenLong";
            this.txtListenLong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListenLong.Size = new System.Drawing.Size(396, 141);
            this.txtListenLong.TabIndex = 16;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGenerateScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateScript.Location = new System.Drawing.Point(138, 411);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(206, 46);
            this.btnGenerateScript.TabIndex = 22;
            this.btnGenerateScript.Text = "Script generál";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // dpPreachDate
            // 
            this.dpPreachDate.CustomFormat = "yyyy. MMMM. dd";
            this.dpPreachDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpPreachDate.Location = new System.Drawing.Point(138, 40);
            this.dpPreachDate.Name = "dpPreachDate";
            this.dpPreachDate.Size = new System.Drawing.Size(206, 22);
            this.dpPreachDate.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 720);
            this.Controls.Add(this.dpPreachDate);
            this.Controls.Add(this.btnGenerateScript);
            this.Controls.Add(this.btnCopyListenShort);
            this.Controls.Add(this.lblListeningShort);
            this.Controls.Add(this.txtListenShort);
            this.Controls.Add(this.btnCopyListenLong);
            this.Controls.Add(this.lblListeningLong);
            this.Controls.Add(this.txtListenLong);
            this.Controls.Add(this.btnCopyReadingShort);
            this.Controls.Add(this.lblReadingShort);
            this.Controls.Add(this.txtReadingShort);
            this.Controls.Add(this.btnCopyReadingLong);
            this.Controls.Add(this.lblReadingLong);
            this.Controls.Add(this.txtReadingLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreacher);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtTextus);
            this.Controls.Add(this.txtBibel);
            this.Name = "Form1";
            this.Text = "TbRefEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBibel;
        private System.Windows.Forms.TextBox txtTextus;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPreacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReadingLong;
        private System.Windows.Forms.Label lblReadingLong;
        private System.Windows.Forms.Button btnCopyReadingLong;
        private System.Windows.Forms.Button btnCopyReadingShort;
        private System.Windows.Forms.Label lblReadingShort;
        private System.Windows.Forms.TextBox txtReadingShort;
        private System.Windows.Forms.Button btnCopyListenShort;
        private System.Windows.Forms.Label lblListeningShort;
        private System.Windows.Forms.TextBox txtListenShort;
        private System.Windows.Forms.Button btnCopyListenLong;
        private System.Windows.Forms.Label lblListeningLong;
        private System.Windows.Forms.TextBox txtListenLong;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.DateTimePicker dpPreachDate;
    }
}

