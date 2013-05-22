Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Photo
            ''' <summary>
            ''' Name: id
            ''' Description: The photo ID
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The profile (user or page) that posted this photo
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: object containing id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: tags
            ''' Description: The tagged users and their positions in this photo
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: array of objects, the x and y coordinates are percentages from the left and top edges of the photo, respectively
            ''' </summary>
            <DataMember(Name:="tags")>
            Public Property Tags() As Object()
            ''' <summary>
            ''' Name: name
            ''' Description: The user provided caption given to this photo - do not include advertising in this field
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: name_tags
            ''' Description: An array containing an array of objects mentioned in the name field which contain the id, name, and type of each object as well as the offset and length which can be used to match it up with its corresponding string in the name field
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="name_tags")>
            Public Property NameTags() As Object()()
            ''' <summary>
            ''' Name: icon
            ''' Description: The icon that Facebook displays when photos are published to the Feed
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string representing a valid URL
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
            ''' <summary>
            ''' Name: picture
            ''' Description: The thumbnail-sized source of the photo
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string representing a valid URL
            ''' </summary>
            <DataMember(Name:="picture")>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: source
            ''' Description: The source image of the photo - currently this can have a maximum width or height of 720px, increasing to 960px on 1st March 2012
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string representing a valid URL
            ''' </summary>
            <DataMember(Name:="source")>
            Public Property Source() As String
            ''' <summary>
            ''' Name: height
            ''' Description: The height of the photo in pixels
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="height")>
            Public Property Height() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: width
            ''' Description: The width of the photo in pixels
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="width")>
            Public Property Width() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: images
            ''' Description: The 4 different stored representations of the photo
            ''' Permissions: Requires access_token
            ''' Return: array of objects, containing height, width, and source fields
            ''' </summary>
            <DataMember(Name:="images")>
            Public Property Images() As Object()
            ''' <summary>
            ''' Name: link
            ''' Description: A link to the photo on Facebook
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string representing a valid URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: place 
            ''' Description: Location associated with a Photo, if any
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            ''' </summary>
            <DataMember(Name:="place")>
            Public Property Place() As GraphApi.Venue
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the photo was initially published
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The last time the photo or its caption was updated
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: position
            ''' Description: The position of this photo in the album
            ''' Permissions: generic access_token or user_photos or friends_photos
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="position")>
            Public Property Position() As System.Nullable(Of Double)
        End Class
    End Class
End Namespace
