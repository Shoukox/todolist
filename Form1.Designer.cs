namespace todo_list
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Undone = new System.Windows.Forms.ListBox();
            this.Done = new System.Windows.Forms.ListBox();
            this.text = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.RightArrow = new System.Windows.Forms.Button();
            this.UncompletedLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "to do list";
            // 
            // Undone
            // 
            this.Undone.BackColor = System.Drawing.Color.PeachPuff;
            this.Undone.ForeColor = System.Drawing.Color.Red;
            this.Undone.FormattingEnabled = true;
            this.Undone.Location = new System.Drawing.Point(12, 143);
            this.Undone.Name = "Undone";
            this.Undone.Size = new System.Drawing.Size(212, 199);
            this.Undone.TabIndex = 1;
            this.Undone.Tag = "Undone";
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.PeachPuff;
            this.Done.ForeColor = System.Drawing.Color.DarkGreen;
            this.Done.FormattingEnabled = true;
            this.Done.Location = new System.Drawing.Point(282, 143);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(216, 199);
            this.Done.TabIndex = 2;
            this.Done.Tag = "Done";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 348);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(154, 22);
            this.text.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus.BackgroundImage")));
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus.Location = new System.Drawing.Point(172, 348);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(26, 22);
            this.plus.TabIndex = 4;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minus.BackgroundImage")));
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.Location = new System.Drawing.Point(200, 348);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(26, 22);
            this.minus.TabIndex = 5;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // RightArrow
            // 
            this.RightArrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightArrow.BackgroundImage")));
            this.RightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightArrow.Location = new System.Drawing.Point(230, 205);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(46, 45);
            this.RightArrow.TabIndex = 6;
            this.RightArrow.UseVisualStyleBackColor = false;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // UncompletedLabel
            // 
            this.UncompletedLabel.AutoSize = true;
            this.UncompletedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UncompletedLabel.Location = new System.Drawing.Point(58, 120);
            this.UncompletedLabel.Name = "UncompletedLabel";
            this.UncompletedLabel.Size = new System.Drawing.Size(123, 20);
            this.UncompletedLabel.TabIndex = 8;
            this.UncompletedLabel.Text = "Uncompleted list";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CompletedLabel.Location = new System.Drawing.Point(337, 120);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(106, 20);
            this.CompletedLabel.TabIndex = 9;
            this.CompletedLabel.Text = "Completed list";
            // 
            // LeftArrow
            // 
            this.LeftArrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LeftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrow.BackgroundImage")));
            this.LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftArrow.Location = new System.Drawing.Point(230, 256);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(46, 45);
            this.LeftArrow.TabIndex = 10;
            this.LeftArrow.UseVisualStyleBackColor = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(510, 386);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.UncompletedLabel);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Undone);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Undone;
        private System.Windows.Forms.ListBox Done;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Label UncompletedLabel;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Button LeftArrow;
    }
}

