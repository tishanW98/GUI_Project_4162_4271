   M S B A M L   `   `   `  ����P  LGUI_Project_4162_4271, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GUI_Project_4162_4271.ViewModelGUI_Project_4162_4271.ViewModel  5   	   7    1GUI_Project_4162_4271.Views.AdminUserLogingWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GUI_Project_4162_4271.ViewModel     5   	     � Title$  AdminUserLogingWindow��5	   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      8   2GUI_Project_4162_4271.ViewModel.AdminUserViewModel  5   
   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ LightYellow��6    � Offset$	 0.0Q�6/   � 5      $ 	LightCyan��6   $	 0.5Q�6-   � 5      $ 	LightGray��6   $	 1.0Q�6-   5      .��5      � .+�5   
   �� $��Center=�6   $��Center=�60   $	��300��6M    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius ��Name��%v  '��       '�� �    �� 5      " ��6   .�5      �� 	 � ��$
 16(�61   �� 5      	 � ��$
 5q�6/   �� 5      	 � ��$
 5q�60   �� 5      	 � ��$	
 150��6.   �� 5      	 � ��$
 36��6/   �� 5      	 � ��
 5       �� 5!      " ��6.   .R�5"   "   �� 
������ ���#007ACC$��2q�6X   $ 10��6l   ._�5#   &   �� $ PART_ContentHost��6>   $��0q�63   6>   5$   #   5%      5'      �� 5(      	 � ��
 �#007ACC63   5)      �� 5*      " ��6   .�5+      �� 	 � ��$
 16(�61   �� 5,      	 � ��$
 5q�6/   �� 5-      	 � ��$
 5q�60   �� 5.      	 � ��$	
 120��6.   �� 5/      	 � ��$
 26��6/   �� 50      	 � ��
 51      �� 52      " ��6.   .R�53   "   �� ���#007ACC���#007ACC$��2q�6T   $ 10��6h   ._�54   &   �� $��Center=�67   $��Center=�6T   $��Content��6o    55   *   ���� 56   .   '��       " ��64   .�57   2   �� 	 � ��
 �#F0F0F06O   �� 58   2   	 � ��$
 Arial)�6O   �� 59   2   	 � ��$
 16(�6M   5:   /   5;   +   5<   '   5=   #   5>      5@      5A      5B      .+�5D      ��  �� Orientation$ 
Horizontal=�6   .+�5E      �� $��Username:    ��6   $��	ExtraBold"�61   $��Center=�6H   ���#007ACC6c   �� 5F      -   5         ��Name$ AdminUsernameTextBox��5F      ��68   �� *AdminUsername+5G      �� 5I      $ 
Horizontal=�6   .+�5J      �� $��Password:      ��6   $
��Bold"�63   $��Center=�6E   ���#007ACC6`   �� 5K      -   5        $ AdminPasswordTextBox��5K      ��68   �� *AdminPassword+ �� StringFormat$ 	{0:#;;''}��5L      �� 5N      -   5         ��Name$ LoginButton��5N   %   $��Login��6   $��Center=�6:   $��41��6W   6d   5O      5P      5Q      