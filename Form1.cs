using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Hiel_Mails_Sender
{
    public partial class Main : Form
    {
        private string sentEmailsFilePath = "sent_emails.csv";
        private string credentialsFilePath = "user_credentials.csv";
        private string attachedFilePath = string.Empty;

        public Main()
        {
            InitializeComponent();
            comboBox1.Text = "Gmail";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCredentials();
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

            SaveCredentials(senderEmail, appPassword);

            string htmlEmailBody = $"<html><body style='font-size:14px;line-height=1.5;'>{emailBody}</body></html>";
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
                using (StreamWriter writer = new StreamWriter(sentEmailsFilePath, true))
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
                        if (!string.IsNullOrEmpty(attachedFilePath))
                        {
                            Attachment attachment = new Attachment(attachedFilePath);
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
            // Placeholder for potential future use
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create and show the OpenFileDialog
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Select a file to attach";
                openFileDialog1.Filter = "All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path selected by the user
                    attachedFilePath = openFileDialog1.FileName;
                    MessageBox.Show($"File attached: {attachedFilePath}");
                    textBox7.Text = attachedFilePath;
                }
            }
        }

        private void btnClearCredentials_Click(object sender, EventArgs e)
        {
            File.Delete(credentialsFilePath);
            MessageBox.Show("User credentials have been cleared.");
        }

        private void SaveCredentials(string email, string password)
        {
            using (StreamWriter writer = new StreamWriter(credentialsFilePath, false))
            {
                writer.WriteLine($"{email},{password}");
            }
        }

        private void LoadCredentials()
        {
            if (File.Exists(credentialsFilePath))
            {
                string[] lines = File.ReadAllLines(credentialsFilePath);
                if (lines.Length > 0)
                {
                    string[] credentials = lines[0].Split(',');
                    if (credentials.Length == 2)
                    {
                        textBox4.Text = credentials[0];
                        textBox5.Text = credentials[1];
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string prov = comboBox1.Text;
            if (prov == "Gmail")
            {
                OpenUrl("https://www.youtube.com/watch?v=hXiPshHn9Pw");
            }
            else if (prov == "Outlook")
            {
                OpenUrl("https://www.youtube.com/watch?v=5ukSRLRDQIw");
            }
            else
            {
                MessageBox.Show("Please select a valid email provider.");
            }
        }

        private void OpenUrl(string url)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
