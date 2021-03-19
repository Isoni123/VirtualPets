using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace VirtualPets.AppWPF.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName;

        public string FullName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

    }
}
