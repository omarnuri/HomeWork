   M S B A M L   `   `   `  ����G  CTextRedactor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MyCommands
MyCommands  5   	   +clr-namespace:TextRedactorTextRedactor  5   	       TextRedactor.MainWindow   5      %commandsclr-namespace:MyCommands  5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TextRedactor     5   	   -   5        $��Window��5
   	   $	��450��6   $	��800��6$     � Title$(  "Без Имени - Блокнот��6I    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      6'     5   
   -   5        $
 Save��5      6(     5   
   -   5           MyCommands.Commands   Exit# Z 5      6E     5   
   -   5        $ Print��5      6)     5   
   -   5        $
 Open��5      6(     5   
   -   5           WordWrap# Z 5      6I     5   
   -   5           Color# Z 5      6F     5   
   -	   5           Font# Z 5      6E     5   
   -
   5           About# Z 5      6F     5   
   -   5           HotkeysHelp# Z 5      6L   	 J� InputBindings	 5      �� 5   
   

 �� Key$
 N��6    �� 	Modifiers$
 Ctrlf�6    �� Command$	 New��6.   �� 5   
   $
 S��6   $
 Ctrlf�6   $
 Save��6.   �� 5   
   $
 E��6   $
 Ctrlf�6   # Z 6.   �� 5   
   $
 W��6   $
 Ctrlf�6   # Z 6.   �� 5   
   $
 F��6   $
 Ctrlf�6   # Z 6.   �� 5    
   $
 B��6   $
 Ctrlf�6   # Z 6.   �� 5!   
   $
 I��6   $
 Ctrlf�6   # Z 6.   �� 5"   
   $
 M��6   $
 Ctrlf�6   # Z 6.   .��5(      �  � RowDefinitions 5)   
   �� 5*      $
��Auto �6   �� 5+       � ColumnDefinitions 5-   
   .+�5/   
   o� .@�50      m� $
��File��6   .@�51      m� $	��New��6    m� Command$	 New��6*    m� InputGestureText$ CTRL+N��68   m� 52      $
��Open��6   $
 Open��6*   $ CTRL+O��69   m� 53      $
��Save��6   $
 Save��6*   $ CTRL+S��69   m� 54      $��Print��6   $ Print��6*   $ CTRL+P��6:   m� 55      $
��Exit��6   # Z 6*   $ CTRL+E��6V   56      m� 58      $��Format��6   .@�59      m� $��	Word Wrap��6   # Z 6/   $ CTRL+W��6_   m� 5:      $
��Font��6   # Z 6/   $ CTRL+F��6[   m� 5;      $��Color��6   # Z 6/   $ CTRL+B��6\   5<      m� 5>      $
��Help��6   .@�5?      m� $��Hotkey help��6   # Z 61   $ CTRL+M��6d   m� 5@      $��About��6   # Z 6+   $ CTRL+I��6X   5A      5B      �� 5C   
   -   5        $
��Text��5C   F   $��1��6    �� AcceptsReturn$
 True��6    �� 
AcceptsTab$
 True��64   $
��Auto=�6R   $
��Auto=�6�   .��6�   5D      5G      5H      