   M S B A M L   `   `   `  ????B  >WPFBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFBank.ViewsWPFBank.Views  5   	   7 clr-namespace:WPFBank.ViewModelsWPFBank.ViewModels  5   	        WPFBank.Views.CheckBalance   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFBank.Views     5   	   0vmm clr-namespace:WPFBank.ViewModels     5   	     ? Title$  CheckBalance??5	   	   $	??450??6   $	??800??6+    ? WindowState$ 	Maximized=?67    ? 	Resources 5
      &    WPFBank.ViewModels.BankViewModel   
bankvmObj2??%   &	          5   
   6   5      ??5      ?? 5   
    ?? 
StartPoint$	 0,1&?6    ?? EndPoint$	 1,1&?6/   .??5      ?  ? Offset$ 0Q?6    ? Color$ #bdc3c7??6&   ? 5      $ 1Q?6   $ #2c3e50??6&   5      .??5      ?  ? DataContext# [  6   .+?5   
   ?? -   5        $??	lblHeadng??5   -     lbl#??[ 6   $??Your Current Balance??6>   ?? 5   
   -   5        $	??lbl??5   -   #??[ 6   $??0,151,0,-71q?6W   ??68   ?? *
UI_Balance+6W   ?? 5   
   -   5        $??btnCheckBalance??5   Q   $??
Click Here??6   $??51??6&   $	??160??62   $??	0,272,0,0q?6>     btn1#??[ 6h   $	??Top=?6?   ??6?   ?? *CheckAmount+6?   5      5      