   M S B A M L   `   `   `  ����H  DVirtualOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VirtualOfficeVirtualOffice  5   	       VirtualOffice.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VirtualOffice     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5    
   �� -   5         ��Name$ txtFirstName��5       $��5q�6(   $��2��63   $��1��6@   $��Center=�6P   $��3��6r    �� TextAlignment$
 left=�6�   �� 5!   
   -   5        $ txtLastName��5!      $��Center=�6'   $��5q�6I   $��3��6T   $��1��6a   $��3��6q   $
 left=�6�   �� 5"   
   -   5        $ txtAge��5"      $��5q�6"   $��Center=�6-   $��4��6O   $��1��6\   $��3��6l   $
 left=�6�   �� 5#   
   -   5        $ 	txtSalary��5#      $��5q�6%   $��Center=�60   $��5��6R   $��1��6_   $��3��6o   $
 left=�6�   �� 5$   
   $��
Firstname:��6   $��2��6&   $��Center=�63   $��Center=�6P   $��14(�6k   �� 5%   
   $��	Lastname:��6   $��3��6%   $��Center=�62   $��Center=�6O   $��14(�6j    J� RenderTransformOrigin$ 
0.66,0.416&�6x   �� 5&   
   $
��Age:��6   $��4��6    $��0��6-   $
��Left=�6=   $	��Top=�6X   $��14(�6p   $��23,5,0,0q�6~   �� 5'   
   $��Salary:��6   $��5��6#   $��0��60   $
��Left=�6@   $��Center=�6[   $��14(�6v   $��17,0,0,0q�6�   �� 5(   
   $��New employee��6   $��1��6'   $��1��68   $��1��6E   $��4��6U   $��28(�6i   �� 5)   
   $��
Department��6   $��6��6%   $��Center=�62   $��Center=�6O   $��14(�6j   �� 5*   
   $��Bio (optional)��6   $��7��6)   $��Center=�66   $��Center=�6S   $��14(�6n   �� 5+   
   -   5        $ txtBio��5+      $��7��6"   $��Center=�6/   $��1��6Q   $��3��6a   $��1��6u   
�������$��5,2,5, 0q�6�   �� 5,   
   -   5         ��Name$ EmployeeListView��5,      $��
2, 2, 2, 2q�6-   $��2��6A   $��4��6N   $��3��6^   $��5��6r   	 �� View	 5-      �� 5.      .P�5/      �� $��	Firstname��6%   
 �� Width$
 70��68    �� DisplayMemberBinding 6C   �� *
Förnamn+�� 50      $��Lastname��6%   $
 70��67    6C   �� *	EfterNamn+�� 51      $��
Department��6%   $
 90��69    6E   �� *
Bakgrund+52      54      �� 55   
   -   5        $��comboDepartment��55      $��1��6*   $��5q�6:   $��6��6E   $��3��6R   �� 56   
   -   5        $	��Add��56   &   $��4��64   $��7��6D   $��17(�6Q   $��5q�6_   �� 57   
   -	   5        $��	btndelete��57      $��5��6"   $��7��62   $��5q�6?   $��Remove��6J   $��17(�6[   ${�False��6i   6{   �� 58   
   -
   5        $��
btnDetails��58      $��6��6#   $��7��63   $��Show details��6@   $��5q�6W   6b   �� 59   
   -   5        $��lblcount��59      $��0��6    $��4��6-   $��Registered employees: ��6=   $��3��6^   5:      5;      