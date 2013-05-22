Imports System

Namespace Facebook
	Public Class Api
		Private ReadOnly mAccessToken As String
        Protected ReadOnly Property AccessToken() As String
            Get
                Return Me.mAccessToken
            End Get
        End Property

		Public Sub New(accessToken As String)
            Me.mAccessToken = accessToken
		End Sub
	End Class
End Namespace