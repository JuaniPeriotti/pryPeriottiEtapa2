using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPeriottiEtapa2
{
    internal class clsVehiculo
    {
        string Nombre;
        public PictureBox imgAuto;
        public void crearAuto()
        {
            Nombre = "vehiculoAuto";
            imgAuto = new PictureBox();
            imgAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAuto.Size = new Size(300, 300);
            imgAuto.ImageLocation = @"../../../" + "/Resources/" + "vehiculoAuto.png";
        }
    }
}
