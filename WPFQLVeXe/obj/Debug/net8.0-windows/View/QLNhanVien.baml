   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyVe.ViewQuanLyVe.View  5          QuanLyVe.View.QLNhanVien   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyVe.View     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5
      � $��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#      Mode$ 
PrimaryMid=�60   $��8 4 8 4q�6B      CornerRadius$ 2��6T    K� ZIndex$ 1��6e   $��10q�5   #   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5   #   $	��400��6T   .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� -   5           MaterialDesignToolButton#���   5       � ToolTip$
 Tìm��6L   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6.    J� Opacity$	 .56Q�6=   5      �� 5      -   5        	 ��Name$	 tbSearch��5      $��1��6,   $��8 0 0 0q�5       )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$'
 !Tìm kiếm theo tên nhân viên��6+   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5!      $��0q�6W   $	��400��5"      $��Center=�6&   6A   �� 5$      -   5        $��2��5$       & "MaterialDesignToolForegroundButton#���  6)   $��8 0 0 0q�6f   $ 0��6w   .��5%        $ Close=�6.   5&      5'      5(      �� 5*   
   $��1��6   $	��400��6"   $��Center=�6.   $��Center=�6K    �� Orientation$ 
Horizontal=�6f   .+�5+      �� -   5         ��Name$ stpNV��5+      $	��300��6(   .+�5,      �� -   5        $	 tbMaNV��5,      $
 Mã nhân viên��6f   $	��0,5q�6�    �� 
IsReadOnly$
 True��6�   ��6*   �� *SelectedItem.MaNV+ �� ElementName$ dtgNhanVien��6�   �� 5-      -   5        $	 tbTenNv��5-      $
 Họ và tên��6h   $	��0,5q�6�   $
 True��6�   ��6+   �� *SelectedItem.TenNV+$ dtgNhanVien��6�   (  "System.Windows.Controls.DatePicker  5.      -   5          Name$ 
dpNgaySinh��5.      $
 
Ngày sinh��6�   $	��0,5q�6�      Text 61   �� *SelectedItem.NgaySinh+ �� StringFormat$ 
dd/MM/yyyy��$ dtgNhanVien��6�   �� 5/      -	   5        $	 tbCMND��5/      $

 CMND��6f   $	��0,5q�6�   $
 True��6�   ��6*   �� *SelectedItem.CMND+$ dtgNhanVien��6�   �� 50      -
   5        $	 tbDiaChi��50      $
 Địa chỉ��6j   $	��0,5q�6�   $
 True��6�   ��6,   �� *SelectedItem.DiaChi+$ dtgNhanVien��6�   �� 51      -   5        $	 tbSDT��51      $
 Số điện thoại��6d   $	��0,5q�6�   $
 True��6�   ��6)   �� *SelectedItem.SDT+$ dtgNhanVien��6�   �� 52      -   5         ��Name$ cbLoaiNV��52      $
 Loại nhân viên��6}   $	��0,5q�6�    �� 
IsReadOnly$
 True��6�    �� Text 6-   �� *'%SelectedItem.LoaiNvNavigation.TenLoai+$ dtgNhanVien��6�   53      �� 55      $��10,0,0,0q�6   $��Center=�6+   $��Center=�6H   .+�56      �� -   5        $��Thêm��56      $��0,10,0,5q�6(   6:   �� 57      -   5        $��Sửa��57      $��0,10,0,5q�6'   69   �� 58      -   5        $
��Lưu��58      $	��0,5q�6'   64   59      5:      &   System.Windows.Controls.DataGrid  5<   
   -   5          Name$ dtgNhanVien��5<      $��2��6(      AutoGenerateColumns$ False��65      
IsReadOnly$
 True��6Q   ��6c   ��    Columns 5=      4	  .System.Windows.Controls.DataGridTemplateColumn	  5>       	  CellTemplate 5?      �� 5@      .R�5A      �� -   5         * &MaterialDesignFloatingActionMiniButton#��[ 5A   %   $ Xóa nhân viên��5B   )   $��25��6X   $��25��6d   .��5C   "     $ DeleteForever=�6:   $��20��6O   $��20��6[   5D      5E      5G      0
  *System.Windows.Controls.DataGridTextColumn
  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NV��6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *MaNV+ �� NotifyOnTargetUpdated$
 True�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   
  5I      $ Tên NV��6�       MinWidth$  40Q�6�    6%   �� *TenNV+$
 True��$ TwoWay=�$ PropertyChanged=�6�   
  5J      $ 
Ngày sinh��6�    6%   �� *
NgaySinh+$
 True��$ TwoWay=�$ PropertyChanged=�6�   
  5K      $
 CMND��6�    6%   �� *CMND+$
 True��$ TwoWay=�$ PropertyChanged=�6�   
  5L      $ Địa chỉ��6�    6%   �� *DiaChi+$
 True��$ TwoWay=�$ PropertyChanged=�6�   
  5M      $	 SDT��6�    6%   �� *SDT+$
 True��$ TwoWay=�$ PropertyChanged=�6�   
  5N      $ 	Loại NV��6�    6%   �� *LoaiNvNavigation.TenLoai+$
 True��$ TwoWay=�$ PropertyChanged=�6�   5P      5Q      5R      