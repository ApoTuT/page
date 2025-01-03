namespace page
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageNumInput = new TextBox();
            memoryPageNumInput = new TextBox();
            page = new Label();
            memory = new Label();
            memoryTime = new Label();
            pause = new Label();
            TLBTime = new Label();
            address = new Label();
            memoryTimeInput = new TextBox();
            pageTimeIput = new TextBox();
            TLBTimeInput = new TextBox();
            adressInput = new TextBox();
            SuspendLayout();
            // 
            // pageNumInput
            // 
            pageNumInput.Location = new Point(199, 29);
            pageNumInput.Name = "pageNumInput";
            pageNumInput.Size = new Size(125, 27);
            pageNumInput.TabIndex = 0;
            // 
            // memoryPageNumInput
            // 
            memoryPageNumInput.Location = new Point(199, 86);
            memoryPageNumInput.Name = "memoryPageNumInput";
            memoryPageNumInput.Size = new Size(125, 27);
            memoryPageNumInput.TabIndex = 1;
            // 
            // page
            // 
            page.AutoSize = true;
            page.Location = new Point(44, 29);
            page.Name = "page";
            page.Size = new Size(69, 20);
            page.TabIndex = 2;
            page.Tag = "";
            page.Text = "页面个数";
            // 
            // memory
            // 
            memory.AutoSize = true;
            memory.Location = new Point(44, 93);
            memory.Name = "memory";
            memory.Size = new Size(114, 20);
            memory.TabIndex = 3;
            memory.Text = "内存中页面个数";
            // 
            // memoryTime
            // 
            memoryTime.AutoSize = true;
            memoryTime.Location = new Point(44, 141);
            memoryTime.Name = "memoryTime";
            memoryTime.Size = new Size(99, 20);
            memoryTime.TabIndex = 4;
            memoryTime.Text = "内存读取时间";
            // 
            // pause
            // 
            pause.AutoSize = true;
            pause.Location = new Point(44, 191);
            pause.Name = "pause";
            pause.Size = new Size(99, 20);
            pause.TabIndex = 5;
            pause.Text = "缺页中断时间";
            // 
            // TLBTime
            // 
            TLBTime.AutoSize = true;
            TLBTime.Location = new Point(44, 237);
            TLBTime.Name = "TLBTime";
            TLBTime.Size = new Size(99, 20);
            TLBTime.TabIndex = 6;
            TLBTime.Text = "快表访问时间";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(44, 288);
            address.Name = "address";
            address.Size = new Size(69, 20);
            address.TabIndex = 7;
            address.Text = "地址序列";
            // 
            // memoryTimeInput
            // 
            memoryTimeInput.Location = new Point(199, 138);
            memoryTimeInput.Name = "memoryTimeInput";
            memoryTimeInput.Size = new Size(125, 27);
            memoryTimeInput.TabIndex = 8;
            // 
            // pageTimeIput
            // 
            pageTimeIput.Location = new Point(200, 189);
            pageTimeIput.Name = "pageTimeIput";
            pageTimeIput.Size = new Size(125, 27);
            pageTimeIput.TabIndex = 9;
            // 
            // TLBTimeInput
            // 
            TLBTimeInput.Location = new Point(199, 237);
            TLBTimeInput.Name = "TLBTimeInput";
            TLBTimeInput.Size = new Size(125, 27);
            TLBTimeInput.TabIndex = 10;
            // 
            // adressInput
            // 
            adressInput.Location = new Point(199, 281);
            adressInput.Name = "adressInput";
            adressInput.Size = new Size(353, 27);
            adressInput.TabIndex = 11;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adressInput);
            Controls.Add(TLBTimeInput);
            Controls.Add(pageTimeIput);
            Controls.Add(memoryTimeInput);
            Controls.Add(address);
            Controls.Add(TLBTime);
            Controls.Add(pause);
            Controls.Add(memoryTime);
            Controls.Add(memory);
            Controls.Add(page);
            Controls.Add(memoryPageNumInput);
            Controls.Add(pageNumInput);
            Name = "settings";
            Text = "settings";
            Load += settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pageNumInput;
        private TextBox memoryPageNumInput;
        private Label page;
        private Label memory;
        private Label memoryTime;
        private Label pause;
        private Label TLBTime;
        private Label address;
        private TextBox memoryTimeInput;
        private TextBox pageTimeIput;
        private TextBox TLBTimeInput;
        private TextBox adressInput;
    }
}