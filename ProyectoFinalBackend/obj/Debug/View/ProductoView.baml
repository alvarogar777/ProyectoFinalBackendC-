   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   ,    &ProyectoFinalBackend.View.ProductoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  	Productos��5   	   $	��700��6   $
��1000��6(    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 
ResizeMode$ NoResize=�6m   .��5      �  � RowDefinitions 5   
   �� 5      $
��253* �6   �� 5      $
��214* �6   �� 5      $
��233* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   6.   �� 5      $
��318* �6   �� 5      $	��69* �6   6-   �� 5      $
��256* �6   �� 5      $
��123* �6   .+�5   
   �� $��Codigo Categoria��6   $��0��6+   $��1��68   $��121,33,76,178.8q�6H   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6a   $��18(�6�   $��Arial Black)�6�    � ForceCursor . $��2��6�   �� 5   
   $��Codigo Empaque��6   $��0��6)   $��1��66   $��121,74,76,136.8q�6F   $ Upper=�6_   $��18(�6�   $��Arial Black)�6�    . $��2��6�   �� 5   
   $��Descripción��6   $��0��6&   $��1��63   $��121,116,76,97.8q�6C   $ Upper=�6\   $��18(�6�   $��Arial Black)�6�    . $��2��6�   �� 5   
   $��Precio Unitario��6   $��0��6*   $��1��67   $��121,155,76,0q�6G   $ Upper=�6]   $��18(�6�   $��Arial Black)�6�    . $��43��6�   $	��Top=�6�   $��2��6�   �� 5   
   $��Precio por docena��6   $��1��6,   $��121,198,76,9.8q�6<   $ Upper=�6T   $��18(�6�   $��Arial Black)�6�    .  J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   �� 5    
   $��Preocio por mayor��6   $��1��6,   $��121,0.2,76,174.2q�6<   $ Upper=�6V   $��18(�6�   $��Arial Black)�6�    . $ 0.5,0.5&�6�   $��2��6�   $��1��6�   �� 5!   
   $��
Existencia��6   $��1��6%   $��121,40.2,76,134.2q�65   $ Upper=�6P   $��18(�6�   $��Arial Black)�6�    . $ 0.5,0.5&�6�   $��1��6�   $��2��6�   �� 5"   
   $��Imagen��6   $��1��6!   $��121,80.2,160.2,94.2q�61   $ Upper=�6N   $��18(�6�   $��Arial Black)�6�    . $ 0.5,0.5&�6�   $��1��6�   �� 5#   
   $��Imagen��6   $��1��6!   $��121,80.2,160.2,94.2q�61   $ Upper=�6N   $��18(�6�   $��Arial Black)�6�    . $ 0.5,0.5&�6�   $��1��6�   �� 5%   
   -   5        $��CodigoCategoria��5%      $��0��6)   	 �� 
