   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   .    (ProyectoFinalBackend.View.InventarioView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	     � Title$  
Inventario��5
   	   $	��700��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � 
ResizeMode$ NoResize=�6n   .��5      �  � RowDefinitions 5   
   �� 5      $
��253* �6   �� 5      $
��214* �6   �� 5      $
��233* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   6.   �� 5      $
��318* �6   �� 5      $	��69* �6   6-   �� 5      $
��256* �6   �� 5      $
��123* �6   .+�5   
   �� $��Codigo Producto��6   $��0��6*   $��137,36,127.2,175.8q�67   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6S   $��18(�6�   $��Arial Black)�6�    � ForceCursor . $��2��6�   �� 5   
   $��Tipo Registro��6   $��0��6(   $��137,77,127.2,133.8q�65   $ Upper=�6Q   $��18(�6�   $��Arial Black)�6�    . $��2��6�   �� 5   
   $��Precio��6   $��0��6!   $��137,119,127.2,94.8q�6.   $ Upper=�6J   $��18(�6�   $��Arial Black)�6�    . $��2��6�   �� 5   
   $��Entradas��6   $��0��6#   $��137,158,127.2,0q�60   $ Upper=�6I   $��18(�6�   $��Arial Black)�6�    . $��43��6�   $	��Top=�6�   $��2��6�   �� 5   
   $��Salidas��6   $��137,201,127.2,6.8q�6"   $ Upper=�6=   $��18(�6t   $��Arial Black)�6�    .  J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   �� 5   
   -   5        $��CodigoProdcuto��5      $��0��6(   	 �� 
IsReadOnly	 . $��228,33,88.4,176.8q�6g   $��3��6�   $��Arial)�6�   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 .    	Watermark$ Ingrese codigo producto��6�   $��1��6   ��6G   �� *CodigoProducto+6   �� 5    
   $��0��6   $��228,76,137,137.8q�6j   $��4��6�   $��Arial)�6�   $��16(�6�   
 . $ Tipo de registro��6�   $��1��6  	 6   �� *IsReadOnlyDescripcion+��6L   �� *TipoRegistro+6  �� 5!   
   $��0��6   $��228,114,0.4,95.8q�6d   $��3��6~   $��Arial)�6�   $��16(�6�   
 . $ Ingrese precio��6�   $��1��6  	 6   �� *IsReadOnlyDescripcion+��6L   �� *Precio+6  �� 5"   
   $��0��6   $��228,158,137,49.8q�6f   $��4��6�   $��Arial)�6�   $��16(�6�   
 . $ Ingrese entradas��6�   $��1��6  	 6   �� *IsReadOnlyDescripcion+��6L   �� *
Entradas+6  �� 5#   
   $��228,201,137,6.8q�6X   $��4��6q   $��Arial)�6�   $��16(�6�   
 . $ Ingrese salidas��6�   $��1��6  	 6   �� *IsReadOnlyDescripcion+��6?   �� *	Salidas+6  &   System.Windows.Controls.DataGrid  5&   
   -   5        $��
inventario��5&      $��1��5)      $��Arial)�5*         AutoGenerateColumns .  $��22,127.2,4.4,141q�5,   +   $��2��6E   $��1��6V   $��3��6f    �� SelectedItem 5'      ��  �� Path$ SelectInventario���5(      �� $ Inventarios�   Columns 5-      4  .System.Windows.Controls.DataGridCheckBoxColumn  5.         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   5/   %      EditingElementStyle# �   50   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��51   %      Binding 52   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  54      $ CODIGO��6%      
IsReadOnly .  65   �� *CodigoInventario+6n     55      $ CODIGOProducto��6%    .  6=   �� *CodigoProducto+6t     56      $ FECHA��6%    .  64   �� *Fecha+6b     57      $ TIPOREGISTRO��6%    .  6;   �� *TipoRegistro+6p     58      $ PRECIO��6%    .  65   �� *Precio+6d     59      $ ENTRADAS��6%    .  67   �� *
Entradas+6h     5:      $ SALIDAS��6%    .  66   �� *	Salidas+6f   5<      �� 5>   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�66   $��218,91.8,109.4,0q�6O    � Cursor$
 Hand��6i   $��1��6w    . .+�5?      �� $��Agregar��6   $	��Add��6u   ���	#FF192648
���   �$��1q�6�   {�6-   �� *IsEnabledAdd+��6U   �� *	Instancia+6�   �� 5@      $��
Actualizar��6   $��Update��6u   
���   ����	#FF334619{�6-   �� *IsEnableUpdate+��6U   �� *	Instancia+6�   �� 5A      $��Eliminar��6   $��Delete��6u   ���	#FF730F0F
���   �{�6-   �� *IsEnabledDelete+��6U   �� *	Instancia+6�   �� 5B      $��Guardar��6   $
��Save��6t   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   {�6-   �� *IsEnableSave+��6T   �� *	Instancia+6�   �� 5C      $��Cancelar��6   $��Cancel��6y   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $��52��6�   {�61   �� *IsEnableCancel+��6Y   �� *	Instancia+6�   5D      �� 5E   
   -   5         ��Name$ label��5E      $��
Inventario��6   $��1��64   $
��Left=�6D   $��38��6_   $��	286,0,0,0q�6k   $	��Top=�6~   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . $��3��6�   �� 5F   
   $��Agregar��6   {�. $��AgregarCodigoCategoria��6^   ���	#FF192648
���   �$��1q�6�   $��203,36,0.4,181.8q�6�   $��3��6�   ��6>   �� *	Instancia+6�   5G      5H      