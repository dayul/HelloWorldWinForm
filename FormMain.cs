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

namespace HelloWorldWinForm
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "쾅!";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorld정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 모달창 : 자식 폼에서 다른 폼의 작업을 수행할 수 없다.
            Form formAbout1 = new FormAbout();
            formAbout1.Text = "모달창(Modal)";
            formAbout1.ShowDialog();

            // 모달리스창 : 자식 폼이 생성되어 있어도 다른 폼의 작업을 수행할 수 있다.
            Form formAbout2 = new Form();
            formAbout2.Text = "모달리스창(Modeless)";
            formAbout2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트파일(*.txt)|*.txt|CSV 파일(*.csv)|*.csv";

            DialogResult result = openFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    // textBox1.Text = openFileDialog.FileName;
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("취소했습니다.");
                    break;
                    
            }
        }
    }
}
