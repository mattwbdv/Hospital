namespace HospitalCharges
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

        private int CalcStayCharges(int days)
        {
            return 350 * days;

        }

        private int CalcMiscCharges(int med, int surg, int lab, int rehab)
        {
            return med + surg + lab + rehab;

        }

        private int CalcTotalCharges(int days, int med, int surg, int lab, int rehab)
        {
            return CalcStayCharges(days) + CalcMiscCharges(med, surg, lab, rehab);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = Int32.Parse(box_days.Text); 
            int med = Int32.Parse(box_med.Text);
            int surg = Int32.Parse(box_surg.Text);
            int lab = Int32.Parse(box_lab.Text);
            int rehab = Int32.Parse(box_rehab.Text);

            form_amount.Text = Convert.ToString(CalcTotalCharges(days, med, surg, lab, rehab));
        }
    }
}