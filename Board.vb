Imports System

Class Board
	Private Dim board(2,2) As Char
	
	Public Sub New()
		For i As Integer = 0 To 2
			For j As Integer = 0 To 2
				board(i,j) = " "
			Next
		Next
	End Sub
	
	Sub DrawBoard
		Console.WriteLine("+---+---+---+")
		For i as Integer = 0 To 2
			For j as Integer = 0 To 2
			Console.Write("| " + board(i,j)+ " ")
			Next
			Console.WriteLine("|")
			Console.WriteLine("+---+---+---+")
		Next
	End Sub

   Public Sub MakeMove(player As Player, xpos As Integer, ypos As Integer)
      board(xpos, ypos) = player.GetSymbol
      Console.Write(player.GetPlayerName() + " made a move." + Environment.NewLine)
   End Sub

   Public Function CheckWinner() As Boolean

      ' Horizontal win conditons check
      For i As Integer = 0 To 2
         If board(0, i) <> " " AndAlso
         board(0, i) = board(1, i) AndAlso
         board(1, i) = board(2, i) Then
         Console.WriteLine("DEBUG: There is a winner - vertical")
            Return True
         End If
      Next

      ' Vertical win conditions check
      For i As Integer = 0 To 2
         If board(i, 0) <> " " AndAlso
         board(i, 0) = board(i, 1) AndAlso
         board(i, 1) = board(i, 2) Then
         Console.WriteLine("DEBUG: There is a winner - horizontal")
            Return True 
         End If
      Next

      ' Diagonal win conditions checks
      If board(0, 0) <> " "  AndAlso
      board(0, 0) = board(1, 1) AndAlso
      board(1, 1) = board(2, 2) Then
      Console.WriteLine("DEBUG: There is a winner - diagonal 0 - 2")
         Return True
      End If
      If board(0,2) <> " " AndAlso
      board(0,2) = board(1, 1) AndAlso
      board(1, 1) = board(2, 0) Then
      Console.WriteLine("DEBUG: There is a winner - diagonal 2 to 0")
         Return True
      End If
      
      Return False
   End Function

   Public Function CheckDraw() As Boolean
      For i As Integer = 0 To 2
         For j As Integer = 0 To 2
            If board(i, j) =" "
            Console.WriteLine("DEBUG: There is no draw")
            Return False
            End If
         Next
      Next
      Console.WriteLine("DEBUG: There is a draw")
      Return True
   End Function
    
   Private Sub SetBoard(choice as Char, xpos As Integer, ypos As Integer)
      board(xpos, ypos) = choice 
   End Sub
	
   Function GetBoard(xpos As Integer, ypos as Integer)
      Return board(xpos, ypos)
   End Function
	
End Class
