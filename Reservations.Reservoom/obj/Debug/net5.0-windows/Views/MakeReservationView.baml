   M S B A M L   `   `   `  ����Q  MReservations.Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Reservations.Reservoom.ViewsReservations.Reservoom.Views  5      6    0Reservations.Reservoom.Views.MakeReservationView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Reservations.Reservoom.Views     5      .��5      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5      $��Make Reservation��5      � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Username��6%   �� 5       $��1��5!      $��0 5 0 0q�5"      ��5#      �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�5$      � 5&   
   $��2��6   $��0 10 0 0q�6    5'      �� 5(      $
��auto �6    �� 5)      $
��auto �6     � ColumnDefinitions 5+      �� 5-      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5.      $
��auto �6#   $ SecondColumn��60   .+�51      �� $��0��52      $��0��53      $��	Floor No.��54      �� 55      $��1��56      $��0��57      $��0 5 0 0q�58      ��59      �� *FloorNumber+$ PropertyChanged=��� 5;      $��0��5<      $��1��5=      $��10 0 0 0q�5>      $��Room No.��5?      �� 5@      $��1��5A      $��1��5B      $��10 5 0 0q�5C      ��5D      �� *
RoomNumber+$ PropertyChanged=�5E      � 5G   
   $��3��6   $��0 10 0 0q�6    5H      �� 5I      $
��auto �6    �� 5J      $
��auto �6     5L      �� 5N      $
��auto �6#   $ FirstColumn��60   �� 5O      $
��auto �6#   $ SecondColumn��60   .+�5R      �� $��0��5S      $��0��5T      $��
Start Date��5U      (  "System.Windows.Controls.DatePicker  5V      $��1��5W      $��0��5X      $��0 5 0 0q�5Y         SelectedDate 5Z      �� *	StartDate+$ PropertyChanged=��� 5\      $��0��5]      $��1��5^      $��10 0 0 0q�5_      $��End Date��5`        5a      $��1��5b      $��1��5c      $��10 5 0 0q�5d       5e      �� *	EndDate+$ PropertyChanged=�5f      �� 5h   
   $��4��5i      $��0 25 0 0q�5j       �� Orientation$ 
Horizontal=�5k      .+�5l      �� $��Submit��67   ��6   �� *SubmitCommand+67   �� 5m      $��10 0 0 0q�5n      $��Cancel��5p      ��5o      �� *CancelCommand+5z      5�      �� 5�   
   $��5��5�      $��0 20 0 0q�5�      
���  ��$�� ��5�      5�      5�      