
namespace MedicalCentre
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPatButton = new System.Windows.Forms.Button();
            this.DeletePatButton = new System.Windows.Forms.Button();
            this.VisitsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddVisButton = new System.Windows.Forms.Button();
            this.DelVisButton = new System.Windows.Forms.Button();
            this.AboveVisitLabel = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.AllowUserToAddRows = false;
            this.PatientsGrid.AllowUserToDeleteRows = false;
            this.PatientsGrid.AllowUserToOrderColumns = true;
            this.PatientsGrid.AllowUserToResizeColumns = false;
            this.PatientsGrid.AllowUserToResizeRows = false;
            this.PatientsGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.PatientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsGrid.Location = new System.Drawing.Point(50, 70);
            this.PatientsGrid.MultiSelect = false;
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.ReadOnly = true;
            this.PatientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientsGrid.RowHeadersVisible = false;
            this.PatientsGrid.RowTemplate.Height = 25;
            this.PatientsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PatientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsGrid.Size = new System.Drawing.Size(450, 286);
            this.PatientsGrid.TabIndex = 1;
            this.PatientsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsGrid_RowEnter);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 300F;
            this.Column1.HeaderText = "Имя пациента";
            this.Column1.MaxInputLength = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Стоимость услуг";
            this.Column2.MaxInputLength = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // AddPatButton
            // 
            this.AddPatButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPatButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPatButton.Image")));
            this.AddPatButton.Location = new System.Drawing.Point(50, 362);
            this.AddPatButton.Name = "AddPatButton";
            this.AddPatButton.Size = new System.Drawing.Size(220, 27);
            this.AddPatButton.TabIndex = 2;
            this.AddPatButton.Text = "Добавить пациента";
            this.AddPatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddPatButton.UseVisualStyleBackColor = false;
            this.AddPatButton.Click += new System.EventHandler(this.AddPatButton_Click);
            // 
            // DeletePatButton
            // 
            this.DeletePatButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeletePatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePatButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletePatButton.Image")));
            this.DeletePatButton.Location = new System.Drawing.Point(282, 362);
            this.DeletePatButton.Name = "DeletePatButton";
            this.DeletePatButton.Size = new System.Drawing.Size(220, 27);
            this.DeletePatButton.TabIndex = 3;
            this.DeletePatButton.Text = "Удалить пациента";
            this.DeletePatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeletePatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeletePatButton.UseVisualStyleBackColor = false;
            this.DeletePatButton.Click += new System.EventHandler(this.DeletePatButton_Click);
            // 
            // VisitsGrid
            // 
            this.VisitsGrid.AllowUserToAddRows = false;
            this.VisitsGrid.AllowUserToDeleteRows = false;
            this.VisitsGrid.AllowUserToOrderColumns = true;
            this.VisitsGrid.AllowUserToResizeColumns = false;
            this.VisitsGrid.AllowUserToResizeRows = false;
            this.VisitsGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.VisitsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisitsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VisitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisitsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.VisitsGrid.Location = new System.Drawing.Point(525, 70);
            this.VisitsGrid.MultiSelect = false;
            this.VisitsGrid.Name = "VisitsGrid";
            this.VisitsGrid.ReadOnly = true;
            this.VisitsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VisitsGrid.RowHeadersVisible = false;
            this.VisitsGrid.RowTemplate.Height = 25;
            this.VisitsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VisitsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisitsGrid.Size = new System.Drawing.Size(330, 286);
            this.VisitsGrid.TabIndex = 4;
            this.VisitsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitsGrid_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата посещения";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид услуги";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость услуги";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // AddVisButton
            // 
            this.AddVisButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddVisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVisButton.Image = ((System.Drawing.Image)(resources.GetObject("AddVisButton.Image")));
            this.AddVisButton.Location = new System.Drawing.Point(525, 362);
            this.AddVisButton.Name = "AddVisButton";
            this.AddVisButton.Size = new System.Drawing.Size(160, 27);
            this.AddVisButton.TabIndex = 5;
            this.AddVisButton.Text = "Добавить посещение";
            this.AddVisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddVisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddVisButton.UseVisualStyleBackColor = false;
            this.AddVisButton.Click += new System.EventHandler(this.AddVisButton_Click);
            // 
            // DelVisButton
            // 
            this.DelVisButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DelVisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelVisButton.Image = ((System.Drawing.Image)(resources.GetObject("DelVisButton.Image")));
            this.DelVisButton.Location = new System.Drawing.Point(695, 362);
            this.DelVisButton.Name = "DelVisButton";
            this.DelVisButton.Size = new System.Drawing.Size(160, 27);
            this.DelVisButton.TabIndex = 6;
            this.DelVisButton.Text = "Удалить посещение";
            this.DelVisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelVisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DelVisButton.UseVisualStyleBackColor = false;
            this.DelVisButton.Click += new System.EventHandler(this.DelVisButton_Click);
            // 
            // AboveVisitLabel
            // 
            this.AboveVisitLabel.AutoSize = true;
            this.AboveVisitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboveVisitLabel.Location = new System.Drawing.Point(525, 32);
            this.AboveVisitLabel.Name = "AboveVisitLabel";
            this.AboveVisitLabel.Size = new System.Drawing.Size(0, 22);
            this.AboveVisitLabel.TabIndex = 7;
            // 
            // ofd
            // 
            this.ofd.Filter = "Медицинский Центр |*.gaa |Все файлы |*.*";
            // 
            // sfd
            // 
            this.sfd.Filter = "Медицинский Центр |*.gaa |Все файлы |*.*";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(50, 22);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 32);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.Location = new System.Drawing.Point(160, 22);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(98, 32);
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalCostLabel.Location = new System.Drawing.Point(50, 402);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(425, 22);
            this.TotalCostLabel.TabIndex = 10;
            this.TotalCostLabel.Text = "Суммарная стоимость услуг по медицинскому центру: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AboveVisitLabel);
            this.Controls.Add(this.DelVisButton);
            this.Controls.Add(this.AddVisButton);
            this.Controls.Add(this.VisitsGrid);
            this.Controls.Add(this.DeletePatButton);
            this.Controls.Add(this.AddPatButton);
            this.Controls.Add(this.PatientsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Медицинский Центр №42/12";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button AddPatButton;
        private System.Windows.Forms.Button DeletePatButton;
        private System.Windows.Forms.DataGridView VisitsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button AddVisButton;
        private System.Windows.Forms.Button DelVisButton;
        private System.Windows.Forms.Label AboveVisitLabel;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label TotalCostLabel;
    }
}

