using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSTAGONDERME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("karakaya050@gmail.com");
            ePosta.To.Add(txbKime.Text);
            ePosta.Subject = txbKonu.Text;
            ePosta.Body = txbIcerik.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new SmtpClient();
            smtp.Credentials = new NetworkCredential("karakaya050@gmail.com", "123456");
            smtp.Port = 587;
            smtp.Host = "mail.karakaya050.com";
            smtp.Send(ePosta);
            btnGonder.Text = "E posta Başarıyla Gönderildi";
        }
    }
}
