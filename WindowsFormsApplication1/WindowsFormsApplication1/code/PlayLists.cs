using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class PlayLists
    {
        /// <summary>
        /// текущий плейлист
        /// </summary>
        public static string CurrentPlayList;
        /// <summary>
        /// список всех плейлистов
        /// </summary>
        public static List<string> PlayListsArray = new List<string>();
        /// <summary>
        /// создание нового плейлиста
        /// </summary>
        public static void CreateNewPlayList()
        {
            PlayListsArray.Add(CurrentPlayList);
            File.Create(CurrentPlayList + ".txt");
        }
        /// <summary>
        /// открыть плейлист
        /// </summary>
        /// <returns></returns>
        public static string[] OpenPlayList()
        {
            string[] temp = File.ReadAllLines(CurrentPlayList + ".txt");
            return temp;
        }
        /// <summary>
        /// сохранить плейлист
        /// </summary>
        /// <param name="names"></param>
        public static void SavePlayList(List<string> names)
        {
            string[] temp = names.ToArray();
            File.WriteAllLines(CurrentPlayList + ".txt",temp);
        }
        /// <summary>
        /// сохранить список плейлистов
        /// </summary>
        public static void SavePlayListsArray()
        {
            string[] temp = PlayListsArray.ToArray();
            File.WriteAllLines("PlayLists.txt", temp);
        }
        /// <summary>
        /// открыть список плейлистов
        /// </summary>
        public static void OpenPlayListsArray()
        {
            string[] temp = File.ReadAllLines("PlayLists.txt");
            PlayListsArray.Clear();
            PlayListsArray.AddRange(temp);
        }
    }
}
