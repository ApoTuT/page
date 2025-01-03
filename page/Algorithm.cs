using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;
namespace page
{
    internal class Algorithm
    {
        public Panel MyPanel;
        public ArrayList list;
        public Label label;
        private int TLB = UserInput.timeOfTLB + UserInput.timeOfMemory;
        private int TLBButMissingPage = UserInput.timeOfTLB + UserInput.timeOfMemory + UserInput.timeOfBreak + UserInput.timeOfTLB + UserInput.timeOfMemory + UserInput.timeOfMemory;
        private int WithoutTLB = UserInput.timeOfMemory * 2;
        private int WithoutTLBBuiMissingPage = UserInput.timeOfMemory + UserInput.timeOfBreak + UserInput.timeOfMemory * 2;

        public void Algorithm_FIFO()
        {
            Queue<int> q = new Queue<int>();
            int time = 0;
            int pageNum = UserInput.pageNum;
            int missingPageNum = 0;
            for (int i = 0; i <= list.Count; i++)//列数
            {
                bool fl = false;
                int b = 0;
                if (i != 0)
                {
                    String a = Convert.ToString(list[i - 1]);
                    b = Convert.ToInt32(a);
                    if (!q.Contains(b))
                    {
                        q.Enqueue(b);
                        missingPageNum++;
                        fl = true;
                    }
                }
                for (int j = 0; j < pageNum + 3; j++)//行数
                {
                    Label lab = new Label();
                    if (i == 0)
                    {
                        lab = StyleLable(lab, 1, i, j);
                        if (j == 0)
                        {
                            lab.Text = "访问序列";
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                      ));
                        }
                        else if (j <= pageNum)
                        {
                            lab.Text = "物理块" + j.ToString();
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                lab.Text = "是否缺页";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }
                            else
                            {
                                lab.Text = "缺页率";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }

                        }
                    }
                    else
                    {
                        lab = StyleLable(lab, 2, i, j);
                        if (q.Count > UserInput.pageNum)
                        {
                            q.Dequeue();
                        }
                        int[] num = q.ToArray();

                        if (j == 0)
                        {
                            lab.Text = Convert.ToString(list[i - 1]);
                        }
                        else if (j <= pageNum)
                        {
                            if (j <= q.Count)
                            {
                                //这里应该设置label的颜色
                                if (fl && num[j - 1] == b)
                                {
                                    lab.ForeColor = Color.Red;
                                }
                                lab.Text = num[j - 1].ToString();
                            }
                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                if (fl)
                                    lab.Text = "√";
                            }
                            else//缺页率的计算
                            {
                                //在label中显式缺页率，同时传给UserInput的静态变量。
                                double res = (double)missingPageNum / (double)(i) * 100;
                                lab.Text = ((double)(double)missingPageNum / (double)(i) * 100).ToString();
                                UserInput.FIFOArrayList.Add(res);
                            }
                        }
                        if (MyPanel.IsHandleCreated)
                        {
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.AutoScrollPosition = new Point(0, 0);
                                MyPanel.Controls.Add(lab);
                            }
                              ));
                        }

                    }
                }
                MyPanel.Invoke(new Action(() =>
                {
                    time = FlashTime("FIFO算法时间 ", fl, time);
                }
                   ));
                Sleep(TimeSpan.FromSeconds(1));

            }

        }

        public void Algorithm_LRU()
        {
            int time = 0;
            LinkedList<int> q = new LinkedList<int>();
            int missingPageNum = 0;
            int pageNum = UserInput.pageNum;
            int b = 0;
            for (int i = 0; i <= list.Count; i++)
            {
                bool fl = true;
                if (i != 0)
                {
                    String a = Convert.ToString(list[i - 1]);
                    b = Convert.ToInt32(a);

                    if (q.Contains(b))
                    {
                        fl = false;
                        q.Remove(b);
                    }
                    q.AddFirst(b);
                    if (fl)
                        missingPageNum++;

                }
                for (int j = 0; j < pageNum + 3; j++)
                {
                    Label lab = new Label();
                    if (i == 0)
                    {
                        lab = StyleLable(lab, 1, i, j);
                        if (j == 0)
                        {
                            lab.Text = "访问序列";
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                      ));
                        }
                        else if (j <= pageNum)
                        {
                            lab.Text = "物理块" + j.ToString();
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                      ));
                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                lab.Text = "是否缺页";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }
                            else
                            {
                                lab.Text = "缺页率";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }
                        }
                    }
                    else
                    {
                        lab = StyleLable(lab, 2, i, j);
                        if (q.Count > pageNum)
                        {
                            q.RemoveLast();
                        }
                        int[] num = q.ToArray();
                        if (j == 0)
                        {
                            lab.Text = Convert.ToString(list[i - 1]);
                        }
                        else if (j <= pageNum)
                        {
                            if (j <= q.Count)
                            {
                                if (fl && b == num[j - 1])
                                {
                                    lab.ForeColor = Color.Red;
                                }
                                lab.Text = num[j - 1].ToString();
                            }

                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                if (fl)
                                    lab.Text = "√";
                            }
                            else
                            {
                                double res = (double)missingPageNum / (double)(i) * 100;
                                lab.Text = ((double)(double)missingPageNum / (double)(i) * 100).ToString();
                                UserInput.LRUArrayList.Add(res);
                            }
                        }
                        if (MyPanel.IsHandleCreated)
                        {
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.AutoScrollPosition = new Point(0, 0);
                                MyPanel.Controls.Add(lab);
                            }
                              ));
                        }
                    }

                }
                MyPanel.Invoke(new Action(() =>
                {
                    time = FlashTime("LRU算法时间 ", fl, time);
                }
             ));
                Sleep(TimeSpan.FromSeconds(1));
            }
        }

        public void Algorithm_OPT()
        {
            LinkedList<int> q = new LinkedList<int>();
            int missingPageNum = 0;
            int time = 0;
            int b = 0;
            int pageNum = UserInput.pageNum;
            for (int i = 0; i <= list.Count; i++)
            {
                bool fl = true;
                if (i != 0)
                {
                    String a = Convert.ToString(list[i - 1]);
                    b = Convert.ToInt32(a);
                    if (q.Contains(b))
                    {
                        fl = false;
                    }
                    else
                    {
                        missingPageNum++;
                        if (q.Count == pageNum)
                        {
                            int[] nums = q.ToArray();
                            q.Remove(DeleteOpt(i - 1, nums));
                        }
                        q.AddFirst(b);
                    }

                }
                for (int j = 0; j < pageNum + 3; j++)
                {
                    Label lab = new Label();

                    if (i == 0)
                    {
                        lab = StyleLable(lab, 1, i, j);
                        if (j == 0)
                        {
                            lab.Text = "访问序列";
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else if (j <= pageNum)
                        {
                            lab.Text = "物理块" + j.ToString();
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.Controls.Add(lab);
                            }
                  ));
                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                lab.Text = "是否缺页";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }
                            else
                            {
                                lab.Text = "缺页率";
                                MyPanel.Invoke(new Action(() =>
                                {
                                    MyPanel.Controls.Add(lab);
                                }
                          ));
                            }
                        }
                    }
                    else
                    {
                        lab = StyleLable(lab, 2, i, j);
                        int[] num = q.ToArray();
                        if (j == 0)
                        {
                            lab.Text = Convert.ToString(list[i - 1]);
                        }
                        else if (j <= pageNum)
                        {
                            if (j <= q.Count)
                            {
                                if (fl && b == num[j - 1])
                                {
                                    lab.ForeColor = Color.Red;
                                }
                                lab.Text = num[j - 1].ToString();
                            }

                        }
                        else
                        {
                            if (j == pageNum + 1)
                            {
                                if (fl)
                                    lab.Text = "√";
                            }
                            else//缺页率的计算
                            {
                                double res = (double)missingPageNum / (double)(i) * 100;
                                lab.Text = ((double)(double)missingPageNum / (double)(i) * 100).ToString();
                                UserInput.OPTArrayList.Add(res);
                            }
                        }
                        if (MyPanel.IsHandleCreated)
                        {
                            MyPanel.Invoke(new Action(() =>
                            {
                                MyPanel.AutoScrollPosition = new Point(0, 0);
                                MyPanel.Controls.Add(lab);
                            }
                          ));
                        }
                    }

                }
                MyPanel.Invoke(new Action(() =>
                {
                    time = FlashTime("OPT算法时间 ", fl, time);
                }
                 ));
                Sleep(TimeSpan.FromSeconds(1));
            }
        }

        private int FlashTime(String name, bool fl, int time)
        {

            if (UserInput.TLB)
            {
                if (fl)
                {
                    time += WithoutTLBBuiMissingPage;

                    label.Text = name + WithoutTLBBuiMissingPage.ToString() + "ns，总用时 " + time + "ns";

                }
                else
                {
                    time += TLB; ;
                    label.Text = name + TLB.ToString() + "ns，总用时 " + time + "ns";

                }
            }
            else
            {
                if (fl)
                {
                    time += WithoutTLBBuiMissingPage;
                    label.Text = name + WithoutTLBBuiMissingPage.ToString() + "ns，总用时 " + time + "ns";

                }
                else
                {
                    time += WithoutTLB;
                    label.Text = name + WithoutTLB.ToString() + "ns，总用时 " + time + "ns";

                }

            }
            return time;
        }
        private int DeleteOpt(int index, int[] nums)
        {

            int[] target = new int[UserInput.memoryNum];
            for (int i = 0; i < list.Count; i++)
            {
                String a = Convert.ToString(list[i]);
                target[i] = Convert.ToInt32(a);
            }
            int[] pinlv = new int[UserInput.pageNum];
            for (int i = 0; i < UserInput.pageNum; i++)
            {
                bool NoHave = true;
                for (int j = index; j < list.Count; j++)
                {
                    if (nums[i] == target[j])
                    {
                        pinlv[i] = j;
                        NoHave = false;
                        break;
                    }
                }
                if (NoHave)
                {
                    return nums[i];
                }

            }
            //找出距离当前最远页，返回页号。
            int max = pinlv[0];
            int fanhui = 0;
            for (int i = 0; i < UserInput.pageNum; i++)
            {
                if (pinlv[i] > max)
                {
                    max = pinlv[i];
                    fanhui = i;
                }
            }
            return nums[fanhui];
        }
        private Label StyleLable(Label lab, int index, int i, int j)
        {
            switch (index)
            {
                case 1:
                    lab.Width = 60;
                    lab.Left = 30;
                    lab.Top = j * 25 + 40;
                    break;
                case 2:
                    lab.Width = 30;
                    lab.Left = i * 30 + 90;
                    lab.Top = j * 25 + 40;
                    break;
            }
            return lab;
        }
    }
}
