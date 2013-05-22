Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Album
            ''' <summary>
            ''' Name: id
            ''' Description: The album ID
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The profile that created this album
            ''' Permissions: Any valid access_token
            ''' Return: object containing id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: name
            ''' Description: The title of the album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: description
            ''' Description: The description of the album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>            
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: location
            ''' Description: The location of the album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="location")>
            Public Property Location() As String
            ''' <summary>
            ''' Name: link
            ''' Description: A link to this album on Facebook
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: cover_photo
            ''' Description: The album cover photo ID
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="cover_photo")>
            Public Property CoverPhoto() As String
            ''' <summary>
            ''' Name: privacy
            ''' Description: The privacy settings for the album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="privacy")>
            Public Property Privacy() As String
            ''' <summary>
            ''' Name: count
            ''' Description: The number of photos in this album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="count")>
            Public Property Count() As String
            ''' <summary>
            ''' Name: type
            ''' Description: The type of the album: profile, mobile, wall, normal or album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="type")>
            Public Property Type() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the photo album was initially created
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The last time the photo album was updated
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: can_upload
            ''' Description: Determines whether the UID can upload to the album and returns true if the user owns the album, the album is not full, and the app can add photos to the album
            ''' Permissions: Any valid access_token or user_photos or friend_photos
            ''' Return: boolean
            ''' </summary>
            <DataMember(Name:="can_upload")>
            Public Property CanUpload() As System.Nullable(Of Boolean)
        End Class
    End Class
End Namespace