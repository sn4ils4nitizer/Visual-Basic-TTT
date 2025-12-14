Imports System

Class GameController

   Private board As Board
   Private player1 As Player
   Private player2 As Player
   
   Public Sub New(p1 As Player, p2 As Player)
      player1 = p1
      player2 = p2
      board = New Board()
   End Sub

   Sub RunGame()
      
   End Sub
   
   Sub MakeMove(player As Player)
      Dim move = player.ChoseMove(board)
      Dim xPos = move.Item1
      Dim yPos = move.Item2
      board.MakeMove(player, xPos, yPos)
   End Sub 

   
End Class
