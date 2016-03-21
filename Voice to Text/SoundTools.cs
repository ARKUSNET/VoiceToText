using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CUETools.Codecs;
using CUETools.Codecs.FLAKE;

namespace Voice_to_Text
{
    class SoundTools
    {
        /// <summary> Конвертирование wav-файла во flac </summary>        
        /// <returns>Частота дискретизации</returns>
        public static int Wav2Flac(String wavName, string flacName)
        {
            int sampleRate = 0;

            IAudioSource audioSource = new WAVReader(wavName, null);
            AudioBuffer buff = new AudioBuffer(audioSource, 0x10000);

            FlakeWriter flakewriter = new FlakeWriter(flacName, audioSource.PCM);
            sampleRate = audioSource.PCM.SampleRate;

            FlakeWriter audioDest = flakewriter;
            while (audioSource.Read(buff, -1) != 0)
            {
                audioDest.Write(buff);
            }
            audioDest.Close();

            audioDest.Close();

            return sampleRate;
        }
    }
}