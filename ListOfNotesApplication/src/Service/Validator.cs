using System;
using System.Drawing;

namespace ListOfNotesApplication.Service
{
    /// <summary>
    /// Статический класс с набором методов для проверки значений.
    /// </summary>
    public static class Validator
    {
        public static readonly Color BackColorSuccess = Color.White;

        public static readonly Color BackColorException = Color.LightPink;

        /// <summary>
        /// Проверка на длину строки.
        /// </summary>
        /// <param name="value">Входная строка.</param>
        /// <param name="width">Максимальная длина строки (в символах).</param>
        /// <param name="propertyName">Название св-ва.</param>
        /// <exception cref="ArgumentException">Возникает, когда длина <see cref="value"/> превышает максимальную <see cref="width"/>.</exception>
        public static void AssertStringMaxWidth(string value, int width, string propertyName)
        {
            if (value.Length > width)
            {
                throw new ArgumentException($"Значение \"{propertyName}\" не может иметь длину больше {width} знаков.");
            }
        }

        /// <summary>
        /// Проверяет, чтобы входная строка не была пустой и не null.
        /// </summary>
        /// <param name="value">Входная строка.</param>
        /// <exception cref="ArgumentException">Возникает, когда <see cref="value"/> пустое или null.</exception>
        public static void AssertNotNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Значение поля не может быть пустым!");
            }
        }
    }
}