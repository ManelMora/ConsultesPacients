   M S B A M L   `   `   `  ����L  HConsultesPacients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ConsultesPacientsConsultesPacients  5   	   -    'ConsultesPacients.ModificarVisitaWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ConsultesPacients     5   	     � Title$  ModificarVisitaWindow��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5
   
   �� $��10q�6   .+�5      �� $��	Pacient: ��6   �� 5      -   5         ��Name$ 
txtPacient��5      ��6N   ��  �� Path$ Pacient� �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True�� �� ValidatesOnExceptions$
 True�� �� UpdateSourceTrigger$ PropertyChanged=��� 5      -   5         ��Name$ lblErrorPacient��5      
���  ��6-   �� 5      $��Data de la Visita: ��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtDataVisita��5      	   SelectedDate	 6T   �� $ 
DataVisita�$
 True��$
 True��$
 True��$ PropertyChanged=��� 5      -   5        $ lblErrorDataVisita��5      
���  ��60   �� 5      $��Motiu: ��6   �� 5      -   5        $ txtMotiu��5      ��6L   �� $ Motiu�$
 True��$
 True��$
 True��$ PropertyChanged=��� 5      -   5        $ lblErrorMotiu��5      
���  ��6+   �� 5       -   5        
 ��Name$
 btnAplicarCanvis��5       $��Aplicar Canvis��6/   6H   �� 5!      -   5        $��Cancelar��5!      $��22��6?   5"      5#      5$      