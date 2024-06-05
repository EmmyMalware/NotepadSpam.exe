using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace NotepadSpam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            runButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (MessageBox.Show("ARE YOU REALLY SURE YOU WANT TO?\r\nCONTINUNE AT YOUR OWN RISK", "NotepadSpam", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SoundPlayer fuckboi420 = new SoundPlayer(NotepadSpam.Properties.Resources.Rain);
                fuckboi420.PlayLooping();
                while (true)
                {
                    Process.Start("notepad.exe");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            runButton.Enabled = true;
        }
    }
}
