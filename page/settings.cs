using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            whetherUseTLB.Checked = UserInput.TLB;
            pageNumInput.Text = UserInput.pageNum.ToString();
            memoryPageNumInput.Text = UserInput.memoryNum.ToString();
            address.Text = UserInput.address;
            memoryTimeInput.Text = UserInput.timeOfMemory.ToString();
            TLBTimeInput.Text = UserInput.timeOfTLB.ToString();
            pageTimeIput.Text = UserInput.timeOfBreak.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;
            UserInput.pageNum = Convert.ToInt32(pageNumInput.Text);
            UserInput.memoryNum = Convert.ToInt32(memoryPageNumInput.Text);
            UserInput.address = Convert.ToString(address.Text);
            UserInput.timeOfMemory = Convert.ToInt32(memoryTimeInput.Text);
            UserInput.timeOfTLB = Convert.ToInt32(TLBTimeInput.Text);
            UserInput.timeOfBreak = Convert.ToInt32(pageTimeIput.Text);
            form.setNum();
            this.Close();
        }

        private void whetherUseTLB_CheckedChanged(object sender, EventArgs e)
        {
            UserInput.TLB = !UserInput.TLB;
        }
    }
}
