   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   0    *ProyectoFinalBackend.View.GenerarVentaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	     � Title$  Generar Factura��5   	   $	��800��6!   $
��1200��6.    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`    � 
ResizeMode$ NoResize=�6s   .��5      � $��0,10,0,0q�6    � RowDefinitions 5   
    � ColumnDefinitions 5   
   �� 5      $
��527* �6   �� 5      $
��473* �6   .+�5   
   �� $	��Nit��6   $��66,85,345,647q�6   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�66   $��18(�6m   $��Arial Black)�6{    � ForceCursor . $��1��6�   �� 5   
   $��Total��6   $��0��6    $��69,140,350,586q�6-   $ Upper=�6E   $��18(�6|   $��Arial Black)�6�    . $��1��6�   �� 5   
   -   5        $	��Nit��5      $��0��6    �� 
IsReadOnly . $��223,81,110,647q�6Q   $��Arial)�6i   $��16(�6|   *  $MahApps.Metro.Controls.TextBoxHelper	   ClearTextButton	 . 
   	Watermark$
 Ingrese Nit��6�   $��1��6�   ��6<   �� *Nit+6�   �� 5   
   -   5        $��Total��5      $��0��6    . $��223,143,110,586q�6U   $��Arial)�6n   $��16(�6�   	 . $
 Total��6�   $��1��6�   ��6>   �� *Total+6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��producto��5      $��Arial)�5          AutoGenerateColumns .  $��10,241,327,171q�5"   +    �� SelectedItem 5      ��  �� Path$ SelectProducto���5      �� $ 	Productos�   Columns 5#      4  .System.Windows.Controls.DataGridCheckBoxColumn  5$         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   5%   %      EditingElementStyle# �   5&   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��5'   %      Binding 5(   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5*      $ CODIGO��6%      
IsReadOnly .  65   �� *CodigoProducto+6l     5+      $ DESCRIPCION��6%    .  6:   �� *Descripcion+6n   5-        5.   
   -   5        $��GenerarVenta��5.      $��Arial)�51       .  $��10,239,0,173q�53   +   $��1��6A    5/      �� $ SelectGenerarVenta���50      �� $ GenerarVentas� 54        55      # �   56   %   # �   57   %   $ Seleccionar��58   %    59   %   ��  �� $ DataGridRowL�$ 
IsSelected�$ OneWay=�  5;      $ CODIGO��6%    .  65   �� *CodigoProducto+6l     5<      $ DESCRIPCION��6%    .  6:   �� *Descripcion+6n     5=      $ CANTIDAD��6%    .  67   �� *
Cantidad+6h     5>      $ PrecioUnidad��6%    .  6;   �� *PrecioUnitario+6r     5?      $ TOTAL��6%    .  64   �� *Total+6c   5A      �� 5C   
    �� Orientation$ 
Horizontal=�6   $��110,622,64,9q�6.    � Cursor$
 Hand��6D    . $��1��6e   .+�5D      �� $��Eliminar Registro��6   $��Delete��6W   ���	#FF730F0F
���   ���67   �� *	Instancia+6�   �� 5E      $��Guardar factura��6   $
��Save��6W   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   ��67   �� *	Instancia+6�   �� 5F      $��Cancelar Factura��6   $��Cancel��6W   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $	��118��6�    J� RenderTransformOrigin$ 0.634,0.476&�6�   ��67   �� *	Instancia+6�   5G      �� 5H   
   -   5         ��Name$ label��5H      $��Facturas��6   $
��Left=�62   $��38��6M   $��
536,10,0,0q�6Y   $	��Top=�6m   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . $��2��6�   �� 5I   
   $��Agregar��6   {�. $��AgregarCodigoCliente��6^   ���	#FF192648
���   �$��1q�6�   $��463,81,0,651q�6�   $��1��6�   ��6>   �� *	Instancia+6�   �� 5J   
   -   5         ��Name$ Imagen��5J      $
��Left=�6>   $	��189��6Y   $��	25,15,0,0q�6f   $	��Top=�6y   $	��218��6�   ��6    �� *	UrlImagen+6�   �� 5K   
   $��Cantidad��6   $��0��6#   $��248,85,240,645q�60   $ Upper=�6H   $��18(�6   $��Arial Black)�6�    . $ 0.629,1.177&�6�   �� 5L   
   $��0��6    .  $��397,81,0,645q�6U   $��Arial)�6k   $��16(�6~   	 . $
 Ingrese cantidad��6�   ��63   �� *CantidadProducto+6�   �� 5M   
   $��Agregar productos��6   $	��Add��6S   ���	#FF192648
���   �$��1q�6�   $��255,170,0,554q�6�   ��63   �� *	Instancia+6�   �� 5N   
   $��Precio unitario��6   $��0��6*   $��310,269,202,460q�67   $ Upper=�6P   $��12(�6�   $��Arial Black)�6�    . $ 0.629,1.177&�6�   �� 5O   
   $��Precio Docena��6   $��0��6(   $��310,335,202,392q�65   $ Upper=�6N   $��12(�6�   $��Arial Black)�6�    . $ 0.629,1.177&�6�   �� 5P   
   $��Precio Mayor��6   $ Upper=�6'   $��12(�6^   $��Arial Black)�6l    . $ 0.629,1.177&�6�   $��310,403,202,324q�6�   �� 5Q   
   $��Existencias��6   $ Upper=�6&   $��12(�6]   $��Arial Black)�6k    . $ 0.629,1.177&�6�   $��310,466,207,260q�6�   �� 5R   
   $��0��6    . $��430,274,10,455q�6R   $��Arial)�6j   $��12(�6}   	 . ��62   �� *PrecioUnitario+6�   �� 5S   
   $��0��6    . $��430,336,10,392q�6S   $��Arial)�6k   $��12(�6~   	 . ��62   �� *PrecioPorDocena+6�   �� 5T   
   $��0��6    . $��430,398,10,329q�6R   $��Arial)�6j   $��12(�6}   	 . ��62   �� *PrecioPorMayor+6�   �� 5U   
   $��0��6    . $��430,462,10,263q�6N   $��Arial)�6f   $��12(�6y   	 . ��62   �� *
Existencia+6�   5W      5X      