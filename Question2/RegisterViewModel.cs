using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

public class RegisterViewModel : INotifyPropertyChanged
{
    private string email;
    public string Email
    {
        get => email;
        set
        {
            email = value;
            OnPropertyChanged();
            Validate();
        }
    }

    private void OnPropertyChanged()
    {
        throw new NotImplementedException();
    }

    private string password;
    public string Password
    {
        get => password;
        set
        {
            password = value;
            OnPropertyChanged();
            Validate();
        }
    }

    private bool isChecked;
    public bool IsChecked
    {
        get => isChecked;
        set
        {
            isChecked = value;
            OnPropertyChanged();
            Validate();
        }
    }

    private bool isValid;
    public bool IsValid
    {
        get => isValid;
        set
        {
            isValid = value;
            OnPropertyChanged();
        }
    }

    public ICommand RegisterCommand { get; set; }
    public ICommand UpdateIsCheckedCommand { get; set; }

    private void Validate()
    {
        IsValid = IsEmailValid() && IsPasswordValid() && IsChecked;
    }

    private bool IsEmailValid()
    {
        // validate email
        return true;
    }

    private bool IsPasswordValid()
    {
        // validate password
        return true;
    }

    public event PropertyChangedEventHandler PropertyChanged;

}