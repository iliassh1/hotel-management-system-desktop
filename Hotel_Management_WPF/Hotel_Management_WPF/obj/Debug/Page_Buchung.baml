   M S B A M L   `   `   `  ����O  KHotel_Management_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Hotel_Management_WPFHotel_Management_WPF  5      '    !Hotel_Management_WPF.Page_Buchung   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Hotel_Management_WPF     5        N� Title$  Page_Buchung��5	      .��5      � -   5        #��� ��5       � ColumnDefinitions 5   
   �� 5      $
��287* �6   �� 5      $	��23* �6   �� 5      $	��83* �6   �� 5      $	��67* �6   �� 5      $	��33* �6   �� 5      $
��247* �6   �� 5      $	��60* �6   .+�5   
   �� $��Buchung Nummer��6   $
��Left=�6)   $��
23,109,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ 0.895,3.038&�6p   $��27��6�   $��14(�6�   $
��Bold"�6�   �� 5   
   $��
Einchecken��6   $
��Left=�6%   $��
23,163,0,0q�6@   $	��Top=�6T   $��27��6l   $��14(�6x   $
��Bold"�6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
23,217,0,0q�6:   $	��Top=�6N   $��27��6f   $��14(�6r   $
��Bold"�6�   �� 5   
   $��Vorname��6   $
��Left=�6"   $��
23,275,0,0q�6=   $	��Top=�6Q   $��26��6i   $��14(�6u   $
��Bold"�6�   �� 5   
   $��Geburtsdatum��6   $
��Left=�6'   $��
23,339,0,0q�6B   $	��Top=�6V   $ 0.474,0.885&�6n   $��27��6�   $��14(�6�   $
��Bold"�6�   �� 5   
   $��Telefon��6   $
��Left=�6"   $��
23,396,0,0q�6=   $	��Top=�6Q   $��27��6i   $��14(�6u   $
��Bold"�6�   �� 5   
   $��Total Preis: ��6   $
��Left=�6(   $��
23,441,0,0q�6C   $	��Top=�6W   $��27��6o   $��14(�6{   $
��Bold"�6�   �� 5   
   $��Sonstige��6   $
��Left=�6#   $��	9,335,0,0q�6>   $	��Top=�6Q   $��14(�6i   $
��Bold"�6w   $��3��6�   $��2��6�   �� 5   
   $
��Left=�6   $��
148,83,0,0q�6+   $	��Top=�6?   �� 5   
   $��Verfügbare Zimmern��6   $
��Left=�6-   $��
10,215,0,0q�6H   $	��Top=�6\   $��14(�6t   $
��Bold"�6�   $��3��6�   $��3��6�   �� 5   
   $��
Auschecken��6   $
��Left=�6%   $��	9,162,0,0q�6@   $	��Top=�6S   $��14(�6k   $
��Bold"�6y   $��3��6�   $��3��6�   $	��116��6�   �� 5    
   -   5         ��Name$ txt_name��5       $
��Left=�6$   $��23��6?   $��169,219,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��144��6�   $��3��6�   �� 5!   
   -   5        $ txt_vorname��5!      $
��Left=�6'   $��23��6B   $��169,280,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��144��6�   $��3��6�   �� 5"   
   -   5        $ txt_telefon��5"      $
��Left=�6'   $��23��6B   $��169,398,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��144��6�   $��3��6�   �� 5#   
   -   5         ��Name$ cmbx_sonstige��5#      $
��Left=�6*   $��
72,340,0,0q�6E   $	��Top=�6Y   $	��144��6q   $��5��6}   6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5          Name$ dp_geb��5$      $
��Left=�6%   $��169,340,0,0q�6@   $	��Top=�6U   $	��144��6m   $��3��6y     5%   
   -   5        $ dp_von��5%      $
��Left=�6%   $��169,164,0,0q�6@   $	��Top=�6U   $	��144��6m   $��3��6y     5&   
   -   5        $ dp_bis��5&      $
��Left=�6%   $��
72,166,0,0q�6@   $	��Top=�6T   $	��144��6l   $��5��6x   �� 5'   
   -	   5         ��Name$ 	lbl_preis��5'      $��0.0 €��6#   $
��Left=�63   $��27��6N   $��198,441,0,0q�6Z   $	��Top=�6o   $��60��6�   $��16(�6�   $
��Bold"�6�   �� 5(   
   -
   5        $ lbl_buchung��5(      $	��123��6%   $
��Left=�63   $��210,110,0,0q�6N   $	��Top=�6c   $��16(�6{   $
��Bold"�6�   �� 5)   
   -   5        $��Bestätigen��5)      $
��Left=�6&   $��	0,392,0,0q�6A   $	��Top=�6T   $	��104��6l   $��29��6x   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $��5��6�   �� 5*   
   -   5         ��Name$ cmd_abb��5*      $��	Abbrechen��6"   $
��Left=�66   $��112,392,0,0q�6Q   $	��Top=�6f   $	��104��6~   $��29��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $ 0.538,-3.69&�6�   $��5��6  �� 5+   
   -   5        $ cmbx_zimmer��5+      $
��Left=�6(   $��
72,215,0,0q�6C   $	��Top=�6W   $	��144��6o   $��5��6�   6�   �� 5,   
   $��Passport/Ausweis��6   $��3��6+   $
��Left=�6;   $��
10,278,0,0q�6V   $	��Top=�6j   $
��Bold"�6�   $��14(�6�   $��3��6�   �� 5-   
   -   5        $ txt_Pass��5-      $
��Left=�6$   $��23��6?   $��
72,280,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��144��6�   $��5��6�   6�   �� 5.   
   $��6��6   $
��Left=�6)   $	��427��6D   $��	10,93,0,0q�6Q   $	��Top=�6d   $	��730��6|   51      52      