   M S B A M L   `   `   `  ����?  ;Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Demo.Views
Demo.Views  5          Demo.Views.MainView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Demo.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5        � Title$  MainView��5	      $
��1200��5
      $	��700��5      !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 TrueX�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��5      
��� ��� �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$
 tbox��5      $��70��5      $��30��5      $��10q�5      
���  ��$��3q�5      ��5      �� *MyText+�� 5       $��70��5!      $��30��5"      $��10q�5#      
����� �
���   ���5&      ��  �� ElementName$
 tbox�� �� Path$
 Text��� 5'      $��70��5(      $��30��5)      $��50,10,10,10q�5*      $��ViewA��5,      $��打开页面A��5-      ��5+      �� *OpenCommand+5-      �� 5.      $��70��5/      $��30��50      $��10q�51      $��ViewB��53      $��打开页面B��54      ��52      �� *OpenCommand+54      �� 55      $��70��56      $��30��57      $��10q�58      $��ViewC��5:      $��打开页面C��5;      ��59      �� *OpenCommand+5;      5<      �� 5=   
   $��1��6   !  Prism.Regions.RegionManager   
RegionName$ MainViewRegion��6&   5?      5@      