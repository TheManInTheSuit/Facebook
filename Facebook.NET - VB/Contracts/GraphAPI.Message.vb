Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public Class MessageObject
            ''' <summary>
            ''' Name: id
            ''' Description: The unique ID for this message
            ''' Permissions: read_mailbox
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: A timestamp of when this message was created
            ''' Permissions: read_mailbox
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: from
            ''' Description: 
            ''' Permissions: read_mailbox
            ''' Return: Object containing name and Facebook id (if available)
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: to
            ''' Description: A list of the message recipients
            ''' Permissions: read_mailbox
            ''' Return: Array of objects each containing name and Facebook id (if available)
            ''' </summary>
            <DataMember(Name:="to")>
            Public Property [To]() As GraphApi.Domain()
            ''' <summary>
            ''' Name: message
            ''' Description: The text of the message
            ''' Permissions: read_mailbox
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
        End Class
    End Class
End Namespace
