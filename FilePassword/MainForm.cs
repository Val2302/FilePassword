using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilePassword.Cryptors;

namespace FilePassword
{
    public partial class MainForm : Form
    {
        public MainForm ( )
        {
            var text = "text";
            var password = "password";
            var encryptor = new Encryptor( password );
            var decryptor = new Decryptor( password );
            text = encryptor.EncryptLine( text );
            text = decryptor.DecryptLine( text );

            InitializeComponent( );
        }

        private void NewButton_Click ( object sender, EventArgs e )
        {

        }

        private void OpenButton_Click ( object sender, EventArgs e )
        {

        }

        private void SaveButton_Click ( object sender, EventArgs e )
        {

        }
    }
}
