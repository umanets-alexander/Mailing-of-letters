namespace Mailing_of_letters
{
    partial class MailingOfLetters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailingOfLetters));
            this.panel1 = new System.Windows.Forms.Panel();
            this.save_mail = new System.Windows.Forms.Button();
            this.mail_server = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.result_send_out = new System.Windows.Forms.Label();
            this.send_out = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addressees = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.RichTextBox();
            this.theme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save_mail);
            this.panel1.Controls.Add(this.mail_server);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.e_mail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 46);
            this.panel1.TabIndex = 0;
            // 
            // save_mail
            // 
            this.save_mail.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_mail.Image = ((System.Drawing.Image)(resources.GetObject("save_mail.Image")));
            this.save_mail.Location = new System.Drawing.Point(866, 0);
            this.save_mail.Name = "save_mail";
            this.save_mail.Size = new System.Drawing.Size(46, 46);
            this.save_mail.TabIndex = 6;
            this.save_mail.UseVisualStyleBackColor = true;
            this.save_mail.Click += new System.EventHandler(this.save_mail_Click);
            // 
            // mail_server
            // 
            this.mail_server.Enabled = false;
            this.mail_server.FormattingEnabled = true;
            this.mail_server.Items.AddRange(new object[] {
            "mail.ru"});
            this.mail_server.Location = new System.Drawing.Point(738, 10);
            this.mail_server.Name = "mail_server";
            this.mail_server.Size = new System.Drawing.Size(111, 27);
            this.mail_server.TabIndex = 5;
            this.mail_server.Text = "mail.ru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сервер:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(435, 11);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(230, 26);
            this.pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(366, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // e_mail
            // 
            this.e_mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.e_mail.Location = new System.Drawing.Point(130, 11);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(230, 26);
            this.e_mail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почтовой ящик:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.result_send_out);
            this.panel2.Controls.Add(this.send_out);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 46);
            this.panel2.TabIndex = 1;
            // 
            // result_send_out
            // 
            this.result_send_out.AutoSize = true;
            this.result_send_out.Location = new System.Drawing.Point(161, 13);
            this.result_send_out.Name = "result_send_out";
            this.result_send_out.Size = new System.Drawing.Size(104, 19);
            this.result_send_out.TabIndex = 1;
            this.result_send_out.Text = "result_send_out";
            this.result_send_out.Visible = false;
            // 
            // send_out
            // 
            this.send_out.Location = new System.Drawing.Point(11, 5);
            this.send_out.Name = "send_out";
            this.send_out.Size = new System.Drawing.Size(135, 35);
            this.send_out.TabIndex = 0;
            this.send_out.Text = "Разослать";
            this.send_out.UseVisualStyleBackColor = true;
            this.send_out.Click += new System.EventHandler(this.send_out_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addressees);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(581, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 446);
            this.panel3.TabIndex = 2;
            // 
            // addressees
            // 
            this.addressees.Location = new System.Drawing.Point(6, 36);
            this.addressees.Name = "addressees";
            this.addressees.Size = new System.Drawing.Size(313, 404);
            this.addressees.TabIndex = 1;
            this.addressees.Text = "";
            this.addressees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressees_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Адресаты:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.msg);
            this.panel4.Controls.Add(this.theme);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 446);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Содержание:";
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(11, 97);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(564, 343);
            this.msg.TabIndex = 3;
            this.msg.Text = "";
            // 
            // theme
            // 
            this.theme.Location = new System.Drawing.Point(62, 36);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(513, 26);
            this.theme.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Тема:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Письмо";
            // 
            // MailingOfLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 538);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MailingOfLetters";
            this.Text = "Массовая рассылка писем";
            this.Load += new System.EventHandler(this.MailingOfLetters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save_mail;
        private System.Windows.Forms.ComboBox mail_server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button send_out;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox addressees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox msg;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_send_out;
    }
}

