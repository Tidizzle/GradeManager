   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.1.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   I EGradeManagerV4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GradeManagerGradeManager 5   	      GradeManager.MainWindow   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GradeManager     5   	     � Title$  GradeManager��5	   	   $	��300��6   $	��525��6+    � 
ResizeMode$ NoResize=�5
   	      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	      	TitleCaps .     ShowCloseButton .     ShowMinButton .     ShowMaxRestoreButton .  .��5      � .+�5   
   G� -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��320,144,0,0q�6F   $	��125��6[   $	��Top=�6g   �� 5   
   -   5         ��Name$ usernameBox��5      $
��Left=�6'   $��320,100,0,0q�6B   $	��125��6W   $	��Top=�6c   �� 5   
   -   5        	 ��Name$	 login_button��5      $��LOGIN��6'   $
��Left=�67   $��320,184,0,0q�6R   $	��Top=�6g   $��90��6     AccentedSquareButtonStyle#���  6�   $��Heavy"�6�   6�   �� 5   
   -   5        
 ��Name$
 lblPassword��5      $��	Password:��6%   $
��Left=�69   $��247,144,0,0q�6T   $	��Top=�6i   $��Medium"�6�   �� 5   
   -   5        $
 lblUsername��5      $��	Username:��6%   $
��Left=�69   $��247,100,0,0q�6T   $	��Top=�6i   $��Medium"�6�   �� 5   
   -   5        $
 lblTitle��5      $��Login��6"   $
��Left=�62   $��
320,28,0,0q�6M   $	��Top=�6a   $��20(�6y   $��Italic$�6�   $��
ExtraBlack"�6�   �� 5   
   -   5        $
 errormessage��5      $�� ��6&   $
��Left=�61   $��
320,65,0,0q�6L   $	��Top=�6`   
���  ��$��
ExtraBlack"�6�   $��10(�6�   5         RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $	 newUser��5      .��6<   Users6C   �� 5      -	   5        .��5   2   
Advanced6<   �� 5       -
   5        $
	 exit��5       .��6=   Exit6C   5!      5#      