
namespace oop
{
    internal class Program
    {
        public class student
        {
            public string name;
        }

        public class school
        {
            public string schoolName;

            public void register(student st)
            {
                Console.WriteLine($"{st.name} registered in {schoolName}");
            }
        }

        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "Noor";

            school sc = new school();
            sc.schoolName = "Future School";

            sc.register(s1);
        }
    }
}