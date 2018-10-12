using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.Protocols;
using System.Net;


namespace ADAuth
{
    public partial class frmADAuth : Form
    {
        public frmADAuth()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                LdapConnection connection = new LdapConnection("juf.local");
                NetworkCredential credential = new NetworkCredential(edtUserName.Text, edtPassword.Text);
                connection.Credential = credential;
                connection.Bind();
                lblResult.Text = "Logged In";
            }
            catch (LdapException lexc)
            {
                string error = lexc.ServerErrorMessage;
                lblResult.Text = lexc.ServerErrorMessage;
            }
            catch (Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }
    }
}
