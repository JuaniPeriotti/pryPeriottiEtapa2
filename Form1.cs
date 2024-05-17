namespace pryPeriottiEtapa2
{
    public partial class frmVehiculos : Form
    {
        clsVehiculo objVehiculo;
        public frmVehiculos()
        {
            InitializeComponent();
        }
        string Nombre;
        string Tipo;
        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            objVehiculo = new clsVehiculo();
            objVehiculo.crearAuto();
            objVehiculo.imgAuto.Location = new Point(90, 60);
            Controls.Add(objVehiculo.imgAuto);
            Nombre = lblNombre.Text;
            Tipo = lblTipo.Text;
            lblNombre.Text = "Zentorno";
            lblTipo.Text = "Auto";
        }
    }
}
