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

   Function RunGame() As Player
      board.DrawBoard()
      While True
         MakeMove(player1)
         Console.Clear()
         board.DrawBoard()
         If board.CheckWinner() = True Then
            Console.WriteLine(player1.GetPlayerName() + " has won!")
            Return player1
         End If
         If board.CheckDraw() = True Then
            Console.WriteLine("It is a draw!")
            Return Nothing
         End If

         MakeMove(player2)
         Console.Clear()
         board.DrawBoard()
         If board.CheckWinner() = True Then
            Console.WriteLine(player2.GetPlayerName() + " has won!")
            Return player2
         End If
         If board.CheckDraw() = True Then
            Console.WriteLine("It is a draw!")
            Return Nothing
         End If
         
      End While
   End Function
   
   Sub MakeMove(player As Player)
      Dim move = player.ChooseMove(board)
      Dim xPos = move.Item1
      Dim yPos = move.Item2
      board.MakeMove(player, xPos, yPos)
   End Sub 

   
End Class
