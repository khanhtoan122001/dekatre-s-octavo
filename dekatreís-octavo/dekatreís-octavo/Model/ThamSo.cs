using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class ThamSo
    {
        private string tenThamSo;
        private float giaTri, iDThamSo;

        public float GiaTri { get => giaTri; set => giaTri = value; }
        public float IDThamSo { get => iDThamSo; set => iDThamSo = value; }
        public string TenThamSo { get => tenThamSo; set => tenThamSo = value; }

        public ThamSo() { }

        public ThamSo(DataRow row)
        {
            this.tenThamSo = row["TenThamSo"].ToString();
            this.giaTri = Convert.ToSingle(row["GiaTri"]);
            this.iDThamSo = Convert.ToSingle(row["IDThamSo"]);
        }
    }
}
