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

    public class CategoriaViewModel : INotifyPropertyChanged, ICommand
    {
        #region Campos
        private CategoriaViewModel _Instancia;
        private ObservableCollection<Categoria> _Categoria;
        CategoriaModel categoria = new CategoriaModel();
        private Categoria _SelectCategoria;
        private CategoriaView _mensajes;
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
        public CategoriaViewModel(CategoriaView categoriaView)
        {
            this.Instancia = this;
            borrarCampos();
            Mensajes = categoriaView;
        }
        #endregion

        #region Objeto Obbservador
        public ObservableCollection<Categoria> Categorias
        {
            get
            {
                this._Categoria = categoria.ShowList;
                return this._Categoria;
            }
            set { this._Categoria = value; }
        }
        #endregion

        #region Geters and Seters
        public CategoriaViewModel Instancia
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

        public CategoriaView Mensajes
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

        public Categoria SelectCategoria
        {
            get { return this._SelectCategoria; }
            set
            {
                if (value != null)
                {
                    this._SelectCategoria = value;
                    this.Descripcion = value.Descripcion;
                    ChangeNotify("SelectCategoria");
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
            if (this.Descripcion.Equals(""))
            {
                resultado = false;
            }
            return resultado;
        }

        public void borrarCampos()
        {
            this.Descripcion = "";
            this.Categorias.IndexOf(null);
        }
        #endregion

        #region Metodos Add, Update, Delete, Save
        public async void add()
        {
            bool result;
            result = await categoria.Add(Mensajes);
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
                    if (this.Descripcion.Equals(""))
                    {
                        await Mensajes.ShowMessageAsync("Error", "Ingrese Un tipo de categoria");
                    }
                    else
                    {
                        await Mensajes.ShowMessageAsync("Exito", "Categoria ingresada exitosamente");
                        this.Categorias.Add(categoria.Save(this.Descripcion));
                        borrarCampos();
                        isEnableSave();
                    }
                    break;
                case ACCION.ACTUALIZAR:
                    try
                    {
                        if (this.SelectCategoria != null)
                        {
                            int posicion = this.Categorias.IndexOf(this.SelectCategoria);
                            if (validacionCampos())
                            {
                                var updatCategoria = categoria.update(this.SelectCategoria.CodigoCategoria, this.Descripcion);
                                this.Categorias.RemoveAt(posicion);
                                this.Categorias.Insert(posicion, updatCategoria);
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
                        //await Mensajes.ShowMessageAsync("",e.Message);
                        await Mensajes.ShowMessageAsync("Error", "Seleccione una fila para actualizar");
                        isEnableErrorActualizar();
                        borrarCampos();
                    }
                    break;
            }
        }

        public void update()
        {
            if (this.SelectCategoria != null)
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
            if (this.SelectCategoria!= null)
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
                        categoria.Delete(this.SelectCategoria);
                        this.Categorias.Remove(this.SelectCategoria);
                        borrarCampos();
                        this.IsReadOnlyDescripcion = true;
                        this.accion = ACCION.NINGUNO;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    this.SelectCategoria = null;
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
        }
        #endregion

    }
}
