   M S B A M L   `   `   `  ����N  JPosition Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Position_CalculatorPosition_Calculator  5   	   $    Position_Calculator.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Position_Calculator     5   	     � Title$  position_size_calculator��5   	   $	��500��6*   $	��500��67    � 
ResizeMode$ CanMinimize=�5	   	    � Icon$ logo.ico��5
   	   
�������.��5      � .+�5   
   �� $��Position Size��6   $
��Left=�6*   $��
200,20,0,0q�6E   $	��Top=�6Y   $��Source Sans Pro Black)�6q   $��20(�6�   �� 5   
   $��Starting Cap :��6   $
��Left=�6*   $��100,100,0,0q�6E   $	��Top=�6Z   $��16(�6r   $��SemiBold"�6�   �� 5   
   -   5         ��Name$ Startingcap��5      $
��Left=�6'   $��200,103,0,0q�6B   $	��Top=�6W   $	��100��6o   �� 5   
   $��Price BTC :��6   $
��Left=�6'   $��100,130,0,0q�6B   $	��Top=�6W   $��16(�6o   $��SemiBold"�6}   �� 5   
   -   5        $ BTCprix��5      $
��Left=�6#   $��180,133,0,0q�6>   $	��Top=�6S   $	��150��6k   �� 5   
   $��Risk :��6   $
��Left=�6"   $��100,160,0,0q�6=   $	��Top=�6R   $��16(�6j   $��SemiBold"�6x   �� 5   
   -   5        $
 risk��5      $
��Left=�6    $��140,163,0,0q�6;   $	��Top=�6P   $��50��6h   �� 5   
   $��Entry :��6   $
��Left=�6#   $��
50,300,0,0q�6>   $	��Top=�6R   $��16(�6j   $��SemiBold"�6x   
���p�6�   �� 5   
   $��Take Profit :��6   $
��Left=�6)   $��190,300,0,0q�6D   $	��Top=�6Y   $��16(�6q   $��SemiBold"�6   
��� � �6�   �� 5   
   $��Stop Loss :��6   $
��Left=�6'   $��350,300,0,0q�6B   $	��Top=�6W   $��16(�6o   $��SemiBold"�6}   
���  ��6�   �� 5   
   -   5        $ Entry��5      $
��Left=�6!   $��
50,330,0,0q�6<   $	��Top=�6P   $	��100��6h   �� 5   
   -   5        $ 
TakeProfit��5      $
��Left=�6&   $��190,330,0,0q�6A   $	��Top=�6V   $	��100��6n   �� 5    
   -   5        $ StopLoss��5       $
��Left=�6$   $��350,330,0,0q�6?   $	��Top=�6T   $	��100��6l   �� 5$   
   -   5        $��Calcul��5$      $
��Left=�6"   $��224,430,0,0q�6=   $	��Top=�6R   $��75��6j   6u   5'      5(      