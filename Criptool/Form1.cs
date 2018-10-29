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
        public string namev = "Criptool v.1.0 Alpha by @jefersonrod - 10/2018";
        public static String strToEncrypt { get; set; }
        public static String salt { get; set; }
        public static String encrypted { get; set; }
        public static String str2encode { get; set; }
        public static String ascii2code { get; set; }

        public CriptForm1()
        {
            InitializeComponent();
            this.Text = namev;        
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

        public string str2encodeTb
        {
            get { return tbStrToEncode.Text; }
            set { tbStrToEncode.Text = value; }
        }
        public string ascii2codeTb
        {
            get { return tbASCIICodes.Text; }
            set { tbASCIICodes.Text = value; }
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

        private void btEncode_Click(object sender, EventArgs e)
        {
            str2encode = str2encodeTb;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str2encode);
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                ascii2code = ascii2code+" "+asciiBytes[i].ToString();
            }
            ascii2codeTb = ascii2code;


        }
        #endregion


    }
}
