using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        BigInteger n, e_key, d_key;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = BigInteger.Parse(txtP.Text);
                BigInteger q = BigInteger.Parse(txtQ.Text);

                if (p == q) { MessageBox.Show("p và q không được giống nhau!"); return; }

                n = p * q;
                BigInteger phi = (p - 1) * (q - 1);

                e_key = ChooseE(phi);
                d_key = ModInverse(e_key, phi);

                txtPublicKey.Text = $"n = {n}, e = {e_key}";
                txtPrivateKey.Text = $"n = {n}, d = {d_key}";

                MessageBox.Show("Tạo khóa thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: Hãy nhập số nguyên tố p và q hợp lệ.\n" + ex.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Vui lòng tạo khóa trước!"); return; }

            string plainText = txtPlaintext.Text;
            List<string> cipherNumbers = new List<string>();

            foreach (char c in plainText)
            {
                BigInteger m = (int)c;

                if (m >= n)
                {
                    MessageBox.Show($"Lỗi: Ký tự '{c}' có giá trị {m} lớn hơn n={n}.\nHãy chọn số nguyên tố p, q lớn hơn.");
                    return;
                }

                BigInteger encryptedChar = BigInteger.ModPow(m, e_key, n);
                cipherNumbers.Add(encryptedChar.ToString());
            }

            txtCiphertext.Text = string.Join(",", cipherNumbers);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Vui lòng tạo khóa trước!"); return; }

            try
            {
                string cipherText = txtCiphertext.Text;
                string[] numbers = cipherText.Split(',');
                string decryptedText = "";

                foreach (string numStr in numbers)
                {
                    if (string.IsNullOrWhiteSpace(numStr)) continue;

                    BigInteger c = BigInteger.Parse(numStr.Trim());
                    BigInteger decryptedCharNum = BigInteger.ModPow(c, d_key, n);
                    decryptedText += (char)decryptedCharNum;
                }

                txtPlaintext.Text = decryptedText;
                MessageBox.Show("Giải mã xong: " + decryptedText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã: Định dạng bản mã không đúng.\n" + ex.Message);
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Vui lòng tạo khóa trước!"); return; }

            string message = txtPlaintext.Text;
            if (string.IsNullOrEmpty(message)) { MessageBox.Show("Hãy nhập nội dung cần ký vào ô Bản rõ."); return; }

            List<string> signatureNumbers = new List<string>();

            foreach (char c in message)
            {
                BigInteger m = (int)c;

                if (m >= n)
                {
                    MessageBox.Show("Lỗi: Khóa n quá nhỏ so với nội dung tin nhắn.");
                    return;
                }

                BigInteger s = BigInteger.ModPow(m, d_key, n);
                signatureNumbers.Add(s.ToString());
            }

            txtCiphertext.Text = string.Join(",", signatureNumbers);
            MessageBox.Show("Đã ký tên thành công!");
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Chưa có khóa công khai để xác minh!"); return; }
            if (string.IsNullOrEmpty(txtCiphertext.Text)) { MessageBox.Show("Không có chữ ký để xác minh."); return; }

            try
            {
                string signatureStr = txtCiphertext.Text;
                string originalMessage = txtPlaintext.Text;

                string[] numbers = signatureStr.Split(',');
                string decryptedSignature = "";

                foreach (string numStr in numbers)
                {
                    if (string.IsNullOrWhiteSpace(numStr)) continue;
                    BigInteger s = BigInteger.Parse(numStr.Trim());

                    BigInteger m_prime = BigInteger.ModPow(s, e_key, n);
                    decryptedSignature += (char)m_prime;
                }

                if (decryptedSignature == originalMessage)
                {
                    MessageBox.Show("CHỮ KÝ HỢP LỆ!\nThông điệp chính xác.", "Kết quả xác minh");
                }
                else
                {
                    MessageBox.Show($"CHỮ KÝ KHÔNG HỢP LỆ!\nNội dung từ chữ ký: {decryptedSignature}\nNội dung gốc: {originalMessage}", "Cảnh báo giả mạo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xác minh: " + ex.Message);
            }
        }

        private void btnSecureSend_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Vui lòng tạo khóa trước!"); return; }

            string message = txtPlaintext.Text;
            if (string.IsNullOrEmpty(message)) { MessageBox.Show("Hãy nhập nội dung cần gửi."); return; }

            try
            {
                List<string> signatureList = new List<string>();
                foreach (char c in message)
                {
                    BigInteger m = (int)c;
                    if (m >= n) { MessageBox.Show("Lỗi: Ký tự quá lớn so với n."); return; }
                    BigInteger s = BigInteger.ModPow(m, d_key, n);
                    signatureList.Add(s.ToString());
                }
                string signatureBlock = string.Join(",", signatureList);

                List<string> cipherList = new List<string>();
                foreach (char c in message)
                {
                    BigInteger m = (int)c;
                    BigInteger encryptedChar = BigInteger.ModPow(m, e_key, n);
                    cipherList.Add(encryptedChar.ToString());
                }
                string cipherBlock = string.Join(",", cipherList);

                string finalPackage = signatureBlock + "#" + cipherBlock;

                txtCiphertext.Text = finalPackage;
                MessageBox.Show("Đã Ký và Mã hóa thành công!\nGói tin bao gồm chữ ký và nội dung mật.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSecureReceive_Click(object sender, EventArgs e)
        {
            if (n == 0) { MessageBox.Show("Chưa có khóa!"); return; }
            if (string.IsNullOrEmpty(txtCiphertext.Text)) return;

            try
            {
                string package = txtCiphertext.Text;

                string[] parts = package.Split('#');
                if (parts.Length != 2)
                {
                    MessageBox.Show("Gói tin sai định dạng (Thiếu chữ ký hoặc nội dung).");
                    return;
                }

                string signatureBlock = parts[0];
                string cipherBlock = parts[1];

                string[] cipherNumbers = cipherBlock.Split(',');
                string decryptedMessage = "";
                foreach (string numStr in cipherNumbers)
                {
                    if (string.IsNullOrWhiteSpace(numStr)) continue;
                    BigInteger c = BigInteger.Parse(numStr.Trim());
                    BigInteger m = BigInteger.ModPow(c, d_key, n);
                    decryptedMessage += (char)m;
                }

                txtPlaintext.Text = decryptedMessage;

                string[] signatureNumbers = signatureBlock.Split(',');
                string verifiedSignature = "";
                foreach (string numStr in signatureNumbers)
                {
                    if (string.IsNullOrWhiteSpace(numStr)) continue;
                    BigInteger s = BigInteger.Parse(numStr.Trim());
                    BigInteger v = BigInteger.ModPow(s, e_key, n);
                    verifiedSignature += (char)v;
                }

                if (decryptedMessage == verifiedSignature)
                {
                    MessageBox.Show("TUYỆT VỜI!\n\n1. Nội dung đã được giải mã an toàn.\n2. Chữ ký xác thực ĐÚNG là của người gửi.", "Kết quả kiểm tra");
                }
                else
                {
                    MessageBox.Show("CẢNH BÁO!\n\nGiải mã được nội dung nhưng Chữ ký KHÔNG khớp.\nCó thể dữ liệu đã bị sửa đổi!", "Kết quả kiểm tra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý gói tin: " + ex.Message);
            }
        }

        private BigInteger ChooseE(BigInteger phi)
        {
            BigInteger e = 65537;
            if (e >= phi) e = 3;

            while (BigInteger.GreatestCommonDivisor(e, phi) != 1)
            {
                e += 2;
            }
            return e;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;
            if (m == 1) return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0) x += m0;

            return x;
        }
    }
}
