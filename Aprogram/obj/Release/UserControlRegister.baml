   M S B A M L   `   `   `  ���� C  ?Aprogram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AprogramAprogram  "    Aprogram.UserControlRegister   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  "localclr-namespace:Aprogram  $	��500��$	��350��.��� ���#212121.+��� $	��280��$	��Top=�  �� RadiusY$  2.656�� �� RadiusX$ 2.656������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ #F20457��� $ #FE5680�� � Offset$ 1Q�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Register=�
������ 
�������$��50��$��50��$	��Top=�$��Center=�$��20q��� $	��280��$	��320�����#212121$��Bottom=�$��0,100q�$  4.167��$ 4.167�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��	   ShadowDepth$	 1Q�
   	Direction$
 0Q�   Opacity$
 0.25Q�   
BlurRadius$ 10Q�� $	��280��$	��320��$��Bottom=�$��0,100q�.+��� $��Register��$��Center=�$	��Top=�$��30q����	#FFF20457$��18(�$��Roboto Regular)��� $��Center=�$��10q�.+��� -    ��Name$ 	userinput��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username�� %  !MaterialDesignFloatingHintTextBox#��[  $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(�G� -    G�Name$ 	passinput��$ Password�� ) %MaterialDesignFloatingHintPasswordBox#��[ $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(��� -   $ 
emailinput��$ Email��#��[  $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(��� -   $ licenseinput��$ 
LicenseKey��#��[  $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(��� -    ��Name$ registerbtn��$��Bottom=�$
��0,85q�$	��150��$��Register��$��Roboto Regular)����	#FFF20457�� $��Bottom=�7  1MaterialDesignThemes.Wpf.Transitions.Transitioner   MovePreviousCommand#��Z $��Center=�$��40q�
������ 
������ .���� $��Back to Login�� � Cursor$
 Hand��$��Bottom=�$��10(�$��Center=����#F40057$��Roboto Regular)�� .+�'  !MaterialDesignThemes.Wpf.Snackbar  -     Name$ notification��   IsActive .  
������    Message. .  (MaterialDesignThemes.Wpf.SnackbarMessage  -   $
��name��
�������   ActionContent$ Close��