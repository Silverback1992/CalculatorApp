   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � Title$  
MainWindow��5   	   $	��525��6   $	��350��6)   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ equationLabel��5      $��Right=�5      $��30(�5      $��Candara Light)�5      $��4��5      �� 5   
   -   5        $ resultLabel��5      $��0��5      $��Right=�5      $��Bottom=�5       $��60(�5!      $��4��5"      �� 5#   
   -   5         ��Name$ acButton��5#      $��AC��5%      $��1��5&      �� 5'   
   -   5        $ negativeButton��5'      $	��+/-��5)      $��1��5*      $��1��5+      �� 5,   
   -   5        $ percentageButton��5,      $��%��5.      $��1��5/      $��2��50      �� 51   
   -   5        $ divideButton��51         operatorButtonStyle#��[  52      $��/��54      $��1��55      $��3��56      �� 57   
   -   5        $ sevenButton��57        numberAndDecimalButtonStyle#��[ 58      $��7��59      $��2��5:      �� 5;   
   -   5        $ eightButton��5;      #��[ 5<      $��8��5=      $��2��5>      $��1��5?      �� 5@   
   -	   5        $ 
nineButton��5@      #��[ 5A      $��9��5B      $��2��5C      $��2��5D      �� 5E   
   -
   5        $ multiplyButton��5E      #��[  5F      $��*��5H      $��2��5I      $��3��5J      �� 5K   
   -   5        $ 
fourButton��5K      #��[ 5L      $��4��5M      $��3��5N      �� 5O   
   -   5        $ 
fiveButton��5O      #��[ 5P      $��5��5Q      $��3��5R      $��1��5S      �� 5T   
   -   5        $ 	sixButton��5T      #��[ 5U      $��6��5V      $��3��5W      $��2��5X      �� 5Y   
   -   5        $ minusButton��5Y      #��[  5Z      $��-��5\      $��3��5]      $��3��5^      �� 5_   
   -   5        $ 	oneButton��5_      #��[ 5`      $��1��5a      $��4��5b      �� 5c   
   -   5        $ 	twoButton��5c      #��[ 5d      $��2��5e      $��4��5f      $��1��5g      �� 5h   
   -   5        $ threeButton��5h      #��[ 5i      $��3��5j      $��4��5k      $��2��5l      �� 5m   
   -   5        $ 
plusButton��5m      #��[  5n      $��+��5p      $��4��5q      $��3��5r      �� 5s   
   -   5        $ 
zeroButton��5s      #��[ 5t      $��0��5u      $��5��5v      $��2��5w      �� 5x   
   -   5        $ decimalButton��5x      #��[ 5y      $��.��5{      $��5��5|      $��2��5}      �� 5~   
   -   5        $ equalButton��5~      #��[  5      $��=��5�      $��5��5�      $��3��5�      5�      5�      