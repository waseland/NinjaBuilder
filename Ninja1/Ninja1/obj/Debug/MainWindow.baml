   M S B A M L   `   `   `  ����A  =Ninja1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Ninja1.ViewModelNinja1.ViewModel  5   	       Ninja1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0localclr-namespace:Ninja1.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5   	   �� *Main+   Locator �� Source# [  .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly . $��10,41,10,129q�6c   ��6A   �� *	Equipment+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *name+  5      $ Strength��6%    67   �� *
strength+  5      $ Intelligence��6%    6;   �� *intelligence+  5      $ Agillity��6%    67   �� *	agility+  5      $ 	Categorie��6%    68   �� *categorie.name+5      �� 5   
   $��Agility��6   $
��Left=�6"   $��
15,257,0,0q�6=   $	��Top=�6Q   �� 5   
   $
��Name��6   $
��Left=�6   $��	10,10,0,0q�6:   $	��Top=�6M   �� 5   
   $��Intelligence��6   $
��Left=�6'   $��
15,283,0,0q�6B   $	��Top=�6V   �� 5   
   $��
Strength
��6   $
��Left=�6-   $��
15,231,0,0q�6H   $	��Top=�6\   $��26��6t   �� 5   
   $
��gold��6   $
��Left=�6   $��432,283,0,0q�6:   $	��Top=�6O   �� 5   
   $
��Left=�6B   $��	57,10,0,0q�6]   $	��Top=�6p   ��6   �� *name+ �� FallbackValue$ #myname#��6p   �� 5   
   $
��Left=�6O   $��109,283,0,0q�6j   $	��Top=�6   $��26��6�   ��6   �� *intelligence+$ #intelligence#��6�   �� 5   
   $
��Left=�6E   $��109,257,0,0q�6`   $	��Top=�6u   $��26��6�   ��6   �� *	agility+$ 	#agility#��6�   �� 5   
   $
��Left=�6G   $��109,231,0,0q�6b   $	��Top=�6w   $��26��6�   ��6   �� *
strength+$ 
#Strength#��6�   �� 5   
   $
��Left=�6?   $��466,283,0,0q�6Z   $	��Top=�6o   ��6   �� *gold+$ #Gold#��6o   �� 5   
   -   5        $
��Left=�5      $��
432,10,0,0q�6,   $	��Top=�6@   $��75��6X   $��26��6c   $��Store��6   5      5      5!      