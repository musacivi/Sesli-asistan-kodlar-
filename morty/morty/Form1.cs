using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace morty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine recoEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSyn = new SpeechSynthesizer();
        bool izin;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }   
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            sestanima_ayarları();
            recoEngine.RecognizeAsync();
            izin = true;
        }
        void sestanima_ayarları()
        {
            string[] ihtimaller = { "Hello", "How are you", "Please open League Of Legends"," open mj","open the opera","open the youtube","open the Visual Studio","What time is it","Thank you MJ","Open the C"
              ,"Open the Unity","Open the game file","Open the game"};
            Choices seçenekler = new Choices(ihtimaller);
            Grammar grammar = new Grammar(new GrammarBuilder(seçenekler));
            recoEngine.LoadGrammar(grammar);
            recoEngine.SetInputToDefaultAudioDevice();
            recoEngine.SpeechRecognized += ses_tanıdıgında;

        }

        private void ses_tanıdıgında(object sender, SpeechRecognizedEventArgs e)
        {
            speechSyn.SelectVoiceByHints(VoiceGender.Female);
            if (izin == true)
            {
                pictureBox1.Visible = true;
                izin = false;
                if(e.Result.Text == "Please open League Of Legends")
                {
                    System.Diagnostics.Process.Start("C:\\Riot Games\\League of Legends");
                    if(radioButton1.Checked == true)
                    {
                        speechSyn.SpeakAsync("Okey Sir League Of Legends is opening");
                    }
                }
                if(e.Result.Text == "Hello")
                {
                    speechSyn.SpeakAsync("Hello sir How can ı help you"); 
                }
                if (e.Result.Text == "open mj")
                {
                    System.Diagnostics.Process.Start("C:\\Users\\90536\\Desktop\\cemre");
                    speechSyn.SpeakAsync(" Sir. Who is this beautiful woman");

                }
                if (e.Result.Text == "open the opera")
                {
                    System.Diagnostics.Process.Start("C:\\Users\\90536\\AppData\\Local\\Programs\\Opera\\launcher.exe");
                    speechSyn.SpeakAsync("Okey I opening opera");
                }
                if(e.Result.Text == "open the youtube")
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/signin?action_handle_signin=true&authuser=1&next=https%3A%2F%2Fwww.youtube.com%2F&feature=masthead_switcher&skip_identity_prompt=true");
                    speechSyn.SpeakAsync("Okey Sir Opening Opera");
                }
                if(e.Result.Text == "open the Visual Studio")
                {
                    System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\");
                    speechSyn.SpeakAsync("Yes sir");
                } 
                if(e.Result.Text == "What time is it")
                {

                    speechSyn.SpeakAsync("Time is"+DateTime.Today);
                }
                if(e.Result.Text == "Thank you MJ")
                {
                    speechSyn.SpeakAsync("You are welcome sir");
                }
                if (e.Result.Text == "Open the C")
                {
                    System.Diagnostics.Process.Start("C:\\");
                    speechSyn.SpeakAsync("C is opening");
                }
                if(e.Result.Text == "Open the Unity")
                {
                    System.Diagnostics.Process.Start("C:\\Program Files\\Unity Hub\\Unity Hub.exe");
                    
                    speechSyn.SpeakAsync("Unity is opening");
                }
                if (e.Result.Text == "Open the game file")
                {
                    System.Diagnostics.Process.Start("C:\\Users\\90536\\Desktop\\New folder (2)");
                    speechSyn.SpeakAsync("Game file is opening");
                }
                if (e.Result.Text == "Open the game")
                {
                    System.Diagnostics.Process.Start("C:\\Riot Games\\Riot Client");
                    speechSyn.SpeakAsync("Valorant is opening");
                }
               

            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void konuşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label1.Visible = false;
            radioButton1.Visible = false;
           
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = true;
            radioButton1.Visible = true;
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dil_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
