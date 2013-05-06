using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        [DataContract]
        public sealed partial class Event : GraphAPI.IObject
        {
            /// <summary>
            /// Name: id
            /// Description: The event ID
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.ID)]
            public string ID { get; set; }

            /// <summary>
            /// Name: owner
            /// Description: The profile that created the event
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: object containing id and name fields
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Owner)]
            public GraphAPI.Domain Owner { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The event title
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Name)]
            public string Name { get; set; }

            /// <summary>
            /// Name: description
            /// Description: The long-form description of the event
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Description)]
            public string Description { get; set; }

            /// <summary>
            /// Name: start_time
            /// Description: The start time of the event, as you want it to be displayed on facebook
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.StartTime)]
            public string StartTime { get; set; }

            /// <summary>
            /// Name: end_time
            /// Description: The end time of the event, if one has been set
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string containing an ISO-8601 formatted date/time (see 'Events Timezone Migration Note' above for details on returned formats)
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.EndTime)]
            public string EndTime { get; set; }

            /// <summary>
            /// Name: location
            /// Description: The location for this event
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Location)]
            public string Location { get; set; }

            /// <summary>
            /// Name: venue
            /// Description: The location of this event
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: object containing one or more of the following fields: id, street, city, state, zip, country, latitude, and longitude fields
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Venue)]
            public GraphAPI.Venue Venue { get; set; }

            /// <summary>
            /// Name: privacy
            /// Description: The visibility of this event
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string containing 'OPEN', 'SECRET', 'FRIENDS', or 'CLOSED' (deprecated)
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Privacy)]
            public string Privacy { get; set; }

            /// <summary>
            /// Name: updated_time
            /// Description: The last time the event was updated
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string containing ISO-8601 date-time
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.UpdatedTime)]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: picture
            /// Description: The URL of the event's picture (only returned if you explicitly include picture in the fields param; example: ?fields=id,name,picture)
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.Picture)]
            public string Picture { get; set; }

            /// <summary>
            /// Name: ticket_uri
            /// Description: The URL to a location to buy tickets for this event (on Events for Pages only)
            /// Permissions: generic access_token, user_events or friends_events
            /// Returns: string
            /// </summary>
            [DataMember(Name = GraphAPI.Event.Fields.TicketURI)]
            public string TicketURI { get; set; }
        }
    }
}
