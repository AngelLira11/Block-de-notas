namespace Block_de_notas
{
    public partial class Form1 : Form
    {
        bool archivoGuardado = false;
        string filepath2 = null;
        string fileResult = null;
        string filePath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (archivoGuardado == false)
            {
                resultado = saveFileDialogEditor.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    filePath = saveFileDialogEditor.FileName;
                    string texto = rtbEditor.Text;
                    try
                    {
                        File.WriteAllText(filePath, texto);
                        MessageBox.Show("Archivo guardado correctamente");
                        archivoGuardado = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    string texto = rtbEditor.Text;
                    File.WriteAllText(filePath, texto);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogEditor.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialogEditor.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    rtbEditor.Text = texto;
                    archivoGuardado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        private void saloirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (archivoGuardado == false)
            {
                DialogResult res = MessageBox.Show("Deseas salir sin guardar?", "Sistema", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

            }
            else {

                DialogResult res2 = MessageBox.Show("Deseas salir?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res2 == DialogResult.OK)
                {
                    this.Close();
                }
            }

            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = saveFileDialogEditor.ShowDialog();

            if (resultado == DialogResult.OK)
                {
                filePath = saveFileDialogEditor.FileName;
                string texto = rtbEditor.Text;

                    try
                    {
                    

                    File.WriteAllText(filePath, texto);
                    archivoGuardado = true;
                    MessageBox.Show("Archivo guardado correctamente");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);

                    }

                }

            }
            //}

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();

        }
    }
}
