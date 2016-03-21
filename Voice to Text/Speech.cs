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

namespace Voice_to_Text
{
    public partial class Speech : Form
    {
        public Speech()
        {
            InitializeComponent();
        }

        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл для преобразования в текст.";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "файл звука (*.wav)|*.wav";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tBPathFile.Text = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Не могу прочитать файл с диска. Текс Ошибки: " + ex.Message);
                }
            }
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            string[] nameFile = tBPathFile.Text.Split('\\');
            String responseFromServer = GoogleVoice.GoogleSpeechRequest(tBPathFile.Text, @nameFile[nameFile.Length - 1]);
            string result = JSon.Parse(responseFromServer);
            if (!String.IsNullOrEmpty(result))
            {
                tBAllText.Text = result;
            }
            else
            {
                tBAllText.Text += String.Format("None");
            }
        }
    }
}
