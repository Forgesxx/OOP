namespace Щоденник.Forms
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reminderOffButton = new System.Windows.Forms.RadioButton();
            this.reminderOnButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfNotesToRemindNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.automaticOpeningLastFile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.automaticOpeningLastFileOff = new System.Windows.Forms.RadioButton();
            this.automaticOpeningLastFileOn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNotesToRemindNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нагадування";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reminderOffButton);
            this.panel1.Controls.Add(this.reminderOnButton);
            this.panel1.Location = new System.Drawing.Point(65, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 55);
            this.panel1.TabIndex = 1;
            // 
            // reminderOffButton
            // 
            this.reminderOffButton.AutoSize = true;
            this.reminderOffButton.Location = new System.Drawing.Point(3, 26);
            this.reminderOffButton.Name = "reminderOffButton";
            this.reminderOffButton.Size = new System.Drawing.Size(58, 17);
            this.reminderOffButton.TabIndex = 0;
            this.reminderOffButton.Text = "Вимкн";
            this.reminderOffButton.UseVisualStyleBackColor = true;
            // 
            // reminderOnButton
            // 
            this.reminderOnButton.AutoSize = true;
            this.reminderOnButton.Location = new System.Drawing.Point(3, 3);
            this.reminderOnButton.Name = "reminderOnButton";
            this.reminderOnButton.Size = new System.Drawing.Size(44, 17);
            this.reminderOnButton.TabIndex = 0;
            this.reminderOnButton.Text = "Вкл";
            this.reminderOnButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість записів у нагадуванні";
            // 
            // numberOfNotesToRemindNumeric
            // 
            this.numberOfNotesToRemindNumeric.Location = new System.Drawing.Point(65, 168);
            this.numberOfNotesToRemindNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberOfNotesToRemindNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfNotesToRemindNumeric.Name = "numberOfNotesToRemindNumeric";
            this.numberOfNotesToRemindNumeric.Size = new System.Drawing.Size(120, 20);
            this.numberOfNotesToRemindNumeric.TabIndex = 1;
            this.numberOfNotesToRemindNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfNotesToRemindNumeric.ValueChanged += new System.EventHandler(this.numberOfNotesToRemindNumeric_ValueChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(216, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Скасувати";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // automaticOpeningLastFile
            // 
            this.automaticOpeningLastFile.AutoSize = true;
            this.automaticOpeningLastFile.Location = new System.Drawing.Point(66, 225);
            this.automaticOpeningLastFile.Name = "automaticOpeningLastFile";
            this.automaticOpeningLastFile.Size = new System.Drawing.Size(219, 13);
            this.automaticOpeningLastFile.TabIndex = 6;
            this.automaticOpeningLastFile.Text = "Автоматичне відкриття останнього файлу";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.automaticOpeningLastFileOff);
            this.panel2.Controls.Add(this.automaticOpeningLastFileOn);
            this.panel2.Location = new System.Drawing.Point(69, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 50);
            this.panel2.TabIndex = 7;
            // 
            // automaticOpeningLastFileOff
            // 
            this.automaticOpeningLastFileOff.AutoSize = true;
            this.automaticOpeningLastFileOff.Location = new System.Drawing.Point(3, 26);
            this.automaticOpeningLastFileOff.Name = "automaticOpeningLastFileOff";
            this.automaticOpeningLastFileOff.Size = new System.Drawing.Size(58, 17);
            this.automaticOpeningLastFileOff.TabIndex = 2;
            this.automaticOpeningLastFileOff.Text = "Вимкн";
            this.automaticOpeningLastFileOff.UseVisualStyleBackColor = true;
            // 
            // automaticOpeningLastFileOn
            // 
            this.automaticOpeningLastFileOn.AutoSize = true;
            this.automaticOpeningLastFileOn.Location = new System.Drawing.Point(3, 3);
            this.automaticOpeningLastFileOn.Name = "automaticOpeningLastFileOn";
            this.automaticOpeningLastFileOn.Size = new System.Drawing.Size(44, 17);
            this.automaticOpeningLastFileOn.TabIndex = 2;
            this.automaticOpeningLastFileOn.Text = "Вкл";
            this.automaticOpeningLastFileOn.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(303, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.automaticOpeningLastFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberOfNotesToRemindNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Налаштування";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNotesToRemindNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton reminderOffButton;
        private System.Windows.Forms.RadioButton reminderOnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfNotesToRemindNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label automaticOpeningLastFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton automaticOpeningLastFileOff;
        private System.Windows.Forms.RadioButton automaticOpeningLastFileOn;
    }
}