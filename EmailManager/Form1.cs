using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailManager
{
    public partial class Form1 : Form
    {
        MailAddress from;
        MailAddress to;
        MailMessage mess;
        SmtpClient client;
        string login;
        string password;
        int port;
        string server;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            from = new MailAddress("snegovoyzhenya@gmail.com");
            login = "f15be3791730e7";
            password = "4a6012115a81e5";
            port = 2525;
            server = "sandbox.smtp.mailtrap.io";
            client = new SmtpClient(server, port);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(login, password);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                to = new MailAddress(ToField.Text);
                mess = new MailMessage(from, to);
                mess.Subject = SubjectField.Text;
                mess.Body = MessageField.Text;
                client.Send(mess);
                MessageBox.Show("Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
// ТЕСТОВАЯ ВЕРСИЯ