IsReadOnly	 . $��0.8,31,98,178.8q�6i   $��3��6�   $��Arial)�6�   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 .    	Watermark$ Ingrese codigo categoria��6�   $��2��6!  ��6H   �� *CodigoCategoria+6!  �� 5&   
   -   5        $��CodigoEmpaque��5&      $��0��6'   	 . $��0.8,74,98,136.8q�6e   $��3��6~   $��Arial)�6�   $��16(�6�   
 . $ Ingrese codigo Empaque��6�   $��2��6  ��6F   �� *CodigoEmpaque+6  �� 5'   
   $��0��6   $��0.8,116,9,97.8q�6i   $��3��6�   $��Arial)�6�   $��16(�6�   
 . $ Ingrese una descripcion��6�   $��2��6  	 6   �� *IsReadOnlyDescripcion+��6L   �� *Descripcion+6  �� 5(   
   $��0��6   $��0.8,155,10,54.8q�6l   $��3��6�   $��Arial)�6�   $��16(�6�   
 . $ Ingrese precio unitario��6�   $��2��6#  	 6   �� *IsReadOnlyDescripcion+��6L   �� *PrecioUnitario+6#  �� 5)   
   $��0��6   $��0.8,198,9,9.8q�6m   $��3��6�   $��Arial)�6�   $��16(�6�   
 . $ Ingrese precio por docena��6�   $��2��6$  	 6   �� *IsReadOnlyDescripcion+��6L   �� *PrecioPorDocena+6$  �� 5*   
   $��1��6   $��0.8,0.2,9,169.2q�6l   $��3��6�   $��Arial)�6�   $��16(�6�   
 . $! Ingrese un precio por mayor��6�   $��2��6'  	 6   �� *IsReadOnlyDescripcion+��6L   �� *PrecioPorMayor+6'  �� 5+   
   $��1��6   $��0.8,40.2,9,129.2q�6h   $��3��6�   $��Arial)�6�   $��16(�6�   
 . $ Ingrese Existencia��6�   $��2��6  	 6   �� *IsReadOnlyDescripcion+��6L   �� *
Existencia+6  �� 5,   
   $��1��6   	 . $��200,83.2,116.4,94.2q�6K   $��3��6h   $��Arial)�6|   $��10(�6�   
 . $ Ingrese una url��6�   $��1��6�   ��61   �� *Imagen+6�   �� 5-   
   $��1��6   	 . $��170,84.2,98,93.2q�6Q   $��Arial)�6k   $��10(�6~   
 . $ Nombre��6�   $��3��6�   $��2��6�   ��61   �� *NombreImagen+6�   &   System.Windows.Controls.DataGrid  50   
   -   5        $��producto��50      $��1��53      $��Arial)�54         AutoGenerateColumns .  $��22,127.2,4.4,141q�56   +   $��2��6E   $��1��6V   $��3��6f    �� SelectedItem 51      ��  �� Path$ SelectProducto���52      �� $ 	Productos�   Columns 57      4  .System.Windows.Controls.DataGridCheckBoxColumn  58         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   59   %      EditingElementStyle# �   5:   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��5;   %      Binding 5<   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5>      $ CODIGO��6%      
IsReadOnly .  65   �� *CodigoProducto+6l     5?      $ CODIGOCATEGORIA��6%    .  6>   �� *CodigoCategoria+6v     5@      $ CODIGOEMPAQUE��6%    .  6<   �� *CodigoEmpaque+6r     5A      $ DESCRIPCION��6%    .  6:   �� *Descripcion+6n     5B      $ PRECIOUNITARIO��6%    .  6=   �� *PrecioUnitario+6t   5D      �� 5F   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�66   $��218,91.8,109.4,0q�6O    � Cursor$
 Hand��6i   $��1��6w    . .+�5G      �� $��Agregar��6   $	��Add��6u   ���	#FF192648
���   �$��1q�6�   {�6-   �� *IsEnabledAdd+��6U   �� *	Instancia+6�   �� 5H      $��
Actualizar��6   $��Update��6u   
���   ����	#FF334619{�6-   �� *IsEnableUpdate+��6U   �� *	Instancia+6�   �� 5I      $��Eliminar��6   $��Delete��6u   ���	#FF730F0F
���   �{�6-   �� *IsEnabledDelete+��6U   �� *	Instancia+6�   �� 5J      $��Guardar��6   $
��Save��6t   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   {�6-   �� *IsEnableSave+��6T   �� *	Instancia+6�   �� 5K      $��Cancelar��6   $��Cancel��6y   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $��52��6�   {�61   �� *IsEnableCancel+��6Y   �� *	Instancia+6�   5L      �� 5M   
   -   5         ��Name$ label��5M      $��3��6   $��	Productos��63   $��1��6G   $
��Left=�6W   $��38��6r   $��	256,0,0,0q�6~   $	��Top=�6�   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . 6�   �� 5N   
   -   5         ��Name$ Imagen��5N      $
��Left=�6>   $	��189��6Y   $��	42,64,0,0q�6f   $	��Top=�6y   $	��218��6�   $��2��6�   $��2��6�   ��6    �� *	UrlImagen+6�   �� 5O   
   $��Agregar��6   {�. $��AgregarImagen��6^   ���	#FF192648
���   �$��1q�6�   $��44.6,85.2,10,94.2q�6�   $��1��6�   $��4��6�   ��6>   �� *	Instancia+6�   �� 5P   
   $��Agregar��6   {�. $��AgregarCodigoCategoria��6^   ���	#FF192648
���   �$��1q�6�   $��44.6,33,10,184.8q�6�   $��4��6�   ��6>   �� *	Instancia+6�   �� 5Q   
   $��Agregar��6   {�. $��AgregarCodigoEmpaque��6^   ���	#FF192648
���   �$��1q�6�   $��45.6,76,9,141.8q�6�   $��4��6�   ��6>   �� *	Instancia+6�   �� 5R   
   $#��Agregar Producto a Inventario��6   {�. $��AgregarProducto��6�   
���   �
���  ��$��26,0.2,239.2,155.2q�6�   $��2��6�   $��1��6  y�69   �� *IsvisibleAdd+��6p   �� *	Instancia+6  5S      5T      