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
            label1 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            lblTipo = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 37);
            label1.TabIndex = 1;
            label1.Text = "TIPO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 37);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(175, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(149, 37);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "____________";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(415, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(149, 37);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "____________";
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(576, 515);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearVehiculo);
            MaximumSize = new Size(592, 554);
            MinimizeBox = false;
            MinimumSize = new Size(592, 554);
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrearVehiculo;
        private Label label1;
        private Label label2;
        private Label lblNombre;
        private Label lblTipo;
    }
}
