
namespace EstructuraDeDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conceptosBasicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practica1TiposDeDatosAbstractosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciaDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filasYColasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesBinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memoramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptosBasicosToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.filasYColasToolStripMenuItem,
            this.arbolesBinariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conceptosBasicosToolStripMenuItem
            // 
            this.conceptosBasicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practica1TiposDeDatosAbstractosToolStripMenuItem,
            this.recursividadToolStripMenuItem});
            this.conceptosBasicosToolStripMenuItem.Name = "conceptosBasicosToolStripMenuItem";
            this.conceptosBasicosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.conceptosBasicosToolStripMenuItem.Text = "1. Conceptos Basicos";
            // 
            // practica1TiposDeDatosAbstractosToolStripMenuItem
            // 
            this.practica1TiposDeDatosAbstractosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDT2ToolStripMenuItem});
            this.practica1TiposDeDatosAbstractosToolStripMenuItem.Name = "practica1TiposDeDatosAbstractosToolStripMenuItem";
            this.practica1TiposDeDatosAbstractosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.practica1TiposDeDatosAbstractosToolStripMenuItem.Text = "Practica 1.- Tipos de datos abstractos";
            this.practica1TiposDeDatosAbstractosToolStripMenuItem.Click += new System.EventHandler(this.practica1TiposDeDatosAbstractosToolStripMenuItem_Click);
            // 
            // aDT2ToolStripMenuItem
            // 
            this.aDT2ToolStripMenuItem.Name = "aDT2ToolStripMenuItem";
            this.aDT2ToolStripMenuItem.ShowShortcutKeys = false;
            this.aDT2ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.aDT2ToolStripMenuItem.Text = "ADT 2";
            this.aDT2ToolStripMenuItem.Click += new System.EventHandler(this.aDT2ToolStripMenuItem_Click);
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secuenciaDeFibonacciToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // secuenciaDeFibonacciToolStripMenuItem
            // 
            this.secuenciaDeFibonacciToolStripMenuItem.Name = "secuenciaDeFibonacciToolStripMenuItem";
            this.secuenciaDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.secuenciaDeFibonacciToolStripMenuItem.Text = "Secuencia de Fibonacci";
            this.secuenciaDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.secuenciaDeFibonacciToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoramaToolStripMenuItem});
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.arreglosToolStripMenuItem.Text = "2. Arreglos";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.listasToolStripMenuItem.Text = "3. Listas";
            // 
            // filasYColasToolStripMenuItem
            // 
            this.filasYColasToolStripMenuItem.Name = "filasYColasToolStripMenuItem";
            this.filasYColasToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.filasYColasToolStripMenuItem.Text = "4. Pilas y Colas";
            this.filasYColasToolStripMenuItem.Click += new System.EventHandler(this.filasYColasToolStripMenuItem_Click);
            // 
            // arbolesBinariosToolStripMenuItem
            // 
            this.arbolesBinariosToolStripMenuItem.Name = "arbolesBinariosToolStripMenuItem";
            this.arbolesBinariosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.arbolesBinariosToolStripMenuItem.Text = "5. Arboles binarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estructura de datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "El alumno empleará estructuras de datos abstractas \r\nen el desarrollo de aplicaci" +
    "ones multiplataforma \r\nusando el paradigma orientado a objetos para agilizar el " +
    "acceso a los datos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // memoramaToolStripMenuItem
            // 
            this.memoramaToolStripMenuItem.Name = "memoramaToolStripMenuItem";
            this.memoramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memoramaToolStripMenuItem.Text = "Memorama";
            this.memoramaToolStripMenuItem.Click += new System.EventHandler(this.memoramaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conceptosBasicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filasYColasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesBinariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem practica1TiposDeDatosAbstractosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem aDT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciaDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoramaToolStripMenuItem;
    }
}

