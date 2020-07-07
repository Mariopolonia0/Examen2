using Examen2.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Examen1.UI.Registro
{
    /// <summary>
    /// Interaction logic for rpre.xaml
    /// </summary>
    public partial class rProyecto : Window
    {
        private Proyectos proyecto = new Proyectos();
        public rProyecto()
        {
            InitializeComponent();
            this.DataContext = proyecto;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyecto;
        }

        private void Limpiar()
        {
            this.proyecto = new Proyectos();
            this.DataContext = proyecto;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        
    }
}



/*
 
     

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Tareas encontrado = TareasBLL.Buscar(Tarea.TareaId);

            if(encontrado != null)
            {
                Tarea = encontrado;
                Cargar();
                MessageBox.Show("Tarea encontrada", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Tarea no existe en la base de datos","Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            Tarea.Detalle.Add(new TareasDetalle(Tarea.TareaId, RequerimientoTextBox.Text, Convert.ToSingle(ValorTextBox.Text)));

            Cargar();

            RequerimientoTextBox.Clear();
            ValorTextBox.Clear();
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if(DetalleDataGrid.Items.Count > 1 && DetalleDataGrid.SelectedIndex < DetalleDataGrid.Items.Count - 1)
            {
                Tarea.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Tareas esValido = TareasBLL.Buscar(Tarea.TareaId);

            return (esValido != null);
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            if (Tarea.TareaId == 0)
            {
                paso = TareasBLL.Guardar(Tarea);
            }
            else
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    paso = TareasBLL.Guardar(Tarea);
                }
                else
                {
                    MessageBox.Show("No existe en la base de datos", "ERROR");
                }
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Fallo al guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Tareas existe = TareasBLL.Buscar(Tarea.TareaId);

            if(existe == null)
            {
                MessageBox.Show("No existe la tarea en la base de datos","Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else 
            {
                TareasBLL.Eliminar(Tarea.TareaId);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }


    }
     
     */
