using Microsoft.Office.Interop.Outlook;
using System.Reflection;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csv;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hiel_Mails_Sender
{
    public partial class Main : Form
    {
        private string csvFilePath = "sent_emails.csv";

        public Main()
        {
            InitializeComponent();
            comboBox1.Text = "Gmail";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0 && progressBar1.Value < 100)
            {
                MessageBox.Show("Email sending is already in progress.");
                return;
            }

            string provider = comboBox1.SelectedItem?.ToString();
            string senderEmail = textBox4.Text;
            string appPassword = textBox5.Text;
            string recipients = textBox2.Text;
            string emailBody = textBox3.Text;

            if (string.IsNullOrWhiteSpace(provider) || string.IsNullOrWhiteSpace(senderEmail) ||
                string.IsNullOrWhiteSpace(appPassword) || string.IsNullOrWhiteSpace(recipients) ||
                string.IsNullOrWhiteSpace(emailBody))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string[] recipientList = recipients.Split(',').Select(r => r.Trim()).ToArray();

            SmtpClient smtpClient = null;
            if (provider == "Gmail")
            {
                smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(senderEmail, appPassword),
                    EnableSsl = true
                };
            }
            else if (provider == "Outlook")
            {
                smtpClient = new SmtpClient("smtp.office365.com", 587)
                {
                    Credentials = new NetworkCredential(senderEmail, appPassword),
                    EnableSsl = true
                };
            }
            else
            {
                MessageBox.Show("Please select a valid email provider.");
                return;
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = recipientList.Length;
            progressBar1.Value = 0;

            try
            {
                using (StreamWriter writer = new StreamWriter(csvFilePath, true))
                {
                    for (int i = 0; i < recipientList.Length; i++)
                    {
                        string recipient = recipientList[i];
                        MailMessage mail = new MailMessage
                        {
                            From = new MailAddress(senderEmail),
                            Subject = textBox6.Text,
                            Body = emailBody,
                            IsBodyHtml = false
                        };
                        mail.To.Add(recipient);

                        // Attachment Feature
                        if (!string.IsNullOrEmpty(textBox7.Text))
                        {
                            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(textBox7.Text);
                            mail.Attachments.Add(attachment);
                        }

                        await Task.Run(() => smtpClient.Send(mail));

                        progressBar1.Value = i + 1;
                        await Task.Delay(100);

                        string[] emailDetails = { DateTime.Now.ToString(), senderEmail, textBox6.Text, recipient, emailBody };
                        writer.WriteLine(string.Join(",", emailDetails));
                    }
                }

                MessageBox.Show("Emails sent successfully!");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error sending emails: {ex.Message}");
            }
            finally
            {
                smtpClient?.Dispose();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            textBox1.Text = text;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}