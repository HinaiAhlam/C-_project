using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; 

namespace project01
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();

            dgvStudents.DataSource = students;

           
            txtID.PlaceholderText = "رقم الطالب...";
            txtName.PlaceholderText = "اسم الطالب...";
            txtAge.PlaceholderText = "العمر...";
            txtSearchID.PlaceholderText = "ادخل الرقم للبحث...";

            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("يرجى إدخال الرقم والاسم على الأقل");
                    return;
                }

                students.Add(new Student
                {
                    ID = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Gender = cmbGender.Text,
                    Age = string.IsNullOrEmpty(txtAge.Text) ? 0 : int.Parse(txtAge.Text)
                });

                MessageBox.Show("تمت إضافة الطالب بنجاح ✅");

                ClearInputs();
            }
            catch (FormatException)
            {
                MessageBox.Show("خطأ: يرجى كتابة أرقام فقط في خانة الرقم والعمر");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchId;
            if (int.TryParse(txtSearchID.Text, out searchId))
            {
                var res = students.FirstOrDefault(s => s.ID == searchId);
                if (res != null)
                {
                    MessageBox.Show($"🔍 تم العثور على الطالب:\nالاسم: {res.Name}\nالجنس: {res.Gender}\nالعمر: {res.Age}");
                }
                else
                {
                    MessageBox.Show("عفواً، لا يوجد طالب يحمل هذا الرقم");
                }
            }
            else
            {
                MessageBox.Show("يرجى كتابة رقم الطالب بشكل صحيح (أرقام فقط)");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int searchId;
            if (int.TryParse(txtSearchID.Text, out searchId))
            {
                var res = students.FirstOrDefault(s => s.ID == searchId);
                if (res != null)
                {
                    students.Remove(res);
                    MessageBox.Show("تم حذف الطالب بنجاح 🗑️");
                    txtSearchID.Clear();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على طالب لحذفه");
                }
            }
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1; 
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public int Age { get; set; }
    }
}