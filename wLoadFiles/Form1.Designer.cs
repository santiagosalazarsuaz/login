namespace wLoadFiles
{
    partial class Form1
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
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.cmdPorLineas = new System.Windows.Forms.Button();
            this.gparchivo = new System.Windows.Forms.GroupBox();
            this.dtGCSV = new System.Windows.Forms.DataGridView();
            this.cmdCSV = new System.Windows.Forms.Button();
            this.gparchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(27, 21);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(344, 303);
            this.txtArchivo.TabIndex = 0;
            // 
            // cmdPorLineas
            // 
            this.cmdPorLineas.Location = new System.Drawing.Point(84, 354);
            this.cmdPorLineas.Name = "cmdPorLineas";
            this.cmdPorLineas.Size = new System.Drawing.Size(134, 23);
            this.cmdPorLineas.TabIndex = 1;
            this.cmdPorLineas.Text = "Línea a Línea";
            this.cmdPorLineas.UseVisualStyleBackColor = true;
            this.cmdPorLineas.Click += new System.EventHandler(this.cmdPorLineas_Click);
            // 
            // gparchivo
            // 
            this.gparchivo.Controls.Add(this.dtGCSV);
            this.gparchivo.Controls.Add(this.cmdCSV);
            this.gparchivo.Controls.Add(this.txtArchivo);
            this.gparchivo.Controls.Add(this.cmdPorLineas);
            this.gparchivo.Location = new System.Drawing.Point(12, 2);
            this.gparchivo.Name = "gparchivo";
            this.gparchivo.Size = new System.Drawing.Size(1313, 428);
            this.gparchivo.TabIndex = 2;
            this.gparchivo.TabStop = false;
            this.gparchivo.Text = "Cargar Archivo";
            this.gparchivo.Enter += new System.EventHandler(this.gparchivo_Enter);
            // 
            // dtGCSV
            // 
            this.dtGCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGCSV.Location = new System.Drawing.Point(440, 18);
            this.dtGCSV.Name = "dtGCSV";
            this.dtGCSV.RowTemplate.Height = 24;
            this.dtGCSV.Size = new System.Drawing.Size(773, 305);
            this.dtGCSV.TabIndex = 3;
            // 
            // cmdCSV
            // 
            this.cmdCSV.Location = new System.Drawing.Point(286, 354);
            this.cmdCSV.Name = "cmdCSV";
            this.cmdCSV.Size = new System.Drawing.Size(134, 23);
            this.cmdCSV.TabIndex = 2;
            this.cmdCSV.Text = "CSV";
            this.cmdCSV.UseVisualStyleBackColor = true;
            this.cmdCSV.Click += new System.EventHandler(this.cmdCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 486);
            this.Controls.Add(this.gparchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gparchivo.ResumeLayout(false);
            this.gparchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button cmdPorLineas;
        private System.Windows.Forms.GroupBox gparchivo;
        private System.Windows.Forms.Button cmdCSV;
        private System.Windows.Forms.DataGridView dtGCSV;
    }
}

