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

        private const string FILE_DEFAULT_NAME = "제목 없음";
        private const string FILENAME_FILTER = "텍스트파일(*.txt)|*.txt|CSV 파일(*.csv)|*.csv";
        private const string TEXTBOX_DEFAULT_MESSAGE = "뭔가 입력하세요";
        private const string FILE_MODIFY_SYMBOL = "⁂";
        private string ORIGINAL_FILE_CONTENT = "";

        public FormMain()
        {
            InitializeComponent();

            // 초기화 코드
            lblFileName.Text = FILE_DEFAULT_NAME;
            textBox1.Text = TEXTBOX_DEFAULT_MESSAGE;
            lblModify.Text = "";
            ORIGINAL_FILE_CONTENT = textBox1.Text;
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

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FILENAME_FILTER;

            DialogResult result = openFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    // textBox1.Text = openFileDialog.FileName;
                    lblFileName.Text = openFileDialog.FileName;
                    var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        textBox1.Text = reader.ReadToEnd();
                        lblModify.Text = "";
                        ORIGINAL_FILE_CONTENT = textBox1.Text;
                        lblModify.Text = "";
                        ORIGINAL_FILE_CONTENT = textBox1.Text;
                    }
                    fileStream.Close();
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("취소했습니다.");
                    break;
                    
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lblFileName.Text == FILE_DEFAULT_NAME)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = FILENAME_FILTER;
                DialogResult result = saveFileDialog.ShowDialog();

                if (DialogResult == DialogResult.Cancel)
                {
                    return;
                }
                lblFileName.Text = saveFileDialog.FileName;
            }

            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
                lblModify.Text = "";
                ORIGINAL_FILE_CONTENT = textBox1.Text;
            }
            
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILENAME_FILTER;
            saveFileDialog.FileName = lblFileName.Text;
            DialogResult result = saveFileDialog.ShowDialog();

            if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
            lblFileName.Text = saveFileDialog.FileName;
            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
            }
             private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == FILE_DEFAULT_NAME)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = FILENAME_FILTER;
                DialogResult result = saveFileDialog.ShowDialog();

                if (DialogResult == DialogResult.Cancel)
                {
                    return;
                }
                lblFileName.Text = saveFileDialog.FileName;
            }

            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
                lblModify.Text = "";
                ORIGINAL_FILE_CONTENT = textBox1.Text;
            }

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILENAME_FILTER;
            saveFileDialog.FileName = lblFileName.Text;
            DialogResult result = saveFileDialog.ShowDialog();

            if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
            lblFileName.Text = saveFileDialog.FileName;
            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
                lblModify.Text = "";
                ORIGINAL_FILE_CONTENT = textBox1.Text;
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 이터널 코드, 매직 넘버는 상수로 선언하기
            textBox1.Text = TEXTBOX_DEFAULT_MESSAGE;
            lblFileName.Text = FILE_DEFAULT_NAME;
            lblModify.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != ORIGINAL_FILE_CONTENT)
            {
                lblModify.Text = FILE_MODIFY_SYMBOL;
            }
            else
            {
                lblModify.Text = "";
            }

        }

        //private void statusStrip1_TextChanged(object sender, EventArgs e)
        //{
        //    //lblModify.Text = FILE_MODIFY_SYMBOL;
        //}
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lblFileName.Text == FILE_DEFAULT_NAME)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = FILENAME_FILTER;
                DialogResult result = saveFileDialog.ShowDialog();

                if (DialogResult == DialogResult.Cancel)
                {
                    return;
                }
                lblFileName.Text = saveFileDialog.FileName;
            }

            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
                lblModify.Text = "";
                ORIGINAL_FILE_CONTENT = textBox1.Text;
            }
            
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILENAME_FILTER;
            saveFileDialog.FileName = lblFileName.Text;
            DialogResult result = saveFileDialog.ShowDialog();

            if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
            lblFileName.Text = saveFileDialog.FileName;
            var fileStream = new FileStream(lblFileName.Text, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(textBox1.Text);
                writer.Close();
                lblModify.Text = "";
                ORIGINAL_FILE_CONTENT = textBox1.Text;
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 이터널 코드, 매직 넘버는 상수로 선언하기
            textBox1.Text = TEXTBOX_DEFAULT_MESSAGE;
            lblFileName.Text = FILE_DEFAULT_NAME;
            lblModify.Text = "";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != ORIGINAL_FILE_CONTENT)
            {
                lblModify.Text = FILE_MODIFY_SYMBOL;
            }
            else
            {
                lblModify.Text = "";
            }
            
        }

        //private void statusStrip1_TextChanged(object sender, EventArgs e)
        //{
        //    //lblModify.Text = FILE_MODIFY_SYMBOL;
        //}
}
}
