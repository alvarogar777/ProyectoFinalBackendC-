using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ProyectoFinalBackend.Entity;
using ProyectoFinalBackend.Model;
using System.Windows.Input;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ProyectoFinalBackend.View;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalBackend.ModelView
{
    public class ProductoViewModel :  INotifyPropertyChanged, ICommand
    {
        #region Campos
        private ProductoViewModel _Instancia;
        private ObservableCollection<Producto> _Producto;
        ProductoModel producto = new ProductoModel();
        private Producto _SelectProducto;
        private ProductoView _mensajes;
        private ACCION accion = ACCION.NINGUNO;
        private bool _IsReadOnlyDescripcion = true;
        private string _CodigoCategoria;
        private string _CodigoEmpaque;        
        private string _Descripcion;
        private string _PrecioUnitario;
        private string _PrecioPorDocena;
        private string _PrecioPorMayor;
        private string _Existencia;
        private string _Imagen;
        private string _NombreImagen;
        private string _UrlImagen;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;


        #endregion

        #region Constructores
        public ProductoViewModel(ProductoView productoView)
        {
            this.Instancia = this;
            
            Mensajes = productoView;
            borrarCampos();
        }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Producto> Productos
        {
            get
            {
                this._Producto = producto.ShowList;
                return this._Producto;
            }
            set { this._Producto = value; }
        }
        #endregion

        #region Geters and Seters
        public ProductoViewModel Instancia
        {
            get
            {
                return this._Instancia;
            }
            set
            {
                this._Instancia = value;
            }
        }

        public ProductoView Mensajes
        {
            get
            {
                return this._mensajes;
            }
            set
            {
                this._mensajes = value;
            }
        }

 

        public Boolean IsReadOnlyDescripcion
        {
            get
            {
                return this._IsReadOnlyDescripcion;
            }
            set
            {
                this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion");
            }
        }

        public Boolean IsEnabledAdd
        {
            get
            {
                return this._IsEnabledAdd;
            }
            set
            {
                this._IsEnabledAdd = value;
                ChangeNotify("IsEnabledAdd");
            }
        }
        public Boolean IsEnabledDelete
        {
            get
            {
                return this._IsEnabledDelete;
            }
            set
            {
                this._IsEnabledDelete = value;
                ChangeNotify("IsEnabledDelete");
            }
        }

        public Boolean IsEnableUpdate
        {
            get
            {
                return this._IsEnableUpdate;
            }
            set
            {
                this._IsEnableUpdate = value;
                ChangeNotify("IsEnableUpdate");
            }
        }

        public Boolean IsEnableSave
        {
            get
            {
                return this._IsEnableSave;
            }
            set
            {
                this._IsEnableSave = value;
                ChangeNotify("IsEnableSave");
            }
        }

        public Boolean IsEnableCancel
        {
            get
            {
                return this._IsEnableCancel;
            }
            set
            {
                this._IsEnableCancel = value;
                ChangeNotify("IsEnableCancel");
            }
        }

        public Producto SelectProducto
        {
            get { return this._SelectProducto; }
            set
            {
                if (value != null)
                {
                    this._SelectProducto = value;
                    this.CodigoCategoria = value.CodigoCategoria.ToString();
                    this.CodigoEmpaque = value.CodigoEmpaque.ToString();
                    this.Descripcion = value.Descripcion;
                    this.PrecioUnitario = value.PrecioUnitario.ToString();
                    this.PrecioPorDocena = value.PrecioPorDocena.ToString();
                    this.PrecioPorMayor = value.PrecioPorMayor.ToString();
                    this.Existencia = value.Existencia.ToString();
                    this.Imagen = value.Imagen;
                    this.NombreImagen = value.NombreImagen;
                    this.UrlImagen = @value.Imagen;
                    ChangeNotify("SelectProducto");
                }
            }
        }
        #endregion

        #region campos de la BD
        public string CodigoCategoria
        {
            get
            {
                return _CodigoCategoria;
            }
            set
            {
                this._CodigoCategoria = value;
                ChangeNotify("CodigoCategoria");
            }
        }
        public string CodigoEmpaque
        {
            get
            {
                return _CodigoEmpaque;
            }
            set
            {
                this._CodigoEmpaque = value;
                ChangeNotify("CodigoEmpaque");
            }
        }
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                this._Descripcion = value;
                ChangeNotify("Descripcion");
            }
        }

        public string PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }
            set
            {
                this._PrecioUnitario = value;
                ChangeNotify("PrecioUnitario");
            }
        }

        public string PrecioPorDocena
        {
            get
            {
                return _PrecioPorDocena;
            }
            set
            {
                this._PrecioPorDocena = value;
                ChangeNotify("PrecioPorDocena");
            }
        }
        public string PrecioPorMayor
        {
            get
            {
                return _PrecioPorMayor;
            }
            set
            {
                this._PrecioPorMayor = value;
                ChangeNotify("PrecioPorMayor");
            }
        }

        public string Existencia
        {
            get
            {
                return _Existencia;
            }
            set
            {
                this._Existencia = value;
                ChangeNotify("Existencia");
            }
        }
        public string Imagen
        {
            get
            {
                return _Imagen;
            }
            set
            {
                this._Imagen = value;
                ChangeNotify("Imagen");
            }
        }

        public string NombreImagen
        {
            get
            {
                return _NombreImagen;
            }
            set
            {
                this._NombreImagen = value;
                ChangeNotify("NombreImagen");
            }
        }

        public string UrlImagen
        {
            get
            {
                return _UrlImagen;
            }
            set
            {
                this._UrlImagen = value;
                ChangeNotify("UrlImagen");
            }
        }
        #endregion

        #region Metodos Enabled y validacion de campos
        public void isEnabledAdd()
        {
            this.IsReadOnlyDescripcion = false;
            this.IsEnableSave = true;
            this.IsEnableUpdate = false;
            this.IsEnabledDelete = false;
            this.IsEnableCancel = true;
            this.accion = ACCION.NUEVO;
        }

        public void isEnableSave()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableUpdate()
        {
            this.accion = ACCION.ACTUALIZAR;
            this.IsReadOnlyDescripcion = false;
            this.IsEnabledAdd = false;
            this.IsEnabledDelete = false;
            this.IsEnableUpdate = false;
            this.IsEnableSave = true;
            this.IsEnableCancel = true;
        }

        public void isEnableActualizar()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsEnabledAdd = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableErrorActualizar()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsReadOnlyDescripcion = true;
        }

        public void isEnableCancel()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsReadOnlyDescripcion = true;
        }


        public void borrarCampos()
        {
            Mensajes.CodigoCategoria.Text = "";
            this.CodigoEmpaque = "";
            this.Descripcion = "";
            this.PrecioUnitario = "";
            this.PrecioPorDocena = "";
            this.PrecioPorMayor = "";
            this.Existencia = "";
            this.Imagen = "";
            this.NombreImagen = "";
            this.UrlImagen = "";
            this.Productos.IndexOf(null);
        }

        public bool validacionCampos()
        {
            bool resultado = true;
            if (Mensajes.CodigoCategoria.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta CodigoCategoria");
                resultado = false;
            }
            else if (Mensajes.CodigoEmpaque.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta CodigoEmpaque");
                resultado = false;
            }
            else if (this.Descripcion.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Descripcion");
                resultado = false;
            }
            else if (this.PrecioUnitario.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta PrecioUnitario");
                resultado = false;
            }
            else if (this.PrecioPorDocena.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta PrecioPorDocena");
                resultado = false;
            }
            else if (this.PrecioPorMayor.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta PrecioPorMayor");
                resultado = false;
            }
            else if (this.Existencia.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Existencia");
                resultado = false;
            }
            return resultado;
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            result = await producto.Add(Mensajes);
            if (result == true)
            {
                isEnabledAdd();
            }
        }

        public async void save()
        {
            switch (this.accion)
            {
                case ACCION.NUEVO:
                    if (!validacionCampos())
                    {
                        await Mensajes.ShowMessageAsync("Error", "Ingrese Un tipo de Producto");
                    }
                    else
                    {

                        try
                        {
                            this.Productos.Add(producto.Save(Convert.ToInt16(Mensajes.CodigoCategoria.Text), Convert.ToInt16(Mensajes.CodigoEmpaque.Text), this.Descripcion, Convert.ToDecimal(this.PrecioUnitario),
                                Convert.ToDecimal(this.PrecioPorDocena), Convert.ToDecimal(this.PrecioPorMayor), Convert.ToInt16(this.Existencia), this.Imagen, this.NombreImagen));
                            await Mensajes.ShowMessageAsync("Exito", "Producto ingresada exitosamente");
                            moverImagen(this.Imagen, this.NombreImagen);
                        }catch(Exception e)
                        {
                            System.Console.WriteLine(e);
                            await Mensajes.ShowMessageAsync("Error", "Formato Incorrecto");
                        }
                        borrarCampos();
                        isEnableSave();
                    }
                    break;
                case ACCION.ACTUALIZAR:
                    try
                    {
                        if (this.SelectProducto != null)
                        {
                          
                            //Mensajes.CodigoCategoria.Focus();
                            int posicion = this.Productos.IndexOf(this.SelectProducto);
                            if (validacionCampos())
                            {
                                //await Mensajes.ShowMessageAsync("Error", Mensajes.CodigoCategoria.Text);
                                var updatProducto = producto.update(this.SelectProducto.CodigoProducto, Convert.ToInt16(Mensajes.CodigoCategoria.Text), Convert.ToInt16(Mensajes.CodigoEmpaque.Text), this.Descripcion, Convert.ToDecimal(this.PrecioUnitario),
                            Convert.ToDecimal(this.PrecioPorDocena), Convert.ToDecimal(this.PrecioPorMayor), Convert.ToInt16(this.Existencia), this.Imagen,this.NombreImagen);
                                this.Productos.RemoveAt(posicion);
                                this.Productos.Insert(posicion, updatProducto);
                                await Mensajes.ShowMessageAsync("Exito", "Registro actualizado correctamente");
                                isEnableActualizar();
                                borrarCampos();
                            }
                            else
                            {
                                await Mensajes.ShowMessageAsync("Actualizar", "Debe ingresar todos los campos");
                            }
                        }
                        else
                        {
                            await Mensajes.ShowMessageAsync("Error", "Ingrese una descripción");
                        }
                    }
                    catch (Exception e)
                    {
                        await Mensajes.ShowMessageAsync("",e.Message);
                        await Mensajes.ShowMessageAsync("Error", "Seleccione una fila para actualizar");
                        isEnableErrorActualizar();
                        borrarCampos();
                    }
                    break;
            }
        }

        public void update()
        {
            if (this.SelectProducto!= null)
            {
                isEnableUpdate();
            }
            else
            {
                Mensajes.ShowMessageAsync("Actualizar", "Debe seleccionar un registro");
            }
        }

        public async void delete()
        {
            if (this.SelectProducto != null)
            {
                var respuesta = await Mensajes.ShowMessageAsync("Esta seguro de eliminar el registro", "Eliminar",
                MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
                {
                    AffirmativeButtonText = "Si",
                    NegativeButtonText = "No",
                    AnimateShow = true,
                    AnimateHide = false
                });

                if (respuesta == MessageDialogResult.Affirmative)
                {
                    try
                    {
                        producto.Delete(this.SelectProducto);
                        this.Productos.Remove(this.SelectProducto);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        System.Windows.MessageBox.Show(e.Message);
                    }
                    this.SelectProducto = null;
                    await Mensajes.ShowMessageAsync("Exito", "Registro eliminado Correctamente");
                }

                else
                {
                    await Mensajes.ShowMessageAsync("Eliminar", "No se elimino ningun registro");

                }
            }
            else
            {
                await Mensajes.ShowMessageAsync("Eliminar", "Debe seleccionar un registro");
            }
        }

        public void agregarImagen()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Solo Imagenes|*.jpg;*.png;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            string nombreArchivo = openFileDialog1.FileName;
            string nombre = openFileDialog1.SafeFileName;
            //System.Windows.MessageBox.Show(nombre, "");
            string sourceFile = @nombreArchivo;
            
            // To move a file or folder to a new location:
            this.Imagen = nombreArchivo;
            this.NombreImagen = nombre;
            this.UrlImagen = @nombreArchivo;
        }

        public void moverImagen(string sourceFile, string nombre)
        {
            string destinationFile = @"C:\Users\usuario\Desktop\ImagenesProyecto\" + nombre;
            try
            {
                System.IO.File.Move(@sourceFile, destinationFile);
            }
            catch (Exception e) {
                System.Console.WriteLine(e);
            }
        }
  

        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.Equals("Add"))
            {
                add();
                //Mensajes.DescripcionFocus.Focus();
            }
            if (parameter.Equals("Save"))
            {
                save();
            }
            else if (parameter.Equals("Update"))
            {
                update();
            }
            else if (parameter.Equals("Delete"))
            {
                delete();
            }

            else if (parameter.Equals("AgregarImagen"))
            {
                agregarImagen();
            }
            else if (parameter.Equals("Cancel"))
            {
                isEnableCancel();
                borrarCampos();
            }
            else if (parameter.Equals("AgregarCodigoCategoria"))
            {
                new CategoriaView(Mensajes).ShowDialog();
            }
            else if (parameter.Equals("AgregarCodigoEmpaque"))
            {
                new TipoEmpaqueView(Mensajes).ShowDialog();
            }
        }
        #endregion

    }
}
