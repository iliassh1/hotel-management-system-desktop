   M S B A M L   `   `   `  ����O  KHotel_Management_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Hotel_Management_WPFHotel_Management_WPF  5   	   ,    &Hotel_Management_WPF.Umbuchung_Fenster   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Hotel_Management_WPF     5   	     � Title$  Umbuchung_Fenster��5   	   $	��600��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � -   5        #��� ��5	       � ColumnDefinitions 5
   
   �� 5      $	��13* �6   �� 5      $
��319* �6   �� 5      $	��57* �6   �� 5      $
��392* �6   �� 5      $	��11* �6   .+�5   
   �� $��Buchung Nummer��6   $
��Left=�6)   $��
10,109,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ 0.895,3.038&�6p   $��27��6�   $��14(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   $��
Einchecken��6   $
��Left=�6%   $��
10,163,0,0q�6@   $	��Top=�6T   $��27��6l   $��14(�6x   $
��Bold"�6�   $��1��6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
10,217,0,0q�6:   $	��Top=�6N   $��27��6f   $��14(�6r   $
��Bold"�6�   $��1��6�   �� 5   
   $��Vorname��6   $
��Left=�6"   $��
10,275,0,0q�6=   $	��Top=�6Q   $��26��6i   $��14(�6u   $
��Bold"�6�   $��1��6�   �� 5   
   $��Geburtsdatum��6   $
��Left=�6'   $��
10,339,0,0q�6B   $	��Top=�6V   $ 0.474,0.885&�6n   $��27��6�   $��14(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   $��Telefon��6   $
��Left=�6"   $��
10,396,0,0q�6=   $	��Top=�6Q   $��27��6i   $��14(�6u   $
��Bold"�6�   $��1��6�   �� 5   
   $��Total Preis: ��6   $
��Left=�6(   $��
10,441,0,0q�6C   $	��Top=�6W   $��27��6o   $��14(�6{   $
��Bold"�6�   $��1��6�   �� 5   
   $��Sonstige��6   $
��Left=�6#   $��	9,335,0,0q�6>   $	��Top=�6Q   $��14(�6i   $
��Bold"�6w   $��3��6�   �� 5   
   $
��Left=�6   $��
135,83,0,0q�6+   $	��Top=�6?   $��1��6W   �� 5   
   $��Verfügbare Zimmern��6   $
��Left=�6-   $��
10,215,0,0q�6H   $	��Top=�6\   $��14(�6t   $
��Bold"�6�   $��3��6�   �� 5   
   $��
Auschecken��6   $
��Left=�6%   $��	9,162,0,0q�6@   $	��Top=�6S   $��14(�6k   $
��Bold"�6y   $��3��6�   $	��102��6�   �� 5   
   -   5         ��Name$ txt_name��5      $
��Left=�6$   $��23��6?   $��156,219,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��144��6�   $��1��6�   6�   �� 5   
   -   5        $ txt_vorname��5      $
��Left=�6'   $��23��6B   $��156,280,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��144��6�   $��1��6�   �� 5   
   -   5        $ txt_telefon��5      $
��Left=�6'   $��23��6B   $��156,398,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��144��6�   $��1��6�   �� 5   
   -   5         ��Name$ cmbx_sonstige��5      $
��Left=�6*   $��172,340,0,0q�6E   $	��Top=�6Z   $	��144��6r   $��3��6~   6�   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ dp_geb��5       $
��Left=�6%   $��156,340,0,0q�6@   $	��Top=�6U   $	��144��6m   $��1��6y     5!   
   -   5        $ dp_von��5!      $
��Left=�6%   $��156,164,0,0q�6@   $	��Top=�6U   $	��144��6m   $��1��6y      SelectedDateFormat$ Short=�6�     5"   
   -   5        $ dp_bis��5"      $
��Left=�6%   $��172,166,0,0q�6@   $	��Top=�6U   $	��144��6m   $��3��6y   �� 5#   
   -	   5        	 ��Name$	 	lbl_preis��5#      $��0.0 €��6#   $
��Left=�63   $��27��6N   $��185,441,0,0q�6Z   $	��Top=�6o   $��60��6�   $��16(�6�   $
��Bold"�6�   $��1��6�   �� 5$   
   -
   5        $	 lbl_buchung��5$      $�� ��6%   $
��Left=�60   $��197,110,0,0q�6K   $	��Top=�6`   $��16(�6x   $
��Bold"�6�   $��1��6�   �� 5%   
   -   5        
 ��Name$
 bt_Speichern��5%      $��Änderung Speichern��6'   $
��Left=�6D   $��
10,396,0,0q�6_   $	��Top=�6s   $	��147��6�   $��29��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $��3��6�   6�   �� 5&   
   -   5        $
 cmd_abb��5&      $��	Abbrechen��6"   $
��Left=�66   $��172,396,0,0q�6Q   $	��Top=�6f   $	��144��6~   $��29��6�   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   $ 0.538,-3.69&�6�   $��3��6�   6�   �� 5'   
   -   5        $ cmbx_zimmer��5'      $
��Left=�6(   $��172,215,0,0q�6C   $	��Top=�6X   $	��144��6p   $��3��6}   6�   �� 5(   
   $��Passport/Ausweis��6   $��3��6+   $
��Left=�6;   $��
10,278,0,0q�6V   $	��Top=�6j   $
��Bold"�6�   $��14(�6�   �� 5)   
   -   5        $ txt_Pass��5)      $
��Left=�6$   $��23��6?   $��172,280,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��144��6�   $��3��6�   5,      5-      