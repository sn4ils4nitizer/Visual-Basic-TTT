Imports System
Imports System.Text.RegularExpressions

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

   Public Shared Function GenerateNewPlayer(playerSymbol As Char) As Player
   Console.WriteLine("Please enter player Name:")
   While True
   Dim playerName = Console.ReadLine().Trim()
      If Not Regex.IsMatch(playerName, "^[A-Za-z]+$") Then
         Console.WriteLine("Please enter a valid name. The name can only consists of alpha characters.")
      Else
         Return New Player(playerName, playerSymbol)
      End If
      End While
End Function
   
   Public Shared Function CreateNewPlayer(playerSymbol As Char) As Player
   Console.WriteLine("Please enter player name:")
   Dim playerName = Console.ReadLine()
   playerName = playerName.Trim()
   If Regex.IsMatch(playerName, "^[A-Za-z]+$") AndAlso
      playerSymbol = "O" OrElse playerSymbol = "X" Then
         Return New Player(False, playerName, playerSymbol)
Else
   Console.WriteLine("Please enter a valid name. The name may contain only alpha characters.")
   Return CreateNewPlayer(playerSymbol)
         ' Return Nothing
      End If
   End Function
   
End Class
