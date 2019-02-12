using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TesteDGCTemplate
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<Registro> Registros { get; set; }

        public RelayCommand<Registro> EliminarCommand { get; private set; }

        public MainWindowViewModel()
        {

            Registros = new List<Registro>
            {
                new Registro() { ID = 1 },
                new Registro() { ID = 2 },
                new Registro() { ID = 3 },
                new Registro() { ID = 4 },
                new Registro() { ID = 5 }
            };

            EliminarCommand = new RelayCommand<Registro>(Eliminar_Execute);

        }

        private void Eliminar_Execute(Registro registro)
        {
            MessageBox.Show(registro.ID.ToString());
        }


    }
}
