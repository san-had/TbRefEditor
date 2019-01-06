using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using ScriptGeneration.Dto;
using ScriptGeneration.Extensibility;

namespace TbRefEditor
{
    public partial class Form1 : Form
    {
        private readonly IScriptGenerator scriptGenerator;

        private TextBox[] textBoxes;

        public Form1(IScriptGenerator scriptGenerator)
        {
            InitializeComponent();

            LoadConstants();

            LoadTextBoxArray();

            this.scriptGenerator = scriptGenerator;
        }

        private void LoadTextBoxArray()
        {
            textBoxes = new TextBox[]
            {
                txtReadingLong,
                txtReadingShort,
                txtListenLong,
                txtListenShort
            };
        }

        private void LoadConstants()
        {
            txtPreacher.Text = ConfigurationManager.AppSettings["preacher"];
            txtTitle.Text = ConfigurationManager.AppSettings["title"];

            lblReadingLong.Text = ConfigurationManager.AppSettings["lblReadingLong"];
            lblReadingShort.Text = ConfigurationManager.AppSettings["lblReadingShort"];
            lblListeningLong.Text = ConfigurationManager.AppSettings["lblListeningLong"];
            lblListeningShort.Text = ConfigurationManager.AppSettings["lblListeningShort"];
        }

        private InputDto LoadInputs()
        {
            var inputDto = new InputDto();
            inputDto.PreachDate = dpPreachDate.Value;
            inputDto.Lecture = txtBibel.Text.Replace(',', ':');
            inputDto.Textus = txtTextus.Text.Replace(',', ':');
            inputDto.Title = txtTitle.Text;
            inputDto.Preacher = txtPreacher.Text;
            return inputDto;
        }

        private void btnGenerateScript_Click(object sender, System.EventArgs e)
        {
            var inputDto = LoadInputs();

            var scriptDto = scriptGenerator.ScriptGeneration(inputDto);

            txtReadingLong.Text = scriptDto.ReadingLong;
            txtReadingShort.Text = scriptDto.ReadingShort;

            txtListenLong.Text = scriptDto.ListeningLong;
            txtListenShort.Text = scriptDto.ListeningShort;
        }

        private void btnCopyReadingLong_Click(object sender, System.EventArgs e)
        {
            TextBoxHandling(txtReadingLong);
        }

        private void btnCopyReadingShort_Click(object sender, System.EventArgs e)
        {
            TextBoxHandling(txtReadingShort);
        }

        private void btnCopyListenLong_Click(object sender, System.EventArgs e)
        {
            TextBoxHandling(txtListenLong);
        }

        private void btnCopyListenShort_Click(object sender, System.EventArgs e)
        {
            TextBoxHandling(txtListenShort);
        }

        private void TextBoxHandling(TextBox textBox)
        {
            textBox.Focus();
            textBox.Copy();
            SetBackColor(textBox);
        }

        private void SetBackColor(TextBox selectedTextBox)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (selectedTextBox.Name == textBoxes[i].Name)
                {
                    textBoxes[i].BackColor = Color.NavajoWhite;
                }
                else
                {
                    textBoxes[i].BackColor = Color.White;
                }
            }
        }
    }
}