   M S B A M L   `   `   `  ����B  >Tarneeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TarneebTarneeb  5           Tarneeb.InstructionsScreen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Tarneeb     5      .��5	      � -   5        $��	gridTable��5	   	   ��5      �� 5        �� ImageSource$  /Images/Table.jpg��6    j� Stretch$ UniformToFill=�69   .+�5   
   �� $��Hidden=�6   $	��950��6<   $	��550��6H   .��5      �� .+�5      �� -   5        $��	txtTitle0��5      $��35(�6+   $
��Wrap=�69   
�������$��Tarneeb Rules��6`    �� TextAlignment$ Center=�6u   $��0,0,0,0q�6�   6�   �� 5      -   5        $��	txtTitle1��5      $��25(�6-   $
��Wrap=�6;   
�������$��Players and Cards��6b   6}   �� 5      -   5        $��	txtRules1��5      $��20(�6-   $
��Wrap=�6;   
�������$����There are four players in fixed partnerships, partners facing each other. A standard international 52-card pack is used, the cards in each suit ranking from high to low: A-K-Q-J-10-9-8-7-6-5-4-3-2. The game is normally played counter-clockwise.��6b   $��0,0,0,10q�5   1   6E   �� 5      -   5        $��	txtTitle2��5      $��25(�6-   $
��Wrap=�6;   
�������$
��Deal��6b   6p   �� 5      -   5        $��	txtRules2��5      $��20(�6-   $
��Wrap=�6;   $��0,0,0,10q�6O   
�������$����The first dealer is chosen randomly. After each hand the turn to deal passes to the right.The cards are shuffled and cut, and are all dealt out, one at a time so that everyone has 13 cards.��6t   6;  �� 5      -   5        $��	txtTitle3��5      $��25(�6-   $
��Wrap=�6;   
�������$��Bidding��6b   6s   �� 5      -   5        $��	txtRules3��5      $��20(�6-   $
��Wrap=�6;   $��0,0,0,10q�6O   
�������$����Bidding starts with the player to the dealer's right and moves counterclockwise. The lowest bid is 7 and the highest is 13, and they represent the number of tricks that the bidder's team thinks they can take. Players can choose to match the current bid or choose to bid higher. All players must bid and are only allowed to bid once. The highest��6t   5   �   �� 5      -	   5        $��	txtTitle4��5      $��25(�6-   $
��Wrap=�6;   
�������$��Gameplay��6b   6t   �� 5      -
   5        $��	txtRules4��5      $��20(�6-   $
��Wrap=�6;   $��0,0,0,10q�6O   
�������$����The player who won the bidding (the highest bid or the last player to match the highest bid) leads to the first trick, and thereafter the winner of each trick leads to the next. Tarneeb is played counterclockwise. Players must follow suit if able to. Those unable to follow suit may play any card. Each trick is won by the highest trump in it, or by the highest card of the suit led if it contains no trumps.��6t   5   s   �� 5      -   5        $��	txtTitle5��5      $��25(�6-   $
��Wrap=�6;   
�������$��Scoring��6b   6s   �� 5      -   5        $��	txtRules5��5      $��20(�6-   $
��Wrap=�6;   $��0,0,0,10q�6O   
�������$����The bidder's team tries to take as many tricks as they can or at least as many tricks as they bid. If their bid is less than 13 and succeed, they score the number of tricks they won, and the other team scores nothing. If the bidding team takes fewer tricks than they bid, they lose the amount of their bid. Winning all 13 tricks is called Kaboot. Kaboot brings a bonus of 3 points, so 16 points in total instead of 13. If they lose any tricks, they score minus 16 and the other team scores double the number the tricks that they win. Further hands are played until one team achieves a cumulative score of 31 points or more, and wins the game.��6t   5"   q   �� 5#      -   5        $��btnBack��5#      $
��Back��6&   $	��150��65   $��60��6A   $��0,0,0,0q�6M   
���   �
�������$��20(�6�    � ToolTip$ Back to Home��6�    � 	Resources 5$       �� 
TargetType �� Property �� Value��%_   '��       �� 5%      " ��6   .�5&      ��  �@��CornerRadius$ 15��65   5'      5(      5)      �� 5*      -   5        $��btnStartGame��5*      $��
Start Game��6+   $	��150��6@   $��60��6L   $��0,20,0,0q�6X   
���   �
�������$��20(�6�   $ Play against AI��6�    5+      ��%_   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 15��65   5.      5/      50      51      52      53      54      