using System.Security.Cryptography.X509Certificates;

namespace FinalExam;

public partial class listview : ContentPage
{
    public listview()
    {
        InitializeComponent();

        List<Contact> contacts = new List<Contact>() {
            new Contact { Name="Omelandah", Email="omelandah@vought.com"},
            new Contact { Name="Alex the Frog", Email="alex@rep.com"},
            new Contact { Name="Jorgunmandr", Email="afraidof@noone.com"},
            new Contact { Name="Michael Scarn", Email="michaelscott@dundermifflin.com"},
            new Contact { Name="Waltuh White", Email="heisenberg@meth.com"}
        };

        listContacts.ItemsSource = contacts;
    }

    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}