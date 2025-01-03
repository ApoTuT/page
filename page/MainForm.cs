using System.Collections;
using System.Collections.Generic;

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
            userSetting.Text = "用户已选择：" + UserInput.pageNum + UserInput.memoryNum + UserInput.memoryNum + "快表" + UserInput.TLB;
        }

        public void setNum()
        {
            userSetting.Text = "用户已选择：" + UserInput.pageNum + UserInput.memoryNum + UserInput.memoryNum + "快表" + UserInput.TLB;
        }

        private string clean() {
            FIFO = null;
            LRU = null;
            OPT = null;
            input.Clear();
            return change();
        }
        private string change()
        {
            string result = "";
            string a = UserInput.address;
            int max = UserInput.memoryNum;
            int i;
            for (i = 0; i < max - 1; i++)
            {
                string ui;
                ui = a[i * 6].ToString();
                switch (ui)
                {
                    case "A":
                        ui = 10.ToString();
                        break;
                    case "B":
                        ui = 11.ToString();
                        break;
                    case "C":
                        ui = 12.ToString();
                        break;
                    case "D":
                        ui = 13.ToString();
                        break;
                    case "E":
                        ui = 14.ToString();
                        break;
                    case "F":
                        ui = 15.ToString();
                        break;
                }
                result += ui;
                input.Add(ui);
                result += ",";
            }
            result += a[i * 6];
            input.Add(a[i * 6]);
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            button = 1;
            string result = clean();
            FIFOPanel.BringToFront();
            if(FIFO == null)
            {
                Label label = new Label();
                label.Name = "FIFO";
                label.Top = 10;
                label.Left = 20;
                label.AutoSize = true;

                FIFOPanel.Controls.Add(label);
                Algorithm algorithm = new Algorithm();
                algorithm.list = input;
                algorithm.label = label;
                algorithm.MyPanel = FIFOPanel;
                FIFO = new Thread(new ThreadStart(algorithm.Algorithm_FIFO));
                FIFO.Start();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {
            if(FIFO != null || LRU != null || OPT != null) {
                MessageBox.Show("请等待当前算法结束");
                return;
            }
            else {
                settings settings = new settings();
                settings.Owner = this;
                settings.ShowDialog();
            }
        }
    }
}
