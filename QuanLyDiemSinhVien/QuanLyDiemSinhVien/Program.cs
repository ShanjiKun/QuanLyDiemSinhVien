using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QuanLyDiemSinhVien.Forms.Login;
using QuanLyDiemSinhVien.Forms.Base;
using QuanLyDiemSinhVien.Models.User;

namespace QuanLyDiemSinhVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static BaseRibbonForm ribbonForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new LoginForm());
        }

        public static void logout()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            UserProfile.sharedInstance().reset();

            Program.ribbonForm.Close();
        }
    }
}
