   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5      $    WPFQLVeXe.View.NVThongTinDatVe   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WPFQLVeXe.View     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5
      �� .+�5   
   � $��50��6   $��20q�6    .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  $��1��6'       Mode$  
PrimaryMid=�64   $��8 4 8 4q�6F      CornerRadius$ 2��6X    K� ZIndex$ 1��6i   $��	16 0 16 0q�5   #   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5   #   .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      �� -   5           MaterialDesignToolButton#���   5       � ToolTip$
 Tìm��6P   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�62    J� Opacity$	 .56Q�6A   5      �� 5      -   5         ��Name$ tbSearch��5      $��1��60   $��8 0 0 0q�5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Tìm kiếm vé��6+   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   DecorationVisibility$
 Hidden=�5      $��0q�6W   $	��400��5      $��Center=�6&   6A   �� 5      -   5        $��2��5       & "MaterialDesignToolForegroundButton#���  6-   $ Xem danh sách vé��6j   $��8 0 0 0q�6�   $ 0��6�   .��5         $ Close=�62   5!      5"      5#      5$      � 5%   
   .+�5&      �� .+�5'      �� $��Thông tin khách hàng��6   $	��280��69   .��5(      � .+�5)      �� .+�5*      �� .��6$   Tên khách hàng64   �� 5+      .��6$   CMND6*   �� 5,      .��6$   Địa chỉ6-   �� 5-      .��6$   Số điện thoại63   5.      �� 5/      .+�50      �� -   5        $ tbTen��50   &   $��25��65   $	��150��6A    �� 
IsReadOnly$
 True��6M   6a   �� 51      -   5        $ tbCMND��51   &   $��25��66   $	��150��6C   $
 True��6O   6c   �� 52      -   5        $ tbDiaChi��52   &   $��25��68   $	��150��6D   $
 True��6P   6d   �� 53      -   5        $ tbSDT��53   &   $��25��65   $	��150��6A   $
 True��6M   6a   54      55      56      57      �� 58      .+�59      �� $��Thông tin đặt vé��6   .��5:      � .+�5;      �� .+�5<      �� .��6$   Mã tuyến6.   �� 5=      .��6$   Địa điểm đi61   �� 5>      .��6$   	Ngày đi6-   �� 5?      .��6$   	Giờ đi6,   5@      �� 5A      .+�5B      �� -	   5        $ 	tbMaTuyen��5B   &   $��25��6:   $��80��6F   $
 True��6Q   6e   �� 5C      -
   5        $ 	tbTuyenDi��5C   &   $��25��6:   $��80��6F   $
 True��6Q   6e   �� 5D      -   5        $ tbNgayDi��5D   &   $��25��69   $��80��6E   $
 True��6P   6d   �� 5E      -   5        $ tbGioDi��5E   &   $��25��68   $��80��6D   $
 True��6O   6c   5F      �� 5G      .+�5H      �� .��6$   Vị trí ghế60   �� 5I      .��6$   Địa điểm đến62   �� 5J      .��6$   Ngày đến6.   �� 5K      .��6$   Giờ đến6-   5L      �� 5M      .+�5N      �� -   5        $ tbGhe��5N   &   $��25��66   $��80��6B   $
 True��6M   6a   �� 5O      -   5        $ 
tbTuyenDen��5O   &   $��25��6;   $��80��6G   $
 True��6R   6f   �� 5P      -   5        $ 	tbNgayDen��5P   &   $��25��6:   $��80��6F   $
 True��6Q   6e   �� 5Q      -   5        $ tbGioDen��5Q   &   $��25��69   $��80��6E   $
 True��6P   6d   5R      5S      5T      5U      �� 5V      $��10q�6   .+�5W      �� -   5        $��30��5W      $��80��6%   .��6B   Sửa6G   �� 5X      -   5        $��30��5X      $��80��6%   $��0,10,0,0q�6@   .��6R   Lưu6W   5Y      5Z      � 5[   
   $��0,20,0,0q�6   $	��280��6!   .+�5\      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgVe��5\         AutoGenerateColumns$ False��6>      
IsReadOnly$
 True��6Z   ��6&   ��    Columns 5]      0  *System.Windows.Controls.DataGridTextColumn  5^      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã vé��6)   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 68   �� *MaVe+ �� NotifyOnTargetUpdated$
 True�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5_      $ Mã khách hàng��6)    6@   �� *MaKh+$
 True��$ TwoWay=�$ PropertyChanged=�  5`      $ 	Ngày đi��6)    6:   �� *NgayDi+ �� StringFormat$ 
dd/MM/yyyy��$
 True��$ TwoWay=�$ PropertyChanged=�  5a      $ 	Giờ đi��6)    69   �� *GioDi+$
 True��$ TwoWay=�$ PropertyChanged=�  5b      $ Vị trí ghế��6)    6=   �� *MaGhe+$
 True��$ TwoWay=�$ PropertyChanged=�  5c      $ Số xe��6)    68   �� *SoXe+$
 True��$ TwoWay=�$ PropertyChanged=�  5d      $ Giá vé��6)    69   �� *GiaVe+$
 True��$ TwoWay=�$ PropertyChanged=�5f      5g      5h      5i      