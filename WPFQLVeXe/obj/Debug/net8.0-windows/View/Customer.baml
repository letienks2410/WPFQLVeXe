   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5   	   /clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5   	       WPFQLVeXe.View.Customer   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:WPFQLVeXe.View  5   	   'viewclr-namespace:WPFQLVeXe.View  5   	     � Title$  Customer��5   	   $	��450��6   $	��800��6'   .��5      )  #MaterialDesignThemes.Wpf.DialogHost  .��5   
   )  #MaterialDesignThemes.Wpf.DrawerHost     IsLeftDrawerOpen 6$   ��  �� ElementName$ MenuToggleButton�� �� Path$ 	IsChecked�   LeftDrawerContent 5      ]� 5      $	��200��6   ���	#FF0097FF.+�5      d�  '  #MaterialDesignHamburgerToggleButton#���   6#   $	��Top=�5       $��Right=�5       $��16q�6<   
������� d� 	IsChecked 5       �� $ MenuToggleButton��$ 	IsChecked� �� Mode$ TwoWay=�6p   �� 5      .+�5      ��   MaterialDesignDivider#���  6!   $��1��6V   $��Stretch=�6a    J� SnapsToDevicePixels$
 True��6   �� 5      -   5        $��
Đặt Vé��5   !   $
��Left=�62   
���������6T   Z� ��6j   Z� 6�   �� 5      #���  6!   $��1��6V   $��Stretch=�6a   $
 True��6   �� 5      -   5        $��Thông Tin Đặt Vé��5   !   $
��Left=�6<   
���������6^   Z� ��6t   Z� 6�   �� 5      #���  6!   $��1��6V   $��Stretch=�6a   $
 True��6   �� 5      -   5        $��
Hàng Hóa��5   !   $
��Left=�64   
���������6V   Z� ��6l   Z� 6�   �� 5      #���  6!   $��1��6V   $��Stretch=�6a   $
 True��6   �� 5      -   5        $��Thông Tin Hàng Hóa��5   !   $
��Left=�6>   
���������6`   Z� ��6v   Z� 6�   �� 5!      #���  6!   $��1��6V   $��Stretch=�6a   $
 True��6   5"      5#      .��5&      ]� .+�5'      (  "MaterialDesignThemes.Wpf.ColorZone  -   5        $��5q�5'   +   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�67   	   Mode$	 
PrimaryMid=�5(   (   $	��Top=�6:   .��5)      ]� .+�5*      d� -   5        
 d�Name$
 MenuToggleButton��5+   &   #���   5*   '   $ FalseY�6e   5+   &   '  !MaterialDesignThemes.Wpf.PopupBox  5,      $��Right=�62      PlacementMode$ BottomAndAlignRightEdges=�6I      	StaysOpen$ False��6r      PopupContent. 5-      �� .+�5.   "   �� -   5        $��
Thông Tin��5.   )   6=   �� 5/   "   -   5        $��Đăng Xuất��5/   )   6=   �� 50   "   �� 51   "   -	   5        $��Thoát��51   )   69   52      53      �� 54      -
   5         ��Name$ 
txbContent��54   $   $��Center=�69   $��Center=�6V   $��22(�6q   :8Quản lý hệ thống bán vé - Dành cho nhân viên6�   55      56      � 57      .+�58      !   WPFQLVeXe.View.ViewSwitcher  $��5q�6(   59      5:      5;      5<      5=      