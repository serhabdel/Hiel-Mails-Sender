# Hiel Mails Sender

Hiel Mails Sender is a Windows Forms application that allows users to send bulk emails easily and efficiently. It supports both Gmail and Outlook as email providers and includes features like attachment support and credential management.

## Features

- Send bulk emails to multiple recipients
- Support for Gmail and Outlook email providers
- Attachment functionality
- User credential management (save and load) => can reset and delete the user credentials by clicking on "Reset" Button
- Progress bar to track email sending progress
- Logging of sent emails

## Prerequisites

- .NET Framework (.Net 8 recommended)
- Windows operating system

## Setup

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio.
3. Build the solution to restore NuGet packages and compile the application.

## Usage

1. Launch the application.
2. Select your email provider (Gmail or Outlook).
3. Enter your email address and app password.
4. Input the recipient email addresses (comma-separated for multiple recipients).
5. Compose your email subject and body.
6. (Optional) Attach a file by clicking the "Attach File" button.
7. Click "Send Email" to start sending.

## Important Notes

- For Gmail and Outlook, you need to use an "App Password" instead of your regular account password. The application provides links to tutorials on how to set up app passwords for both providers.
- The application saves sent email details in a `sent_emails.csv` file for record-keeping.
- User credentials are saved in a `user_credentials.csv` file for convenience. Use the "Clear Credentials" button to remove saved credentials.

## Security Considerations

- The application stores email credentials locally. Ensure you're using this application on a secure, personal device.
- Always use app-specific passwords rather than your main account password.

## Contributing

Contributions to improve Hiel Mails Sender are welcome. Please feel free to fork the repository, make changes, and submit pull requests.



## Disclaimer

This tool is for legitimate bulk emailing purposes only. Users are responsible for complying with all applicable laws and regulations regarding bulk email sending.
