   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5          WPFQLVeXe.View.QLPhanCong   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:WPFQLVeXe.View  5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ gpbTaiXe��5      $��	Tài Xế��6%   $��1��65   $��0��6E   .��5      �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $	��Mã��6    �� 5      $
��Tên��6    5      �� 5      $��10,0,0,0q�6!   .+�5       �� -   5         ��Name$ tbMaTX��5    "   $	��150��6h   ��62   �� *SelectedItem.MaNV+ �� ElementName$ dtgTX��6h   �� 5!      -   5        $ tbTenTX��5!   "   ��63   �� *SelectedItem.TenNv+$ dtgTX��5"      5#      �� 5$      -   5        $
��Xóa��5$      $��Right=�6'   $��Bottom=�6C   $
��Auto��6^   $��0,5,0,0q�6l   6}   5%      5&      �� 5(   
   -   5        $ gpbPhuXe��5(      $��Phụ Xe��6%   $��2��65   $��0��6E   .��5)      �� $��Center=�6   .+�5*      �� $ 
Horizontal=�6   .+�5+      �� $
��Left=�6!   .+�5,      �� $	��Mã��6    �� 5-      $
��Tên��6    5.      �� 50      $��Right=�6!   .+�51      �� -   5        $ tbMaPX��51   "   $	��150��6h   ��62   �� *SelectedItem.MaNV+$ dtgPX��6h   �� 52      -   5        $ tbTenPX��52   "   ��63   �� *SelectedItem.TenNv+$ dtgPX��53      54      �� 55      -   5        $
��Xóa��55      $��Right=�6'   $��Bottom=�6C   $��0,5,0,0q�6^   $
��Auto��6o   6}   56      57      �� 59   
   -	   5        $ 
gpbTuyenXe��59      $��
Tuyến Xe��6'   $��0��69   $��0��6I   .��5:      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5;      �� $
��Left=�6   .+�5<      �� $	��Mã��6   �� 5=      $
��Từ��6   �� 5>      $��Đến��6   5?      �� 5A      $��Right=�6   .+�5B      �� -
   5        $ tbMaTXe��5B      $	��150��6o   ��6/   �� *SelectedItem.MaTuyen+$ dtgTuyenXePC��6o   �� 5C      -   5        $
 tbTu��5C      ��6,   �� *SelectedItem.DiaDiemDi+$ dtgTuyenXePC���� 5D      -   5        $ tbDen��5D      ��6-   �� *SelectedItem.DiaDiemDen+$ dtgTuyenXePC��5E      5F      5G      �� 5I   
   $��2��6   $��0��6"   $��3��62   $ 
Horizontal=�6F   $��Center=�6_   $��Center=�6|   $��40��6�   .+�5J      �� -   5        $
��Lưu��5J      $��Center=�6#   $��Center=�6@   $��75��6[   $��	0,0,200,0q�6f   $
��Auto��6y   6�   �� 5K      -   5        $
��Xóa��5K      $��Center=�6#   $��Center=�6@   $��75��6[   $��0q�6f   $
��26.5��6q   6   5L      � 5N   
   $��1��6   $��1��6   $��0,0,5,0q�6,   .+�5O      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgTX��5O         AutoGenerateColumns$ False��6<      
IsReadOnly$
 True��6X   	   Columns	 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Mã��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *MaNV+ �� NotifyOnTargetUpdated$
 True�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5R      $

 Tên��6�    6)   �� *TenNv+$
 True��$ OneWay=�$ PropertyChanged=�6�   5T      5U      � 5W   
   $��1��6   $��2��6   $��0,0,5,0q�6,   .+�5X        -   5        $ dtgPX��5X      $ False��6<   $
 True��6X   	 5Y        5Z      $	
 Mã��6�    6)   �� *MaNV+$
 True��$ OneWay=�$ PropertyChanged=�6�     5[      $

 Tên��6�    6)   �� *TenNv+$
 True��$ OneWay=�$ PropertyChanged=�6�   5]      5^      � 5`   
   $��1��6   $��0��6   .+�5a        -   5        $ dtgTuyenXePC��5a      $ False��6J   $
 True��6f   	 5b        5c      $	
 Mã��6�    6)   �� *	MaTuyen+$
 True��$ OneWay=�$ PropertyChanged=�6�     5d      $
 Nơi đi��6�    6)   �� *	DiaDiemDi+$
 True��$ OneWay=�$ PropertyChanged=�6�     5e      $
 Nơi đến��6�    6)   �� *
DiaDiemDen+$
 True��$ OneWay=�$ PropertyChanged=�6�   5g      5h        5j   
   -   5        $ dtgPhanCong��5j      $��3��6(   $��0��65   $��3��6E   $ False��6u   $
 True��6�   	 5k      4  .System.Windows.Controls.DataGridTemplateColumn  5l         CellTemplate 5m      �� 5n      .R�5o      �� -   5         *  &MaterialDesignFloatingActionMiniButton#��[  5o   %    � ToolTip$ Xóa nhân viên��5p   )   $��25��6X   $��25��6d   .��5q   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ DeleteForever=�6:   $��20��6O   $��20��6[   5r      5s      5u        5v      $
 Mã Tuyến��6�    6%   �� *	MaTuyen+$
 True��$ OneWay=�$ PropertyChanged=�6�     5w      $
 	Ngày đi��6�    6%   �� *NgayDi+ �� StringFormat$ 
dd/MM/yyyy��$
 True��$ OneWay=�$ PropertyChanged=�6�     5x      $
 Mã tài xế��6�    6%   �� *MaNV+$
 True��$ OneWay=�$ PropertyChanged=�6�     5y      $
 Mã phụ xe��6�    6%   �� *MaPX+$
 True��$ OneWay=�$ PropertyChanged=�6�   5{      5|      5}      