using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class WorkClass
    {
        public static int LastPlayed;
        public static int PlayedIndex;
        /// <summary>
        /// Путь к данному приложению
        /// </summary>
        public static string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// Список полных имён файлов для вопспроизведения
        /// </summary>
        public static List<string> Files = new List<string>();
        /// <summary>
        /// получения имени файла
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileName(string file)
        {
            string[] temp = file.Split('\\');
            return temp[temp.Length - 1];
        }
    }
}

