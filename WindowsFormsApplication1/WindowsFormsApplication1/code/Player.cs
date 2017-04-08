using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Un4seen.Bass;

namespace WindowsFormsApplication1
{
    public static class Player
    {
        /// <summary>
        /// частота дескритизации
        /// </summary>
        private static int HZ = 44100;

        public static int hz { get { return HZ; } }
        /// <summary>
        /// флаг инициализации ядра
        /// </summary>
        private static bool InitDefaultDevice;
        public static bool initdefaultdevice { get { return InitDefaultDevice;} }
        /// <summary>
        /// дескриптор потока
        /// </summary>
        private static int Stream;
        public static int stream { get { return Stream; } }
        /// <summary>
        /// громкость
        /// </summary>
        private static int Volume = 100;
        public static int volume { get { return Volume;} }
        /// <summary>
        /// Дескрипторы подключаемых плагинов
        /// </summary>
        private static readonly List<int> PluginHandlers = new List<int>();
        /// <summary>
        /// инициализация ядра
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
            {
                Bass.BASS_Free();
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT,IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bass_aac.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bass_ac3.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bass_ape.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bass_mpc.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bass_tta.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bassalac.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bassflac.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\bassopus.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\basswma.dll"));
                    PluginHandlers.Add(Bass.BASS_PluginLoad(WorkClass.ApplicationPath + @"plugins\basswv.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < PluginHandlers.Count; i++)
                    {
                        if (PluginHandlers[i] == 0)
                            ErrorCount++;
                    }
                    if (ErrorCount != 0)
                    {
                        MessageBox.Show("Не загружено плагинов" + ErrorCount,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Warning);
                    }
                    ErrorCount = 0;
                }
            }
            return InitDefaultDevice;
        }
        /// <summary>
        /// стоп
        /// </summary>
        public static void Stop()
        {
            if (Stream != 0)
            {
                Bass.BASS_ChannelStop(Stream);
                Bass.BASS_StreamFree(Stream);
            }
        }
        /// <summary>
        /// установка громкости
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="vol"></param>
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);

        }
        /// <summary>
        /// воспроизведение
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="vol"></param>
        public static void Play(string FileName, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream)==BASSActive.BASS_ACTIVE_PAUSED)
            {
                Bass.BASS_ChannelPlay(Stream, false);
            }
            else
            {
                Stop();
                if (InitDefaultDevice)
                {
                    Stream = Bass.BASS_StreamCreateFile(FileName, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
        }
        /// <summary>
        /// длинна композиции
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetTimeOfStream(int stream)
        {
            long TimeBites = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBites);
            return (int) Time;
        }
        /// <summary>
        /// текущее положение воспроизведения
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetPosOfStream(int stream)
        {
            long PosBites = Bass.BASS_ChannelGetPosition(stream);
            double Pos = Bass.BASS_ChannelBytes2Seconds(stream, PosBites);
            return (int) Pos;
        }
        /// <summary>
        /// установка положения воспроизведения
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="pos"></param>
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double) pos);
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
            }
        }
    }
}
