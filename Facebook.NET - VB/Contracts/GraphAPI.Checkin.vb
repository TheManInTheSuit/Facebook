Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Checkin
            ''' <summary>
            ''' Name: id
            ''' Description: The checkin ID
            ''' Permissions: user_checkins
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The ID and name of the user who made the checkin
            ''' Permissions: user_checkins
            ''' Return: object containing the id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: tags
            ''' Description: The users the author tagged in the checkin
            ''' Permissions: user_checkins
            ''' Return: array of objects containing the id and name fields
            ''' </summary>
            <DataMember(Name:="tags")>
            Public Property Tags() As GraphApi.Domain()
            ''' <summary>
            ''' Name: place
            ''' Description: Information about the Facebook Page that represents the location of the checkin
            ''' Permissions: user_checkins
            ''' Return: object containing the Page id, name, and location; location includes the specific latitude and longitude along with information about the postal addresses, if available
            ''' </summary>
            <DataMember(Name:="place")>
            Public Property Place() As Venue
            ''' <summary>
            ''' Name: application
            ''' Description: Information about the application that made the checkin
            ''' Permissions: user_checkins
            ''' Return: object that contains the name and id, canvas_name, and namespace of the application
            ''' </summary>
            <DataMember(Name:="application")>
            Public Property Application() As Application
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the checkin was created
            ''' Permissions: user_checkins
            ''' Return: string containing ISO-8601 date-time datetime
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: likes
            ''' Description: Users who like the checkin
            ''' Permissions: user_checkins
            ''' Return: array of objects containing id and name fields
            ''' </summary>
            <DataMember(Name:="likes")>
            Public Property Likes() As GraphApi.Domain()
            ''' <summary>
            ''' Name: message
            ''' Description: The message the user added to the checkin
            ''' Permissions: user_checkins
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
            ''' <summary>
            ''' Name: comments
            ''' Description: All of the comments on this link
            ''' Permissions: user_checkins
            ''' Return: Array of objects containing id, from, message and created_time fields
            ''' </summary>
            <DataMember(Name:="comments")>
            Public Property Comments() As GraphApi.MessageObject()
            ''' <summary>
            ''' Name: type
            ''' Description: The type of this object; always returns checkin
            ''' Permissions: user_checkins
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="type")>
            Public Property Type() As String
        End Class
    End Class
End Namespace
