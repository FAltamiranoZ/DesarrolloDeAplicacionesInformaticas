   M S B A M L   `   `   `  ����R  NWpfApplication6-Sistema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApplication6_SistemaWpfApplication6_Sistema  5   	   %    WpfApplication6_Sistema.Almacen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WpfApplication6_Sistema     5   	     � Title$  Almacen��5   	   $��302.663��6   $��560.947��6*   .��5	      � .+�5
   
   �� $��Fecha de entrada:��6   $
��Left=�6,   $��	26,10,0,0q�6G   $	��Top=�6Z   �� 5   
   $��Fecha factura:��6   $
��Left=�6)   $��	293,9,0,0q�6D   $	��Top=�6W   �� 5   
   -   5         ��Name$ txtFechaFactura��5      $
��Left=�6+   $��23��6F   $��
381,12,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��Nombre del proveedor:��6   $
��Left=�60   $��	26,68,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ txtNombreProv��5      $
��Left=�6)   $��30��6D   $��	26,94,0,0q�6P   $
 Wrap=�6c   $	��Top=�6w   $	��241��6�   �� 5   
   $��	Articulo:��6   $
��Left=�6$   $��
26,142,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ 
cbArticulo��5      $
��Left=�6'   $��106,142,0,0q�6B   $	��Top=�6W   $	��120��6o   �� 5   
   $��	cantidad:��6   $
��Left=�6$   $��
26,173,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $ txtCant��5      $
��Left=�6#   $��23��6>   $��106,173,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��precio:��6   $
��Left=�6"   $��
26,204,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5        $ 	txtPrecio��5      $
��Left=�6%   $��23��6@   $��106,213,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $��Folio factura:��6   $
��Left=�6)   $��
293,40,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $ txtFolioFac��5      $
��Left=�6'   $��23��6B   $��
381,40,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5         ��Name$ 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��345,196,0,0q�6R   $	��Top=�6g   $��75��6   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dtEntrada��5      $
��Left=�6(   $��
135,12,0,0q�6C   $	��Top=�6W      DisplayDate$ 
2017-10-05��6o   �� 5   
   $��IdUser��6   $
��Left=�6!   $��
293,94,0,0q�6<   $	��Top=�6P   �� 5   
   -	   5        $ cbIdUser��5      $
��Left=�6%   $��
358,94,0,0q�6@   $	��Top=�6T   $	��120��6l    �� DisplayMemberPath$ idUser��6x   ��6�   �� �� 5   
   -
   5        $ 	btnAbrirV��5      $��Salida de Artículos��6$   $
��Left=�6B   $��326,236,0,0q�6]   $	��Top=�6r   $	��117��6�   6�   5      5      