Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class AchievementInstance
            ''' <summary>
            ''' Name: id
            ''' Description: id of the achievement(instance)
            ''' Permissions: app or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The user who achieved the achievement
            ''' Permissions: app or user access_token
            ''' Return: object containing the id and name of user
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: created_time
            ''' Description: Time at which the achievement was achieved
            ''' Permissions: app or user access_token
            ''' Return: string containing an ISO-8601 datetime
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: application
            ''' Description: The application in which the user achieved the achievement
            ''' Permissions: app or user access_token
            ''' Return: object containing id and name of application
            ''' </summary>
            <DataMember(Name:="application")>
            Public Property Application() As GraphApi.Domain
            ''' <summary>
            ''' Name: achievement
            ''' Description: The achievement object that the user achieved
            ''' Permissions: app or user access_token
            ''' Return: object containing the id, url, type, and title of the achievement
            ''' </summary>
            <DataMember(Name:="achievement")>
            Public Property Achievement() As GraphApi.Achievement
            ''' <summary>
            ''' Name: likes
            ''' Description: likes received by the story
            ''' Permissions: app or user access_token
            ''' Return: object containing the count of likes, as well as an array containing the name and id of users who like it
            ''' </summary>
            <DataMember(Name:="likes")>
            Public Property Likes() As GraphApi.Array(Of GraphApi.Domain)
            ''' <summary>
            ''' Name: comments
            ''' Description: Comments received by the achievement story
            ''' Permissions: app or user access_token
            ''' Return: object containing the count of comments, as well as an array containing id of the comment, from object containing the name and id of users who created the comment, message and created_time of the comment
            ''' </summary>
            <DataMember(Name:="comments")>
            Public Property Comments() As GraphApi.Array(Of GraphApi.MessageObject)
        End Class
    End Class
End Namespace
