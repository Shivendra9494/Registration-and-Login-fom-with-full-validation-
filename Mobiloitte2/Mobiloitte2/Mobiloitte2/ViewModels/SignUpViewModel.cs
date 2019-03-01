using Mobiloitte2.Behaviours;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mobiloitte2.ViewModels
{
	public class SignUpViewModel : BindableBase
	{
        private readonly INavigationService _navigationService;
        private readonly Regex FirstNameRegex = new Regex("\b");
        private readonly Regex PhoneRegex = new Regex("\b");
        public SignUpViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value;
                RaisePropertyChanged(nameof(FirstName));
                if (string.IsNullOrEmpty(FirstName))
                {
                    ErrorMsgFirstName = "Required Field";
                    IsInputWrongFirstName = true;
                }
                else if (!Regex.IsMatch(FirstName, RegexPage.FirstNameRegex().ToString()))
                {
                    ErrorMsgFirstName = "*please enter valid name";
                    IsInputWrongFirstName = true;
                }
                else
                {
                    ErrorMsgFirstName = string.Empty;
                    IsInputWrongFirstName = false;
                }
            }
        }
        private string _errorMsgFirstName;

        public string ErrorMsgFirstName
        {
            get { return _errorMsgFirstName; }
            set { _errorMsgFirstName = value;
                RaisePropertyChanged(nameof(ErrorMsgFirstName));
            }
        }
        private bool _isInputWrongFirstName;

        public bool IsInputWrongFirstName
        {
            get { return _isInputWrongFirstName; }
            set { _isInputWrongFirstName = value;
                RaisePropertyChanged(nameof(IsInputWrongFirstName));
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                RaisePropertyChanged(nameof(LastName));
                if (string.IsNullOrEmpty(LastName))
                {
                    _errorMsgLastName = "Required Field";
                    IsInputWrongLastName = true;
                }
                else if (!Regex.IsMatch(LastName, RegexPage.FirstNameRegex().ToString()))
                {
                    ErrorMsgLastName = "*please enter valid name";
                    IsInputWrongLastName = true;
                }
                else
                {
                    ErrorMsgLastName = string.Empty;
                    IsInputWrongLastName = false;
                }
            }
        }
        private string _errorMsgLastName;

        public string ErrorMsgLastName
        {
            get { return _errorMsgLastName; }
            set { _errorMsgLastName = value;
                RaisePropertyChanged(nameof(ErrorMsgLastName));
            }
        }
        private bool _isInputWrongLastName;

        public bool IsInputWrongLastName
        {
            get { return _isInputWrongLastName; }
            set { _isInputWrongLastName = value;
                RaisePropertyChanged(nameof(IsInputWrongLastName));
            }
        }

        private string _inputEmail;
        private string _errorMsgEmail;
        private bool _isInputWrongEmail;

        public string InputEmail
        {
            get
            { return _inputEmail; }
            set
            {
                _inputEmail = value;
                RaisePropertyChanged(nameof(InputEmail));
                if (string.IsNullOrEmpty(InputEmail))
                {
                    ErrorMsgEmail = "Required Field";
                    IsInputWrongEmail = true;
                }
                else if (!Regex.IsMatch(InputEmail, RegexPage.EmailRegex().ToString()))
                {
                    ErrorMsgEmail = "please enter valid email id";
                    IsInputWrongEmail = true;
                }
                else
                {
                    ErrorMsgEmail = string.Empty;
                    IsInputWrongEmail = false;
                }
            }
        }

        public string ErrorMsgEmail
        {
            get { return _errorMsgEmail; }
            set
            {
                _errorMsgEmail = value;
                RaisePropertyChanged(nameof(ErrorMsgEmail));
            }
        }

        public bool IsInputWrongEmail
        {
            get { return _isInputWrongEmail; }
            set
            {
                _isInputWrongEmail = value;
                RaisePropertyChanged(nameof(IsInputWrongEmail));
            }
        }
        private string _inputPassword;
        private string _errorMsgPassword;
        private bool _isInputWrongPassword;
        private string _inputCPassword;
        private string _errorMsgCPassword;
        private bool _isInputWrongCPassword;
        private string _inputPhone;
        private readonly Regex PasswordRegex = new Regex("\b");


        public string InputPhone
        {
            get { return _inputPhone; }
            set { _inputPhone = value;
                RaisePropertyChanged(nameof(InputPhone));
                if (string.IsNullOrEmpty(InputPhone))
                {
                    ErrorMsgPhone = "Required Field";
                    IsInputWrongPhone = true;
                }
                else if (!Regex.IsMatch(InputPhone, RegexPage.PhoneRegex().ToString()))
                {
                    ErrorMsgPhone = "please enter valid phone no.";
                    IsInputWrongPhone = true;
                }
                else
                {
                    ErrorMsgPhone = string.Empty;
                    IsInputWrongPhone = false;
                }
            }
        }
        private string _errorMsgPhone;

        public string ErrorMsgPhone
        {
            get { return _errorMsgPhone; }
            set { _errorMsgPhone = value;
                RaisePropertyChanged(nameof(ErrorMsgPhone));
            }
        }
        private bool _isInputWrongPhone;

        public bool IsInputWrongPhone
        {
            get { return _isInputWrongPhone; }
            set { _isInputWrongPhone = value;
                RaisePropertyChanged(nameof(IsInputWrongPhone));
            }
        }
        public string InputPassword
        {
            get { return _inputPassword; }
            set
            {
                _inputPassword = value;
                RaisePropertyChanged(nameof(InputPassword));
                if (string.IsNullOrEmpty(InputPassword))
                {
                    ErrorMsgPassword = "Required Field";
                    IsInputWrongPassword = true;
                }
                else if (!Regex.IsMatch(InputPassword, RegexPage.PasswordRegex().ToString()))
                {
                    ErrorMsgPassword = "Password contain must atleast 8 char, including Upper/lowercase,Special char and number";
                    IsInputWrongPassword = true;
                }
                else
                {
                    ErrorMsgPassword = string.Empty;
                    IsInputWrongPassword = false;
                }
            }

        }


        public string ErrorMsgPassword
        {
            get { return _errorMsgPassword; }
            set
            {
                _errorMsgPassword = value;
                RaisePropertyChanged(nameof(ErrorMsgPassword));
            }
        }



        public bool IsInputWrongPassword
        {
            get { return _isInputWrongPassword; }
            set
            {
                _isInputWrongPassword = value;
                RaisePropertyChanged(nameof(IsInputWrongPassword));
            }
        }

        public string InputCPassword
        {
            get { return _inputCPassword; }
            set
            {
                _inputCPassword = value;
                RaisePropertyChanged(nameof(InputCPassword));
                if (string.IsNullOrEmpty(InputCPassword))
                {
                    ErrorMsgCPassword = "Required Field";
                    IsInputWrongCPassword = true;
                }
                else if (!Regex.IsMatch(InputCPassword, RegexPage.PasswordRegex().ToString()))
                {
                    ErrorMsgCPassword = "Password contain must atleast 8 char, including Upper/lowercase,Special char and number";
                    IsInputWrongCPassword = true;
                }
                else
                {
                    ErrorMsgCPassword = string.Empty;
                    IsInputWrongCPassword = false;
                }
            }

        }
        public string ErrorMsgCPassword
        {
            get { return _errorMsgCPassword; }
            set
            {
                _errorMsgCPassword = value;
                RaisePropertyChanged(nameof(ErrorMsgCPassword));
            }
        }



        public bool IsInputWrongCPassword
        {
            get { return _isInputWrongCPassword; }
            set
            {
                _isInputWrongCPassword = value;
                RaisePropertyChanged(nameof(IsInputWrongCPassword));
            }
        }

        private DateTime _minDate = DateTime.Now.AddYears(-50);

        public DateTime MinDate
        {
            get { return _minDate; }
            set
            {
                _minDate = value;
                RaisePropertyChanged(nameof(MinDate));
            }
        }
        private DateTime _maxDate = DateTime.Now;

        public DateTime MaxDate
        {
            get { return _maxDate; }
            set
            {
                _maxDate = value;
                RaisePropertyChanged(nameof(MaxDate));
            }
        }

        private DateTime _selectedDate = DateTime.Today;

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                RaisePropertyChanged(nameof(SelectedDate));
            }
        }
        public DelegateCommand SignInTap => new DelegateCommand(async () =>
        {
            if (string.IsNullOrWhiteSpace(InputEmail) || string.IsNullOrWhiteSpace(InputPassword) || string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(InputPhone) || string.IsNullOrWhiteSpace(InputPassword))
            {
                if (string.IsNullOrEmpty(FirstName))
                {
                    ErrorMsgFirstName = "Required Field";
                    IsInputWrongFirstName = true;
                }
                else if (!Regex.IsMatch(FirstName, RegexPage.FirstNameRegex().ToString()))
                {
                    ErrorMsgFirstName = "*please enter valid name";
                    IsInputWrongFirstName = true;
                }
                else
                {
                    ErrorMsgFirstName = string.Empty;
                    IsInputWrongFirstName = false;
                }

                if (string.IsNullOrEmpty(LastName))
                {
                    _errorMsgLastName = "Required Field";
                    IsInputWrongLastName = true;
                }
                else if (!Regex.IsMatch(LastName, RegexPage.FirstNameRegex().ToString()))
                {
                    ErrorMsgLastName = "*please enter valid name";
                    IsInputWrongLastName = true;
                }
                else
                {
                    ErrorMsgLastName = string.Empty;
                    IsInputWrongLastName = false;
                }
                if (string.IsNullOrEmpty(InputEmail))
                {
                    ErrorMsgEmail = "Required Field";
                    IsInputWrongEmail = true;
                }
                else if (!Regex.IsMatch(InputEmail, RegexPage.EmailRegex().ToString()))
                {
                    ErrorMsgEmail = "please enter valid email id";
                    IsInputWrongEmail = true;
                }
                else
                {
                    ErrorMsgEmail = string.Empty;
                    IsInputWrongEmail = false;
                }
                if (string.IsNullOrEmpty(InputPhone))
                {
                    ErrorMsgPhone = "Required Field";
                    IsInputWrongPhone = true;
                }
                else if (!Regex.IsMatch(InputPhone, RegexPage.PhoneRegex().ToString()))
                {
                    ErrorMsgPhone = "please enter valid phone no.";
                    IsInputWrongPhone = true;
                }
                else
                {
                    ErrorMsgPhone = string.Empty;
                    IsInputWrongPhone = false;
                }
                if (string.IsNullOrEmpty(InputPassword))
                {
                    ErrorMsgPassword = "Required Field";
                    IsInputWrongPassword = true;
                }
                else if (!Regex.IsMatch(InputPassword, RegexPage.PasswordRegex().ToString()))
                {
                    ErrorMsgPassword = "Password contain must atleast 8 char, including Upper/lowercase,Special char and number";
                    IsInputWrongPassword = true;
                }
                else
                {
                    ErrorMsgPassword = string.Empty;
                    IsInputWrongPassword = false;
                }
                if (string.IsNullOrEmpty(InputCPassword))
                {
                    ErrorMsgCPassword = "Required Field";
                    IsInputWrongCPassword = true;
                }
                else if (!Regex.IsMatch(InputCPassword, RegexPage.PasswordRegex().ToString()))
                {
                    ErrorMsgCPassword = "Password contain must atleast 8 char, including Upper/lowercase,Special char and number";
                    IsInputWrongCPassword = true;
                }
                else
                {
                    ErrorMsgCPassword = string.Empty;
                    IsInputWrongCPassword = false;
                }
                
            }
            else if (InputCPassword != InputPassword)
            {
                ErrorMsgCPassword = "not match with new password";
                IsInputWrongCPassword = true;
            }

            else
            {
                await _navigationService.NavigateAsync("ResetPassword");
            }



        });
        
    }
}
