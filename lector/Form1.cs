using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Speech.Recognition;
using System.Collections;
using System.Globalization;
using System.Diagnostics;


//using System.Diagnostics;

namespace lector
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer lector = new SpeechSynthesizer();
        SpeechRecognitionEngine reconocer = new SpeechRecognitionEngine(new CultureInfo("es-MX",true));
       string archivo = "";
        string texto = "";
     
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            


        }

        private void leer_Click(object sender, EventArgs e)
        {
            
                //lector.Speak(archivo);
                lector.SpeakAsync(archivo);
            lector.SpeakAsync(txtArchivo.Text);
                

         
          
        }
        private void detener_Click(object sender, EventArgs e)
        {
            if(lector != null)
            {
                if(lector.State == SynthesizerState.Speaking)
                {
                    lector.Pause(); detener.Text = "pausado";
                    
                }else if (lector.State == SynthesizerState.Paused)
                {
                    lector.Resume(); detener.Text = "reamudar";
                }
            }

        }

        private void buscador_Click(object sender, EventArgs e)
        {

            //using (OpenFileDialog archivo = new OpenFileDialog())
            // {

            // archivo.InitialDirectory = "C:\\";
            // archivo.Filter = "txt files (*.txt)|*.txt";
            // }
            //Process.Start("explorer.exe");
            //texto = buscarTxt.Text;
            //try
            //{


            //    archivo = File.ReadAllText(texto);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);

            //}



            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


               
                //MessageBox.Show(filePath);
            }
            archivo = File.ReadAllText(filePath);
            buscarTxt.Text = filePath;
            txtArchivo.Text = fileContent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lector != null)
            {
                lector.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lector = new SpeechSynthesizer();
                using (SaveFileDialog guardar = new SaveFileDialog())
                {


                    guardar.Filter = "mp3 files|.mp3";
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        lector.SpeakAsync(archivo);
                        lector.SpeakAsync(txtArchivo.Text);
                        FileStream team = new FileStream(guardar.FileName, FileMode.Create, FileAccess.Write);
                        lector.SetOutputToWaveStream(team);
                    }
                   
                    
                


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Choices palabras = new Choices(new string[] { "buscar", "hola", });
                //GrammarBuilder buscar = new GrammarBuilder(palabras);
                //buscar.Append(palabras);
                //Grammar nuevas = new Grammar(buscar);
                //reconocer.LoadGrammar(nuevas);



                reconocer.LoadGrammar(new DictationGrammar());
                reconocer.RequestRecognizerUpdate();
                reconocer.SetInputToDefaultAudioDevice();
                reconocer.RecognizeAsync(RecognizeMode.Multiple);
                reconocer.SpeechRecognized += Reconocer_SpeechRecognized;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }

        private void Reconocer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
                foreach (RecognizedWordUnit item in e.Result.Words)
                {
                    txtArchivo.Text += $" {item.Text}" ;

                }
            texto = e.Result.Text;
            switch (texto) 
            {
                case "hola":
                    lector.Speak("hola Que se necesita");
                    break;
                case "buscar":
                      lector.SpeakAsync("abriendo buscador");
                    Process.Start("https://www.google.com.ar/");
                    break;
                default:
                    break;
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            reconocer.RecognizeAsyncStop();
        }
    }
}
