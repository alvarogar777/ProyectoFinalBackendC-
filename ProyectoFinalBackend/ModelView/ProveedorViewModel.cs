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

namespace ProyectoFinalBackend.ModelView
{
    public class ProveedorViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private ProveedorViewModel _Instancia;
        private ObservableCollection<Proveedor> _Proveedor;
        ProveedorModel proveedor = new ProveedorModel();
        private Proveedor _SelectProveedor;
        private ProveedorView _mensajes;
        private GenerarCompraView _AgregandoNit;
        private ACCION accion = ACCION.NINGUNO;
        private bool _IsReadOnlyDescripcion = true;
        private string _Nit;
        private string _Razon_Social;
        private string _Direccion;
        private string _Pagina_Web;
        private string _ContactoPrincipal;
        private string _IsvisibleAdd;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;


        #endregion

        #region Constructores
        public ProveedorViewModel(ProveedorView proveedorView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = proveedorView;
            IsvisibleAdd = "Hidden";
        }

        public ProveedorViewModel(ProveedorView proveedorView, GenerarCompraView generarCompraView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = proveedorView;
            this.AgregandoNit = generarCompraView;
            IsvisibleAdd = "Visible";
        }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Proveedor> Proveedores
        {
            get
            {
                this._Proveedor = proveedor.ShowList;
                return this._Proveedor;
            }
            set { this._Proveedor = value; }
        }
        #endregion

        #region Geters and Seters
        public ProveedorViewModel Instancia
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

        public ProveedorView Mensajes
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

        public string Nit
        {
            get
            {
                return _Nit;
            }
            set
            {
                this._Nit = value;
                ChangeNotify("Nit");
            }
        }

        public string Razon_Social
        {
            get
            {
                return _Razon_Social;
            }
            set
            {
                this._Razon_Social = value;
                ChangeNotify("Razon_Social");
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                this._Direccion = value;
                ChangeNotify("Direccion");
            }
        }

        public string Pagina_Web
        {
            get
            {
                return _Pagina_Web;
            }
            set
            {
                this._Pagina_Web = value;
                ChangeNotify("Pagina_Web");
            }
        }

        public string ContactoPrincipal
        {
            get
            {
                return _ContactoPrincipal;
            }
            set
            {
                this._ContactoPrincipal = value;
                ChangeNotify("ContactoPrincipal");
            }
        }
        public GenerarCompraView AgregandoNit
        {
            get
            {
                return _AgregandoNit;
            }
            set
            {
                this._AgregandoNit= value;
            }
        }

        public string IsvisibleAdd
        {
            get
            {
                return _IsvisibleAdd;
            }
            set
            {
                this._IsvisibleAdd = value;
                ChangeNotify("IsvisibleAdd");
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

        public Proveedor SelectProveedor
        {
            get { return this._SelectProveedor; }
            set
            {
                if (value != null)
                {
                    this._SelectProveedor = value;
                    this.Nit = value.Nit;
                    this.Razon_Social = value.Razon_Social;
                    this.Direccion = value.Direccion;
                    this.Pagina_Web = value.Pagina_Web;
                    this.ContactoPrincipal = value.ContactoPrincipal;
                    ChangeNotify("SelectProveedor");
                }
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
        public bool validacionCampos()
        {
            bool resultado = true;
            if (this.Nit.Equals(""))
            {
                MessageBox.Show("Falta nit");
                resultado = false;
            }
            else if (this.Razon_Social.Equals(""))
            {
                MessageBox.Show("Falta razon social");
                resultado = false;
            }
            else if (this.Direccion.Equals(""))
            {
                MessageBox.Show("Falta Direccion");
                resultado = false;
            }
            else if (this.Pagina_Web.Equals(""))
            {
                MessageBox.Show("Falta pagina web");
                resultado = false;
            }
            else if (this.ContactoPrincipal.Equals(""))
            {
                MessageBox.Show("Falta contacto");
                resultado = false;
            }
            return resultado;
        }

        public void borrarCampos()
        {
            this.Nit = "";
            this.Razon_Social = "";
            this.Direccion = "";
            this.Pagina_Web = "";
            this.ContactoPrincipal = "";
            this.Proveedores.IndexOf(null);
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            result = await proveedor.Add(Mensajes);
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
                        await Mensajes.ShowMessageAsync("Error", "Ingrese todos los campos");
                    }
                    else
                    {
                        await Mensajes.ShowMessageAsync("Exito", "Proveedor ingresado exitosamente");
                        this.Proveedores.Add(proveedor.Save(this.Nit, this.Razon_Social, this.Direccion, this.Pagina_Web, this.ContactoPrincipal));
                        borrarCampos();
                        isEnableSave();
                    }
                    break;
                case ACCION.ACTUALIZAR:
                    try
                    {
                        if (this.SelectProveedor != null)
                        {
                            int posicion = this.Proveedores.IndexOf(this.SelectProveedor);
                            if (validacionCampos())
                            {
                                var updatTipoEmpaque = proveedor.update(this.SelectProveedor.CodigoProveedor, this.Nit, this.Razon_Social, this.Direccion, this.Pagina_Web, this.ContactoPrincipal);
                                this.Proveedores.RemoveAt(posicion);
                                this.Proveedores.Insert(posicion, updatTipoEmpaque);
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
                            await Mensajes.ShowMessageAsync("Error", "Ingrese todos los campos");
                        }
                    }
                    catch (Exception e)
                    {
                        await Mensajes.ShowMessageAsync("Error", "Seleccione una fila para actualizar");
                        isEnableErrorActualizar();
                        borrarCampos();
                    }
                    break;
            }
        }

        public void update()
        {
            if (this.SelectProveedor != null)
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
            if (this.SelectProveedor != null)
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
                        proveedor.Delete(this.SelectProveedor);
                        this.Proveedores.Remove(this.SelectProveedor);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    this.SelectProveedor = null;
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
        public void AgregarNitProveedor()
        {
            if (this.SelectProveedor != null)
            {
                AgregandoNit.Nit.Text = this.SelectProveedor.CodigoProveedor.ToString();

                Mensajes.ShowMessageAsync("Agregar", "Codigo proveedor Agregado exitosamente en la ventana Compras");
            }
            else
            {
                Mensajes.ShowMessageAsync("Actualizar", "Debe seleccionar un registro");
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
                Mensajes.DescripcionFocus.Focus();
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
            else if (parameter.Equals("AgregarProveedor"))
            {
                AgregarNitProveedor();
            }
        }
        #endregion
    }
}
