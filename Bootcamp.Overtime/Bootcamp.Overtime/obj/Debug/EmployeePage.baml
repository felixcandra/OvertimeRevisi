   M S B A M L   `   `   `  ����G  CWPF.Overtime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF.OvertimeWPF.Overtime  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       WPF.Overtime.EmployeePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF.Overtime     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5          � Title$  EmployeePage��5	   	   $��624.342��6   $��893.997��6/   $��Center=�5
       $��Center=�6=    � 
ResizeMode$ NoResize=�6X    � WindowStartupLocation$ CenterScreen=�6n   .��5      � $��0,0,0,1q�6    � ColumnDefinitions 5   
   �� 5      $
��419* �6   �� 5      $	��43* �6   �� 5      $
��179* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ OvertimeEmployeeGrid��5         
IsReadOnly .    GridLinesVisibility$	 All=�6C   $��1q�6]      AutoGenerateColumns .  $
��Left=�6�   $��	10,88,0,0q�6�   $	��Top=�6�   $	��494��6�   $	��866��6�   $��3��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Date��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$ check_in�6a     5      $	 Hours��6%   $
 * 6X    64   �� $ 
difference�6d     5      $	 Overtime Salary��6%   $
 * 6g    6>   �� $ overtime_salary�6s   5      �� 5   
   -   5         ��Name$ LogoutButton��5      $��Log Out��6'   $
��Left=�69   $��
163,10,0,0q�6T   $	��Top=�6h   $��75��6�   $��2��6�   �� 5   
   -   5        $ ChangeButton��5      $��Change Password��6'   $
��Left=�6A   $��	10,10,0,0q�6\   $	��Top=�6o   $	��143��6�   $��2��6�   �� 5   
   -   5         ��Name$ label��5      $��OVERTIME DATA THIS MONTH��6   $��Center=�6B   $��378,56,28,0q�6_   $	��Top=�6t   $��26��6�   5      5      