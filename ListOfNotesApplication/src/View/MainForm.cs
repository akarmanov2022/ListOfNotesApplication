using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ListOfNotesApplication.Model;
using ListOfNotesApplication.Service;

namespace ListOfNotesApplication.View
{
    /// <summary>
    /// Представляет главную форму приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов <see cref="Note"/>.
        /// </summary>
        private List<Note> _notes;

        /// <summary>
        /// Текущий объект <see cref="Note"/>.
        /// </summary>
        private Note _currentNote;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public MainForm()
        {
            _currentNote = new Note();
            InitializeComponent();

            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }

            ExceptionNameLabel.ForeColor = Validator.BackColorException;
            NotesListBox.SelectionMode = SelectionMode.One;
            CategoryComboBox.SelectedIndex = 0;
            NotePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Icon = new Icon(@"noted_64.ico");

            CreateFilesToAppData();
            LoadNoteFromJson();
            UpdateNoteListBox(_notes);
        }

        /// <summary>
        /// Метод очистки полей на форме.
        /// </summary>
        private void ClearTextFields()
        {
            NameTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            MultiLineTextBox.Text = string.Empty;
            NotePictureBox.Image = null;
        }

        /// <summary>
        /// Обновление данных на форме.
        /// </summary>
        private void UpdateNoteInfo()
        {
            var index = NotesListBox.SelectedIndex;
            _currentNote.DateTime = DateTime.Now;
            var note = new Note(_currentNote);
            var notes = _notes;
            notes[index] = note;
            UpdateNoteListBox(notes);
            NotesListBox.SelectedIndex = notes.FindIndex(n => n.Id.Equals(note.Id));
            
            _notes = notes;
        }

        /// <summary>
        /// Создает мета-данные приложения в папке AppData.
        /// </summary>
        private static void CreateFilesToAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "List Of Notes");
                
                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);
                
                var filePath = Path.Combine(appDataPath, "List Of Notes\\save_notes.json");
                
                if (File.Exists(filePath)) return;
                File.Create(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Обновление данных в списке.
        /// </summary>
        /// <param name="notes">Список объектов <see cref="Note"/>.</param>
        private void UpdateNoteListBox(List<Note> notes)
        {
            notes.Sort();
            NotesListBox.Items.Clear();
            var arrayList = new ArrayList(notes);
            NotesListBox.Items.AddRange(arrayList.ToArray());
        }

        /// <summary>
        /// Загрузка данных из файла на форму.
        /// </summary>
        private void LoadNoteFromJson()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, "List Of Notes\\save_notes.json");
            _notes = Serializer.fromJson(filePath);
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            var notes = _notes;
            var note = new Note
            {
                DateTime = DateTime.Now
            };
            notes.Add(note);
            UpdateNoteListBox(notes);
            _notes = notes;
        }

        private void AddNoteButton_MouseEnter(object sender, EventArgs e)
        {
            AddNoteButton.Image = Resources.note_add_24x24;
        }

        private void AddNoteButton_MouseLeave(object sender, EventArgs e)
        {
            AddNoteButton.Image = Resources.note_add_24x24_uncolor;
        }

        private void EditNoteButton_MouseEnter(object sender, EventArgs e)
        {
            EditNoteButton.Image = Resources.note_edit_24x24;
        }

        private void EditNoteButton_MouseLeave(object sender, EventArgs e)
        {
            EditNoteButton.Image = Resources.note_edit_24x24_uncolor;
        }

        private void RemoveNoteButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveNoteButton.Image = Resources.note_remove_24x24;
        }

        private void RemoveNoteButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveNoteButton.Image = Resources.note_remove_24x24_uncolor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text)) SearchTextBox.Text = "";
            if (CategoryComboBox.SelectedIndex == -1) return;
            if (NotesListBox.SelectedIndex == -1) return;

            var category = (Category)CategoryComboBox.SelectedItem;
            _currentNote.Category = category;

            if (CategoryComboBox.Focused) UpdateNoteInfo();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text)) SearchTextBox.Text = "";
            ExceptionNameLabel.Visible = false;
            AddNoteButton.Enabled = true;
            NameTextBox.BackColor = Validator.BackColorSuccess;
            try
            {
                if (NameTextBox.Text == string.Empty) return;
                if (NotesListBox.SelectedIndex == -1) return;
                _currentNote.Name = NameTextBox.Text;
                if (NameTextBox.Focused) UpdateNoteInfo();
            }
            catch (Exception exception)
            {
                NameTextBox.BackColor = Validator.BackColorException;
                ExceptionNameLabel.Text = exception.Message;
                ExceptionNameLabel.Visible = true;
                AddNoteButton.Enabled = false;
            }
        }

        private void MultiLineTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text)) SearchTextBox.Text = "";
            if (MultiLineTextBox.Text == string.Empty) return;
            var text = MultiLineTextBox.Text;
            _currentNote.Text = text;

            if (MultiLineTextBox.Focused) UpdateNoteInfo();
        }

        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1) return;

            var notes = _notes;
            var index = NotesListBox.SelectedIndex;
            notes.RemoveAt(index);
            UpdateNoteListBox(notes);
            _notes = notes;

            ClearTextFields();

            if (notes.Count != 0) return;
            RemoveNoteButton.Enabled = false;
            EditNoteButton.Enabled = false;
            OpenFileButton.Enabled = false;
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            var note = (Note)NotesListBox.Items[index];
            _currentNote = new Note(note);

            NameTextBox.Text = _currentNote.Name;
            CategoryComboBox.SelectedIndex = _currentNote.Category.GetHashCode();
            MultiLineTextBox.Text = _currentNote.Text;

            if (!string.IsNullOrEmpty(_currentNote.Image))
            {
                NotePictureBox.Image = Converter.Base64ToImage(_currentNote.Image);
                DeleteFileButton.Enabled = true;
            }
            else
            {
                NotePictureBox.Image = null;
                DeleteFileButton.Enabled = false;
            }

            RemoveNoteButton.Enabled = true;
            EditNoteButton.Enabled = true;
            OpenFileButton.Enabled = true;
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1) return;

            UpdateNoteInfo();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(appDataPath, "List Of Notes\\save_notes.json");
            var notes = _notes;
            Serializer.NotesToJson(notes, filePath);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == string.Empty)
            {
                UpdateNoteListBox(_notes);
            }
            else
            {
                var text = SearchTextBox.Text;
                var notes = _notes;
                var searchNotes = from note in notes 
                    where note.Contains(text) 
                    select note;
                UpdateNoteListBox(searchNotes.ToList());
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"(*.png)|*.png";
            openFileDialog.Title = @"Выбор картинки";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var fileName = openFileDialog.FileName;
            var image = Image.FromFile(fileName);
            _currentNote.Image = Converter.ImageToBase64(image);
            NotePictureBox.Image = image;
            DeleteFileButton.Enabled = true;
            UpdateNoteInfo();
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            if (NotePictureBox.Image == null) return;
            NotePictureBox.Image = null;
            _currentNote.Image = null;
            DeleteFileButton.Enabled = false;
        }
    }
}