   M S B A M L   `   `   `  ���� T  PInteractiveShravyaProfile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:InteractiveShravyaProfileInteractiveShravyaProfile  *    $InteractiveShravyaProfile.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:InteractiveShravyaProfile       � Title$  Interactive Profile��$	��600��$
��1200�� � DataContext �� *MainViewModel+   ViewModelLocator �� Source# [  .���  � RowDefinitions �� $��15 ��� $��80 ��� $��20 ��� $��35 ��� $
��100* ��� $��15 �.+�� $��0��
�������� $��1��
����=H�.+��  � ColumnDefinitions �� $	��60* ��� $	��40* �.+�� $��0��.+��� $#��Shravya's Interactive Profile��$<��6pack://InteractiveShravyaProfile:,,,/Fonts/#Good Times)�  AppTitle#���  � $��1��.+��� $��/Images/MnsuLogo.png��$��2,0,40,0q�� $��2��
��� ���� $��3��
���   � �� $��* ��� $��* ��� $��* �.+��� -    ��Name$ ResumeButton��$��0��$��Resume��$��ResumeScreen��  	MnsuStyle#���  ���� *NavigateToResume+�� -   $ 
App1Button��$��1��$��AI Demo��$��
App1Screen��#���  ���� *NavigateToApp1+�� -   $ 
App2Button��$��3��$��Application 2��$��
App2Screen��#���  ���� *NavigateToApp2+�� -   $ 
HelpButton��$��3��$��Documentation��$��
HelpScreen��#���  ���� *NavigateToHelp+� $��4�����#eeee.+��� -    ��Name$ contentControl��$��3q����� *CurrentViewModel+� $��5��
�������