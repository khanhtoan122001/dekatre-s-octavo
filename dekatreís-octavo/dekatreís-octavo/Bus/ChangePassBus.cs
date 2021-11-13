using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Bus
{
    public class ChangePassBus
    {
        private static ChangePassBus instance;

        public static ChangePassBus Instance { get { if (instance == null) instance = new ChangePassBus(); return instance; } set => instance = value; }

        public int ChangePassword(string oldPass, string newPass, string confirmPass)
        {

            if (DataProvider.Instance.Encrypt(oldPass) == DataProvider.Instance.TaiKhoan.MatKhau)
            {
                if (newPass == confirmPass)
                {
                    DataProvider.Instance.TaiKhoan.MatKhau = DataProvider.Instance.Encrypt(newPass);
                    DataProvider.Instance.db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                    //MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                }
            }
            else
            {
                return 2;
                //MessageBox.Show("Sai mật khẩu!");
            }
        }
    }
}
