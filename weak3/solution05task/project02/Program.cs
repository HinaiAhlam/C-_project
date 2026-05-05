using System;
using System.Windows.Forms;

namespace solution05task
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // هذا السطر هو الذي يقوم بتشغيل شاشة "Mini Netflix"
            // تأكدي أن الاسم هنا Form1 مطابق تماماً لاسم الكلاس في ملف Form1.cs
            Application.Run(new Form1());
        }
    }
}