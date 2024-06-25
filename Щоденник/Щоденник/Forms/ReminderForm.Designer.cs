namespace Щоденник
{
    partial class ReminderForm
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
            this.components = new System.ComponentModel.Container();
            this.reminderTable = new System.Windows.Forms.DataGridView();
            this.noteNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reminderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reminderTable
            // 
            this.reminderTable.AllowUserToAddRows = false;
            this.reminderTable.AllowUserToDeleteRows = false;
            this.reminderTable.AllowUserToResizeColumns = false;
            this.reminderTable.AllowUserToResizeRows = false;
            this.reminderTable.AutoGenerateColumns = false;
            this.reminderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reminderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteNumber,
            this.title,
            this.date,
            this.time,
            this.duration,
            this.venue,
            this.description,
            this.editButton,
            this.deleteButton});
            this.reminderTable.DataSource = this.noteBindingSource;
            this.reminderTable.Location = new System.Drawing.Point(12, 91);
            this.reminderTable.Name = "reminderTable";
            this.reminderTable.Size = new System.Drawing.Size(957, 150);
            this.reminderTable.TabIndex = 1;
            this.reminderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reminderTable_CellClick);
            // 
            // noteNumber
            // 
            this.noteNumber.HeaderText = "№";
            this.noteNumber.Name = "noteNumber";
            this.noteNumber.Width = 40;
            // 
            // title
            // 
            this.title.HeaderText = "Назва";
            this.title.Name = "title";
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // time
            // 
            this.time.HeaderText = "Час";
            this.time.Name = "time";
            this.time.Width = 70;
            // 
            // duration
            // 
            this.duration.HeaderText = "Тривалість";
            this.duration.Name = "duration";
            this.duration.Width = 70;
            // 
            // venue
            // 
            this.venue.HeaderText = "Місце події";
            this.venue.Name = "venue";
            // 
            // description
            // 
            this.description.HeaderText = "Опис";
            this.description.Name = "description";
            this.description.Width = 250;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Редагувати";
            this.editButton.Name = "editButton";
            this.editButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editButton.Text = "Редагувати";
            this.editButton.UseColumnTextForButtonValue = true;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "Видалити";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нагадування найближчих справ\r\n";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(882, 270);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Щоденник.Note);
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 305);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reminderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReminderForm";
            this.Text = "Нагадування";
            ((System.ComponentModel.ISupportInitialize)(this.reminderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reminderTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}