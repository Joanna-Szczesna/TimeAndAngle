   M S B A M L   `   `   `  ����J  FWpfTimeAndAngle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfTimeAndAngle.ViewModelsWpfTimeAndAngle.ViewModels  5   	        WpfTimeAndAngle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WpfTimeAndAngle.ViewModels     5   	     � Title$  Time and angle [Wpf]��5   	   $	��200��6&   $	��450��63    � DataContext 5	      4  .WpfTimeAndAngle.ViewModels.MainWindowViewModel  5
   
    � 	Resources 5       �� 
TargetType   	TitleText �� Property �� Value  ResourceLabel  TextBox��%�  &	        &	 �     &	 :    �� 5   
   " ��6   .�5      ��  � ��$ Comic Sans MS)�6+   �� 5       � ��$ 12(�6)   �� 5       � ��$
 Left=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ Comic Sans MS)�6+   �� 5       � ��$ 12(�6)   �� 5       � ��$
 Left=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ Comic Sans MS)�6+   �� 5       � ��$ 12(�6)   5      5      .��5      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   .+�5&   
   �� $��0��6   $��2��6!   #��[  65   $��0,0,0,10q�6X    �� TextAlignment$ Center=�6j   $
��Bold"�6�   1/Program do obliczania kątu zawartego pomiędzy�� 5'   <   %#wskazówką minutową, a godzinową5(      �� 5)   
   $��1��6   $��0��6   $��Wpisz czas, np. 14:30��6-   #��[ 6M   �� 5*   
   -   5        $��UserInputText��5*   �   $��1��6   $��1��6   	 �� 	MaxLength$	 5��6/   $��70��6E   #��[ 6�   ��6P   �� 
 �� Path$
 UserInputText� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5+   
   $��2��6   $��0��6   $��Kat[°]:��6-   $��70��6?   #��[ 6J   �� 5,   
   $��2��6   $��1��6   #��[ 6T   ��6-   �� *Angle+ �� Mode$ TwoWay=�6T   5-      5.      