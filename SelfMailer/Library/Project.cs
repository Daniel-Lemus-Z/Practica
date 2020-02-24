using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer.Library
{
    public class Project : IReportChildrenChange
    {
        protected string filename = "sin titulo.smpx", path;
        protected DataTable data = new DataTable();
        protected bool hasChanged;

        public string Filename
        {
            get { return filename; }
            set
            {
                if (this.filename != value)
                {
                    filename = value;
                    this.hasChanged = true;
                }
            }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public DataTable Data
        {
            get { return data; }
            set { data = value; }
        }

        public bool HasChanged
        {
            get { return hasChanged; }
            set { hasChanged = value; }
        }

        public ProjectSettings ProjectSettings { get; set; }
        public MailServerSettings MailServerSettings { get; set; }

        public event EventHandler<ChangedEventArgs> Changed;

        public Project()
        {
            this.ProjectSettings = new ProjectSettings();
            this.ProjectSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
            this.MailServerSettings = new MailServerSettings();
            this.MailServerSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
        }
        
        /// <summary>  
        /// Hace una copia de seguridad del proyecto.  
        /// </summary>  
        /// <param name="Ask">Especifica si el usuario debe confirmar la  
        /// copia de seguridad.</param>  
        /// <param name="ShowDialog">Especifica si el usuario tiene la  
        /// posibilidad de elegir el archivo.</param>  
        public void Save(bool Ask = false, bool ShowDialog = false)
        {
            /* Si el usuario debe confirmar la copia de seguridad y el  
             * proyecto se ha modificado, el usuario debe pulsar en el  
             * botón Sí del cuadro de diálogo */
            if (!Ask ||
                (this.HasChanged &&
                MessageBox.Show("¿Desea hacer una copia de seguridad de las modificaciones?",
                "Guardar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1)== DialogResult.Yes))
            {
                /* Si el usuario no puede elegir un  
                 * archivo y el nombre del archivo así como su ruta de acceso  
                 * están definidos, el proyecto se guarda y la propiedad  
                 * HasChanged se reinicializa */
                if (!ShowDialog
                    && !string.IsNullOrEmpty(this.Filename)
                    && !string.IsNullOrEmpty(this.Path))
                {
                    // Hace copia de seguridad de los datos no implementados 
                    this.HasChanged = false;
                }
                /* En caso contrario, el usuario debe elegir una  
                 * ruta de acceso y un nombre de archivo para el proyecto,  
                 * que se guardará */
                else
                {
                    /* Instanciación e inicialización del cuadro de  
                     * diálogo de copia de seguridad de archivos */
                    SaveFileDialog sfdProject = new SaveFileDialog();
                    sfdProject.Filter = " Self Mailer (*.smpx)|*.smpx";
                    sfdProject.RestoreDirectory = true;
                    sfdProject.SupportMultiDottedExtensions = true;
                    sfdProject.Title = "Guardar el proyecto";
                    /* Muestra el cuadro de diálogo y verifica el  
                     * valor de retorno */
                    if (sfdProject.ShowDialog() == DialogResult.OK)
                    {
                        /* Asignación de los valores a las variables y  
                         * copia de seguridad del proyecto */
                        this.Filename = System.IO.Path.GetFileName(sfdProject.FileName);
                        this.Path = System.IO.Path.GetDirectoryName(sfdProject.FileName);
                        // Hace copia de seguridad de los datos no implementados 
                        this.HasChanged = false;
                    }
                }
            }
        }

        public void ChildChanged(object sender, ChangedEventArgs e)
        {
            if (sender is IReportChange)
            {
                IReportChange Child = (IReportChange)sender;
                this.HasChanged = Child.HasChanged;
                MessageBox.Show("Ha cambiado el objeto de tipo " +
                    Child.GetType().ToString());
            }
        }
    }
}
