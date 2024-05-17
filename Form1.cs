namespace pryPeriottiEtapa2
{
    public partial class frmVehiculos : Form
    {
        clsVehiculo objVehiculo;
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            objVehiculo = new clsVehiculo();
            objVehiculo.crearAuto();
            objVehiculo.imgAuto.Location = new Point(130, 80);
            Controls.Add(objVehiculo.imgAuto);
        }
    }
}
