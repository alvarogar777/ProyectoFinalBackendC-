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
    public class ClienteViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private ClienteViewModel _Instancia;
        private ObservableCollection<Cliente> _Cliente;
        private ObservableCollection<TelefonoCliente> _TelefonoClientes;
        ClienteModel cliente = new ClienteModel();
        private Cliente _SelectCliente;
        private TelefonoCliente _SelectTelefono;
        private ClienteView _mensajes;
        private GenerarVentaView _AgregandoCodigo;
        private ACCION accion = ACCION.NINGUNO;
        private bool _IsReadOnlyDescripcion = true;
        private bool _IsReadOnlyNit = true;
        private string _Nit;
        private string _Dpi;
        private string _Nombre;
        private string _Direccion;
        private string _IsvisibleAdd;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;
        private string _NitTelefono;
        private string _TelefonoCliente;
        private string _Descripcion;
        #endregion

        #region Constructores
        public ClienteViewModel(ClienteView clienteView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = clienteView;
            IsvisibleAdd = "Hidden";
        }

        public ClienteViewModel(ClienteView clienteView, GenerarVentaView generarVentaView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = clienteView;
            this.AgregandoCodigo = generarVentaView;
            IsvisibleAdd = "Visible";
        }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Cliente> Clientes
        {
            get
            {
                this._Cliente = cliente.ShowList;
                return this._Cliente;
            }
            set { this._Cliente = value; }
        }
        public ObservableCollection<TelefonoCliente> Telefonos
        {
            get
            {
                if (this._TelefonoClientes == null)
                {
                    this._TelefonoClientes = new ObservableCollection<TelefonoCliente>();
                }     
                return this._TelefonoClientes;
            }
            set { this._TelefonoClientes = value; }
        }
        #endregion

        #region Geters and Seters
        public ClienteViewModel Instancia
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

        public ClienteView Mensajes
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

        public string Dpi
        {
            get
            {
                return _Dpi;
            }
            set
            {
                this._Dpi = value;
                ChangeNotify("Dpi");
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

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                this._Nombre = value;
                ChangeNotify("Nombre");
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

        public Boolean IsReadOnlyNit
        {
            get
            {
                return this._IsReadOnlyNit;
            }
            set
            {
                this._IsReadOnlyNit= value;
                ChangeNotify("IsReadOnlyNit");
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

        public string NitTelefono
        {
            get { return this._NitTelefono; }
            set { this._NitTelefono = value;
                ChangeNotify("NitTelefono");
            }
        }
        public string TelefonoCliente
        {
            get { return this._TelefonoCliente; }
            set
            {
                this._TelefonoCliente = value;
                ChangeNotify("TelefonoCliente");
            }
        }

        public string Descripcion
        {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                ChangeNotify("Descripcion");
            }
        }



        public Cliente SelectCliente
        {
            get { return this._SelectCliente; }
            set
            {
                if (value != null)
                {
                    this._SelectCliente = value;
                    this.Nit = value.Nit;
                    this.Direccion = value.Direccion;
                    this.Dpi = value.Dpi;
                    this.Nombre = value.Nombre;
                    this.NitTelefono = value.Nit;
                    FindListTelefono(value.Nit);                   
                    
                    ChangeNotify("SelectCliente");
                }
            }
        }
        public TelefonoCliente SelectTelefono
        {
            get { return this._SelectTelefono; }
            set
            {
                if (value != null)
                {
                    this._SelectTelefono = value;
                    this.TelefonoCliente = value.Numero;
                    this.Descripcion = value.Descripcion;
                    ChangeNotify("SelectTelefono");
                }
            }
        }



        #endregion

        #region Metodos Enabled y validacion de campos
        public void isEnabledAdd()
        {
            this.IsReadOnlyDescripcion = false;
            this.IsReadOnlyNit = false;
            this.IsEnableSave = true;
            this.IsEnableUpdate = false;
            this.IsEnabledDelete = false;
            this.IsEnableCancel = true;
            this.accion = ACCION.NUEVO;            
        }

        public void isEnableSave()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyNit = true;
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
            this.IsReadOnlyNit = true;
        }

        public void isEnableCancel()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyNit = true;
        }
        public bool validacionCampos()
        {
            bool resultado = true;
            if (this.Nit.Equals(""))
            {
                MessageBox.Show("Falta nit");
                resultado = false;
            }
            else if (this.Dpi.Equals(""))
            {
                MessageBox.Show("Falta dpi");
                resultado = false;
            }
            else if (this.Nombre.Equals(""))
            {
                MessageBox.Show("Falta Nombre");
                resultado = false;
            }
            else if (this.Direccion.Equals(""))
            {
                MessageBox.Show("Falta dirección");
                resultado = false;
            }           
            return resultado;
        }

        public void borrarCampos()
        {
            this.Nit = "";
            this.Dpi = "";
            this.Direccion = "";
            this.Nombre = "";
            this.NitTelefono = "";
            this.TelefonoCliente = "";
            this.Descripcion = "";
            this.Clientes.IndexOf(null);
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            result = await cliente.Add(Mensajes);
            if (result == true)
            {
                isEnabledAdd();
            }
        }

        public async void Save()
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
                        try
                        {
                            this.Clientes.Add(cliente.Save(this.Nit, this.Dpi, this.Nombre, this.Direccion));
                            await Mensajes.ShowMessageAsync("Exito", "Cliente ingresado exitosamente");
                        }
                        catch (Exception e)
                        {
                            await Mensajes.ShowMessageAsync(e.Message, "Nit ya ingresado");
                        }
                        //borrarCampos();
                        this.NitTelefono = this.Nit;
                        isEnableSave();
                    }
                    break;
                case ACCION.ACTUALIZAR:
                    try
                    {
                        if (this.SelectCliente != null)
                        {
                            int posicion = this.Clientes.IndexOf(this.SelectCliente);
                            if (validacionCampos())
                            {
                                var updatCliente = cliente.update(this.SelectCliente.Nit, this.Dpi, this.Nombre, this.Direccion);
                                this.Clientes.RemoveAt(posicion);
                                this.Clientes.Insert(posicion, updatCliente);
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

        public void Update()
        {
            if (this.SelectCliente != null)
            {
                isEnableUpdate();
            }
            else
            {
                Mensajes.ShowMessageAsync("Actualizar", "Debe seleccionar un registro");
            }
        }

        public async void Delete()
        {
            if (this.SelectCliente != null)
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
                        cliente.Delete(this.SelectCliente);
                        this.Clientes.Remove(this.SelectCliente);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    this.SelectCliente = null;
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

        public void AgregarCodigoCategoria()
        {
            if (this.SelectCliente != null)
            {
                AgregandoCodigo.Nit.Text = this.SelectCliente.Nit;

                Mensajes.ShowMessageAsync("Agregar", "Nit Agregado exitosamente en la ventana Factura");
            }
            else
            {
                Mensajes.ShowMessageAsync("Actualizar", "Debe seleccionar un registro");
            }
        }

        public GenerarVentaView AgregandoCodigo
        {
            get
            {
                return _AgregandoCodigo;
            }
            set
            {
                this._AgregandoCodigo = value;
            }
        }

        public async void SaveTelefono()
        {
            if (this.NitTelefono.Equals("") || this.TelefonoCliente.Equals(""))
            {
                await Mensajes.ShowMessageAsync("Error","Escoja algun cliente e ingrese numero");
            }
            else
            {
                TelefonoClienteModel telefonoCliente = new TelefonoClienteModel();
                this.Telefonos.Add(telefonoCliente.Save(this.TelefonoCliente,this.Descripcion,this.NitTelefono));
                await Mensajes.ShowMessageAsync("Exito", "Telefono ingresado exitosamente");
                this.TelefonoCliente = "";
                this.Descripcion = "";
            }
        }

        public void FindListTelefono(string nit)
        {
            TelefonoClienteModel telefonoCliente = new TelefonoClienteModel();
            TelefonoCliente telefono = new TelefonoCliente();
            Telefonos.Clear();
            foreach (TelefonoCliente item in telefonoCliente.FindList(nit))
            {
                this.Telefonos.Add(item);
            }
            this.TelefonoCliente = "";
            this.Descripcion = "";
        }

        public void UpdateTelefono()
        {
            if (this.SelectTelefono!=null)
            {
                TelefonoClienteModel telefono = new TelefonoClienteModel();
                telefono.Update(SelectTelefono.CodigoTelefono,this.TelefonoCliente,this.Descripcion);
                FindListTelefono(this.Nit);
                this.TelefonoCliente = "";
                this.Descripcion = "";
            }
        }

        public void DeleteTelefono()
        {
            if (this.SelectTelefono!=null)
            {
                TelefonoClienteModel telefono = new TelefonoClienteModel();
                telefono.Delete(this.SelectTelefono.CodigoTelefono);
                FindListTelefono(this.Nit);
                this.TelefonoCliente = "";
                this.Descripcion = "";
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
                Mensajes.NitFocus.Focus();
            }
            if (parameter.Equals("Save"))
            {
                Save();
            }
            else if (parameter.Equals("Update"))
            {
                Update();
            }
            else if (parameter.Equals("Delete"))
            {
                Delete();
            }
            else if (parameter.Equals("Cancel"))
            {
                isEnableCancel();
                borrarCampos();
            }
            else if (parameter.Equals("AgregarCliente"))
            {
                AgregarCodigoCategoria();
            }
            else if (parameter.Equals("SaveTelefono"))
            {
                SaveTelefono();
            }
            else if (parameter.Equals("UpdateTelefono"))
            {
                UpdateTelefono();
            }
            else if (parameter.Equals("DeleteTelefono"))
            {
                DeleteTelefono();
            }
        }
        #endregion
    }
}
