
namespace MedicalCentre
{
    partial class VisitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.IncorrectPass = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ServicetextBox = new System.Windows.Forms.TextBox();
            this.CosttextBox = new System.Windows.Forms.TextBox();
            this.IncorrectService = new System.Windows.Forms.Label();
            this.IncorrectCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(294, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(391, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(12, 24);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(178, 27);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Дата посещения:";
            // 
            // DatetextBox
            // 
            this.DatetextBox.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatetextBox.Location = new System.Drawing.Point(211, 24);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(197, 31);
            this.DatetextBox.TabIndex = 3;
            this.DatetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatetextBox.TextChanged += new System.EventHandler(this.DatetextBox_TextChanged);
            // 
            // IncorrectPass
            // 
            this.IncorrectPass.AutoSize = true;
            this.IncorrectPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.IncorrectPass.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPass.Location = new System.Drawing.Point(211, 58);
            this.IncorrectPass.Name = "IncorrectPass";
            this.IncorrectPass.Size = new System.Drawing.Size(162, 18);
            this.IncorrectPass.TabIndex = 4;
            this.IncorrectPass.Text = "Некорректный ввод даты";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServiceLabel.Location = new System.Drawing.Point(12, 83);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(191, 27);
            this.ServiceLabel.TabIndex = 5;
            this.ServiceLabel.Text = "Оказанная услуга:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CostLabel.Location = new System.Drawing.Point(12, 142);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(190, 27);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Стоимость услуги:";
            // 
            // ServicetextBox
            // 
            this.ServicetextBox.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServicetextBox.Location = new System.Drawing.Point(211, 83);
            this.ServicetextBox.Name = "ServicetextBox";
            this.ServicetextBox.Size = new System.Drawing.Size(197, 31);
            this.ServicetextBox.TabIndex = 7;
            this.ServicetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CosttextBox
            // 
            this.CosttextBox.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CosttextBox.Location = new System.Drawing.Point(211, 142);
            this.CosttextBox.Name = "CosttextBox";
            this.CosttextBox.Size = new System.Drawing.Size(197, 31);
            this.CosttextBox.TabIndex = 8;
            this.CosttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncorrectService
            // 
            this.IncorrectService.AutoSize = true;
            this.IncorrectService.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.IncorrectService.ForeColor = System.Drawing.Color.Red;
            this.IncorrectService.Location = new System.Drawing.Point(211, 117);
            this.IncorrectService.Name = "IncorrectService";
            this.IncorrectService.Size = new System.Drawing.Size(102, 18);
            this.IncorrectService.TabIndex = 9;
            this.IncorrectService.Text = "Заполните поле";
            // 
            // IncorrectCost
            // 
            this.IncorrectCost.AutoSize = true;
            this.IncorrectCost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.IncorrectCost.ForeColor = System.Drawing.Color.Red;
            this.IncorrectCost.Location = new System.Drawing.Point(211, 176);
            this.IncorrectCost.Name = "IncorrectCost";
            this.IncorrectCost.Size = new System.Drawing.Size(193, 18);
            this.IncorrectCost.TabIndex = 10;
            this.IncorrectCost.Text = "Некорректный ввод стоимости";
            // 
            // VisitForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(514, 251);
            this.Controls.Add(this.IncorrectCost);
            this.Controls.Add(this.IncorrectService);
            this.Controls.Add(this.CosttextBox);
            this.Controls.Add(this.ServicetextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.IncorrectPass);
            this.Controls.Add(this.DatetextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление посещения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DatetextBox;
        private System.Windows.Forms.Label IncorrectPass;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ServicetextBox;
        private System.Windows.Forms.TextBox CosttextBox;
        private System.Windows.Forms.Label IncorrectService;
        private System.Windows.Forms.Label IncorrectCost;
    }
}