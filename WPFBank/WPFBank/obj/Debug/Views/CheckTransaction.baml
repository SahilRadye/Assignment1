   M S B A M L   `   `   `  ????B  >WPFBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFBank.ViewsWPFBank.Views  5   	   7 clr-namespace:WPFBank.ViewModelsWPFBank.ViewModels  5   	   $    WPFBank.Views.CheckTransaction   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFBank.Views     5   	   /vm clr-namespace:WPFBank.ViewModels     5   	     ? Title$  CheckTransaction??5	   	   $	??450??6"   $	??800??6/    ? WindowState$ 	Maximized=?6;    ? 	Resources 5
      &    WPFBank.ViewModels.BankViewModel   bankObj??%   &	          5   
   6   5      ??5      ?? 5   
    ?? 
StartPoint$	 0,1&?6    ?? EndPoint$	 1,1&?6/   .??5      ?  ? Offset$ 0Q?6    ? Color$ #bdc3c7??6&   ? 5      $ 1Q?6   $ #2c3e50??6&   5      .??5      ?  ? DataContext# [  6    ? ColumnDefinitions 5   
   ?? 5      $
??103* ?6   ?? 5      $	??97* ?6   .+?5   
   ?? -   5        $??	lblHeadng??5   -     lbl#??[ 6   $??Your Transaction??6>   $??2??6Y   $
??Left=?6m   $??274,40,0,40q?6?   ?? 5   
   -   5        $??btnCheckBalance??5   b   $ ??Click Here For Transaction??6   $??34??66   $	??223??6B   $??
286,91,0,0q?6N     btn1#??[ 6y   $	??Top=?6?   $??2??6?   $
??Left=?6?   ??6?   ?? *	Statement+6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??dataGrid??5      	   AutoGenerateColumns	 . $??50,144,51,21q?6?   $??2??6?   ??6@   ?? *TransactionList+
 ?? UpdateSourceTrigger$
 PropertyChanged=?6?   5      5      