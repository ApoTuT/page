using System.Collections;

namespace page
{
    public partial class MainForm : Form
    {
        private int button = 0;
        private Thread FIFO = null;
        private Thread LRU = null;
        private Thread OPT = null;

        private ArrayList input = new ArrayList();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userSetting.Text = "用户已选择：" + UserInput.pageNum  + UserInput.memoryNum + UserInput.address + UserInput.memoryNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
