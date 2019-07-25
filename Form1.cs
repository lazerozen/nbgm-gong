using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace NbgmGong
{
    public partial class Form1 : Form
    {
        private readonly WaveOut _waveOut;
        private bool _isPlaying = false;
        private Mp3FileReader _mp3Reader;
        public Form1()
        {
            InitializeComponent();
            _waveOut = new WaveOut();

            //_mp3Reader = new Mp3FileReader(new MemoryStream(Properties.Resources.Gong_Variante_1));
            //_waveOut = new WaveOut(); // or WaveOutEvent()
            //_waveOut.Init(_mp3Reader);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (_waveOut.PlaybackState == PlaybackState.Playing)
                return;

            _mp3Reader = new Mp3FileReader(new MemoryStream(Properties.Resources.Gong_Variante_1));
            _waveOut.Init(_mp3Reader);
            _waveOut.Play();
        }
    }
}
