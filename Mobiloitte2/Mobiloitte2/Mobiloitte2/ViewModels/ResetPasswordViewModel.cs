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
	public class ResetPasswordViewModel : BindableBase
	{
        private readonly INavigationService _navigationService;
        public ResetPasswordViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private string _inputPassword;
        private string _errorMsgPassword;
        private bool _isInputWrongPassword;
        private string _inputCPassword;
        private string _errorMsgCPassword;
        private bool _isInputWrongCPassword;
        private readonly Regex PasswordRegex = new Regex("\b");


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
        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            if (string.IsNullOrWhiteSpace(InputPassword) || string.IsNullOrWhiteSpace(InputCPassword))
            {
                if(string.IsNullOrEmpty(InputPassword))
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
            else if (!Regex.IsMatch(InputPassword, RegexPage.PasswordRegex().ToString()))
            {
                ErrorMsgPassword = "Password contain must atleast 8 char, including Upper/lowercase,Special char and number";
                IsInputWrongPassword = true;
            }
            else if (InputCPassword != InputPassword)
            {
                ErrorMsgCPassword = "not match with new password";
                IsInputWrongCPassword = true;
            }
            else
            {
                await _navigationService.NavigateAsync("MainPage");

            }

        });
    }
}
