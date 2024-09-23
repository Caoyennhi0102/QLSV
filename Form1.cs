namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> listStudent = new List<Student>();
        private void btNhap_Click(object sender, EventArgs e)
        {
            Student sv = new Student(txtHovaten.Text, dateTimePicker1.Value, txtGioiTinh.Text, txtID.Text, txtLop.Text, Convert.ToDouble(txtDTB.Text)

                );

            listStudent.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listStudent;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            foreach(Student sv in listStudent)
            {
                if(sv.Student_ID1 == txtID.Text)
                {
                    sv.FullName1 = txtHovaten.Text;
                    sv.DTB1 = double.Parse(txtDTB.Text);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listStudent;
        }
        
    }
}
