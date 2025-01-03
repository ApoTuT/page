namespace page
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FIFOButton = new Button();
            LRUButton = new Button();
            OPTButton = new Button();
            button4 = new Button();
            FIFOPanel = new Panel();
            LRUPanel = new Panel();
            OPTPanel = new Panel();
            userSetting = new Label();
            setting = new Button();
            SuspendLayout();
            // 
            // FIFOButton
            // 
            FIFOButton.Location = new Point(52, 57);
            FIFOButton.Name = "FIFOButton";
            FIFOButton.Size = new Size(101, 46);
            FIFOButton.TabIndex = 0;
            FIFOButton.Text = "FIFO";
            FIFOButton.UseVisualStyleBackColor = true;
            FIFOButton.Click += button1_Click;
            // 
            // LRUButton
            // 
            LRUButton.Location = new Point(52, 147);
            LRUButton.Name = "LRUButton";
            LRUButton.Size = new Size(101, 46);
            LRUButton.TabIndex = 1;
            LRUButton.Text = "LRU";
            LRUButton.UseVisualStyleBackColor = true;
            // 
            // OPTButton
            // 
            OPTButton.Location = new Point(52, 234);
            OPTButton.Name = "OPTButton";
            OPTButton.Size = new Size(101, 38);
            OPTButton.TabIndex = 2;
            OPTButton.Text = "OPT";
            OPTButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(52, 320);
            button4.Name = "button4";
            button4.Size = new Size(101, 40);
            button4.TabIndex = 3;
            button4.Text = "开始/暂停";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FIFOPanel
            // 
            FIFOPanel.AutoScroll = true;
            FIFOPanel.BackColor = SystemColors.ButtonShadow;
            FIFOPanel.BorderStyle = BorderStyle.Fixed3D;
            FIFOPanel.Location = new Point(319, 42);
            FIFOPanel.Name = "FIFOPanel";
            FIFOPanel.Size = new Size(613, 103);
            FIFOPanel.TabIndex = 4;
            // 
            // LRUPanel
            // 
            LRUPanel.AutoScroll = true;
            LRUPanel.BackColor = SystemColors.ButtonShadow;
            LRUPanel.BorderStyle = BorderStyle.Fixed3D;
            LRUPanel.Location = new Point(319, 310);
            LRUPanel.Name = "LRUPanel";
            LRUPanel.Size = new Size(611, 77);
            LRUPanel.TabIndex = 5;
            // 
            // OPTPanel
            // 
            OPTPanel.AutoScroll = true;
            OPTPanel.BackColor = SystemColors.ButtonShadow;
            OPTPanel.BackgroundImageLayout = ImageLayout.None;
            OPTPanel.BorderStyle = BorderStyle.Fixed3D;
            OPTPanel.Location = new Point(319, 186);
            OPTPanel.Name = "OPTPanel";
            OPTPanel.Size = new Size(600, 96);
            OPTPanel.TabIndex = 6;
            OPTPanel.Paint += panel2_Paint;
            // 
            // userSetting
            // 
            userSetting.AutoSize = true;
            userSetting.Location = new Point(67, 18);
            userSetting.Name = "userSetting";
            userSetting.Size = new Size(99, 20);
            userSetting.TabIndex = 7;
            userSetting.Text = "用户已选择：";
            // 
            // setting
            // 
            setting.Location = new Point(52, 399);
            setting.Name = "setting";
            setting.Size = new Size(94, 29);
            setting.TabIndex = 8;
            setting.Text = "设置";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 585);
            Controls.Add(setting);
            Controls.Add(userSetting);
            Controls.Add(OPTPanel);
            Controls.Add(LRUPanel);
            Controls.Add(FIFOPanel);
            Controls.Add(button4);
            Controls.Add(OPTButton);
            Controls.Add(LRUButton);
            Controls.Add(FIFOButton);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FIFOButton;
        private Button LRUButton;
        private Button OPTButton;
        private Button button4;
        private Panel FIFOPanel;
        private Panel LRUPanel;
        private Panel OPTPanel;
        private Label userSetting;
        private Button setting;
    }
}
