   M S B A M L   `   `   `  ���� C  ?Aprogram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AprogramAprogram      Aprogram.UserControlLogin   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  "localclr-namespace:Aprogram  -   $	��500��$	��350��.��� -     �Name$  usercontrolgrid��.+��� $	��280��$	��Top=� �� RadiusY$ 2.656�� �� RadiusX$ 2.656������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ #F20457��� $ #FE5680�� � Offset$ 1Q�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Login=�
������ 
�������$��50��$��50��$	��Top=�$��Center=�$��20q��� $	��280��$	��240�����#212121$��Bottom=�$��0,100q�$ 4.167��$ 4.167�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   Color$	 Black��
   ShadowDepth$
 1Q�   	Direction$ 0Q�   Opacity$
 0.25Q�   
BlurRadius$ 10Q�� $	��280��$	��240��$��Bottom=�$��0,100q�.+��� $��Login��$��Center=�$	��Top=�$��30q����	#FFF20457$��18(�$��Roboto Regular)��� $��Center=�$��10q�.+��� -    ��Name$ usernameinput��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username�� %  !MaterialDesignFloatingHintTextBox#��[  $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(�G� -    G�Name$ 	passinput��$ Password�� ) %MaterialDesignFloatingHintPasswordBox#��[ $
��0,10q����	#FFF20457���#F40057$��Roboto Regular)�$��15(��� -    ��Name$ RememberCheck��$��Remember me�����#F20457$��10(� d� 	IsChecked$
 TrueY����#F20457���#F20457�� -    ��Name$ loginbtn��$��Bottom=�$
��0,85q�$	��150��$��Login��$��Roboto Regular)����	#FFF20457�� $��Bottom=�7  1MaterialDesignThemes.Wpf.Transitions.Transitioner   MoveNextCommand#��Z $��Center=�$��40q�
������ 
������ .���� $��Dont have an Account?�� � Cursor$
 Hand��$��Bottom=�$��10(�$��Center=����#F40057$��Roboto Regular)�� .+�'  !MaterialDesignThemes.Wpf.Snackbar  -     Name$ notification��   IsActive .  
������    Message. .  (MaterialDesignThemes.Wpf.SnackbarMessage  -   $
��name��
�������   ActionContent$ Close���� ���#FE5680$��50��$��50��$	��Top=�$��Center=�$��20q� �� CornerRadius$ 10��y��� *
Visibility+�� $	��280��$	��240�����#F20457$��Bottom=�$��0,100q�$ 4.167��$ 4.167��y��� *
Visibility+   $	 Black��$
 1Q�$ 0Q�$
 0.25Q�$ 10Q�� ���#212121$	��280��$	��240��$��Bottom=�$��0,100q�y��� *
Visibility+.+��� $��Center=�$	��Top=�$��30q�$ 10��$��80��$��20�����#FE5680y��� *
Visibility+�� $��Center=�$��10q�.+��� ���#FE5680$
��0,10q�$	��250��$��40��$ 20��y��� *
Visibility+�� $
��0,10q����#FE5680$	��250��$��40��$ 20��y��� *
Visibility+�� $��Bottom=�$
��0,85q�$	��150��$��35�����#FE5680$ 5��y��� *
Visibility+�� $��Bottom=�$��Center=�$��50q����#FE5680$	��110��$��15��$ 5��y��� *
Visibility+