   M S B A M L   `   `   `  ����O  KHotel_Management_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Hotel_Management_WPFHotel_Management_WPF  5   	        Hotel_Management_WPF.Konto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Hotel_Management_WPF     5   	   -   5          � 
ResizeMode$  CanMinimize=�5   	    � Title$ Konto��5	   	   $	��544��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�6I   .��5
      � $��0,0,2,0q�6   #��� ��6   .+�5   
   �� $d��^Füllen Sie Bitte den Formular mit den folgenden Informationen und Mit dem Button bestätigen:��6   $
��Left=�6w   $��46��6�   $��	61,24,0,0q�6�   $	��Top=�6�   $	��542��6�   $
��Bold"�6�   $��Segoe UI Symbol)�6�   �� 5   
   $��* Benutzername:��6   $
��Left=�6*   $��133,237,0,0q�6E   $	��Top=�6Z    J� RenderTransformOrigin$ 0.289,0.423&�6r   $��14(�6�   $	��166��6�   $��38��6�   �� 5   
   $��Name:��6   $
��Left=�6    $��
133,96,0,0q�6;   $	��Top=�6O   $��14(�6g   $��64��6u   $��38��6�   �� 5   
   $��* Email:��6   $
��Left=�6#   $��133,203,0,0q�6>   $	��Top=�6S   $��14(�6k   $	��179��6y   $��38��6�   �� 5   
   $ ��* Geburtstag: (dd/mm/yyyy)��6   $
��Left=�65   $��133,170,0,0q�6P   $	��Top=�6e   $��14(�6}   $	��243��6�   $��37��6�   �� 5   
   $��Vorname��6   $
��Left=�6"   $��133,130,0,0q�6=   $	��Top=�6R   $��14(�6j   $��82��6x   $��37��6�   �� 5   
   $��* Password:��6   $
��Left=�6&   $��133,277,0,0q�6A   $	��Top=�6V   $ 0.289,0.423&�6n   $��14(�6�   $	��130��6�   $��38��6�   �� 5   
   -   5         ��Name$ txt_name��5      $
��Left=�6$   $��26��6?   $��
335,99,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��185��6�   $��
2147483610��6�   �� 5   
   $��* Password Wiederholen:��6   $
��Left=�62   $��133,313,0,0q�6M   $	��Top=�6b   $ 0.289,0.423&�6z   $��14(�6�   $	��196��6�   $��38��6�   �� 5   
   -   5        $ 	txt_email��5      $
��Left=�6%   $��24��6@   $��335,206,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��185��6�   $��
2147483613��6�   �� 5   
   -   5        $ txt_vorname��5      $
��Left=�6'   $��27��6B   $��335,133,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��185��6�   $��
2147483611��6�   �� 5   
   -   5        $ txt_benutzer��5      $
��Left=�6(   $��26��6C   $��335,239,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��185��6�   $��
2147483614��6�   �� 5   
   -   5         ��Name$ btn_b��5      $��Bestätigen��6    $
��Left=�65   $��24��6P   $��335,390,0,0q�6\   $	��Top=�6q   $��86��6�   6�   �� 5   
   -   5         ��Name$ Check1��5      $+��%Ich stimme die Nutzung Bedingungen zu��6#   $
��Left=�6S   $��163,356,0,0q�6n   $	��Top=�6�   �� 5   
   -   5        $��	Abbrechen��5      $
��Left=�6%   $��24��6@   $��439,390,0,0q�6L   $	��Top=�6a   $��81��6y   6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ 
dp_geburt2��5      $
��Left=�6)   $��335,168,0,0q�6D   $	��Top=�6Y   $	��185��6q   $��29��6}   G� 5   
   -
   5        	 G�Name$	 txt_Password��5      $
��Left=�6,   $��335,286,0,0q�6G   $	��Top=�6\   $	��185��6t   $��20��6�   G� 5   
   -   5        $	 
txt_PasswW��5      $
��Left=�6*   $��334,318,0,0q�6E   $	��Top=�6Z   $	��185��6r   $��20��6~   5      5       