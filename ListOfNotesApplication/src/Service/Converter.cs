using System;
using System.Drawing;
using System.IO;

namespace ListOfNotesApplication.Service
{
    /// <summary>
    /// Статический класс с набором методов для конвертирования изображения в строку в кодировке Base64, и наоборот.
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Преобразует объект <see cref="Image"/> в эквивалентное строковое представление, состоящее из цифр в кодировке Base64.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string ImageToBase64(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                var bytes = ms.ToArray();
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Преобразует заданную строку, представляющую двоичные данные в виде цифр в кодировке Base64, в эквивалентный объект <see cref="Image"/>.
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static Image Base64ToImage(string base64String)
        {
            var bytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}