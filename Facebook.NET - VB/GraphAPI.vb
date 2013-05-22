Imports System
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.Serialization.Json

Namespace Facebook
	Public NotInheritable Partial Class GraphApi
        Private Const OAuthCodeUri As String = "https://www.facebook.com/dialog/oauth"
		Private Const AccessTokenUri As String = "https://graph.facebook.com/oauth/access_token"
		Private Const MeUri As String = "https://graph.facebook.com/me"
		Private Const GraphUri As String = "https://graph.facebook.com/"

		Private Shared ReadOnly uniqueID As Guid = Guid.NewGuid()

		Public Shared Function GetAccessTokenUri(appID As String, appSecret As String, authCode As String, redirectUri As String) As String
            Return String.Format("{0}?client_id={0}&redirect_uri={1}&client_secret={2}&code={3}",
                          AccessTokenUri,
                          appID,
                          redirectUri,
                          appSecret,
                          authCode
            )
		End Function

		Public Shared Function GetOAuthCodeUri(appID As String, redirectUri As String) As String
            Return String.Format("{0}?client_id={0}&redirect_uri={1}&state={2}",
                                 OAuthCodeUri,
                                 appID,
                                 redirectUri,
                                 uniqueID
            )
		End Function
		Friend Shared Function GetParameterizedString(name As String, ParamArray values As String()) As String
			Dim isNullOrEmpty As Boolean = values Is Nothing OrElse values.Count() = 0

            Return If(isNullOrEmpty = False,
                      String.Format("{0}={1}",
                                    name,
                                    values.Aggregate(Function(previous, current) String.Format("{0},{1}", previous, current))
                                    ), Nothing)
		End Function

		Friend Shared Function GetFormattedUri(uriBase As String, ParamArray parameters As String()) As String
			Dim builder As New UriBuilder(uriBase)
			If parameters IsNot Nothing Then
                builder.Query = parameters.Aggregate(Function(previous, current) If(String.IsNullOrEmpty(previous),
                                                                                    current,
                                                                                    If(String.IsNullOrEmpty(current),
                                                                                       previous,
                                                                                       String.Format("{0}&{1}", previous, current))))
			End If
			Return builder.ToString()
		End Function

		Friend Shared Function DeserializeResponse(Of T)(uri As String, Optional method As String = "GET") As T
			Dim result As T
			Dim request As WebRequest = HttpWebRequest.Create(uri)
			request.Method = method
			Using response As WebResponse = request.GetResponse()
				Using stream As Stream = response.GetResponseStream()
					Dim serializer As New DataContractJsonSerializer(GetType(T))
					result = DirectCast(serializer.ReadObject(stream), T)
					stream.Close()
				End Using
				response.Close()
			End Using

			Return result
		End Function
	End Class
End Namespace
