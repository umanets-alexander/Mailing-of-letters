using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using OpenPop.Pop3; //устанавливается через консоль NuGet - Install-Package OpenPop.NET
using System.Threading;

namespace Mailing_of_letters
{
    public partial class MailingOfLetters : Form
    {
        public MailingOfLetters()
        {
            InitializeComponent();
        }

        // Обработчик сохранения в текстовый формат данных входа, для избегания вводить каждый раз логин и пароль
        private void save_mail_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("connect.txt", new string[] { e_mail.Text, pass.Text, mail_server.Text });
        }

        // При первичном запуске программы сначало проверяется наличие сохранений учётки и загружается автоматически из текстового файла
        private void MailingOfLetters_Load(object sender, EventArgs e)
        {
            string curFile = "connect.txt";
            if (File.Exists(curFile) == true)
            {
                e_mail.Text = Convert.ToString(File.ReadAllLines(curFile)[0]);
                pass.Text = Convert.ToString(File.ReadAllLines(curFile)[1]);
                mail_server.Text = Convert.ToString(File.ReadAllLines(curFile)[2]);
            }
        }

        // Адресаты указываются в текстовом типе
        private void addressees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                addressees.Text += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }

        // Обработчик рассылки письма
        private void send_out_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = addressees.Text;
            string[] split = s.Split('\n');
            foreach (string adr in split)
            {
                if (adr == "")
                {
                    continue;
                }
                MailMessage mail = new MailMessage(e_mail.Text, adr, theme.Text, msg.Text);
                SmtpClient client = new SmtpClient("smtp.mail.ru");
                client.Port = 25;
                client.Credentials = new System.Net.NetworkCredential(e_mail.Text, pass.Text);
                client.EnableSsl = true;
                Thread.Sleep(2000);
                i += 1;
                result_send_out.Visible = true;
                if (i == 1)
                {
                    result_send_out.Text = "Разослано 1 адресату";
                }
                else result_send_out.Text = "Разослано " + i + " адресатам";
                try
                {
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        // Подсчёт количества строк в адрессатах при изменении содержимого
        private void addressees_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            label8.Text = "Количество строк в адресатах: " + addressees.Lines.Length.ToString();
        }
    }
}
