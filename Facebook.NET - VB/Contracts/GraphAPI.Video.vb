Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Video
            ''' <summary>
            ''' Name: id
            ''' Description: The video ID
            ''' Permissions: user_videos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The profile (user or page) that created the video
            ''' Permissions: user_videos
            ''' Return: object containing id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: tags
            ''' Description: The users who are tagged in this video
            ''' Permissions: user_videos
            ''' Return: array of objects containing id and name fields
            ''' </summary>
            <DataMember(Name:="tags")>
            Public Property Tags() As GraphApi.Domain()
            ''' <summary>
            ''' Name: name
            ''' Description: The video title or caption
            ''' Permissions: user_videos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: description
            ''' Description: The description of the video
            ''' Permissions: user_videos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: picture
            ''' Description: The URL for the thumbnail picture for the video
            ''' Permissions: user_videos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="picture")>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: embed_html
            ''' Description: The html element that may be embedded in an Web page to play the video
            ''' Permissions: user_videos
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="embed_html")>
            Public Property EmbedHtml() As String
            ''' <summary>
            ''' Name: icon
            ''' Description: The icon that Facebook displays when video are published to the Feed
            ''' Permissions: user_videos
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
            ''' <summary>
            ''' Name: source
            ''' Description: A URL to the raw, playable video file
            ''' Permissions: user_videos
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="source")>
            Public Property Source() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the video was initially published
            ''' Permissions: user_videos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The last time the video or its caption were updated
            ''' Permissions: user_videos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: comments
            ''' Description: All of the comments on this video
            ''' Permissions: user_videos
            ''' Return: array of objects containing id, from, message, created_time, and likes fields
            ''' </summary>
            <DataMember(Name:="comments")>
            Public Property Comments() As GraphApi.Comment()
        End Class
    End Class
End Namespace
