   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProyectoFinalBackendProyectoFinalBackend  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   %    ProyectoFinalBackend.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProyectoFinalBackend     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Menú principal��5	   	   $	��600��6    $
��1200��6-    � WindowStyle$
 None=�6:    � 
ResizeMode$ NoResize=�6M    � WindowStartupLocation$ CenterScreen=�6c    � WindowState$ 	Maximized=�6�   (  "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5
      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��settings��6   �� 5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��4 0 0 0q�6    $��Center=�61   $��Salir��6L   5      5      5      .��5      �  � Cursor$
 Hand��6   .+�5   
   !  MahApps.Metro.Controls.Tile  $��TipoEmpaque��6   {�.    Title$ Tipo Empaque��6g   	   TitleFontSize$	 23Q�6|   
   
TiltFactor$
 7��6�   $��Arial Black)�6�   $��14(�6�   $��206,89,854,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�    J� Opacity$
 0.80Q�6	  ��67   �� *	Instancia+ J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 9Q�6#      
BlurRadius$ 10Q�63   .��5      �� $��Imagenes/TipoEmpaque.png��6   $	��145��66   $	��119��6B   6R   5        5   
   $��	Categoria��6   {�. $ 	Categoria��6e   $	 22Q�6w   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��363,89,697,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��65   �� *	Instancia+ 5        5      $ 9Q�6#   $ 10Q�63   .��5!      �� $��Imagenes/categoria.png��6   $	��145��64   $	��119��6@   5"        5$   
   $��
Inventario��6   {�. $ 
Inventario��6f   $	 21Q�6y   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��521,89,539,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��66   �� *	Instancia+ 5%        5&      $ 9Q�6#   $ 10Q�63   .��5(      �� $��Imagenes/Inventario.png��6   $	��145��65   $	��119��6A   5)        5+   
   $��Producto��6   {�. $ Producto��6d   $	 23Q�6u   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��679,89,381,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��64   �� *	Instancia+ 5,        5-      $ 9Q�6#   $ 10Q�63   .��5/      �� $��Imagenes/producto.png��6   $	��145��63   $	��119��6?   50        52   
   $��GenerarVenta��6   {�. $ Generar venta��6h   $	 23Q�6~   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��839,89,221,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��68   �� *	Instancia+ 53        54      $ 9Q�6#   $ 10Q�63   .��56      �� $ ��Imagenes/detallecompra.png��6   $	��145��68   $	��119��6D   57        59   
   $��EmailProveedor��6   {�. $ Email Proveedor��6j   $	 21Q�6�   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��1003,89,57,371q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��6:   �� *	Instancia+ 5:        5;      $ 9Q�6#   $ 10Q�63   .��5=      �� $��Imagenes/email2.png��6   $	��145��61   $	��119��6=   5>        5@   
   $��	Proveedor��6   {�. $ 	Proveedor��6e   $	 21Q�6w   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��204,321,856,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  $
 Hand��6  ��65   �� *	Instancia+ 5A        5B      $ 9Q�6#   $ 10Q�63   .��5D      �� $��Imagenes/clientes.png��6   $	��145��63   $	��119��6?   5E        5G   
   $��TelefonoProveedor��6   {�. $ Telefono Proveedor��6m   $	 21Q�6�   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��363,321,697,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��6=   �� *	Instancia+ 5H        5I      $ 9Q�6#   $ 10Q�63   .��5K      �� $��Imagenes/phone.png��6   $	��145��60   $	��119��6<   5L        5N   
   $��GenerarCompra��6   {�. $ Generar Compra��6i   $	 22Q�6�   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��839,321,221,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��69   �� *	Instancia+ 5O        5P      $ 9Q�6#   $ 10Q�63   .��5R      �� $ ��Imagenes/detallecompra.png��6   $	��145��68   $	��119��6D   5S        5U   
   $��Clientes��6   {�. $ Clientes��6d   $	 23Q�6u   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��679,321,381,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��64   �� *	Instancia+ 5V        5W      $ 9Q�6#   $ 10Q�63   .��5Y      �� $��Imagenes/clientes.png��6   $	��145��63   $	��119��6?   5Z        5\   
   $��EmailClientes��6   {�. $ Email Clientes��6i   $	 23Q�6�   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��521,321,539,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��69   �� *	Instancia+ 5]        5^      $ 9Q�6#   $ 10Q�63   .��5`      �� $��Imagenes/email2.png��6   $	��145��61   $	��119��6=   5a        5c   
   $��TelefonoClientes��6   {�. $ Telefono Clientes��6l   $	 23Q�6�   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��1003,321,57,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  ��6<   �� *	Instancia+ 5d        5e      $ 9Q�6#   $ 10Q�63   .��5g      �� $��Imagenes/phone.png��6   $	��145��60   $	��119��6<   5h        5i   
   $��Compra��6   {�. $ Compras��6b   $	 23Q�6r   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��40,321,1020,139q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6   ��62   �� *	Instancia+ 5j        5k      $ 9Q�6#   $ 10Q�63   .��5m      �� $��Imagenes/compra.png��6   $	��145��61   $	��119��6=   5n        5o   
   $��Factura��6   {�. $ Facturas��6c   $	 21Q�6t   $
 7��6�   $��Arial Black)�6�   $��14(�6�   $��40,88,1020,372q�6�   $
��Bold"�6�   $��4,2,0,4q�6�   $
 0.80Q�6  $
 Hand��6  ��63   �� *	Instancia+ 5p        5q      $ 9Q�6#   $ 10Q�63   .��5s      �� $��Imagenes/factura.png��6   $	��145��62   $	��119��6>   5t      �� 5u   
   -   5         ��Name$ label��5u      $��Menú principal��6   $
��Left=�68   $��
642,33,0,0q�6S   $	��Top=�6g   $	��236��6   $��24(�6�   $��Arial Black)�6�   5v      5w      