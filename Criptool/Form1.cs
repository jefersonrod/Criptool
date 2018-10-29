using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Criptool
{
    public partial class CriptForm1 : Form
    {
        //declare vars
        public static String strToEncrypt { get; set; }
        public static String salt { get; set; }
        public static String encrypted { get; set; }

        public CriptForm1()
        {
            InitializeComponent();            
        }
        #region Functions
        public string stringToEncrypt
        {
            get { return tbStrToEncrypt.Text; }
            set { tbStrToEncrypt.Text = value; }
        }
        public string encryptedString
        {
            get { return tbEncrypted.Text; }
            set { tbEncrypted.Text = value; }
        }
        
        public string salttb
        {
            get { return tbSalt.Text; }
            set { tbSalt.Text = value; }
        }        

        #endregion

        #region Buttons
        private void btEncrypt_Click(object sender, EventArgs e)
        {
            strToEncrypt = stringToEncrypt;
            salt = salttb;
            String encryptstr = crypto.Encrypt.EncryptString(strToEncrypt, salt);
            encryptedString = encryptstr;
        }

        #endregion

        private void btClearAll_Click(object sender, EventArgs e)
        {
            tbStrToEncrypt.Text = "";
            tbSalt.Text = "";
            tbEncrypted.Text = "";
        }

        private void btClearEncodeTab_Click(object sender, EventArgs e)
        {
            tbStrToEncode.Text = "";
            tbASCIICodes.Text = "";
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            encrypted = encryptedString;
            salt = salttb;
            String decryptstr = crypto.Encrypt.DecryptString(encrypted, salt);
            stringToEncrypt = decryptstr;
        }
    }
}
