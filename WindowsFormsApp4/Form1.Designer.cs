
using System;
using System.Windows.Forms;

namespace WindowsFormsApp4удалить
{
    partial class MainForm
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
            this.label_caption = new System.Windows.Forms.CheckBox();
            this.label_university = new System.Windows.Forms.CheckBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.CheckBox();
            this.lebel_information = new System.Windows.Forms.CheckBox();
            this.label_start = new System.Windows.Forms.CheckBox();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_caption
            // 
            this.label_caption.AutoSize = true;
            this.label_caption.Font = new System.Drawing.Font("Constantia", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_caption.ForeColor = System.Drawing.SystemColors.Info;
            this.label_caption.Location = new System.Drawing.Point(344, 9);
            this.label_caption.Name = "label_caption";
            this.label_caption.Size = new System.Drawing.Size(226, 59);
            this.label_caption.TabIndex = 0;
            this.label_caption.Text = "Деканат";
            this.label_caption.UseVisualStyleBackColor = true;
            this.label_caption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(381, 516);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(640, 17);
            this.label_university.TabIndex = 1;
            this.label_university.Text = "ФГБОУ ВО \"Сибирскй государственный университет имени М.Ф. Решетнева\" Лесосибирски" +
    "й филиал";
            this.label_university.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.lebel_information);
            this.panel_main.Controls.Add(this.label_start);
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 2;
            this.panel_main.MouseHover += new System.EventHandler(this.panel_main_MouseHover);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(758, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(117, 37);
            this.label_exit.TabIndex = 5;
            this.label_exit.Text = "Выход";
            this.label_exit.UseVisualStyleBackColor = true;
            this.label_exit.CheckedChanged += new System.EventHandler(this.label_exit_CheckedChanged);
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // lebel_information
            // 
            this.lebel_information.AutoSize = true;
            this.lebel_information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lebel_information.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lebel_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lebel_information.Location = new System.Drawing.Point(331, 12);
            this.lebel_information.Name = "lebel_information";
            this.lebel_information.Size = new System.Drawing.Size(213, 37);
            this.lebel_information.TabIndex = 4;
            this.lebel_information.Text = "Информация";
            this.lebel_information.UseVisualStyleBackColor = true;
            this.lebel_information.CheckedChanged += new System.EventHandler(this.lebel_information_CheckedChanged);
            this.lebel_information.MouseLeave += new System.EventHandler(this.lebel_information_MouseLeave);
            this.lebel_information.MouseHover += new System.EventHandler(this.lebel_information_MouseHover);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_start.Location = new System.Drawing.Point(25, 12);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(124, 37);
            this.label_start.TabIndex = 3;
            this.label_start.Text = "Запуск";
            this.label_start.UseVisualStyleBackColor = true;
            this.label_start.CheckedChanged += new System.EventHandler(this.label_start_CheckedChanged);
            this.label_start.MouseHover += new System.EventHandler(this.label_start_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApp4удалить.Properties.Resources.Безымянный;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Диалоговая программа \"Деканат\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nrmClosed);
            this.MouseHover += new System.EventHandler(this.MainForm_MouseHover);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nrmClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox label_caption;
        private System.Windows.Forms.CheckBox label_university;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.CheckBox label_start;
        private System.Windows.Forms.CheckBox lebel_information;
        private System.Windows.Forms.CheckBox label_exit;
    }
}

