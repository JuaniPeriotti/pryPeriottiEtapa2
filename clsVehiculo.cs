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
            Nombre = "Zentorno";
            imgAuto = new PictureBox();
            imgAuto.SizeMode = PictureBoxSizeMode.Zoom;
            imgAuto.Size = new Size(400, 400);
            imgAuto.ImageLocation = @"../../../" + "/Resources/" + "Zentorno.jpg";
        }
    }
}
