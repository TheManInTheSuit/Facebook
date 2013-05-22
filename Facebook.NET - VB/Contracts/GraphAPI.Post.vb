Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Post
            ''' <summary>
            ''' Name: id
            ''' Description: The post ID
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: Information about the user who posted the message
            ''' Permissions: Requires access_token
            ''' Return: object containing the name and Facebook id of the user who posted the message
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: to
            ''' Description: Profiles mentioned or targeted in this post
            ''' Permissions: Requires access_token
            ''' Return: Contains in data an array of objects, each with the name and Facebook id of the user
            ''' </summary>
            <DataMember(Name:="to")>
            Public Property [To]() As GraphApi.Domain()
            ''' <summary>
            ''' Name: message
            ''' Description: The message
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
            ''' <summary>
            ''' Name: message_tags
            ''' Description: Objects tagged in the message (Users, Pages, etc)
            ''' Permissions: Requires access_token
            ''' Return: object containing fields whose names are the indexes to where objects are mentioned in the message field; each field in turn is an array containing an object with id, name, offset, and length fields, where length is the length, within the message field, of the object mentioned
            ''' </summary>
            <DataMember(Name:="message_tags")>
            Public Property MessageTags() As Object()
            ''' <summary>
            ''' Name: picture
            ''' Description: If available, a link to the picture included with this post
            ''' Permissions: Requires access_token
            ''' Return: link
            ''' </summary>
            <DataMember(Name:="picture")>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: link
            ''' Description: The link attached to this post
            ''' Permissions: Requires access_token
            ''' Return: string containing the URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: name
            ''' Description: The name of the link
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: caption
            ''' Description: The caption of the link (appears beneath the link name)
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="caption")>
            Public Property Caption() As String
            ''' <summary>
            ''' Name: description
            ''' Description: A description of the link (appears beneath the link caption)
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: source
            ''' Description: A URL to a Flash movie or video file to be embedded within the post
            ''' Permissions: Requires access_token
            ''' Return: string containing the URL
            ''' </summary>
            <DataMember(Name:="source")>
            Public Property Source() As String
            ''' <summary>
            ''' Name: properties
            ''' Description: A list of properties for an uploaded video, for example, the length of the video
            ''' Permissions: Requires access_token
            ''' Return: array of objects containing the name and text
            ''' </summary>
            <DataMember(Name:="properties")>
            Public Property Properties() As Object()
            ''' <summary>
            ''' Name: icon
            ''' Description: A link to an icon representing the type of this post
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
            ''' <summary>
            ''' Name: actions
            ''' Description: A list of available actions on the post (including commenting, liking, and an optional app-specified action)
            ''' Permissions: Requires access_token
            ''' Return: array of objects containing the name and link
            ''' </summary>
            <DataMember(Name:="actions")>
            Public Property Actions() As Object()
            ''' <summary>
            ''' Name: privacy
            ''' Description: The privacy settings of the Post
            ''' Permissions: read_stream
            ''' Return: A JSON object with fields described here
            ''' </summary>
            <DataMember(Name:="privacy")>
            Public Property Privacy() As Object
            ''' <summary>
            ''' Name: type
            ''' Description: A string indicating the type for this post (including link, photo, video)
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="type")>
            Public Property Type() As String
            ''' <summary>
            ''' Name: likes
            ''' Description: Likes for this post
            ''' Permissions: Requires access_token
            ''' Return: Structure containing a data object and the count of total likes, with data containing an array of objects, each with the name and Facebook id of the user who liked the post
            ''' </summary>
            <DataMember(Name:="likes")>
            Public Property Likes() As Object
            ''' <summary>
            ''' Name: place
            ''' Description: Location associated with a Post, if any
            ''' Permissions: read_stream
            ''' Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            ''' </summary>
            <DataMember(Name:="place")>
            Public Property Place() As GraphApi.Venue
            ''' <summary>
            ''' Name: story
            ''' Description: Text of stories not intentionally generated by users, such as those generated when two users become friends; you must have the "Include recent activity stories" migration enabled in your app to retrieve these stories
            ''' Permissions: read_stream
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="story")>
            Public Property Story() As String
            ''' <summary>
            ''' Name: story_tags
            ''' Description: Objects (Users, Pages, etc) tagged in a non-intentional story; you must have the "Include recent activity stories" migration enabled in your app to retrieve these tags
            ''' Permissions: read_stream
            ''' Return: object containing fields whose names are the indexes to where objects are mentioned in the message field; each field in turn is an array containing an object with id, name, offset, and length fields, where length is the length, within the message field, of the object mentioned
            ''' </summary>
            <DataMember(Name:="story_tags")>
            Public Property StoryTags() As Object
            ''' <summary>
            ''' Name: with_tags
            ''' Description: Objects (Users, Pages, etc) tagged as being with the publisher of the post ("Who are you with?" on Facebook)
            ''' Permissions: read_stream
            ''' Return: objects containing id and name fields, encapsulated in a data[] array
            ''' </summary>
            <DataMember(Name:="with_tags")>
            Public Property WithTags() As Object()
            ''' <summary>
            ''' Name: comments
            ''' Description: Comments for this post
            ''' Permissions: read_stream
            ''' Return: Structure containing a data object containing an array of objects, each with the id, from, message, and created_time for each comment
            ''' </summary>
            <DataMember(Name:="comments")>
            Public Property Comments() As Object
            ''' <summary>
            ''' Name: object_id
            ''' Description: The Facebook object id for an uploaded photo or video
            ''' Permissions: read_stream
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="object_id")>
            Public Property ObjectID() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: application
            ''' Description: Information about the application this post came from
            ''' Permissions: read_stream
            ''' Return: object containing the name and id of the application
            ''' </summary>
            <DataMember(Name:="application")>
            Public Property Application() As GraphApi.Domain
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the post was initially published
            ''' Permissions: read_stream
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The time of the last comment on this post
            ''' Permissions: read_stream
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: include_hidden
            ''' Description: Whether to include posts that have been set to Hidden from Timeline
            ''' Permissions: read_stream
            ''' Return: boolean
            ''' </summary>
            <DataMember(Name:="include_hidden")>
            Public Property IncludeHidden() As System.Nullable(Of Boolean)
        End Class
    End Class
End Namespace
