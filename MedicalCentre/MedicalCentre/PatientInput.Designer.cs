
namespace MedicalCentre
{
    partial class PatientInput
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
            this.PatientNameInput = new System.Windows.Forms.TextBox();
            this.PatientInputButton = new System.Windows.Forms.Button();
            this.UpperPanelInputForm = new System.Windows.Forms.Panel();
            this.XButton = new System.Windows.Forms.Label();
            this.UpperPanelInputForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientNameInput
            // 
            this.PatientNameInput.ForeColor = System.Drawing.Color.DarkGray;
            this.PatientNameInput.Location = new System.Drawing.Point(12, 40);
            this.PatientNameInput.Name = "PatientNameInput";
            this.PatientNameInput.Size = new System.Drawing.Size(304, 23);
            this.PatientNameInput.TabIndex = 1;
            this.PatientNameInput.TabStop = false;
            this.PatientNameInput.Text = "Введите имя пациента";
            this.PatientNameInput.Click += new System.EventHandler(this.PatientNameInput_Click);
            // 
            // PatientInputButton
            // 
            this.PatientInputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientInputButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatientInputButton.Location = new System.Drawing.Point(47, 80);
            this.PatientInputButton.Name = "PatientInputButton";
            this.PatientInputButton.Size = new System.Drawing.Size(221, 23);
            this.PatientInputButton.TabIndex = 2;
            this.PatientInputButton.Text = "Ввод";
            this.PatientInputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatientInputButton.UseVisualStyleBackColor = true;
            this.PatientInputButton.Click += new System.EventHandler(this.PatientInputButton_Click);
            // 
            // UpperPanelInputForm
            // 
            this.UpperPanelInputForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanelInputForm.Controls.Add(this.XButton);
            this.UpperPanelInputForm.Location = new System.Drawing.Point(0, 0);
            this.UpperPanelInputForm.Name = "UpperPanelInputForm";
            this.UpperPanelInputForm.Size = new System.Drawing.Size(328, 22);
            this.UpperPanelInputForm.TabIndex = 3;
            this.UpperPanelInputForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanelInputForm_MouseMove);
            // 
            // XButton
            // 
            this.XButton.AutoSize = true;
            this.XButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.XButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XButton.Location = new System.Drawing.Point(309, 0);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(19, 22);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            this.XButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XButton_MouseDown);
            // 
            // PatientInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 115);
            this.Controls.Add(this.UpperPanelInputForm);
            this.Controls.Add(this.PatientInputButton);
            this.Controls.Add(this.PatientNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PatientInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пациента";
            this.Click += new System.EventHandler(this.PatientInput_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientInput_KeyDown);
            this.UpperPanelInputForm.ResumeLayout(false);
            this.UpperPanelInputForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientNameInput;
        private System.Windows.Forms.Button PatientInputButton;
        private System.Windows.Forms.Panel UpperPanelInputForm;
        private System.Windows.Forms.Label XButton;
    }
}