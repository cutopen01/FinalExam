using System.Security.Cryptography.X509Certificates;

namespace Question4;

public partial class profile : ContentPage
{
    public profile()
    {
        InitializeComponent();

        List<Contact> contacts = new List<Contact>() {
            new Contact { Image = new Image { Source = "dotnet_bot.svg" }, Name="Jenny Dalby", Description="My name is Jenny Dalby"},
            new Contact { Name="Jonv", Description="My name is Jonv"},
            new Contact { Name="RachelMartin", Description="My name is RachelMartin"},
            new Contact { Name="Nivan Jay", Description="My name is Nivan Jay"},
            new Contact { Name="SanazZ", Description="My name is SanazZ"},
            new Contact { Name="NextLab", Description="My name is NextLab"},
            new Contact { Name="Alex B", Description="My name is Alex B"},
            new Contact { Name="Tara Chang", Description="My name is Tara Chang"},
            new Contact { Name="Tom K", Description="My name is Tom K"}


        };

        listContacts.ItemsSource = contacts;
    }

    public class Contact
    {

        public Image Image { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}