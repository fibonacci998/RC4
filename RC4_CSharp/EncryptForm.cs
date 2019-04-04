using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC4_CSharp
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePathOpen.Text = openFile.FileName;
                var lines = File.ReadLines(openFile.FileName);
                String line1=null, line2=null;
                foreach (var line in lines)
                {
                    if (line1 == null)
                    {
                        line1 = line;
                    }
                    else
                    {
                        line2 = line;
                    }
                }
                txtInput.Text = line1;
                txtKKey.Text = line2;
            }
            
        }
        string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
        string encrypt_main()
        {
            StringBuilder input = new StringBuilder(txtInput.Text);
            StringBuilder k = new StringBuilder(txtKKey.Text);

            char[] key = new char[input.Length];
            var s = new byte[256];
            var t = new byte[256];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = (byte)i;
                t[i] = (byte)k[i % (k.Length / 2)];
            }

            txtSKey.Text = ByteArrayToString(s);
            txtTKey.Text = ByteArrayToString(t);

            //KSA
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + s[i] + t[i]) % 256;
                byte temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            txtKeySchedule.Text = ByteArrayToString(s);
            //RPGA
            j = 0;
            for (int i = 0; i < input.Length;)
            {
                i++;
                j = (j + s[i]) % 256;
                byte temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                key[i - 1] = (char)(s[(int)(s[i] + s[j]) % 256]);
                input[i - 1] = (char)((byte)input[i - 1] ^ (byte)key[i - 1]);
            }
            txtKeyStream.Text = ByteArrayToString(s);
            txtKeyStreamRead.Text = txtKeyStream.Text;


            string result = input.ToString();
            return result;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string result = encrypt_main();
            txtOutput.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream s = File.Open(saveFile.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txtOutput.Text);
                }

            }
        }
    }
}
