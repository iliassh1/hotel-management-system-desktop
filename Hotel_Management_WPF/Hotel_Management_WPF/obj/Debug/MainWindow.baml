   M S B A M L   `   `   `  ����O  KHotel_Management_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Hotel_Management_WPFHotel_Management_WPF  5   	   %    Hotel_Management_WPF.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Hotel_Management_WPF     5   	   -   5          � 
ResizeMode$  CanMinimize=�5	   	    � Title$ Hotel Management V 1.0��5
   	   $	��600��6(   $	��800��65    � WindowStartupLocation$ CenterScreen=�6A   .��5      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��993* �6    �� 5      $
��607* �6     � ColumnDefinitions 5      �� 5      $	��50* �6#   �� 5      $��0* �6#   �� 5      $	��23* �6#   �� 5      $
��444* �6#   .+�5      �� $0��*imgs/Blue-And-White-Abstract-Wallpaper.jpg��6   $��UniformToFill=�6H   $��4��6`   $��-25,10,25,-10q�6t   $��2��6�   6�   �� 5      -   5         ��Name$ lbl_ben��5      $��Benutzername��6%   $
��Left=�6<   $��363,661,0,0q�6W   $	��Top=�6l   $��82��6�   $	��409��6�   $��48(�6�   $��1��6�   #��� ��6�   $
��Bold"�6  �� 5      -   5        $ lbl_Password��5      $��Passwort��6*   $
��Left=�6=   $��373,773,0,0q�6X   $	��Top=�6m   $��72��6�   $	��364��6�   $��48(�6�   $��1��6�    J� RenderTransformOrigin$ -8.625,8.999&�6�   #��� ��6�   $
��Bold"�6-  �� 5      -   5         ��Name$ txt_log��5      $
��Left=�6'   $��72��6B   $��750,671,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��723��6�   $��1��6�   $��48(�6�   $��2��6�   �� 5      -   5        $��Anmelden��5      $��1��6(   $
��Left=�68   $��750,921,0,0q�6S   $	��Top=�6h   $	��726��6�   $��96��6�   $��48(�6�   $��2��6�   G� 5      -   5        	 G�Name$	 txt_password��5      $��1��60   $
��Left=�6@   $��753,782,0,0q�6[   $	��Top=�6p   $	��724��6�   $ 0.5,0.5&�6�   $��63��6�   $��48(�6�   $��2��6�   z�5      V� 5      .~�5       �� �� 5!      
 �� AngleY$
 0.003Q�6(   �� 5"       �� Angle$ 0.019Q�6*   T� 5#      5$      5&      �� 5'      -   5        $��Konto Erstellen��5'      $��1��6/   $
��Left=�6?   $��98��6Z   $��750,1066,0,0q�6f   $	��Top=�6|   $	��728��6�   $��48(�6�   $��2��6�   �� 5(      -   5        $��Passwort Vergessen��5(      $��1��62   $
��Left=�6B   $��92��6]   $��750,1221,0,0q�6i   $	��Top=�6   $	��728��6�   $��48(�6�   $��2��6�   5,      5-      5.      