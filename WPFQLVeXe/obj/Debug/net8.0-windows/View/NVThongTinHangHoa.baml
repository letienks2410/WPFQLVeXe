   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5      &     WPFQLVeXe.View.NVThongTinHangHoa   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:WPFQLVeXe.View  5      .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone      Mode$  
PrimaryMid=�6#   $��8 4 8 4q�65      CornerRadius$ 2��6G    K� ZIndex$ 1��6X   $��40,20,20,20q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      $	��400��6P   .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� -   5           MaterialDesignToolButton#���   5       � ToolTip$
 Tìm��6L   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6.    J� Opacity$	 .56Q�6=   5      �� 5      -   5         ��Name$ tbSearch��5      $��1��6,   $��8 0 0 0q�5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Tìm kiếm hàng hóa��6'   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   DecorationVisibility$
 Hidden=�5      $��0q�6S   $	��400��5      $��Center=�6"   6=   �� 5      -   5        $��2��5       & "MaterialDesignToolForegroundButton#���  6)   $ Xem danh sách vé��6f   $��8 0 0 0q�6�   $ 0��6�   .��5         $ Close=�6.   5!      5"      5#      � 5%   
   .+�5&      �� $��Người gửi��6   
����·�$��5,0,0,20q�6@   .��5'      �� -   5         ��Name$ 	stpSender��5'      $	��200��60   .+�5(      �� -   5        $ tbGui��5(      $	 	Họ tên��6-    �� 
IsReadOnly$
 True��6U   �� 5)      -   5        $ 	tbGuiCMND��5)      $
	 CMND��61   $
 True��6W   �� 5*      -   5        $ tbGuiDiaChi��5*      $	 Địa chỉ��63   $
 True��6\   �� 5+      -   5        $ tbGuiSDT��5+      $	 Điện thoại��60   $
 True��6\   5,      5-      �� 5/      $��Người nhận��6   
����·�$��	30,0,0,20q�6@   .��50      �� -	   5        $ stpReceiver��50      $	��200��62   .+�51      �� -
   5        $ tbNhan��51      $	 	Họ tên��6.   $
 True��6V   �� 52      -   5        $ 
tbNhanCMND��52      $
	 CMND��62   $
 True��6X   �� 53      -   5        $ tbNhanDiaChi��53      $	 Địa chỉ��64   $
 True��6]   �� 54      -   5        $ 	tbNhanSDT��54      $	 Điện thoại��61   $
 True��6]   55      56      �� 58      .+�59      �� -   5        $��Sửa��59      $	��100��6(   $��30��64   $��	10,20,0,0q�6@   6S   �� 5:      -   5        $
��Lưu��5:      $	��100��6(   $��30��64   $��	10,10,0,0q�6@   6S   5;      5<      � 5>   
   $��0,20,0,0q�6   $	��280��6!   .+�5?      &   System.Windows.Controls.DataGrid  -   5          Name$ dtgHang��5?         AutoGenerateColumns$ False��6@      
IsReadOnly$
 True��6\   ��6(   ��    Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ 	Mã Hàng��6)   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6:   �� *MaHh+ �� NotifyOnTargetUpdated$
 True�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5B      $ Loại hàng hóa��6)    6@   �� *LoaiHh+$
 True��$ TwoWay=�$ PropertyChanged=�  5C      $ Người gửi��6)    6<   �� *
NguoiGui+ �� StringFormat$ 
dd/MM/yyyy��$
 True��$ TwoWay=�$ PropertyChanged=�  5D      $ Người nhận��6)    6=   �� *	NguoiNhan+$
 True��$ TwoWay=�$ PropertyChanged=�  5E      $ Khối lượng��6)    6=   �� *	KhoiLuong+$
 True��$ TwoWay=�$ PropertyChanged=�  5F      $
 Phí��6)    66   �� *Phi+$
 True��$ TwoWay=�$ PropertyChanged=�5H      5I      5J      5K      