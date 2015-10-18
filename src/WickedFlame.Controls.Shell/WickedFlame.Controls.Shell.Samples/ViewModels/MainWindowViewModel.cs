using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WickedFlame.Common.Mvvm;
using WickedFlame.Common.Mvvm.Commands;
using WickedFlame.Controls.Shell;

namespace WickedFlame.Controls.Shell.Samples.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        bool _isMainView;
        public bool IsMainView
        {
            get
            {
                return _isMainView;
            }
            set
            {
                _isMainView = value;
                OnPropertyChanged(() => IsMainView);
            }
        }

        ContentControl _content;
        public ContentControl Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                OnPropertyChanged(() => Content);
                IsMainView = _content == null;
            }
        }

        ICommand _showSubviewCommand;
        public ICommand ShowSubviewCommand
        {
            get
            {
                if (_showSubviewCommand == null)
                {
                    _showSubviewCommand = new RelayCommand(() =>
                      {
                          Content = new SubView
                          {
                              Content = new Border
                              {
                                  Background = Brushes.White
                              },
                              BackCommand = new RelayCommand(()=>
                              {
                                  Content = null;
                              })
                          };
                      });
                }

                return _showSubviewCommand;
            }
        }
    }
}
