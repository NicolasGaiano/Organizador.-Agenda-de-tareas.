
namespace EJ2
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.comboBoxConf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfCancel = new System.Windows.Forms.Button();
            this.buttonConfGuardar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxConf
            // 
            this.comboBoxConf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConf.FormattingEnabled = true;
            this.comboBoxConf.Items.AddRange(new object[] {
            "Fecha",
            "Prioridad"});
            this.comboBoxConf.Location = new System.Drawing.Point(52, 186);
            this.comboBoxConf.Name = "comboBoxConf";
            this.comboBoxConf.Size = new System.Drawing.Size(344, 23);
            this.comboBoxConf.TabIndex = 0;
            this.comboBoxConf.SelectedIndexChanged += new System.EventHandler(this.comboBoxConf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenar lista de tareas segun:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonConfCancel
            // 
            this.buttonConfCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfCancel.ForeColor = System.Drawing.Color.Silver;
            this.buttonConfCancel.Location = new System.Drawing.Point(206, 265);
            this.buttonConfCancel.Name = "buttonConfCancel";
            this.buttonConfCancel.Size = new System.Drawing.Size(92, 36);
            this.buttonConfCancel.TabIndex = 3;
            this.buttonConfCancel.Text = "Cancelar ";
            this.buttonConfCancel.UseVisualStyleBackColor = false;
            this.buttonConfCancel.Click += new System.EventHandler(this.buttonConfCancel_Click);
            // 
            // buttonConfGuardar
            // 
            this.buttonConfGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfGuardar.ForeColor = System.Drawing.Color.Silver;
            this.buttonConfGuardar.Location = new System.Drawing.Point(304, 265);
            this.buttonConfGuardar.Name = "buttonConfGuardar";
            this.buttonConfGuardar.Size = new System.Drawing.Size(92, 36);
            this.buttonConfGuardar.TabIndex = 4;
            this.buttonConfGuardar.Text = "Guardar";
            this.buttonConfGuardar.UseVisualStyleBackColor = false;
            this.buttonConfGuardar.Click += new System.EventHandler(this.buttonConfGuardar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(52, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 25);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Usar contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBoxContra
            // 
            this.textBoxContra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContra.Location = new System.Drawing.Point(52, 94);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(344, 23);
            this.textBoxContra.TabIndex = 6;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 313);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonConfGuardar);
            this.Controls.Add(this.buttonConfCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxConf);
            this.Name = "FormConfig";
            this.ShowIcon = false;
            this.Text = "Configuraciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfCancel;
        private System.Windows.Forms.Button buttonConfGuardar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxContra;
    }
}