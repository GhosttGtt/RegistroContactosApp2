namespace WinFormsApp1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nombre = new TextBox();
            lista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Agregar = new Button();
            Limpiar = new Button();
            Telefono = new TextBox();
            Correo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            label4.Click += label3_Click;
            // 
            // Nombre
            // 
            Nombre.BackColor = Color.FromArgb(64, 64, 64);
            Nombre.BorderStyle = BorderStyle.FixedSingle;
            Nombre.ForeColor = SystemColors.Window;
            resources.ApplyResources(Nombre, "Nombre");
            Nombre.Name = "Nombre";
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // lista
            // 
            lista.BackColor = Color.FromArgb(30, 30, 30);
            lista.BorderStyle = BorderStyle.None;
            lista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            resources.ApplyResources(lista, "lista");
            lista.ForeColor = SystemColors.Window;
            lista.Name = "lista";
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = View.Details;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.ForestGreen;
            Agregar.Cursor = Cursors.Hand;
            Agregar.FlatAppearance.BorderColor = Color.LimeGreen;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            resources.ApplyResources(Agregar, "Agregar");
            Agregar.ForeColor = Color.Black;
            Agregar.Name = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += button1_Click;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = Color.White;
            Limpiar.Cursor = Cursors.Hand;
            Limpiar.FlatAppearance.BorderSize = 0;
            Limpiar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            resources.ApplyResources(Limpiar, "Limpiar");
            Limpiar.Name = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += button2_Click;
            // 
            // Telefono
            // 
            Telefono.BackColor = Color.FromArgb(64, 64, 64);
            Telefono.BorderStyle = BorderStyle.FixedSingle;
            Telefono.ForeColor = SystemColors.Window;
            resources.ApplyResources(Telefono, "Telefono");
            Telefono.Name = "Telefono";
            Telefono.TextChanged += Telefono_TextChanged;
            // 
            // Correo
            // 
            Correo.BackColor = Color.FromArgb(64, 64, 64);
            Correo.BorderStyle = BorderStyle.FixedSingle;
            Correo.ForeColor = SystemColors.Window;
            resources.ApplyResources(Correo, "Correo");
            Correo.Name = "Correo";
            Correo.TextChanged += Correo_TextChanged;
            // 
            // Registro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 23, 23);
            resources.ApplyResources(this, "$this");
            Controls.Add(Nombre);
            Controls.Add(Correo);
            Controls.Add(Telefono);
            Controls.Add(Limpiar);
            Controls.Add(Agregar);
            Controls.Add(lista);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            Name = "Registro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nombre;
        private TextBox Telefono;
        private TextBox Correo;
        private ListView lista;
        private Button Agregar;
        private Button Limpiar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
