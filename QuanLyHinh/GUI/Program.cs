using QuanLyHinh.DAO;

namespace QuanLyHinh.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form1 frm = new Form1();
            var dao = new HinhDAO("D:\\Winform-C#\\Ngay6 - v3\\Ngay6\\QuanLyHinh\\Data.txt");
            frm.InjectHinhDAO(dao);

            Application.Run(frm);
        }
    }
}