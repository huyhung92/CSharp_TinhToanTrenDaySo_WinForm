namespace CSharp_TinhToanTrenDaySo_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tt_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(!int.TryParse(sbd.Text, out _))
            {
                errorProvider1.SetError(sbd, "Phai nhap so nguyen");
                return;
            }
            if(!int.TryParse(skt.Text, out _))
            {
                errorProvider1.SetError(skt, "Phai nhap so nguyen");
            }
            if (string.IsNullOrEmpty(sbd.Text))
            {
                errorProvider1.SetError(sbd, "Bat buoc nhap");
            }
            if (string.IsNullOrEmpty(skt.Text))
            {
                errorProvider1.SetError(skt, "Bat buoc nhap");
            }

            double Sbd = Convert.ToDouble(sbd.Text);
            double Skt = Convert.ToDouble(skt.Text);

            double tongcs = 0, tichcs = 1, tongsc = 0, tongsl = 0;
            for (double i = Sbd; i <= Skt; i++)
            {
                tongcs += i;
                tichcs += i;
                if (i % 2 == 0)
                {
                    tongsc += i;
                }
                else
                {
                    tongsl += i;
                }
            }

            tongcstxt.Text = tongcs.ToString();
            tichcstxt.Text = tichcs.ToString();
            tongsctxt.Text = tongsc.ToString();
            tongsltxt.Text = tongsl.ToString();
        }
    }
}
