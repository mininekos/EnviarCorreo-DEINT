using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreo_DEINT
{
    public partial class Form1 : Form
    {
        Attachment data;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(tbUsuario.Text);
                correo.To.Add(tbDestinatario.Text);
                correo.Subject = tbAsunto.Text;
                correo.Body = tbContenido.Text;
                if (data != null)
                {
                    correo.Attachments.Add(data);
                }
                correo.IsBodyHtml = false;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential(tbUsuario.Text, tbContrasenna.Text);

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Send(correo);

                MessageBox.Show("Correo Enviado");

                tbAsunto.Clear();
                tbContenido.Clear();
                tbDestinatario.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show("Algo ha salido mal");
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            data = new Attachment(filePath, MediaTypeNames.Application.Octet);
        }
    }
}
