Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Group
            ''' <summary>
            ''' Name: id
            ''' Description: The group ID
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: icon
            ''' Description: The URL for the group's icon
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
            ''' <summary>
            ''' Name: cover
            ''' Description: The URL for the group's cover photo
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: array containing a valid URL, cover_id and image offset
            ''' </summary>
            <DataMember(Name:="cover")>
            Public Property Cover() As GraphApi.Cover()
            ''' <summary>
            ''' Name: owner
            ''' Description: The profile that created this group
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: object containing the id and name fields
            ''' </summary>
            <DataMember(Name:="owner")>
            Public Property Owner() As GraphApi.Domain
            ''' <summary>
            ''' Name: name
            ''' Description: The name of the group
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: description
            ''' Description: A brief description of the group
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: link
            ''' Description: The URL for the group's website
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: privacy
            ''' Description: The privacy setting of the group
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string containing OPEN, CLOSED, or SECRET
            ''' </summary>
            <DataMember(Name:="privacy")>
            Public Property Privacy() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The last time the group was updated
            ''' Permissions: generic access_token, user_groups, or friends_groups
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
        End Class
    End Class
End Namespace