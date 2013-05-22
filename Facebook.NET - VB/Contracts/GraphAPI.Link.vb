Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class LinkObject
            ''' <summary>
            ''' Name: id
            ''' Description: The link ID
            ''' Permissions: generic access_token or read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The user that created the link
            ''' Permissions: generic access_token or read_stream
            ''' Return: Object containing the id and name field
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: link
            ''' Description: The URL that was shared
            ''' Permissions: generic access_token or read_stream
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: name
            ''' Description: The name of the link
            ''' Permissions: generic access_token or read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: comments
            ''' Description: All of the comments on this link
            ''' Permissions: read_stream
            ''' Return: Array of objects containing id, from, message and created_time fields
            ''' </summary>
            <DataMember(Name:="comments")>
            Public Property Comments() As GraphApi.Comment()
            ''' <summary>
            ''' Name: description
            ''' Description: A description of the link (appears beneath the link caption)
            ''' Permissions: generic access_token or read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: icon
            ''' Description: A URL to the link icon that Facebook displays in the news feed
            ''' Permissions: generic access_token or read_stream
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
            ''' <summary>
            ''' Name: picture
            ''' Description: A URL to the thumbnail image used in the link post
            ''' Permissions: generic access_token or read_stream
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="picture")>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: message
            ''' Description: The optional message from the user about this link
            ''' Permissions: generic access_token or read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the message was published
            ''' Permissions: generic access_token or read_stream
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: type
            ''' Description: The type of this object; always returns link
            ''' Permissions: generic access_token or read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="type")>
            Public Property Type() As String
        End Class
    End Class
End Namespace