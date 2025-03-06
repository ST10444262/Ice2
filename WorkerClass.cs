using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace Ice2
{
    class WorkerClass
    {
        public WorkerClass()
        {

        }
        public void PlayAudio()
        {
            //.wav file locations
            String wav1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "eastwood_lawyers.wav");
            String wav2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edison.wav");
            String wav3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "graham_any_nation.wav");

            //Create object for each sound
            SoundPlayer player1 = new SoundPlayer(wav1);
            SoundPlayer player2 = new SoundPlayer(wav2);
            SoundPlayer player3 = new SoundPlayer(wav3);

            //Load and play each sound
            player1.PlaySync();
            player1.PlaySync();
            player3.PlaySync();


        }
      


    }
}
//--------------------------END OF FILE------------------------------///