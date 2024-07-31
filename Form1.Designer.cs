namespace CSharp_TinhToanTrenDaySo_WinForm
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sbd = new TextBox();
            label4 = new Label();
            skt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tongcstxt = new TextBox();
            tichcstxt = new TextBox();
            tongsctxt = new TextBox();
            tongsltxt = new TextBox();
            tt = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 32);
            label1.Name = "label1";
            label1.Size = new Size(259, 29);
            label1.TabIndex = 0;
            label1.Text = "Tính Toán Trên Dãy Số";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 107);
            label2.Name = "label2";
            label2.Size = new Size(215, 27);
            label2.TabIndex = 1;
            label2.Text = "Giới Hạn Của Dãy Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 107);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 2;
            label3.Text = "Số bắt đầu";
            // 
            // sbd
            // 
            sbd.Location = new Point(477, 100);
            sbd.Name = "sbd";
            sbd.Size = new Size(153, 34);
            sbd.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 107);
            label4.Name = "label4";
            label4.Size = new Size(121, 27);
            label4.TabIndex = 4;
            label4.Text = "Số kết thúc";
            // 
            // skt
            // 
            skt.Location = new Point(781, 100);
            skt.Name = "skt";
            skt.Size = new Size(153, 34);
            skt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 179);
            label5.Name = "label5";
            label5.Size = new Size(91, 27);
            label5.TabIndex = 6;
            label5.Text = "Kết Quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 236);
            label6.Name = "label6";
            label6.Size = new Size(134, 27);
            label6.TabIndex = 7;
            label6.Text = "Tổng Các Số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 291);
            label7.Name = "label7";
            label7.Size = new Size(125, 27);
            label7.TabIndex = 8;
            label7.Text = "Tích Các Số";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 343);
            label8.Name = "label8";
            label8.Size = new Size(190, 27);
            label8.TabIndex = 9;
            label8.Text = "Tổng Các Số Chẵn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 394);
            label9.Name = "label9";
            label9.Size = new Size(171, 27);
            label9.TabIndex = 10;
            label9.Text = "Tổng Các Số Lẻ ";
            // 
            // tongcstxt
            // 
            tongcstxt.Location = new Point(254, 229);
            tongcstxt.Name = "tongcstxt";
            tongcstxt.Size = new Size(208, 34);
            tongcstxt.TabIndex = 11;
            // 
            // tichcstxt
            // 
            tichcstxt.Location = new Point(254, 284);
            tichcstxt.Name = "tichcstxt";
            tichcstxt.Size = new Size(208, 34);
            tichcstxt.TabIndex = 13;
            // 
            // tongsctxt
            // 
            tongsctxt.Location = new Point(254, 336);
            tongsctxt.Name = "tongsctxt";
            tongsctxt.Size = new Size(208, 34);
            tongsctxt.TabIndex = 14;
            // 
            // tongsltxt
            // 
            tongsltxt.Location = new Point(254, 387);
            tongsltxt.Name = "tongsltxt";
            tongsltxt.Size = new Size(208, 34);
            tongsltxt.TabIndex = 15;
            // 
            // tt
            // 
            tt.Location = new Point(254, 458);
            tt.Name = "tt";
            tt.Size = new Size(192, 45);
            tt.TabIndex = 16;
            tt.Text = "Tính Toán";
            tt.UseVisualStyleBackColor = true;
            tt.Click += tt_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 559);
            Controls.Add(tt);
            Controls.Add(tongsltxt);
            Controls.Add(tongsctxt);
            Controls.Add(tichcstxt);
            Controls.Add(tongcstxt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(skt);
            Controls.Add(label4);
            Controls.Add(sbd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sbd;
        private Label label4;
        private TextBox skt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tongcstxt;
        private TextBox tichcstxt;
        private TextBox tongsctxt;
        private TextBox tongsltxt;
        private Button tt;
        private ErrorProvider errorProvider1;
    }
}
