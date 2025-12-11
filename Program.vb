Imports System

Module Program
Sub Main(args As String())

   Dim gameBoard As New Board()
   Dim TestPlayer As New Player(False, "Fufacz", "X")
   Dim playerAI As New Player(True, "COMPUTER", "O")
   ' Dim winCondition As Boolean = False
   
   gameboard.DrawBoard()
   Dim index As Integer = 0
   Do
      Dim move1 = TestPlayer.ChooseMove(gameBoard)
      Dim xPos1 = move1.Item1
      Dim yPos1 = move1.Item2
      gameBoard.MakeMove(TestPlayer, xPos1, yPos1)
      Console.Clear()
      gameBoard.DrawBoard()
      If gameBoard.CheckWinner() = True Then
         Console.WriteLine(TestPlayer.GetPlayerName() + " has won!")
         Exit Do
      End IF
      If gameBoard.CheckDraw() = True Then
         Console.WriteLine("It's a draw!")
         Exit Do
      End If
      
      Dim move2 = playerAI.ChooseMove(gameBoard)
      Dim xPos2 = move2.Item1
      Dim yPos2 = move2.Item2
      gameBoard.MakeMove(playerAI, xPos2, yPos2)
      Console.Clear()
      gameBoard.DrawBoard()

      If gameBoard.CheckWinner() = True Then
         Console.WriteLine(playerAi.GetPlayerName() + " has won!")
         Exit Do
      End If
      If gameBoard.CheckDraw() = True Then
         Console.WriteLine("It's a draw!")
         Exit Do
      End IF
      

      ' index += 1
   
   Loop Until index = 3
   
   Console.Write("Program Terminated")
  End Sub
    
End Module
