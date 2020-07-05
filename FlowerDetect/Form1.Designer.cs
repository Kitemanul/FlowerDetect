namespace FlowerDetect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connect = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.tscbxCameras = new System.Windows.Forms.ComboBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_captrue = new System.Windows.Forms.Button();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.TextBox();
            this.C3 = new System.Windows.Forms.TextBox();
            this.paozhenwei = new System.Windows.Forms.TextBox();
            this.qingxiejiaodu = new System.Windows.Forms.TextBox();
            this.C4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Button_save = new System.Windows.Forms.Button();
            this.button_process = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(903, 73);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(116, 53);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "连接摄像头";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 54);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(639, 307);
            this.videoSourcePlayer1.TabIndex = 2;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(696, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择视频输入设备";
            // 
            // tscbxCameras
            // 
            this.tscbxCameras.FormattingEnabled = true;
            this.tscbxCameras.Location = new System.Drawing.Point(700, 89);
            this.tscbxCameras.Name = "tscbxCameras";
            this.tscbxCameras.Size = new System.Drawing.Size(157, 23);
            this.tscbxCameras.TabIndex = 5;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(1066, 73);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(116, 53);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "关闭摄像头";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_captrue
            // 
            this.button_captrue.Location = new System.Drawing.Point(903, 160);
            this.button_captrue.Name = "button_captrue";
            this.button_captrue.Size = new System.Drawing.Size(116, 48);
            this.button_captrue.TabIndex = 7;
            this.button_captrue.Text = "抓取";
            this.button_captrue.UseVisualStyleBackColor = true;
            this.button_captrue.Click += new System.EventHandler(this.button_captrue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 347);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "拍摄画面";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(262, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "抓取的图片";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(786, 298);
            this.A1.Name = "A1";
            this.A1.ReadOnly = true;
            this.A1.Size = new System.Drawing.Size(141, 25);
            this.A1.TabIndex = 11;
            this.A1.Tag = "";
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(981, 298);
            this.A2.Name = "A2";
            this.A2.ReadOnly = true;
            this.A2.Size = new System.Drawing.Size(140, 25);
            this.A2.TabIndex = 12;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(786, 384);
            this.B1.Name = "B1";
            this.B1.ReadOnly = true;
            this.B1.Size = new System.Drawing.Size(141, 25);
            this.B1.TabIndex = 13;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(981, 384);
            this.B2.Name = "B2";
            this.B2.ReadOnly = true;
            this.B2.Size = new System.Drawing.Size(140, 25);
            this.B2.TabIndex = 14;
            this.B2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(786, 469);
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Size = new System.Drawing.Size(141, 25);
            this.C1.TabIndex = 15;
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(786, 545);
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Size = new System.Drawing.Size(141, 25);
            this.C3.TabIndex = 17;
            // 
            // paozhenwei
            // 
            this.paozhenwei.Location = new System.Drawing.Point(981, 631);
            this.paozhenwei.Name = "paozhenwei";
            this.paozhenwei.ReadOnly = true;
            this.paozhenwei.Size = new System.Drawing.Size(140, 25);
            this.paozhenwei.TabIndex = 18;
            // 
            // qingxiejiaodu
            // 
            this.qingxiejiaodu.Location = new System.Drawing.Point(786, 631);
            this.qingxiejiaodu.Name = "qingxiejiaodu";
            this.qingxiejiaodu.ReadOnly = true;
            this.qingxiejiaodu.Size = new System.Drawing.Size(141, 25);
            this.qingxiejiaodu.TabIndex = 19;
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(981, 545);
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Size = new System.Drawing.Size(140, 25);
            this.C4.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "A1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "A2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(786, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "B1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(984, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "B2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "C1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(984, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "C2";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "C3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(984, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "C4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(786, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "倾斜角度";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(984, 597);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "跑针位";
            // 
            // Button_save
            // 
            this.Button_save.Location = new System.Drawing.Point(1066, 160);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(116, 48);
            this.Button_save.TabIndex = 31;
            this.Button_save.Text = "保存数据";
            this.Button_save.UseVisualStyleBackColor = true;
            this.Button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(700, 160);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(128, 48);
            this.button_process.TabIndex = 32;
            this.button_process.Text = "处理图片";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(981, 469);
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Size = new System.Drawing.Size(140, 25);
            this.C2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 790);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.Button_save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.qingxiejiaodu);
            this.Controls.Add(this.paozhenwei);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_captrue);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.tscbxCameras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.button_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_connect;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tscbxCameras;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_captrue;
        private AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.TextBox C3;
        private System.Windows.Forms.TextBox paozhenwei;
        private System.Windows.Forms.TextBox qingxiejiaodu;
        private System.Windows.Forms.TextBox C4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Button_save;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.TextBox C2;
    }
}

