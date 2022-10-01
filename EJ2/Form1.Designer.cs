
namespace EJ2
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.buttonConfig = new System.Windows.Forms.Button();
            this.button_nuev = new System.Windows.Forms.Button();
            this.buttonGuardadTxt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnTarea = new System.Windows.Forms.ColumnHeader();
            this.columnPrioridad = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcion = new System.Windows.Forms.ColumnHeader();
            this.columnContador = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTituloMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCerar = new System.Windows.Forms.Button();
            this.buttonBorrarTarea = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxCont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxEsc = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxEsc.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfig.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfig.Image")));
            this.buttonConfig.Location = new System.Drawing.Point(3, 3);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 66);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_nuev
            // 
            this.button_nuev.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_nuev.Image = ((System.Drawing.Image)(resources.GetObject("button_nuev.Image")));
            this.button_nuev.Location = new System.Drawing.Point(3, 75);
            this.button_nuev.Name = "button_nuev";
            this.button_nuev.Size = new System.Drawing.Size(75, 66);
            this.button_nuev.TabIndex = 4;
            this.button_nuev.UseVisualStyleBackColor = false;
            this.button_nuev.Click += new System.EventHandler(this.button_nuev_Click);
            // 
            // buttonGuardadTxt
            // 
            this.buttonGuardadTxt.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuardadTxt.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardadTxt.Image")));
            this.buttonGuardadTxt.Location = new System.Drawing.Point(3, 147);
            this.buttonGuardadTxt.Name = "buttonGuardadTxt";
            this.buttonGuardadTxt.Size = new System.Drawing.Size(75, 66);
            this.buttonGuardadTxt.TabIndex = 5;
            this.buttonGuardadTxt.UseVisualStyleBackColor = false;
            this.buttonGuardadTxt.Click += new System.EventHandler(this.buttonGuardadTxt_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTarea,
            this.columnPrioridad,
            this.columnFecha,
            this.columnDescripcion,
            this.columnContador});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.SystemColors.Info;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 437);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnTarea
            // 
            this.columnTarea.Text = "Tarea ";
            this.columnTarea.Width = 195;
            // 
            // columnPrioridad
            // 
            this.columnPrioridad.Text = "Prioridad";
            this.columnPrioridad.Width = 110;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 138;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Width = 0;
            // 
            // columnContador
            // 
            this.columnContador.Width = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.buttonConfig);
            this.flowLayoutPanel2.Controls.Add(this.button_nuev);
            this.flowLayoutPanel2.Controls.Add(this.buttonGuardadTxt);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(882, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(83, 437);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTituloMain
            // 
            this.labelTituloMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTituloMain.AutoSize = true;
            this.labelTituloMain.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloMain.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTituloMain.Location = new System.Drawing.Point(0, 19);
            this.labelTituloMain.Name = "labelTituloMain";
            this.labelTituloMain.Size = new System.Drawing.Size(115, 50);
            this.labelTituloMain.TabIndex = 9;
            this.labelTituloMain.Text = "Titulo";
            this.labelTituloMain.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(134, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(319, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prioridad:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(246, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha:";
            this.label5.Visible = false;
            // 
            // buttonCerar
            // 
            this.buttonCerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerar.BackColor = System.Drawing.Color.Black;
            this.buttonCerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCerar.ForeColor = System.Drawing.Color.Silver;
            this.buttonCerar.Location = new System.Drawing.Point(387, 17);
            this.buttonCerar.Name = "buttonCerar";
            this.buttonCerar.Size = new System.Drawing.Size(34, 30);
            this.buttonCerar.TabIndex = 15;
            this.buttonCerar.Text = "X";
            this.buttonCerar.UseVisualStyleBackColor = false;
            this.buttonCerar.Visible = false;
            this.buttonCerar.Click += new System.EventHandler(this.buttonCerar_Click);
            // 
            // buttonBorrarTarea
            // 
            this.buttonBorrarTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBorrarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBorrarTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrarTarea.ForeColor = System.Drawing.Color.Silver;
            this.buttonBorrarTarea.Location = new System.Drawing.Point(6, 381);
            this.buttonBorrarTarea.Name = "buttonBorrarTarea";
            this.buttonBorrarTarea.Size = new System.Drawing.Size(92, 36);
            this.buttonBorrarTarea.TabIndex = 16;
            this.buttonBorrarTarea.Text = "Eliminar";
            this.buttonBorrarTarea.UseVisualStyleBackColor = false;
            this.buttonBorrarTarea.Visible = false;
            this.buttonBorrarTarea.Click += new System.EventHandler(this.buttonBorrarTarea_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Agenda.txt";
            this.saveFileDialog1.Filter = "Archivos.txt (*.txt)|*.txt";
            // 
            // textBoxCont
            // 
            this.textBoxCont.Location = new System.Drawing.Point(17, 81);
            this.textBoxCont.Name = "textBoxCont";
            this.textBoxCont.Size = new System.Drawing.Size(434, 23);
            this.textBoxCont.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(17, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ingrese contraseña";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEntrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrar.ForeColor = System.Drawing.Color.Silver;
            this.buttonEntrar.Location = new System.Drawing.Point(186, 127);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(92, 36);
            this.buttonEntrar.TabIndex = 19;
            this.buttonEntrar.Text = "Ingresar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonEntrar);
            this.groupBox1.Controls.Add(this.textBoxCont);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(286, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 203);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBoxEsc
            // 
            this.groupBoxEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEsc.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEsc.Controls.Add(this.labelTituloMain);
            this.groupBoxEsc.Controls.Add(this.buttonCerar);
            this.groupBoxEsc.Controls.Add(this.buttonBorrarTarea);
            this.groupBoxEsc.Controls.Add(this.label4);
            this.groupBoxEsc.Controls.Add(this.label5);
            this.groupBoxEsc.Controls.Add(this.label1);
            this.groupBoxEsc.Controls.Add(this.label3);
            this.groupBoxEsc.Controls.Add(this.label2);
            this.groupBoxEsc.Location = new System.Drawing.Point(449, 1);
            this.groupBoxEsc.Name = "groupBoxEsc";
            this.groupBoxEsc.Size = new System.Drawing.Size(427, 423);
            this.groupBoxEsc.TabIndex = 21;
            this.groupBoxEsc.TabStop = false;
            this.groupBoxEsc.Visible = false;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(962, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEsc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgenda";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEsc.ResumeLayout(false);
            this.groupBoxEsc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button button_nuev;
        private System.Windows.Forms.Button buttonGuardadTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTituloMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnTarea;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnPrioridad;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private System.Windows.Forms.ColumnHeader columnContador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCerar;
        private System.Windows.Forms.Button buttonBorrarTarea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxCont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxEsc;
    }
}

