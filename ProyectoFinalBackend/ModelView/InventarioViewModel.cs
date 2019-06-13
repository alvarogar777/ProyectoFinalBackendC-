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
    public class InventarioViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private InventarioViewModel _Instancia;
        private ObservableCollection<Inventario> _Inventario;
        InventarioModel inventario = new InventarioModel();
        private Inventario _SelectInventario;
        private InventarioView _mensajes;
        private ACCION accion = ACCION.NINGUNO;
        private bool _IsReadOnlyDescripcion = true;
        private string _CodigoProducto;
        private string _TipoRegistro;
        private string _Precio;
        private string _Entradas;
        private string _Salidas;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;


        #endregion

        #region Constructores
        public InventarioViewModel(InventarioView inventarioView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = inventarioView;
        }


        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Inventario>   Inventarios
        {
            get
            {
                this._Inventario = inventario.ShowList;
                return this._Inventario;
            }
            set { this._Inventario = value; }
        }
        #endregion

        #region Geters and Seters
        public InventarioViewModel Instancia
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

        public InventarioView Mensajes
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

        public Inventario SelectInventario
        {
            get { return this._SelectInventario; }
            set
            {
                if (value != null)
                {
                    this._SelectInventario = value;
                    this.CodigoProducto = value.CodigoProducto.ToString();
                    this.TipoRegistro = value.TipoRegistro.ToString();
                    this.Precio = value.Precio.ToString();
                    this.Entradas = value.Entradas.ToString();
                    this.Salidas = value.Salidas.ToString();
                    ChangeNotify("SelectInventario");
                }
            }
        }
        #endregion

        #region campos de la BD
        public string CodigoProducto
        {
            get
            {
                return _CodigoProducto;
            }
            set
            {
                this._CodigoProducto = value;
                ChangeNotify("CodigoProducto");
            }
        }
        public string TipoRegistro
        {
            get
            {
                return _TipoRegistro;
            }
            set
            {
                this._TipoRegistro = value;
                ChangeNotify("TipoRegistro");
            }
        }
        public string Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                this._Precio = value;
                ChangeNotify("Precio");
            }
        }

        public string Entradas
        {
            get
            {
                return _Entradas;
            }
            set
            {
                this._Entradas = value;
                ChangeNotify("Entradas");
            }
        }

        public string Salidas
        {
            get
            {
                return _Salidas;
            }
            set
            {
                this._Salidas = value;
                ChangeNotify("Salidas");
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
            this.CodigoProducto = "";
            this.TipoRegistro = "";
            this.Precio = "";
            this.Entradas = "";
            this.Salidas = "";
            this.Inventarios.IndexOf(null);
        }

        public bool validacionCampos()
        {
            bool resultado = true;
            if (Mensajes.CodigoProdcuto.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta CodigoProducto ");
                resultado = false;
            }
            else if (this.TipoRegistro.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta TipoRegistro");
                resultado = false;
            }
            else if (this.Precio.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Precio");
                resultado = false;
            }
            else if (this.Entradas.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Entradas");
                resultado = false;
            }
            else if (this.Salidas.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Falta Salidas");
                resultado = false;
            }
  
            return resultado;
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            result = await inventario.Add(Mensajes);
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
                        await Mensajes.ShowMessageAsync("Error", "Ingrese Un tipo de Inventario");
                    }
                    else
                    {

                        try
                        {
                            this.Inventarios.Add(inventario.Save(Convert.ToInt16(Mensajes.CodigoProdcuto.Text), this.TipoRegistro, Convert.ToDecimal(this.Precio),
                                Convert.ToInt16(this.Entradas), Convert.ToInt16(this.Salidas)));
                            await Mensajes.ShowMessageAsync("Exito", "Inventario ingresada exitosamente");
                           
                        }
                        catch (Exception e)
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
                        if (this.SelectInventario != null)
                        {

                            //Mensajes.CodigoCategoria.Focus();
                            int posicion = this.Inventarios.IndexOf(this.SelectInventario);
                            if (validacionCampos())
                            {
                                //await Mensajes.ShowMessageAsync("Error", Mensajes.CodigoCategoria.Text);
                                var updatProducto = inventario.update(this.SelectInventario.CodigoInventario, Convert.ToInt16(Mensajes.CodigoProdcuto.Text), this.TipoRegistro, Convert.ToDecimal(this.Precio),
                                Convert.ToInt16(this.Entradas), Convert.ToInt16(this.Salidas));
                                this.Inventarios.RemoveAt(posicion);
                                this.Inventarios.Insert(posicion, updatProducto);
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
                        await Mensajes.ShowMessageAsync("", e.Message);
                        await Mensajes.ShowMessageAsync("Error", "Seleccione una fila para actualizar");
                        isEnableErrorActualizar();
                        borrarCampos();
                    }
                    break;
            }
        }

        public void update()
        {
            if (this.SelectInventario != null)
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
            if (this.SelectInventario != null)
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
                        inventario.Delete(this.SelectInventario);
                        this.Inventarios.Remove(this.SelectInventario);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        System.Windows.MessageBox.Show(e.Message);
                    }
                    this.SelectInventario = null;
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

  
            else if (parameter.Equals("Cancel"))
            {
                isEnableCancel();
                borrarCampos();
            }
            else if (parameter.Equals("AgregarCodigoCategoria"))
            {
               
                new ProductoView(Mensajes).ShowDialog();
            }

        }
        #endregion
    }
}
