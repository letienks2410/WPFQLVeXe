   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyVe.ViewQuanLyVe.View  5          QuanLyVe.View.QLThongKe   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyVe.View     5      -   5        .��5	      � $��	10,26,8,7q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   .+�5      �� $��50��6   ���	#8200969C.+�5      �� $��Thông kê bán vé:��6   $��Arial)�64   $
��Bold"�5   ,   ���	#FF1A1A15$��5q�6U   $��18(�6`   5      �� 5      $��2��6   $��0��6)    �� Orientation$ 
Horizontal=�66   $��5q�6O   .+�5      �� $��Năm thống kê:��6   $��Center=�61   $��Center=�5   ,   $��90��6G   �� 5       -   5         ��Name$ cbYear��5       $��1��6+   $	��100��68   $��	0,10,20,0q�6D   $��Right=�6W   $	��Top=�6s   .@�5!      �� $
��2016��6#   �� 5"      $
��2017��6#   �� 5#      $
��2018��6#   5$      5&      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ 
dtgThongKe��5(      $��1��6+      AutoGenerateColumns$ False��68      
IsReadOnly$
 True��6T   $	��300��6f      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã vé��6�   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� *MaVe+
 �� NotifyOnTargetUpdated$

 True�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5+      $ Mã khách hàng��6�   	 6)   �� *MaKh+$

 True��$ OneWay=�$ PropertyChanged=�6�     5,      $ Giá vé��6�   	 6)   �� *GiaVe+$

 True��$ OneWay=�$ PropertyChanged=�6�   5.      5/      50      51      