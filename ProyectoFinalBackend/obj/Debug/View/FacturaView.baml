   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   +    %ProyectoFinalBackend.View.FacturaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	     � Title$  Facturas��5
   	   $	��800��6   $
��1200��6'    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�6l   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��Factura��5      $��Arial)�5         AutoGenerateColumns .  $��50,82,640,174q�5   +    �� SelectedItem 5      ��  �� Path$ SelectFactura���5      �� $ Facturas�   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   5   %   	   EditingElementStyle#	 �   5   %   ,  &System.Windows.Controls.DataGridColumn
   Header$
 Seleccionar��5   %      Binding 5   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5      $
 NUMERO FACTURA��6%      
IsReadOnly .  6=   �� *Numerofactura+6s     5      $	
 NIT��6%    .  62   �� *Nit+6^     5      $
 FECHA��6%    .  64   �� *Fecha+6b     5      $
 TOTAL��6%    .  64   �� *Total+6c   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��140,631,820,0q�6.    � Cursor$
 Hand��6E    � ForceCursor . .+�5       �� $��Ver detalle factura��6   $��
VerDetalle��6Z   
���   ����	#FF1E7463$��	0,0,0,0.8q�6�   $	��224��6�    J� RenderTransformOrigin$ 0.634,0.476&�6�   ��6:   �� *	Instancia+6�   5!      �� 5"   
   -   5         ��Name$ label��5"      $��Facturas��6   $
��Left=�62   $��38��6M   $��
536,10,0,0q�6Y   $	��Top=�6m   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . $��2��6�     5#   
   -   5          Name$ DetalleFactura��5#      $��Arial)�5&       .  $��645,152,45,174q�5(   )    5$      �� *SelectDetalleFactura+��5%      �� *DetalleFacturas+ 5)        5+      $
 COD DETALLE��6%    .  6:   �� *CodigoDetalle+6\     5,      $
 NUM FACTURA��6%    .  6:   �� *NumeroFactura+6\     5-      $
 COD PRODUCTO��6%    .  6;   �� *CodigoProducto+6^     5.      $
 CANTIDAD��6%    .  67   �� *
Cantidad+6T     5/      $
 PRECIO��6%    .  65   �� *Precio+6P     50      $
 CANTIDAD��6%    .  67   �� *
Cantidad+6T   52      �� 53   
   $��Total��6   $��0��6    $��701,82,350,654q�6-   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6E   $��18(�6|   $��Arial Black)�6�    . 6�   �� 54   
   -   5         ��Name$ Total��54      $��0��6!    �� 
IsReadOnly . $��855,85,110,653q�6W   $��Arial)�6o   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Total��6�   ��6@   �� *Total+6�   56      57      