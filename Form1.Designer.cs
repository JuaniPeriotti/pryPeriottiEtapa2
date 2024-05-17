namespace pryPeriottiEtapa2
{
    partial class frmVehiculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearVehiculo = new Button();
            SuspendLayout();
            // 
            // btnCrearVehiculo
            // 
            btnCrearVehiculo.Location = new Point(231, 480);
            btnCrearVehiculo.Name = "btnCrearVehiculo";
            btnCrearVehiculo.Size = new Size(102, 23);
            btnCrearVehiculo.TabIndex = 0;
            btnCrearVehiculo.Text = "Crear Vehiculo";
            btnCrearVehiculo.UseVisualStyleBackColor = true;
            btnCrearVehiculo.Click += btnCrearVehiculo_Click;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(576, 515);
            Controls.Add(btnCrearVehiculo);
            MinimizeBox = false;
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiculos";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCrearVehiculo;
    }
}
