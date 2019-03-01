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
	public class OTPScreenViewModel : BindableBase
	{
        private readonly INavigationService _navigationService;
        public OTPScreenViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private string _oTP;

        public string OTP
        {
            get { return _oTP; }
            set
            {
                _oTP = value;
                RaisePropertyChanged(nameof(OTP));
                if (string.IsNullOrEmpty(OTP))
                {
                    ErrorMsgOTP = "Required Field";
                    IsInputWrongOTP = true;
                }
                else if (!Regex.IsMatch(OTP, RegexPage.OTP().ToString()))
                {
                    ErrorMsgOTP = "";
                    IsInputWrongOTP = true;
                }
                else
                {
                    ErrorMsgOTP = string.Empty;
                    IsInputWrongOTP = false;
                }
            }
        }

        private string _errorMsgOTP;

        public string ErrorMsgOTP
        {
            get { return _errorMsgOTP; }
            set
            {
                _errorMsgOTP = value;
                RaisePropertyChanged(nameof(ErrorMsgOTP));
            }
        }
        private bool _isInputWrongOTP;

        public bool IsInputWrongOTP
        {
            get { return _isInputWrongOTP; }
            set
            {
                _isInputWrongOTP = value;
                RaisePropertyChanged(nameof(IsInputWrongOTP));
            }
        }
        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            if (string.IsNullOrWhiteSpace(OTP))
            {
                if (string.IsNullOrEmpty(OTP))
                {
                    ErrorMsgOTP = "Required Field";
                    IsInputWrongOTP = true;
                }
                else if (!Regex.IsMatch(OTP, RegexPage.OTP().ToString()))
                {
                    ErrorMsgOTP = "Input Format is not valid";
                    IsInputWrongOTP = true;
                }
                else
                {
                    ErrorMsgOTP = string.Empty;
                    IsInputWrongOTP = false;
                }
            }
            else if (OTP != "1234")
            {
                ErrorMsgOTP = "*Please enter valid OTP";
                IsInputWrongOTP = true;
            }

            else
            {
                await _navigationService.NavigateAsync("SignUp");

            }

        });
        public DelegateCommand ResendCommand => new DelegateCommand(async () =>
        {


            await _navigationService.NavigateAsync("OTPScreen");

        });
    }
}
