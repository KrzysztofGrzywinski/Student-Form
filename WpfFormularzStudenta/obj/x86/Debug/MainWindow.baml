   M S B A M L   `   `   `  ����  WpfFormularzStudenta%    WpfFormularzStudenta.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$$  Formularz studenta praktykanta��5   	   $	��392��60   $	��640��6=   
����ح� � 	Resources 5         fspButtonStyle �� 
TargetType �� Property �� Value  fspFontStyle  textBoxMenu��%�  &	        &	 �     &	 �     �� 5   
   " ��6'   .�5      ��  � ��
 �����6;   �� 5       � ��
 ��  �6:   �� 5	       � ��$ Arial)�6+   6;   5
      �� 5   
   " ��6%   .�5      ��  � ��$ Verdana)�6+   6=   5      �� 5   
   .@�5      m� $��usunNazwisko��65   -   5        $��Usuń Imię i Nazwisko��5      5      5      5      .��5      � .+�5   
   �� -   5        $��label1��5      $��Imię:��5      $��28��6    $
��Left=�6,   $��	28,25,0,0q�6G   $	��Top=�5      $��40��66   #��[ 6A   �� 5   
   -   5        $
��imie��5   L   $��23��6   $
��Left=�6   $��	74,25,0,0q�69   $	��Top=�5      $	��130��6*   {�.   � ContextMenu# [ 5      �� 5   
   -   5        $��label2��5      $��	Nazwisko:��5      $��28��6$   $
��Left=�60   $��
248,25,0,0q�6K   $	��Top=�5      $��70��66   #��[ 6A   �� 5   
   -   5        $��nazwisko��5   M   $��23��6   $
��Left=�6   $��
320,25,0,0q�69   $	��Top=�5      $	��144��6*   {�.  # [ 5      �� 5   
   -   5        $��label3��5   ^   $��	Uczelnia:��6   $��28��6$   $
��Left=�60   $��	28,67,0,0q�6K   $	��Top=�6l   $��70��6�   �� 5   
   -   5        $��listaUczelni��5   M   $��23��6   $
��Left=�6   $��	91,66,0,0q�6:   $	��Top=�6a   $	��225��6y   {�.  6�   �� 5    
   -	   5        $��czyElektrotech��5!   '   $��Kierunek Elektrotechnika��5       $��16��66   $
��Left=�6B   $��
360,71,0,0q�5!      $	��Top=�6=   $	��151��6U   {�.  6a   �� 5"   
   -
   5        $��label4��5"   p   $!��Data rozpoczęcia praktyki:��6   $��28��65   $
��Left=�6A   $��
28,118,0,0q�6\   $	��Top=�6~   $	��159��6�   (  "System.Windows.Controls.DatePicker  5#   
   -   5        $��dataPraktyki��5#   Q   $��25��6   $
��Left=�6!   $��179,118,0,0q�6<   $	��Top=�5$      $	��275��6-   {�.  69   �� 5%   
   -   5        $��	groupBox1��5%   d   $��Rok studiów��6   $	��160��6(   $
��Left=�65   $��
34,170,0,0q�6P   $	��Top=�6u   $	��136��6�   {�.  .��5&      �� -   5        $��stackPanel1��5&   .   $��0,0,0,0q�6   .+�5'      	� -   5        $
��rok1��5'   :   $��Rok 1��6   $��16��6.   $��0,10,0,0q�6F   	� 5(      -   5        $
��rok2��5(   :   $��Rok 2��6   $��16��6.   $��0,10,0,0q�6F   	� 5)      -   5        $
��rok3��5)   :   $��Rok 3��6   $��16��6.   $��0,10,0,0q�6F   	� 5*      -   5        $
��rok4��5*   :   $��Rok 4��6   $��16��6.   $��0,10,0,0q�6F   	� 5+      -   5        $
��rok5��5+   :   $��Rok 5��6   $��16��6.   $��0,10,0,0q�6F   5,      5-      �� 5.   
   -   5        $��listaJezykow��5.   O   $	��142��6   $
��Left=�6   $��201,182,0,0q�6:   $	��Top=�5/      $	��231��6*   {�.  66   �� 50   
   -   5        $��dodaj��51      $��Dodaj do bazy��50      $��23��6)   $
��Left=�65   $��474,231,0,0q�6P   $	��Top=�51      $	��113��66   #��[  6B   {�.  6~   �� 52   
   -   5        $��wyczysc��53      $��Wyczyść pola��52      $��23��6(   $
��Left=�64   $��474,297,0,0q�6O   $	��Top=�53       $	��113��68   #��[  6D   {�.  6�   ]� 54   
   -   5        $��
dockPanel1��54   I   $��24��6   $��Stretch=�6    $��0q�6>   $	��Top=�6[   $
��Auto��55      .+�56      o� -   5        $��menu1��56      $��23��6   $
��Auto��6,   $	��Top=�69   $	��Top=�6N   .@�57      m� $��_Plik��6   .@�58      m� -   5        $��nowyStazysta��58   7   $��_Nowy Stażysta��6    m� Icon 59      �� 5:      $��Nowy.png��6$   68   5<      m� 5=      -   5        $��
zapiszDane��5=   >   $��_Zapisz Dane Stażysty��6   {�.   5>      �� 5?      $��
Zapisz.png��6$   6:   5A      m� 5B      -   5        $��
otworzDane��5B   >   $��_Otwórz Plik Stażysty��6   5C      �� 5D      6"   m� 5E      -   5        $��wyjscie��5E   1   $��	_Wyjście��6   6X   5F      m� 5G      $��P_omoc��6   .@�5H      m� -   5        $
��info��5H   B   $��Informacja o programie...��6    5I      �� 5J      $��	Pomoc.png��6$   69   5L      5M      5N      5O      �� 5P   
   -   5        $��status��5P   O   $��23��6   $��Stretch=�6    $��0,0,0,0q�6>   $��Bottom=�6]   $
��Auto��6x   5Q      5R      