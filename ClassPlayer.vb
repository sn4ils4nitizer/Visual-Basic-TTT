Imports System

Class Player
   Private Property isAI As Boolean
   Private Property playerName As String
   Private Property symbol As Char
   
   Public Sub New(AI As Boolean, pName As String, pSymbol As Char)
      isAI = AI
      playerName = pName
      symbol = pSymbol
   End Sub

   Public Function ChooseMove(board As Board)
      If isAI = True Then
         Return AImove(board)
         Console.Write(playerName + " selected a move." + Environment.NewLine)
      Else
         Return PlayerMove(board)
         Console.Write(playerName + " selected a move," + Environment.Newline)
      End If
   End Function
   
   Public Function PlayerMove(board As Board)
      Dim xPos As Integer
      Dim yPos As Integer
      Do
         Do
         Console.Write("Please enter an X coordinate (0-2):" + Environment.NewLine)
         Loop Until Integer.TryParse(Console.ReadLine(), xPos) AndAlso xPos >= 0 AndAlso xPos <= 2
         Do
         Console.Write("Please enter a Y coordinate (0-2):" + Environment.NewLine)
         Loop Until Integer.TryParse(Console.ReadLine(), yPos) AndAlso yPos >= 0 AndAlso yPos <= 2
      Loop While board.GetBoard(xPos, yPos) <> " "

      Return (xPos, yPos)
   End Function

   Public Function AIMove(board As Board)
      Dim xPos As Integer
      Dim yPos As Integer

      Randomize()
      Do
         xPos = CInt(Math.FLoor(Rnd() * 3))
         yPos = CInt(Math.Floor(Rnd() * 3))
      Loop While board.GetBoard(xPos, yPos) <> " "
      Return (xPos, yPos)
   End Function
   
   Public Function GetAI
      Return isAI
   End Function

   Public Function GetPlayerName
      Return playerName
   End Function

   Public Function GetSymbol
      Return symbol
   End Function

   Public Function CreateNewPlayer(playerName As String, playerSymbol As Char)
      If playerName = "[A-Za-z]+" AndAlso
      playerSymbol = "O" OR "X" Then
         Return New Player(False, playerName, Char)
      Else
         Return Nothing
      End If
   End Function
   
End Class
