using System;

namespace MediatorPattern
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            articlesListBox = new ListBox(this);
            titleTextBox = new TextBox(this);
            saveButton = new Button(this);
        }

        public void simulateUserInteraction()
        {
            articlesListBox.selection = "Article 1";
            titleTextBox.content = "";
            //articlesListBox.selection = "Article 2";
            Console.WriteLine("TextBox: " + titleTextBox.content);
            Console.WriteLine("Button: " + saveButton.isEnable);
        }

        public override void Changed(UIControl control)
        {
            if (control == articlesListBox)
                articleSelected();
            else if (control == titleTextBox)
                titleChanged();
        }

        private void titleChanged() => saveButton.isEnable = !string.IsNullOrEmpty(titleTextBox.content);
                
        private void articleSelected()
        {
            titleTextBox.content = articlesListBox.selection;
            saveButton.isEnable = true;
        }
    }
}
