using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alert.Alert;
using Alert;
using System.IO;
using Decryptor.Properties;
using System.Text.RegularExpressions;

namespace DragnDropTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void AlertShow(string Message, AlertType Type)
        {
            new Alert.Alert().ShowAlert(Message, Type);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaLabel2.Text = Text;
        }

        private void guna2Panel2_DragEnter(object sender, DragEventArgs e)
        {
           if( e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                gunaLabel1.Text = "Drop";
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void guna2Panel2_DragLeave(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Drop files to decrypt here, \n or click to browse...";
        }

        private async void guna2Panel2_DragDrop(object sender, DragEventArgs e)
        {
            gunaLabel1.Text = "Drop files to decrypt here, \n or click to browse...";


            List<string> paths = new List<string>();
            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(obj))
                {
                    paths.AddRange(Directory.GetFiles(obj, "*.*", SearchOption.AllDirectories));
                
                }
                else
                {
                    paths.Add(obj);
                }
                
            }
            foreach(string line in paths)
            {
                await Task.Run(() => File.Encrypt(line));
                string filename = Path.GetFileName(line);
                AlertShow("File " +filename + " decrypted", AlertType.Info);
            }
        }

        async void guna2Panel2_Paint(object sender, PaintEventArgs e)

        {

            await Task.Run(async () =>

            {

                Pen pen = new Pen(Color.Black, 2);

                for (int i = 30; i > 2; i--, await Task.Delay(30))

                {

                    guna2Panel2.CreateGraphics().Clear(SystemColors.ControlLightLight);

                    pen.DashPattern = new float[] { 2, i };

                    guna2Panel2.CreateGraphics().DrawRectangle(pen, 1, 1, guna2Panel2.Width - 2, guna2Panel2.Height - 2);

                }

            });

        }

        private async void gunaLabel1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            List<string> paths = new List<string>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string obj in openFileDialog1.FileNames)
                {
                    if (Directory.Exists(obj))
                    {
                        paths.AddRange(Directory.GetFiles(obj, "*.*", SearchOption.AllDirectories));

                    }
                    else
                    {
                        paths.Add(obj);
                    }
                    foreach (string line in paths)
                    {
                        await Task.Run(() =>File.Encrypt(line));
                        string filename = Path.GetFileName(line);
                        AlertShow("File " + filename + " decrypted", AlertType.Info);

                    }
                }
            }
        }
    }
}
