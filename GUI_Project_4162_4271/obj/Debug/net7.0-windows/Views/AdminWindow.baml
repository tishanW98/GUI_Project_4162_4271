   M S B A M L   `   `   `  ����P  LGUI_Project_4162_4271, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GUI_Project_4162_4271.ViewModelGUI_Project_4162_4271.ViewModel  5   	   -    'GUI_Project_4162_4271.Views.AdminWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GUI_Project_4162_4271.ViewModel     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*    � DataContext 5	      9   3GUI_Project_4162_4271.ViewModel.NormalUserViewModel  5
   
    � 	Resources 5         BackgroundColor �� 
StartPoint �� EndPoint � Color � Offset  ForegroundColor �� Color��%	  &	        &	 �     �� 5   
   $ 0,0.5&�66   $ 1,0.5&�6I   .��5      � $ LightYellow��6   $	 0.0Q�6/   � 5      $ 	LightCyan��6   $	 0.5Q�6-   � 5      $ 	LightGray��6   $	 1.0Q�6-   5      �� 5   
   $ #545D6A��62   5      .��5      � #��[  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!   
   �� $��0��6   $��	Username:��6!   $��	10 20 0 0q�62   ���#007ACC$
��Bold"�6Z   �� 5"   
   -   5        	 ��Name$	 txtUsername��5"      $��1��6   $��
6 10 380 0q�64   
������ #��[  6�   
����  �$��1q�6�   $	��400��6�   ��6H   �� *NormalUsername+6�   �� 5$   
   $��2��6   $��	Password:��6!   $��	10 20 0 0q�62   ���#007ACC$
��Bold"�6Z   �� 5%   
   -   5        $	 txtPassword��5%      $��3��6   $��
6 10 380 0q�64   
������ #��[  6�   
����  �$��1q�6�   $	��400��6�   ��6H   �� *NormalUserPassword+
 �� StringFormat$
 	{0:#;;''}��6�   �� 5'   
   -   5        $��6��5'      $��Add User��6   $��
10 20 0 10q�61   #��[ 6q   ���#007ACC$	��200��6�   ��6E   �� *InsertNormalUserCommand+6�   5)      5*      