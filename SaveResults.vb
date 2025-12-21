Imports System
Imports System.IO
Imports System.Xml.Serialization

Public Sub WinnerSerializer (player As Player, path As String)
   Dim serializer As New XmlSerializer(GetType(Winner))
   Dim winner As New Winner
   winner.winningPlayer = player.GetPlayerName
   winner.symbol = player.GetSymbol
   
   
End Sub

Class Winner
   Public Property winningPlayer As String
   Public Property symbol As String
End Class
