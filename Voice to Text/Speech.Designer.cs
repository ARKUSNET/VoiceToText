namespace Voice_to_Text
{
    partial class Speech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speech));
            this.lblPathCaption = new System.Windows.Forms.Label();
            this.tBPathFile = new System.Windows.Forms.TextBox();
            this.btnPathSelect = new System.Windows.Forms.Button();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.tBAllText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPathCaption
            // 
            this.lblPathCaption.AutoSize = true;
            this.lblPathCaption.Location = new System.Drawing.Point(51, 42);
            this.lblPathCaption.Name = "lblPathCaption";
            this.lblPathCaption.Size = new System.Drawing.Size(89, 13);
            this.lblPathCaption.TabIndex = 0;
            this.lblPathCaption.Text = "Выберите файл:";
            // 
            // tBPathFile
            // 
            this.tBPathFile.Location = new System.Drawing.Point(146, 39);
            this.tBPathFile.Name = "tBPathFile";
            this.tBPathFile.Size = new System.Drawing.Size(428, 20);
            this.tBPathFile.TabIndex = 1;
            // 
            // btnPathSelect
            // 
            this.btnPathSelect.Location = new System.Drawing.Point(599, 37);
            this.btnPathSelect.Name = "btnPathSelect";
            this.btnPathSelect.Size = new System.Drawing.Size(75, 23);
            this.btnPathSelect.TabIndex = 2;
            this.btnPathSelect.Text = "Обзор...";
            this.btnPathSelect.UseVisualStyleBackColor = true;
            this.btnPathSelect.Click += new System.EventHandler(this.btnPathSelect_Click);
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(729, 24);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(158, 52);
            this.btnStartProcess.TabIndex = 3;
            this.btnStartProcess.Text = "Поехали...";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // tBAllText
            // 
            this.tBAllText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAllText.Location = new System.Drawing.Point(12, 98);
            this.tBAllText.Multiline = true;
            this.tBAllText.Name = "tBAllText";
            this.tBAllText.Size = new System.Drawing.Size(916, 401);
            this.tBAllText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 508);
            this.Controls.Add(this.tBAllText);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.btnPathSelect);
            this.Controls.Add(this.tBPathFile);
            this.Controls.Add(this.lblPathCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "waw - text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathCaption;
        private System.Windows.Forms.TextBox tBPathFile;
        private System.Windows.Forms.Button btnPathSelect;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.TextBox tBAllText;
    }
}

