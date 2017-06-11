using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace Nation1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new System.Net.Mail.MailMessage();
                string fromEmail = "sejesoo@gmail.com";
                string password = "sejesooreneile";
                string toEmail = "sjsore001@myuct.ac.za";
                message.From = new MailAddress(fromEmail);
                message.To.Add(toEmail);
                message.Subject = "Customer Feedback";

                string fullmessage = "From: " + FirstName.Text + " " + LastName.Text + "\n" +
                    "Email: " + Email.Text + "\n" +
                    "Contact Number: " + ContactNumber.Text + "\n" +
                    "Message: " + Message.Text;

                message.Body = fullmessage;

                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                    smtpClient.Send(message.From.ToString(), message.To.ToString(), message.Subject, message.Body);

                    Sent.Text = "Email sucessfully sent - Thank You";
                }
            }
            catch (Exception ex)
            {
                Sent.Text = "Send Email Failed. Error: " + ex.Message;
            }
        }

        protected void Reset(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            ContactNumber.Text = "";
            Message.Text = "";
            Sent.Text = "";


        }

    }
}
