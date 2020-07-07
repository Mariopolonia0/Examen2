using Examen1.BLL;
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
        private TareaDetalle detalle { get; set; }
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

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = bll.Buscar(proyecto.proyectoId);

            if (encontrado != null)
            {
                proyecto = encontrado;
                Cargar();
                MessageBox.Show("Tarea encontrada", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Tarea no existe en la base de datos", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Agregarboton_Click(object sender, RoutedEventArgs e)
        {
            proyecto.Detalle.Add(new TareaDetalle());

            Cargar();

            requerimientoTareaTextBox.Clear();
            minutoTextBox.Clear();
           
            
        }

        private void EliminarFilaboton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count > 1 && DetalleDataGrid.SelectedIndex < DetalleDataGrid.Items.Count - 1)
            {
                proyecto.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            if (proyecto.proyectoId == 0)
            {
                paso = bll.Guardar(proyecto);
            }
            else
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    paso = bll.Guardar(proyecto);
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

        private bool ExisteEnLaBaseDeDatos()
        {
            Proyectos esValido = bll.Buscar(proyecto.proyectoId);

            return (esValido != null);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

            Proyectos existe = bll.Buscar(proyecto.proyectoId);

            if (existe == null)
            {
                MessageBox.Show("No existe la tarea en la base de datos", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                bll.Eliminar(proyecto.proyectoId);
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }
    }
}