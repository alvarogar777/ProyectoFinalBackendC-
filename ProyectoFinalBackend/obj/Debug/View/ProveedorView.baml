   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   -    'ProyectoFinalBackend.View.ProveedorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   T
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	     � Title$  Proveedores��5
   	   $	��600��6   $	��900��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � 
ResizeMode$ NoResize=�6n   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��129* �6   6.   �� 5      $
��318* �6   �� 5      $	��69* �6   6-   �� 5      $
��256* �6   �� 5      $
��123* �6   .+�5   
   �� $	��Nit��6   $��0��6   $��1��6+   $��0.4,32,120.6,126q�6;   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6U   $��18(�6�   $��Arial Black)�6�    � ForceCursor . 6�   �� 5   
   $��Razón social��6   $��0��6'   $��1��64   $��0.4,74,120.6,84q�6D   $ Upper=�6]   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5   
   $��
Dirección��6   $��0��6$   $��1��61   $��0.4,116,120.6,41q�6A   $ Upper=�6[   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5   
   $��
Pagina web��6   $��0��6%   $��1��62   $��0.4,152,120.6,5q�6B   $ Upper=�6[   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5   
   $��Contacto Principal��6   $��1��6-   $��1��6:   $��0.4,0,120.6,157q�6J   $ Upper=�6c   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5    
   -   5        $��DescripcionFocus��5       $��0��6*   $��0.4,31,9,126q�6y   $��3��6�   $��Arial)�6�   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . 	   	Watermark$	 Ingrese un Nit��6�   $��2��6$  
 �� 
IsReadOnly
 67   �� *IsReadOnlyDescripcion+��6d   �� *Nit+6$  �� 5!   
   $��0��6   $��319.4,73,10,84q�6j   $��4��6�   $��Arial)�6�   $��16(�6�    . $	 Ingrese una Razón social��6�   $��1��6!  
 6   �� *IsReadOnlyDescripcion+��6L   �� *Razon_Social+6!  �� 5"   
   $��0��6   $��319.4,116,10,41q�6g   $��4��6�   $��Arial)�6�   $��16(�6�    . $	 Ingrese una Dirección��6�   $��1��6  
 6   �� *IsReadOnlyDescripcion+��6L   �� *	Direccion+6  �� 5#   
   $��0��6   $��0.4,157,9,0q�6h   $��3��6}   $��Arial)�6�   $��16(�6�    . $	 Ingrese una pagina web��6�   $��2��6  
 6   �� *IsReadOnlyDescripcion+��6L   �� *
Pagina_Web+6  �� 5$   
   $��1��6   $��319.4,0,10,157q�6o   $��4��6�   $��Arial)�6�   $��16(�6�    . $#	 Ingrese un contacto principal��6�   $��1��6+  
 6   �� *IsReadOnlyDescripcion+��6L   �� *ContactoPrincipal+6+  &   System.Windows.Controls.DataGrid  5(   
   -   5        $��	categoria��5(      $��1��5+      $��Arial)�5,         AutoGenerateColumns .  $��0.4,93,26.8,110q�5.   +   $��2��6D   $��1��6U   $��3��6e    �� SelectedItem 5)      ��  �� Path$ SelectProveedor���5*      �� $ Proveedores�   Columns 5/      4  .System.Windows.Controls.DataGridCheckBoxColumn  50         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   51   %      EditingElementStyle# �   52   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��53   %      Binding 54   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  56      $ Codigo��6%      
IsReadOnly .  65   �� *CodigoProveedor+6m     57      $	 Nit��6%    .  62   �� *Nit+6^     58      $ RAZON SOCIAL��6%    .  6;   �� *Razon_Social+6p     59      $ 	DIRECCION��6%    .  68   �� *	Direccion+6j     5:      $ 
PAGINA WEB��6%    .  69   �� *
Pagina_Web+6l   5<      �� 5>   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�66   $��166.4,90,160.8,0q�6O    � Cursor$
 Hand��6i   $��1��6w    . .+�5?      �� $��Agregar��6   $	��Add��6u   ���	#FF192648
���   �$��1q�6�   {�6-   �� *IsEnabledAdd+��6U   �� *	Instancia+6�   �� 5@      $��
Actualizar��6   $��Update��6u   
���   ����	#FF334619{�6-   �� *IsEnableUpdate+��6U   �� *	Instancia+6�   �� 5A      $��Eliminar��6   $��Delete��6u   ���	#FF730F0F
���   �{�6-   �� *IsEnabledDelete+��6U   �� *	Instancia+6�   �� 5B      $��Guardar��6   $
��Save��6t   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   {�6-   �� *IsEnableSave+��6T   �� *	Instancia+6�   �� 5C      $��Cancelar��6   $��Cancel��6y   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $��52��6�   {�61   �� *IsEnableCancel+��6Y   �� *	Instancia+6�   5D      �� 5E   
   -   5         ��Name$ label��5E      $��3��6   $��Proveedores��63   $��1��6I   $
��Left=�6Y   $��38��6t   $��218.2,0,0,0q�6�   $	��Top=�6�   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . 6�   �� 5F   
   $ ��Agregar Proveedor a compra��6   {�. $��AgregarProveedor��6�   
���   �
���  ��$��233.4,48,229.8,107q�6�   $��3��6�   $��1��6	  $��1��6  y�66   �� *IsvisibleAdd+��6m   �� *	Instancia+6  5I      5J      