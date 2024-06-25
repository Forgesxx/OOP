namespace Щоденник
{
    partial class NoteInteractionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.durationPicker = new System.Windows.Forms.DateTimePicker();
            this.venueBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.createOrEditButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.noteNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва події";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(147, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Час";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Опис";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Тривалість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Місце проведення";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(147, 109);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(147, 161);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(155, 20);
            this.timePicker.TabIndex = 8;
            this.timePicker.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // durationPicker
            // 
            this.durationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.durationPicker.Location = new System.Drawing.Point(147, 211);
            this.durationPicker.Name = "durationPicker";
            this.durationPicker.ShowUpDown = true;
            this.durationPicker.Size = new System.Drawing.Size(155, 20);
            this.durationPicker.TabIndex = 9;
            this.durationPicker.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // venueBox
            // 
            this.venueBox.Location = new System.Drawing.Point(51, 285);
            this.venueBox.Multiline = true;
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(251, 34);
            this.venueBox.TabIndex = 10;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(51, 368);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(251, 59);
            this.descriptionBox.TabIndex = 11;
            // 
            // createOrEditButton
            // 
            this.createOrEditButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createOrEditButton.Location = new System.Drawing.Point(200, 454);
            this.createOrEditButton.Name = "createOrEditButton";
            this.createOrEditButton.Size = new System.Drawing.Size(75, 23);
            this.createOrEditButton.TabIndex = 13;
            this.createOrEditButton.Text = "Зберегти";
            this.createOrEditButton.UseVisualStyleBackColor = true;
            this.createOrEditButton.Click += new System.EventHandler(this.createOrEditButton_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(72, 454);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Скасувати";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(48, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(18, 13);
            this.numberLabel.TabIndex = 14;
            this.numberLabel.Text = "№";
            // 
            // noteNumberLabel
            // 
            this.noteNumberLabel.AutoSize = true;
            this.noteNumberLabel.Location = new System.Drawing.Point(144, 9);
            this.noteNumberLabel.Name = "noteNumberLabel";
            this.noteNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.noteNumberLabel.TabIndex = 15;
            // 
            // NoteInteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 492);
            this.Controls.Add(this.noteNumberLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createOrEditButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.venueBox);
            this.Controls.Add(this.durationPicker);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NoteInteractionForm";
            this.Text = "Додати замітку";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteInteractionForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker durationPicker;
        private System.Windows.Forms.TextBox venueBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button createOrEditButton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label noteNumberLabel;
    }
}