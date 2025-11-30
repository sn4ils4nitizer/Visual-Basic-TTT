Imports System

Module Program
Sub Main(args As String())

   Dim gameBoard As New Board()
   Dim TestPlayer As New Player(False, "Fufacz", "X")
   Dim playerAI As New Player(True, "COMPUTER", "O")

   gameboard.DrawBoard()
   Dim index As Integer = 0
   Do
      Dim move1 = TestPlayer.ChooseMove(gameBoard)
      Dim xPos1 = move1.Item1
      Dim yPos1 = move1.Item2
      gameBoard.MakeMove(TestPlayer, xPos1, yPos1)
      gameBoard.DrawBoard()
      
      Dim move2 = playerAI.ChooseMove(gameBoard)
      Dim xPos2 = move2.Item1
      Dim yPos2 = move2.Item2
      gameBoard.MakeMove(playerAI, xPos2, yPos2)
      gameBoard.DrawBoard()


      index += 1
   
   Loop Until index = 3
   
   Console.Write("Program Terminated")
  End Sub
    
End Module
