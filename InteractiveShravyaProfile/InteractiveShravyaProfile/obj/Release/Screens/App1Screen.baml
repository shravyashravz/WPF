   M S B A M L   `   `   `  ���� T  PInteractiveShravyaProfile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InteractiveShravyaProfile.Screens!InteractiveShravyaProfile.Screens  2    ,InteractiveShravyaProfile.Screens.App1Screen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Alocal/clr-namespace:InteractiveShravyaProfile.Screens       � DataContext  �� *App1ViewModel+   ViewModelLocator �� Source# [  .��� .+��  � RowDefinitions �� $��40 ��� $��30 ��� $��* �.+�� $��0��
�������.+���  �� Orientation$ 
Horizontal=�.+��� $��Description : ��$
��Bold"�$<��6pack://InteractiveShravyaProfile:,,,/Fonts/#Good Times)�$��15(��� $��10(����� *ContextName+� $��1��.+��� $	��200��$��Upload Image��$
��Left=�$��2q�  	MnsuStyle#���  ���� *
BrowseFile+� $��2��$��5q�.+��  � ColumnDefinitions �� $	��60* ��� $	��40* �.+�� $��0��
���   �.+��� ���� *ImgSrc+� $��1��.+��  �� $	��50* ��� $	��50* �.+�� $��0��.+��� $ Vertical=�.+���  �� Padding$ 	10,0,10,0q�$��5q�$��20(����� *Probability+ �� StringFormat$$ The Following Product is a {0}������  �� 
TargetType" ��.���  �� Property � ��	 �� Value
	 �  ��
 �� Triggers
 ��  �� Binding �� *Probability+ �� Value BTE.a���  � ��
	 � � ���  �� *Probability+ NOT BTE.a���  � ��
	 �  ���� $��	10,0,10,0q�$��5q�$��20(�$%��Predicted with a confidence of ���� $ 
Horizontal=�.+��� $��	10,0,10,0q�$��5q�$��20(����� *
Confidence+�� $��	10,0,10,0q�$��5q�$��20(�$�� %��� $��1��$��10q�.+�&   System.Windows.Controls.DataGrid  ���� *Predictions+