   M S B A M L   `   `   `  ����T  PInteractiveShravyaProfile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InteractiveShravyaProfileInteractiveShravyaProfile  5   	   *    $InteractiveShravyaProfile.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:InteractiveShravyaProfile     5   	     � Title$  Interactive Profile��5   	   $	��600��6%   $
��1200��62    � DataContext 5	   	   �� *MainViewModel+   ViewModelLocator �� Source# [  .��5      �  � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $��80 �6   �� 5      $��20 �6   �� 5      $��35 �6   �� 5      $
��100* �6   �� 5      $��15 �6   .+�5   
   � $��0��6   
�������5      � 5   
   $��1��6   
����=H�.+�5      �  � ColumnDefinitions 5      �� 5      $	��60* �6'   �� 5      $	��40* �6'   .+�5       � $��0��6   .+�5!      �� $#��Shravya's Interactive Profile��6   $<��6pack://InteractiveShravyaProfile:,,,/Fonts/#Good Times)�6E     AppTitle#���  6�   5"      � 5#      $��1��6   .+�5$      �� $��/Images/MnsuLogo.png��6   $��2,0,40,0q�6:   5%      5'      5)      � 5*   
   $��2��6   
��� ���5-      � 5.   
   $��3��6   
���   � 5/      �� 50      $��* �6#   �� 51      $��* �6#   �� 52      $��* �6#   .+�56      �� -   5         ��Name$ ResumeButton��57      $��0��56      $��Resume��58      $��ResumeScreen��5:        	MnsuStyle#���  5;      ��59      �� *NavigateToResume+5;      �� 5=      -   5        $ 
App1Button��5>      $��1��5=      $��AI Demo��5?      $��
App1Screen��5A      #���  5B      ��5@      �� *NavigateToApp1+5B      �� 5D      -   5        $ 
App2Button��5E      $��3��5D      $��Application 2��5F      $��
App2Screen��5H      #���  5I      ��5G      �� *NavigateToApp2+5I      �� 5K      -   5        $ 
HelpButton��5L      $��3��5K      $��Documentation��5M      $��
HelpScreen��5O      #���  5P      ��5N      �� *NavigateToHelp+5P      5U      � 5W   
   $��4��6   ���#eeee.+�5X      �� -   5         ��Name$ contentControl��5X      $��3q�65   ��6@   �� *CurrentViewModel+5Y      � 5[   
   $��5��6   
�������5]      5`      5a      