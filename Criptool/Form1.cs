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
        public string strToEncryptTb
        {
            get { return tbStrToEncrypt.Text; }
            set { tbStrToEncrypt.Text = value; }
        }
        public string encryptedTb
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
            strToEncrypt = strToEncryptTb;
            if (!(string.IsNullOrEmpty(strToEncrypt)))
            {
                salt = salttb;
                String encryptstr = crypto.Encrypt.EncryptString(strToEncrypt, salt);
                encryptedTb = encryptstr;
            }else
            {
                MessageBox.Show("campo String to encrypt vazio");
            }
            
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            tbStrToEncrypt.Text = "";
            tbSalt.Text = "";
            tbEncrypted.Text = "";
            strToEncrypt = "";
            strToEncryptTb = "";
            encrypted = "";
            encryptedTb = "";
            salt = "";

        }

        private void btClearEncodeTab_Click(object sender, EventArgs e)
        {
            tbStrToEncode.Text = "";
            tbASCIICodes.Text = "";
            str2encode = "";
            str2encodeTb = "";
            ascii2code = "";
            ascii2codeTb = "";
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            encrypted = encryptedTb;
            if (!(string.IsNullOrEmpty(encrypted)))
            {
                
                salt = salttb;
                String decryptstr = crypto.Encrypt.DecryptString(encrypted, salt);
                strToEncryptTb = decryptstr;
            }else
            {
                MessageBox.Show("campo Encrypted vazio");
            }
            
        }

        private void btEncode_Click(object sender, EventArgs e)
        {
            str2encode = str2encodeTb;
            if (!(string.IsNullOrEmpty(str2encode)))
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(str2encode);
                for (int i = 0; i < asciiBytes.Length; i++)
                {
                    ascii2code = ascii2code + " " + asciiBytes[i].ToString();
                }
                ascii2codeTb = ascii2code;
            }else
            {
                MessageBox.Show("campo String to encode vazio");
            }


        }
        private void btDecode_Click(object sender, EventArgs e)
        {
            ascii2code = ascii2codeTb;
            ascii2code = ascii2code.Trim();
            if (!(string.IsNullOrEmpty(ascii2code)))
            {
                byte[] bytes = ascii2code.Split(' ').Select(s => Convert.ToByte(s)).ToArray();
                for (int i = 0; i < bytes.Length; i++)
                {
                    str2encode = str2encode + Convert.ToChar(bytes[i]).ToString();
                    str2encodeTb = str2encode;
                }
            }else
            {
                MessageBox.Show("campo ASCII Code vazio");
            }
        }
        #endregion


    }
}
