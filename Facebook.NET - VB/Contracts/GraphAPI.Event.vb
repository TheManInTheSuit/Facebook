Imports System
Imports System.Linq
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Partial Public NotInheritable Class [Event]
            Implements GraphApi.IObject
            ''' <summary>
            ''' Name: id
            ''' Description: The event ID
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.ID)>
            Public Property ID() As String Implements IObject.ID

            ''' <summary>
            ''' Name: owner
            ''' Description: The profile that created the event
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: object containing id and name fields
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Owner)>
            Public Property Owner() As GraphApi.Domain
            ''' <summary>
            ''' Name: name
            ''' Description: The event title
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Name)>
            Public Property Name() As String Implements IObject.Name

            ''' <summary>
            ''' Name: description
            ''' Description: The long-form description of the event
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Description)>
            Public Property Description() As String
            ''' <summary>
            ''' Name: start_time
            ''' Description: The start time of the event, as you want it to be displayed on facebook
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.StartTime)>
            Public Property StartTime() As String
            ''' <summary>
            ''' Name: end_time
            ''' Description: The end time of the event, if one has been set
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.EndTime)>
            Public Property EndTime() As String
            ''' <summary>
            ''' Name: location
            ''' Description: The location for this event
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Location)>
            Public Property Location() As String
            ''' <summary>
            ''' Name: venue
            ''' Description: The location of this event
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: object containing one or more of the following fields: id, street, city, state, zip, country, latitude, and longitude fields
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Venue)>
            Public Property Venue() As GraphApi.Venue
            ''' <summary>
            ''' Name: privacy
            ''' Description: The visibility of this event
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string containing 'OPEN', 'SECRET', 'FRIENDS', or 'CLOSED' (deprecated)
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Privacy)>
            Public Property Privacy() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The last time the event was updated
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.UpdatedTime)>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: picture
            ''' Description: The URL of the event's picture (only returned if you explicitly include picture in the fields param; example: ?fields=id,name,picture)
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.Picture)>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: ticket_uri
            ''' Description: The URL to a location to buy tickets for this event (on Events for Pages only)
            ''' Permissions: generic access_token, user_events or friends_events
            ''' Returns: string
            ''' </summary>
            <DataMember(Name:=GraphApi.[Event].Fields.TicketUri)>
            Public Property TicketUri() As String
        End Class
    End Class
End Namespace