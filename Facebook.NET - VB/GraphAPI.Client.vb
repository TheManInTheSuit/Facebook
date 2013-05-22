Imports System
Imports System.IO

Namespace Facebook
	Public NotInheritable Partial Class GraphApi
        Partial Public NotInheritable Class Client
            Inherits Api
            Private mUser As GraphApi.User = Nothing
            Private ReadOnly Property User() As GraphApi.User
                Get
                    Return If(mUser, (InlineAssignHelper(mUser, [Me].[Get]())))
                End Get
            End Property

            Private mMe As [Me] = Nothing
            Public ReadOnly Property [Me]() As [Me]
                Get
                    Return If(mMe, (InlineAssignHelper(mMe, New [Me](MyBase.AccessToken))))
                End Get
            End Property

            Public Sub New(accessToken As String)
                MyBase.New(accessToken)
            End Sub

            Public Function [Get](Of T)(id As String, ParamArray fields As String()) As T
                Dim formattedUri As String = GraphApi.GetFormattedUri(Path.Combine(GraphUri, id), GraphApi.GetParameterizedString("fields", fields), GraphApi.GetParameterizedString("access_token", MyBase.AccessToken))
                Dim result As T = GraphApi.DeserializeResponse(Of T)(formattedUri)

                Return result
            End Function

            Public Function CreateEvent(name As String, startTime As String, Optional endTime As String = Nothing, Optional description As String = Nothing, Optional location As String = Nothing, Optional locationID As String = Nothing, Optional privacyType As String = Nothing) As GraphApi.Event
                Dim formattedUri As String = GraphApi.GetFormattedUri(
                    Path.Combine(GraphUri, User.ID, "events"),
                    ParameterizeIfNotNull("name", name),
                    ParameterizeIfNotNull("start_time", startTime),
                    ParameterizeIfNotNull("end_time", endTime),
                    ParameterizeIfNotNull("description", description),
                    ParameterizeIfNotNull("location", location),
                    ParameterizeIfNotNull("location_id", locationID),
                    ParameterizeIfNotNull("privacy_type", privacyType),
                    ParameterizeIfNotNull("access_token", MyBase.AccessToken)
                )

                Dim result As GraphApi.Event = GraphApi.DeserializeResponse(Of GraphApi.Event)(formattedUri, "POST")
                result.Name = name
                result.StartTime = startTime
                result.EndTime = endTime
                result.Description = description
                result.Location = location
                result.Privacy = privacyType

                Return result
            End Function

            Public Function ParameterizeIfNotNull(name As String, value As String) As String
                Return If(String.IsNullOrEmpty(value), String.Empty, GraphApi.GetParameterizedString(name, value))
            End Function

            Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
	End Class
End Namespace