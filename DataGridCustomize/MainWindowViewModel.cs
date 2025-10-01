using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridCustomize
{
    public partial class MainWindowViewModel: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<UserViewModel> _users;

        public MainWindowViewModel()
        {
            _users = new ObservableCollection<UserViewModel>
            {
                new UserViewModel
                {
                    Id = 101,
                    Name = "Taro Suzuki",
                    Description = "He is a software engineer.",
                    IsNative = false
                },
                new UserViewModel
                {
                    Id = 102,
                    Name = "Hanako Yamada",
                    Description = "She is a designer.",
                    IsNative = false
                },
                new UserViewModel
                {
                    Id = 103,
                    Name = "Jiro Sato",
                    Description = "He is a project manager.",
                    IsNative = false
                }
            };
        }
    }
}
