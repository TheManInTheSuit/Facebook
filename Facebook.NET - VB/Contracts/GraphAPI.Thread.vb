Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Thread
            ''' <summary>
            ''' Name: id
            ''' Description: The unique ID for this message thread
            ''' Permissions: read_mailbox
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: snippet
            ''' Description: Fragment of the thread for use in thread lists
            ''' Permissions: read_mailbox
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="snippet")>
            Public Property Snippet() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: Timestamp of when the thread was last updated
            ''' Permissions: read_mailbox
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: message_count
            ''' Description: Number of messages in the thread
            ''' Permissions: read_mailbox
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="message_count")>
            Public Property MessageCount() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: unread_count
            ''' Description: Number of unread messages in the thread
            ''' Permissions: read_mailbox
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="unread_count")>
            Public Property UnreadCount() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: tags
            ''' Description: Thread tags
            ''' Permissions: read_mailbox
            ''' Return: array of objects containing name
            ''' </summary>
            <DataMember(Name:="tags")>
            Public Property Tags() As Object()
            ''' <summary>
            ''' Name: participants
            ''' Description: List of the thread participants
            ''' Permissions: read_mailbox
            ''' Return: array of objects each containing name, email, and Facebook id (if available)
            ''' </summary>
            <DataMember(Name:="participants")>
            Public Property Participants() As Object()
            ''' <summary>
            ''' Name: former_participants
            ''' Description: List of former thread participants who have unsubscribed from the thread
            ''' Permissions: read_mailbox
            ''' Return: array of objects each containing name, email, and Facebook id (if available)
            ''' </summary>
            <DataMember(Name:="former_participants")>
            Public Property FormerParticipants() As Object()
            ''' <summary>
            ''' Name: senders
            ''' Description: List of participants who have sent a message in the thread
            ''' Permissions: read_mailbox
            ''' Return: array of objects each containing name, email, and Facebook id (if available)
            ''' </summary>
            <DataMember(Name:="senders")>
            Public Property Senders() As Object()
            ''' <summary>
            ''' Name: messages
            ''' Description: List of the message objects contained in this thread
            ''' Permissions: read_mailbox
            ''' Return: array of message objects
            ''' </summary>
            <DataMember(Name:="messages")>
            Public Property Messages() As GraphApi.MessageObject()
        End Class
    End Class
End Namespace
