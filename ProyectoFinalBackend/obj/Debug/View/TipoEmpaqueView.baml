   M S B A M L   `   `   `  ����O  KProyectoFinalBackend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProyectoFinalBackend.ViewProyectoFinalBackend.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   /    )ProyectoFinalBackend.View.TipoEmpaqueView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ProyectoFinalBackend.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  Tipo Empaque��5   	   $	��600��6   $	��900��6+    � WindowStartupLocation$ CenterScreen=�67    � WindowStyle$
 None=�6\    � 
ResizeMode$ NoResize=�6o   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��129* �6   6.   �� 5      $
��318* �6   �� 5      $	��69* �6   6-   �� 5      $
��256* �6   �� 5      $
��123* �6   .+�5   
   �� $��Descripción��6   $��0��6&   $��1��63   $��0.2,49,120.4,108.4q�6C   +  %MahApps.Metro.Controls.ControlsHelper   ContentCharacterCasing$ Upper=�6_   $��18(�6�   $��Arial Black)�6�    � ForceCursor . 6�   �� 5   
   -   5        $��DescripcionFocus��5      $��0��6*   $��0.6,53,9.6,104.4q�6�   $��3��6�   $��Arial)�6�   $��16(�6�   *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . 	   	Watermark$	 Ingrese una descripción��6�   $��2��69  
 �� 
IsReadOnly
 67   �� *IsReadOnlyDescripcion+��6d   �� *Descripcion+69  &   System.Windows.Controls.DataGrid  5#   
   -   5        $��tipoEmpaque��5#      $��1��5&      $��Arial)�5'         AutoGenerateColumns .  $��22.2,61.6,4.8,141.4q�5)   +   $��2��6H   $��1��6Y   $��3��6i    �� SelectedItem 5$      ��  �� Path$ SelectTipoEmpaque���5%      �� $ TipoEmpaques�   Columns 5*      4  .System.Windows.Controls.DataGridCheckBoxColumn  5+         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �   5,   %      EditingElementStyle# �   5-   %   ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��5.   %      Binding 5/   %   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  51      $ Codigo��6%      
IsReadOnly .  65   �� *CodigoEmpaque+6k     52      $ Descripción��6%    .  6:   �� *Descripcion+6n   54      �� 56   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�66   $��166.2,54.2,160.4,0.4q�6O    � Cursor$
 Hand��6m   $��1��6{    . .+�57      �� $��Agregar��6   $	��Add��6u   ���	#FF192648
���   �$��1q�6�   {�6-   �� *IsEnabledAdd+��6U   �� *	Instancia+6�   �� 58      $��
Actualizar��6   $��Update��6u   
���   ����	#FF334619{�6-   �� *IsEnableUpdate+��6U   �� *	Instancia+6�   �� 59      $��Eliminar��6   $��Delete��6u   ���	#FF730F0F
���   �{�6-   �� *IsEnabledDelete+��6U   �� *	Instancia+6�   �� 5:      $��Guardar��6   $
��Save��6t   
���   ����	#FF949F12$��	0,0,0,0.2q�6�   {�6-   �� *IsEnableSave+��6T   �� *	Instancia+6�   �� 5;      $��Cancelar��6   $��Cancel��6y   
���   ����	#FF1E7463$��	0,0,0,0.4q�6�   $��52��6�   {�61   �� *IsEnableCancel+��6Y   �� *	Instancia+6�   5<      �� 5=   
   -   5         ��Name$ label��5=      $��3��6   $��Tipo de Empaques��63   $��1��6N   $
��Left=�6^   $��38��6y   $��218.2,0,0,0q�6�   $	��Top=�6�   $	��199��6�   $��Arial Black)�6�   $��18(�6�    . 6�   �� 5>   
   $)��#Agregar Tipo de empaque a productos��6   {�. $��AgregarCategoria��6�   
���   �
���  ��$��183.4,0,229.8,141q�6�   $��3��6�   $��1��6  $��1��6!  y�6?   �� *IsvisibleAdd+��6v   �� *	Instancia+6!  5?      5@      