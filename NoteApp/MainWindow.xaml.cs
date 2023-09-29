using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Windows.Globalization.DateTimeFormatting;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NoteApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        ObservableCollection<Note> notes = new ObservableCollection<Note>();

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }

        private void createNoteButton_Click(object sender, RoutedEventArgs e)
        {
            string dateString = "-";
            if(NoteDatePicker.Date.HasValue)
            {
                dateString = NoteDatePicker.Date.Value.ToString("dd-MM-yyyy");
            }
            notes.Add(new Note(NameBox.Text, dateString,notes.Count+1));
        }

         private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(Note note in notes.ToList())
            {
                if(note.Checked == true)
                {
                     notes.Remove(note);
                }
            }
        }
    }
}
