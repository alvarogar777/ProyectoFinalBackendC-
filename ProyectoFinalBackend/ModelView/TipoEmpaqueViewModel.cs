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

namespace ProyectoFinalBackend.ModelView
{
    #region Enum
    enum ACCION
    {
        NINGUNO,
        NUEVO,
        GUARDAR,
        ACTUALIZAR
    };
    #endregion 

    public class TipoEmpaqueViewModel : INotifyPropertyChanged,ICommand
    {
        #region Campos
        private TipoEmpaqueViewModel _Instancia;
        private ObservableCollection<TipoEmpaque> _TipoEmpaque;
        TipoEmpaqueModel tipoEmpaque = new TipoEmpaqueModel();
        private TipoEmpaque _SelectTipoEmpaque;
        private ACCION accion = ACCION.NINGUNO;
        private bool _IsReadOnlyDescripcion = true;        
        private string _Descripcion;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;
        

        #endregion

        #region Constructores
        public TipoEmpaqueViewModel()
        {
            this.Instancia = this;
            borrarCampos();
        }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<TipoEmpaque> TipoEmpaques
        {
            get
            {
                this._TipoEmpaque = tipoEmpaque.ShowList;
                return this._TipoEmpaque;
            }
            set { this._TipoEmpaque = value; }
        }
        #endregion

        #region Geters and Seters
        public TipoEmpaqueViewModel Instancia
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

        public TipoEmpaque SelectTipoEmpaque
        {
            get { return this._SelectTipoEmpaque; }
            set
            {
                if (value != null)
                {
                    this._SelectTipoEmpaque = value;
                    this.Descripcion = value.Descripcion;
                    ChangeNotify("SelectTipoEmpaque");
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
            this.IsReadOnlyDescripcion = false;
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
            if (this.Descripcion.Equals(""))
            {
                resultado = false;
            }
            return resultado;
        }

        public void borrarCampos()
        {
            this.Descripcion = "";
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            result = await tipoEmpaque.Add();
            if (result == true)
            {
                isEnabledAdd();
            }
        }

        public async void save()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            switch (this.accion)
            {
                case ACCION.NUEVO:
                    if (this.Descripcion.Equals(""))
                    {
                        await metroWindow.ShowMessageAsync("Error", "Ingrese Un tipo de empaque");
                    }
                    else
                    {
                        await metroWindow.ShowMessageAsync("Exito", "Tipo ingresado exitosamente");
                        this.TipoEmpaques.Add(tipoEmpaque.Save(this.Descripcion));
                        borrarCampos();
                        isEnableSave();
                    }
                    break;
                case ACCION.ACTUALIZAR:
                    try
                    {
                        if (this.SelectTipoEmpaque != null)
                        {
                            int posicion = this.TipoEmpaques.IndexOf(this.SelectTipoEmpaque);
                            if (validacionCampos())
                            {
                                var updatTipoEmpaque = tipoEmpaque.update(this.SelectTipoEmpaque.CodigoEmpaque, this.Descripcion);
                                this.TipoEmpaques.RemoveAt(posicion);
                                this.TipoEmpaques.Insert(posicion, updatTipoEmpaque);
                                await metroWindow.ShowMessageAsync("Exito", "Registro actualizado correctamente");
                                isEnableActualizar();
                                borrarCampos();
                            }
                            else
                            {
                                await metroWindow.ShowMessageAsync("Actualizar", "Debe ingresar todos los campos");
                            }
                        }
                        else
                        {
                            await metroWindow.ShowMessageAsync("Error", "Ingrese una descripción");
                        }
                    }
                    catch (Exception e)
                    {
                        await metroWindow.ShowMessageAsync("Error", "Seleccione una fila para actualizar");
                        isEnableErrorActualizar();
                        borrarCampos();
                    }
                    break;
            }
        }

        public async void update()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            if (this.SelectTipoEmpaque != null)
            {
                isEnableUpdate();
            }
            else
            {
                await metroWindow.ShowMessageAsync("Actualizar", "Debe seleccionar un registro");
            }
        }

        public async void delete()
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            if (this.SelectTipoEmpaque != null)
            {
                var respuesta = await metroWindow.ShowMessageAsync("Esta seguro de eliminar el registro", "Eliminar",
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
                        tipoEmpaque.Delete(this.SelectTipoEmpaque);
                        this.TipoEmpaques.Remove(this.SelectTipoEmpaque);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    this.SelectTipoEmpaque = null;
                    await metroWindow.ShowMessageAsync("Exito", "Registro eliminado Correctamente");
                }

                else
                {
                    await metroWindow.ShowMessageAsync("Eliminar", "No se elimino ningun registro");

                }
            }
            else
            {
                await metroWindow.ShowMessageAsync("Eliminar", "Debe seleccionar un registro");
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

        public  void Execute(object parameter)
        {
            if (parameter.Equals("Add"))
            {                
                add();
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
        }
        #endregion

    }
}
