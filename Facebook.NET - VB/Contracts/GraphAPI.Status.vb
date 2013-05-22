Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Status
            ''' <summary>
            ''' Name: id
            ''' Description: The status message ID
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The user who posted the message
            ''' Permissions: Requires access_token
            ''' Return: object containing id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: message
            ''' Description: The status message content
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
            ''' <summary>
            ''' Name: place
            ''' Description: Location associated with a Status, if any
            ''' Permissions: Requires access_token
            ''' Return: object containing id and name of Page associated with this location, and a location field containing geographic information such as latitude, longitude, country, and other fields (fields will vary based on geography and availability of information)
            ''' </summary>
            <DataMember(Name:="place")>
            Public Property Place() As GraphApi.Venue
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The time the message was published
            ''' Permissions: Requires access_token
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: type
            ''' Description: The object type which is set to status
            ''' Permissions: Requires access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="type")>
            Public Property Type() As String
        End Class
    End Class
End Namespace
