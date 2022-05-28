using System;
using ListOfNotesApplication.Service;

namespace ListOfNotesApplication.Model
{
    /// <summary>
    /// Представляет объект - заметка.
    /// </summary>
    public class Note : IComparable<Note>
    {
        /// <summary>
        /// Общий счетчик созданных экземпляров.
        /// </summary>
        private static int _allNotesCount;
        
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Note()
        {
            Id = _allNotesCount++;
            Category = Category.None;
        }
        
        /// <summary>
        /// Создает копию экземпляр класса <see cref="Note"/>.
        /// </summary>
        /// <param name="other">Исходный <see cref="Note"/>.</param>
        public Note(Note other)
        {
            Id = other.Id;
            Name = other.Name;
            Text = other.Text;
            Image = other.Image;
            Category = other.Category;
            DateTime = other.DateTime;
        }

        /// <summary>
        /// Возвращает или задает название <see cref="Note"/>.
        /// </summary>
        public string Name
        {
            get => _name ?? $"Note {Id}";
            set
            {
                Validator.AssertNotNull(value);
                Validator.AssertStringMaxWidth(value, 100, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает идентификатор объекта.
        /// </summary>
        public int Id { get; }
        
        /// <summary>
        /// Возвращает или задает картинку.
        /// </summary>
        public string Image { set; get; }

        public string Text { get; set; }

        /// <summary>
        /// Возвращает или задает категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает или задает время.
        /// </summary>
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

        public int CompareTo(Note other)
        {
            if (ReferenceEquals(this, other)) return 0;
            return ReferenceEquals(null, other)
                ? 1
                : other.DateTime.CompareTo(DateTime);
        }

        /// <summary>
        /// Проверяет, присутствует ли в полях объекта искомая строка.
        /// </summary>
        /// <param name="text">Искомая строка.</param>
        /// <returns>Вернет true, если искомая строка присутствует в полях объекта, иначе - false.</returns>
        public bool Contains(string text)
        {
            return (Text?.Contains(text) ?? false)
                   || (Name?.Contains(text) ?? false);
        }
    }
}