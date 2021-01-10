using System;

namespace MediatorWithObserverPattern
{
    public class ArticlesDialogBox
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            //articlesListBox.attach(new IObserver()
            //{
            //    public void update()
            //    {
            //        articleSelected();
            //    }
            //});

            //articlesListBox.attach(() => articleSelected());

            //articlesListBox.attach(this::articleSelected);

            //titleTextBox.attach(this::titleChanged);


            // without interface

            articlesListBox.attach(() => articleSelected());

            titleTextBox.attach(() => titleChanged());
        }

        public void simulateUserInteraction()
        {
            articlesListBox.selection = "Article 1";
            //titleTextBox.content = "";
            //articlesListBox.selection = "Article 2";
            Console.WriteLine("TextBox: " + titleTextBox.content);
            Console.WriteLine("Button: " + saveButton.isEnable);
        }

        private void titleChanged() => saveButton.isEnable = !string.IsNullOrEmpty(titleTextBox.content);
                
        private void articleSelected()
        {
            titleTextBox.content = articlesListBox.selection;
            saveButton.isEnable = true;
        }
    }
}
