   M S B A M L   `   `   `  ����>  :2.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_2._5_2._5  5   	       _2._5.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_2._5     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��700��6)   .��5	      � -   5        $��griiid��5	       � RowDefinitions 5
   
   �� 5      $
��0.8* �6   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��Date_sel��5   F   $��1��6   $��0��6%   $��5��62    $   MaterialDesignOutlinedDatePicker#��[  5         FirstDayOfWeek$ Monday=�6G      SelectedDateFormat$
 Long=�6_   6y   �� 5   
   -   5        $��0��5      $��0��6!     MaterialDesignRaisedButton#��[ 5        � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5!      $��Прошлый��5"      {�5#      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window6�   �� 5%   
   -   5        $
��Next��5%   .   $��6��6   $��0��6!   #��[ 5&      $/ )Resource name: MaterialDesignRaisedButton��5'      $��
Некст��5(      {�5)      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window6�    � 5+   
   -   5        $	��Dni��5+   R   $��0��6   $��1��6    $��7��6-   $��7��6A     � NavigationUIVisibility$ Hidden=�6]    � 5,   
   -   5        $
��Dels��5,   R   $��0��6   $��0��6    $��7��6-   $��7��6A   $ Hidden=�6^   5-      5.      