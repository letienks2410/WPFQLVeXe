   M S B A M L   `   `   `  ����D  @WPFQLVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFQLVeXe.ViewWPFQLVeXe.View  5   	       WPFQLVeXe.View.DangNhap   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:WPFQLVeXe.View  5   	   -   5          � Title$  DangNhap��5	   	   $	��450��6   $	��300��6'   $��Center=�5
   
    � WindowStartupLocation$ CenterScreen=�6%    � 
ResizeMode$ NoResize=�6J    � WindowStyle$
 None=�6`   ���	#FF34465D.��5      � -   5         � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��Center=�6"   $��Center=�6?   .+�5      �� $��26.667(�6   $��Center=�6*   $��Center=�6G   $
��Bold"�6b   
�������Đăng nhập6�   �� 5      $��Center=�6   $��Center=�65   $��0,5,0,0q�6P   $��18.667(�6a   
�������" Hệ thống quản lý bán vé6�   5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   
�������.+�5      �� -   5         ��Name$ tbUser��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập��5      $��Center=�5      $��Center=�60   $	��200��5      $��10,0,0,0q�5      $��13(�6%   ��5      Z� ��5      Z� 5   %   �� 5          MaterialDesignDivider#���   6   $��1��6J   $��Stretch=�6U    J� SnapsToDevicePixels$
 True��6s   G� 5!      -   5         G�Name$ passwordBox��5!      $ Mật khẩu��5"      $
��Left=�5#      $��Center=�5$      $	��200��5%      $��10,0,0,0q�5(      $��13(�6)   ��5&      Z� ��5'      Z� 5(   7   �� 5)      #���   6   $��1��6J   $��Stretch=�6U   $
 True��6s   �� 5+      -   5        	 ��Name$	 checkRemember��5+      $��20 5 0 5q�6.   .��6`   Nhớ mật khẩu6n   5,      �� 5.   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5/      �� -   5        $��Đăng nhập��5/      $
��Left=�50      $	��Top=�51      $	��110��52      $��30��53      ���	#FF1C223C
�������$��0q�57      $��0,0,5,0q�58   #   ��56      Z� 58   #   �� 59      -   5        $��Thoát��59      $��Right=�5:      $	��Top=�5;      $	��110��5<      $��30��5=      
�������
���������5>      Z� 5A      5B      5C      5D      