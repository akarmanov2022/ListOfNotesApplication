using System.Collections.Generic;
using System.IO;
using ListOfNotesApplication.Model;
using Newtonsoft.Json;

namespace ListOfNotesApplication.Service
{
    /// <summary>
    /// Статический класс с набором методов для конвертирования объектов в строку json, и наоборот.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Сериализует коллекцию <see cref="Note"/> в файл json.
        /// </summary>
        /// <param name="notes">Список <see cref="Note"/>.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void NotesToJson(List<Note> notes, string filePath)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Сериализует файл json в <see cref="Note"/>.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns></returns>
        public static List<Note> fromJson(string path)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(path, false))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Note>>(reader) ?? new List<Note>();
            }
        }
    }
}