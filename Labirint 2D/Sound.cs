using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Labirint_2D
{
    static class Sound
    {
        static SoundPlayer sount_fail = new SoundPlayer(Properties.Resources.Else);
        static SoundPlayer sount_Start = new SoundPlayer(Properties.Resources.Start);
        static SoundPlayer sount_Exit = new SoundPlayer(Properties.Resources.Exit);
        static SoundPlayer sound_Whine = new SoundPlayer(Properties.Resources.Whine);
        static bool sound_Enable=true;
        public static void Sound_on()
        {
            sound_Enable = true;
        }
        public static void sound_off()
        {
            sound_Enable = false;
        }

       public static void play_Whine()
        {
            if (sound_Enable)
            sound_Whine.Play();
        }
        public static void play_start()
        {
            if (sound_Enable )
                sount_Start.Play();
        }
        public static void play_exit()
        {
            if (sound_Enable)
                sount_Exit.Play();
        }
       public static void Play_Else()
        {
            if (sound_Enable)
                sount_fail.Play();
        }
    }
}
