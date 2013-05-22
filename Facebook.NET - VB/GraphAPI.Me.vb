Imports System
Imports System.Linq
Imports System.IO

Namespace Facebook
	Public NotInheritable Partial Class GraphApi
        Partial Public NotInheritable Class [Me]
            Inherits Api
            Friend Sub New(accessToken As String)
                MyBase.New(accessToken)
            End Sub

            Public Function [Get](ParamArray fields As String()) As GraphApi.User
                Dim formattedUri As String = GraphApi.GetFormattedUri(
                    MeUri,
                    GraphApi.GetParameterizedString("fields", fields),
                    GraphApi.GetParameterizedString("access_token", MyBase.AccessToken)
                )

                Dim result As GraphApi.User = GraphApi.DeserializeResponse(Of GraphApi.User)(formattedUri)

                Return result
            End Function

            ''' <summary>
            ''' Name: accounts
            ''' Description: The Facebook apps and pages owned by the current user.
            ''' Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            ''' Returns: array of objects containing account name, access_token, category, id
            ''' </summary>
            ''' <returns></returns>
            Public Function Accounts(limit As Integer, ParamArray fields As String()) As GraphApi.Account
                Dim formattedUri As String = GraphApi.GetFormattedUri(
                    Path.Combine(MeUri, "accounts"),
                    GraphApi.GetParameterizedString("access_token", MyBase.AccessToken),
                    GraphApi.GetParameterizedString("limit", limit.ToString()),
                    GraphApi.GetParameterizedString("fields", fields)
                )

                Dim result As GraphApi.Account = GraphApi.DeserializeResponse(Of GraphApi.Account)(formattedUri)

                Return result
            End Function

            ''' <summary>
            ''' Name: accounts
            ''' Description: The Facebook apps and pages owned by the current user.
            ''' Permissions: manage_pages yields access_tokens that can be used to query the Graph API on behalf of the app/page
            ''' Returns: array of objects containing account name, access_token, category, id
            ''' </summary>
            ''' <returns></returns>
            Public Function Accounts(ParamArray fields As String()) As GraphApi.Account
                Dim formattedUri As String = GraphApi.GetFormattedUri(Path.Combine(MeUri, "accounts"), GraphApi.GetParameterizedString("access_token", MyBase.AccessToken), GraphApi.GetParameterizedString("fields", fields))

                Dim result As GraphApi.Account = GraphApi.DeserializeResponse(Of GraphApi.Account)(formattedUri)

                Return result
            End Function
        End Class
	End Class
End Namespace
