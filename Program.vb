Imports System
Imports System.Text.RegularExpressions

Module Program
Sub Main(args As String())

   ' Dim gameBoard As New Board()
   ' Dim TestPlayer As New Player(False, "Fufacz", "X")
   ' Dim playerAI As New Player(True, "COMPUTER", "O")
   ' Dim winCondition As Boolean = False
   
   ' gameboard.DrawBoard()
   ' Dim index As Integer = 0
   ' Do
      ' Dim move1 = TestPlayer.ChooseMove(gameBoard)
      ' Dim xPos1 = move1.Item1
      ' Dim yPos1 = move1.Item2
      ' gameBoard.MakeMove(TestPlayer, xPos1, yPos1)
      ' Console.Clear()
      ' gameBoard.DrawBoard()
      ' If gameBoard.CheckWinner() = True Then
         ' Console.WriteLine(TestPlayer.GetPlayerName() + " has won!")
         ' Exit Do
      ' End IF
      ' If gameBoard.CheckDraw() = True Then
         ' Console.WriteLine("It's a draw!")
         ' Exit Do
      ' End If
      
      ' Dim move2 = playerAI.ChooseMove(gameBoard)
      ' Dim xPos2 = move2.Item1
      ' Dim yPos2 = move2.Item2
      ' gameBoard.MakeMove(playerAI, xPos2, yPos2)
      ' Console.Clear()
      ' gameBoard.DrawBoard()

      ' If gameBoard.CheckWinner() = True Then
         ' Console.WriteLine(playerAi.GetPlayerName() + " has won!")
         ' Exit Do
      ' End If
      ' If gameBoard.CheckDraw() = True Then
        ' Console.WriteLine("It's a draw!")
         ' Exit Do
      ' End IF
   ' index += 1
   
   ' Loop Until index = 3
   Dim player1 As Player
   Dim player2 As Player
   Dim playerChoice As String
   Dim newGame As Boolean = True

   Console.WriteLine("Welcome to Tic Tac Toe game.")
   Console.WriteLine("Would you like to play against another player? (y/n)")
      While True
         playerChoice = Console.ReadLine().Trim()
         If Not Regex.IsMatch(playerChoice, "^[YNyn]$") Then
            Console.WriteLine("Please enter y for ""yes"" or n for ""no""")
         End If
         If playerChoice = "Y" OrElse playerChoice = "y" Then
            player1 = Player.GenerateNewPlayer("X")
            player2 = Player.GenerateNewPlayer("O")
            Exit While
         End If
         If playerChoice = "N" OrElse playerChoice = "n" Then
            player1 = Player.GenerateNewPlayer("X")
            player2 = New Player(True, "Computer", "O")
            Exit While
         End If
         End While
   
         ' Dim player1 = Player.GenerateNewPlayer("X")
         ' Dim player2 As New Player(True, "Computer", "O")
         While newGame = True
         Dim game As New GameController(player1, player2)
         game.RunGame()
         Console.WriteLine("Would you like to play another game?")
         While True
            playerChoice = Console.ReadLine().Trim()
            If Not Regex.IsMatch(playerChoice, "^[YNyn]$") Then
               Console.WriteLine("Please enter y for ""yes"" or n for ""no""")
            End If
            If playerChoice = "Y" OrElse playerChoice = "y" Then
               newGame = True
               Exit While
            End If
            If playerChoice = "N" OrElse playerChoice = "n" Then
               newGame = False
               Exit While
            End If
            End While
            End While
            
            Console.Write("Program Terminated")
End Sub

End Module
