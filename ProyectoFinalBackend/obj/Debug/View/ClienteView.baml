   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   +    %ProyectoFinalBackend.View.ClienteView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  Clientes��5   	   $	��600��6   $	��900��6'    � WindowStartupLocation$ CenterScreen=�63    � WindowStyle$
 None=�6X    � 
ResizeMode$ NoResize=�6k   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��129* �6   6.   �� 5      $
��318* �6   �� 5      $	��69* �6   6-   �� 5      $
��256* �6   �� 5      $
��123* �6   .+�5   
   �� -   5         ��Name$ label��5      $��3��6   $��Clientes��63   $��1��6F   $
��Left=�6V   $��38��6q   $��218.2,0,0,0q�6}   $	��Top=�6�   $	��199��6�   $��Arial Black)�6�   $��18(�6�    � ForceCursor . 6�   �� 5   
   $	��Nit��6   $��0��6   $��1��6+   $��0.4,32,120.6,126q�6;   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6U   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5   
   $	��DPI��6   $��0��6   $��1��6+   $��0.4,74,120.6,84q�6;   $ Upper=�6T   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5   
   $��Nombre��6   $��0��6!   $��1��6.   $��0.4,116,120.6,41q�6>   $ Upper=�6X   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5    
   $��
Dirección��6   $��0��6$   $��1��61   $��0.4,152,120.6,5q�6A   $ Upper=�6Z   $��18(�6�   $��Arial Black)�6�    . 6�   �� 5#   
   -   5        $��NitFocus��5#      $��0��6"   $��0.2,53,9.6,104.4q�6i   $��3��6�   $��Arial)�6�   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper	   ClearTextButton	 . 
   	Watermark$
 Ingrese un Nit��6�   $��3��6   �� 
IsReadOnly 6/   �� *IsReadOnlyNit+��6T   �� *Nit+6  �� 5$   
   $��0��6   $��0.2,87,9.6,71.4q�6a   $��3��6z   $��Arial)�6�   $��16(�6�   	 . $
 Ingrese DPI��6�   $��3��6   6   �� *IsReadOnlyDescripcion+��6L   �� *Dpi+6  �� 5%   
   $��0��6   $��0.2,120,9.6,38.4q�6d   $��3��6~   $��Arial)�6�   $��16(�6�   	 . $
 Ingrese un Nombre��6�   $��3��6   6   �� *IsReadOnlyDescripcion+��6L   �� *Nombre+6  �� 5&   
   $��0��6   $��0.2,153,9.6,5.4q�6g   $��3��6�   $��Arial)�6�   $��16(�6�   	 . $
 Ingrese una Dirección��6�   $��3��6   6   �� *IsReadOnlyDescripcion+��6L   �� *	Direccion+6  &   System.Windows.Controls.DataGrid  5)   
   -   5        $��cliente��5)      $��1��5,      $��Arial)�5-         AutoGenerateColumns .  $��22.2,61.6,4.8,141.4q�5/   +   $��2��6H   $��1��6Y   $��3��6i    �� SelectedItem 5*      ��  �� Path$ SelectCliente���5+      �� $ Clientes�   Columns 50      4  .System.Windows.Controls.DataGridCheckBoxColumn  51         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   52   %      EditingElementStyle# �   53   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��54   %      Binding 55   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  57      $	 NIT��6%      
IsReadOnly .  62   �� *Nit+6^     58      $	 DPI��6%    .  62   �� *Dpi+6^     59      $ NOMBRE��6%    .  65   �� *Nombre+6d     5:      $ 	DIRECCION��6%    .  68   �� *	Direccion+6j   5>      �� 5?   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�66   $��166.2,54.2,160.4,0.4q�6O    � Cursor$
 Hand��6m   $��1��6{    . .+�5@      �� $��Agregar��6   $	��Add��6u   ���	#FF192648
���   �$��1q�6�   {�6-   �� *IsEnabledAdd+��6U   �� *	Instancia+6�   �� 5A      $��
Actualizar��6   $��Update��6u   
���   ����	#FF334619{�6-   �� *IsEnableUpdate+��6U   �� *	Instancia+6�   �� 5B      $��Eliminar��6   $��Delete��6u   ���	#FF730F0F
���   �{�6-   �� *IsEnabledDelete+��6U   �� *	Instancia+6�   �� 5C      $��Guardar��6   $
��Save��6t   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   {�6-   �� *IsEnableSave+��6T   �� *	Instancia+6�   �� 5D      $��Cancelar��6   $��Cancel��6y   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $��52��6�   {�61   �� *IsEnableCancel+��6Y   �� *	Instancia+6�   5E      �� 5F   
   $��Agregar Cliente a factura��6   {�. $��AgregarCliente��6�   
���   �
���  ��$��233.4,12,229.8,143q�6�   $��3��6�   $��1��6  $��1��6  y�65   �� *IsvisibleAdd+��6l   �� *	Instancia+6  5G      5H      