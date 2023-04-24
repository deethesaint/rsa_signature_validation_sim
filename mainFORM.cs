using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Numerics;
using System.Drawing.Text;
using System.Runtime.Remoting.Channels;
using System.Linq.Expressions;
using System.Globalization;

namespace RSA_Digital_Signature
{
    public partial class RSADigitalSignature : System.Windows.Forms.Form
    {
        public RSADigitalSignature()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormClosing += RSADigitalSignature_FormClosing;
        }

        private void RSADigitalSignature_Load(object sender, EventArgs e)
        {
            Alice_Hash_Button.Enabled = false;
            sign_Button.Enabled = false;
            Bob_Hash_button.Enabled = false;
            verify_Button.Enabled = false;
        }

        private void RSADigitalSignature_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            if (MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        RSACryptoServiceProvider rsa;
        RSAParameters privKey;
        RSAParameters pubKey;

        byte[] signature;

        byte[] senderBytes;
        byte[] receiverBytes;

        bool isKeyGenerated = false;

        private void keyGen_button_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider(512);
            privKey = new RSAParameters();
            pubKey = new RSAParameters();

            privKey = rsa.ExportParameters(true);
            pubKey = rsa.ExportParameters(false);

            byte[] _p = privKey.P;
            Array.Reverse(_p);
            BigInteger primeP = FromBigEndian(_p);

            //set the Q parameter
            byte[] _q = privKey.Q;
            Array.Reverse(_q);
            BigInteger primeQ = FromBigEndian(_q);

            //set the d parameter
            byte[] _d = privKey.D;
            Array.Reverse(_d);
            BigInteger privexponent = FromBigEndian(_d);

            //set the e parameter
            byte[] _e = privKey.Exponent;
            Array.Reverse(_e);
            BigInteger pubexponent = FromBigEndian(_e);

            //set the m parameter
            byte[] _m = privKey.Modulus;
            Array.Reverse(_m);
            BigInteger modulus = FromBigEndian(_m);

            p_textBox.Text = primeP.ToString();
            q_textBox.Text = primeQ.ToString();
            mod_textBox.Text = modulus.ToString();
            e_textBox.Text = pubexponent.ToString();
            d_textBox.Text = privexponent.ToString();
            phi_textBox.Text = ((primeP - 1) * (primeQ - 1)).ToString();

            priv_Param1.Text = mod_textBox.Text;
            priv_Param2.Text = e_textBox.Text;

            public_Param1.Text = mod_textBox.Text;
            public_Param2.Text = d_textBox.Text;

            isKeyGenerated = true;

            if (Alice_Hash_Button.Enabled)
                sign_Button.Enabled = true;
            if (Bob_Hash_button.Enabled)
                verify_Button.Enabled = true;

        }

        public static BigInteger FromBigEndian(byte[] p)
        {
            var q = p.Reverse();
            return new BigInteger((p[0] < 128 ? q : q.Concat(new byte[] { 0 })).ToArray());
        }

        private string Hash(byte[] input)
        {
            try
            {
                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    byte[] hash = sha1.ComputeHash(input);
                    StringBuilder sb = new StringBuilder(hash.Length * 2);

                    for (int i = 0; i < hash.Length; ++i)
                    {
                        sb.Append(hash[i].ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
            catch
            {
                return null;
            }
        }

        private void Alice_Hash_Button_Click(object sender, EventArgs e)
        {
            sender_SHA.Text = Hash(senderBytes);
            if (isKeyGenerated)
                sign_Button.Enabled = true;
        }

        private void Bob_Hash_button_Click(object sender, EventArgs e)
        {
            receiver_SHA.Text = Hash(receiverBytes);
            receiver_Sig.Text = sender_Sig.Text;
            if (isKeyGenerated)
                verify_Button.Enabled = true;
        }

        private void send_Alice_Button_Click(object sender, EventArgs e)
        {
            receiver_Sig.Text = sender_Sig.Text;
        }

        private void sign_Button_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] signedBytes;
                signedBytes = rsa.SignData(senderBytes, CryptoConfig.MapNameToOID("SHA1"));
                signature = signedBytes;
                sender_Sig.Text = Convert.ToBase64String(signedBytes);
            }
            catch
            {
                return;
            }
        }
        private void verify_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (RSACryptoServiceProvider verify_rsa = new RSACryptoServiceProvider())
                {
                    verify_rsa.ImportParameters(pubKey);

                    if (verify_rsa.VerifyData(receiverBytes, CryptoConfig.MapNameToOID("SHA1"), signature))
                    {
                        MessageBox.Show("Chữ ký đúng, dữ liệu Bob nhận là chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                    else
                    {
                        MessageBox.Show("Chữ ký sai, dữ liệu Bob nhận đã bị sửa đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                }
            }
            catch
            {
                return;
            }
        }
        
        private void sender_FileBrowse_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                senderBytes = File.ReadAllBytes(openFileDialog.FileName);
                sender_FileName_textBox.Text = openFileDialog.FileName;
                Alice_Hash_Button.Enabled = true;
                sign_Button.Enabled = false;
                sender_SHA.Text = string.Empty;
                sender_Sig.Text = string.Empty;
            }
        }

        private void receiver_FileBrowse_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                receiverBytes = File.ReadAllBytes(openFileDialog.FileName);
                receiver_FileName_textBox.Text = openFileDialog.FileName;
                Bob_Hash_button.Enabled = true;
                verify_Button.Enabled = false;
                receiver_SHA.Text = string.Empty;
            }
        }

    }
}
