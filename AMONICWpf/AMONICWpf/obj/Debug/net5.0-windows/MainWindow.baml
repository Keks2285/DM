   M S B A M L   `   `   `  ????D  @AMONICWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AMONICWpf	AMONICWpf  5   	       AMONICWpf.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AMONICWpf     5   	     ? WindowState$  	Maximized=?5       ? Title$ Login??5   	   $	??450??6   $	??800??6'   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??180* ?6   6.   ?? 5      $
??250* ?6   6.   ?? 5      $
??250* ?6   6.   ?? 5      $
??180* ?6   6.    ? RowDefinitions 5   
   ?? 5      $
??140* ?6   6,   ?? 5      $	??33* ?6   6+   ?? 5      $	??33* ?6   6+   ?? 5      $	??33* ?6   6+   .+?5   
   ?? $	??Top=?6   $??3??6*   $#??/DS2017_TP09_2_colors_@2x.png??6>   $	??122??6e   ?? 5   
   $??1??6   $??	Username:??6   $??Right=?62   $??35??6N   $??	0,10,0,10q?6Z   ?? 5   
   $??2??6   $??	Password:??6   $??Right=?61   $??35??6M   $??	0,10,0,10q?6Y   ?? 5   
   -   5         ??Name$ Username??5      $??1??6$   $??1??61   $??35??6A   $??	0,10,0,10q?6M   $??2??6`   G? 5   
   -   5         G?Name$ Password??5      $??2??6(   $??1??65   $??35??6E   $??	0,10,0,10q?6Q   $??2??6d   ?? 5   
   -   5         ??Name$ LoginBtn??5      $??1??6#   $??Login??63   $	??100??6D   $??
20,5,20,20q?6U   $??3??6i   6v   ?? 5   
   -   5        $ ExitBtn??5      $??2??6"   $
??Exit??62   $	??100??6A   $??
20,5,20,20q?6Q   $??3??6e   6r   ?? 5   
   -   5         ??Name$ MessageLabel??5      $??3??6&   $??Label??66   $??3??6H   $??Center=?6U   5       5!      