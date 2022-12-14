namespace Simulacion_ProgramasInterfaz
{
    partial class Form1
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
            this.btn_generarVariables = new System.Windows.Forms.Button();
            this.txt_numCorridas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_distribucion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_landa = new System.Windows.Forms.TextBox();
            this.DATOS = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_impresion = new System.Windows.Forms.TextBox();
            this.txt_variables = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DATOS.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generarVariables
            // 
            this.btn_generarVariables.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generarVariables.Location = new System.Drawing.Point(272, 176);
            this.btn_generarVariables.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generarVariables.Name = "btn_generarVariables";
            this.btn_generarVariables.Size = new System.Drawing.Size(130, 41);
            this.btn_generarVariables.TabIndex = 0;
            this.btn_generarVariables.Text = "Generar ";
            this.btn_generarVariables.UseVisualStyleBackColor = true;
            this.btn_generarVariables.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_numCorridas
            // 
            this.txt_numCorridas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_numCorridas.Location = new System.Drawing.Point(220, 4);
            this.txt_numCorridas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numCorridas.Name = "txt_numCorridas";
            this.txt_numCorridas.Size = new System.Drawing.Size(64, 35);
            this.txt_numCorridas.TabIndex = 3;
            this.txt_numCorridas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de corridas: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // box_distribucion
            // 
            this.box_distribucion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_distribucion.FormattingEnabled = true;
            this.box_distribucion.Items.AddRange(new object[] {
            "Normal",
            "Poisson"});
            this.box_distribucion.Location = new System.Drawing.Point(224, 60);
            this.box_distribucion.Margin = new System.Windows.Forms.Padding(4);
            this.box_distribucion.Name = "box_distribucion";
            this.box_distribucion.Size = new System.Drawing.Size(154, 38);
            this.box_distribucion.TabIndex = 5;
            this.box_distribucion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distribución:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Landa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_landa
            // 
            this.txt_landa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_landa.Location = new System.Drawing.Point(86, 4);
            this.txt_landa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_landa.Name = "txt_landa";
            this.txt_landa.Size = new System.Drawing.Size(53, 35);
            this.txt_landa.TabIndex = 7;
            this.txt_landa.TextChanged += new System.EventHandler(this.txt_landa_TextChanged);
            // 
            // DATOS
            // 
            this.DATOS.Controls.Add(this.flowLayoutPanel2);
            this.DATOS.Controls.Add(this.flowLayoutPanel1);
            this.DATOS.Controls.Add(this.box_distribucion);
            this.DATOS.Controls.Add(this.btn_generarVariables);
            this.DATOS.Controls.Add(this.label3);
            this.DATOS.Location = new System.Drawing.Point(33, 27);
            this.DATOS.Margin = new System.Windows.Forms.Padding(4);
            this.DATOS.Name = "DATOS";
            this.DATOS.Padding = new System.Windows.Forms.Padding(4);
            this.DATOS.Size = new System.Drawing.Size(649, 225);
            this.DATOS.TabIndex = 9;
            this.DATOS.TabStop = false;
            this.DATOS.Text = "DATOS";
            this.DATOS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txt_landa);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(385, 60);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(265, 52);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txt_numCorridas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 51);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // txt_impresion
            // 
            this.txt_impresion.AcceptsTab = true;
            this.txt_impresion.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_impresion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_impresion.Location = new System.Drawing.Point(12, 272);
            this.txt_impresion.Multiline = true;
            this.txt_impresion.Name = "txt_impresion";
            this.txt_impresion.ReadOnly = true;
            this.txt_impresion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_impresion.Size = new System.Drawing.Size(915, 347);
            this.txt_impresion.TabIndex = 11;
            // 
            // txt_variables
            // 
            this.txt_variables.AcceptsTab = true;
            this.txt_variables.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_variables.Location = new System.Drawing.Point(933, 272);
            this.txt_variables.Multiline = true;
            this.txt_variables.Name = "txt_variables";
            this.txt_variables.ReadOnly = true;
            this.txt_variables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_variables.Size = new System.Drawing.Size(195, 347);
            this.txt_variables.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(975, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Variables";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_variables);
            this.Controls.Add(this.txt_impresion);
            this.Controls.Add(this.DATOS);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Generador de variables aleatorias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DATOS.ResumeLayout(false);
            this.DATOS.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_generarVariables;
        private TextBox txt_numCorridas;
        private Label label2;
        private ComboBox box_distribucion;
        private Label label3;
        private Label label4;
        private TextBox txt_landa;
        private GroupBox DATOS;
        private TextBox txt_impresion;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txt_variables;
        private Label label1;
    }
}