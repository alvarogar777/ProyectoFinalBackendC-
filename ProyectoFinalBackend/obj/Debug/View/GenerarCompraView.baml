   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   1    +ProyectoFinalBackend.View.GenerarCompraView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Generar Compra��5
   	   $	��800��6    $
��1200��6-    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_    � 
ResizeMode$ NoResize=�6r   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ producto��5      $��Arial)�5         AutoGenerateColumns .  $��10,322,895,100q�5   )    �� SelectedItem 5      �� *SelectProducto+��5      �� *	Productos+   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   5      	   EditingElementStyle#	 �   5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Seleccionar��5         Binding 5      �� *
IsSelected+ �� Mode$ OneWay=� �� RelativeSource ��  �� AncestorType)  #System.Windows.Controls.DataGridRow"  0  *System.Windows.Controls.DataGridTextColumn  5      $
 CODIGO��6%      
IsReadOnly .  65   �� *CodigoProducto+6X     5      $
 DESCRIPCION��6%    .  6:   �� *Descripcion+6Z   5      �� 5   
   -   5         ��Name$ Imagen��5      $
��Left=�6>   $	��189��6Y   $��	25,15,0,0q�6f   $	��Top=�6y   $	��218��6�   ��6    �� *	UrlImagen+6�   �� 5   
   $��Cantidad��6   $��0��6#   $��248,85,808,654.6q�60   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6J   $��18(�6�   $��Arial Black)�6�    � ForceCursor .  J� RenderTransformOrigin$ 0.629,1.177&�6�   �� 5    
   $��0��6    �� 
IsReadOnly .  $��397,81,568,654q�6M   $��Arial)�6e   $��16(�6x   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Ingrese cantidad��6�   ��63   �� *
Cantidad+6�   �� 5!   
   $��Agregar productos��6   $	��Add��6S   ���	#FF192648
���   �$��1q�6�   $��255,251,568,483q�6�   ��63   �� *	Instancia+6�   �� 5"   
   $��Existencias��6   $ Upper=�6&   $��12(�6]   $��Arial Black)�6k    . $ 0.629,1.177&�6�   $��310,466,775,269.6q�6�   �� 5#   
   $��0��6    . $��430,462,578,272q�6N   $��Arial)�6g   $��12(�6z    . ��62   �� *
Existencia+6�   �� 5$   
   -   5         ��Name$ label��5$      $��Compras��6   $
��Left=�61   $��38��6L   $��
536,10,0,0q�6X   $	��Top=�6l   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . 6�   �� 5%   
   $��Precio��6   $��0��6!   $��248,150,808,589q�6.   $ Upper=�6G   $��18(�6~   $��Arial Black)�6�    . $ 0.629,1.177&�6�   �� 5&   
   $��0��6    .  $��397,150,568,585q�6K   $��Arial)�6d   $��16(�6w    . $ Ingrese precio��6�   ��63   �� *Precio+6�   �� 5'   
   $	��Nit��6   $��698,85,345,656.6q�6   $ Upper=�69   $��18(�6p   $��Arial Black)�6~    . 6�   �� 5(   
   $��Total��6   $��0��6    $��701,140,350,595.6q�6-   $ Upper=�6H   $��18(�6   $��Arial Black)�6�    . 6�   �� 5)   
   $��Numero Documento��6   $��0��6+   $��701,204,350,531q�68   $ Upper=�6Q   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5*   
   -   5         ��Name$	 Nit��5*      $��0��6    . $��855,81,110,656q�6S   $��Arial)�6k   $��16(�6~    . $ Ingrese Nit��6�   ��6>   �� *Nit+6�   �� 5+   
   -   5        $ Total��5+      $��0��6!    . $��855,143,110,595q�6W   $��Arial)�6p   $��16(�6�    . $ Total��6�   ��6@   �� *Total+6�   �� 5,   
   -   5        $ NumeroDocumento��5,      $��0��6+    .  $��855,204,110,534q�6l   $��Arial)�6�   $��16(�6�    . $ NumeroDocumento��6�   ��6K   �� *NumeroDocumento+6�     5-   
   -   5        $ GenerarCompra��5-      $��Arial)�50       .  $��642,322,40,100q�52   )    5.      �� *SelectGenerarCompra+��5/      �� *GenerarCompras+ 53        54      # �   55      #	 �   56      $
 Seleccionar��57       58      �� *
IsSelected+$ OneWay=� �� "    5:      $
 Codigo Producto��6%    .  6>   �� *CodigoProducto+6a     5;      $
 CANTIDAD��6%    .  67   �� *
Cantidad+6T     5<      $
 PrecioUnidad��6%    .  6;   �� *Precio+6V     5=      $
 TOTAL��6%    .  64   �� *
SubTotal+6Q   5?      �� 5@   
   $��Agregar��6   {�. $��AgregarCodigoCliente��6^   ���	#FF192648
���   �$��1q�6�   $��1095,81,0,660.6q�6�   ��6>   �� *	Instancia+6�   �� 5A   
    �� Orientation$ 
Horizontal=�6   $��766,700,40,0q�6.    � Cursor$
 Hand��6D    . .+�5B      �� $��Eliminar Registro��6   $��Delete��6W   ���	#FF730F0F
���   ���67   �� *	Instancia+6�   �� 5C      $��Guardar factura��6   $
��Save��6W   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   ��67   �� *	Instancia+6�   �� 5D      $��Cancelar Factura��6   $��Cancel��6W   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $	��118��6�   $ 0.634,0.476&�6�   ��67   �� *	Instancia+6�   5E      5G      5H      