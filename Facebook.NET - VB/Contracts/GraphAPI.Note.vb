Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Note
            Inherits MessageObject
            ''' <summary>
            ''' Name: subject
            ''' Description: The title of the note
            ''' Permissions: generic access_token or user_notes or friends_notes
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="subject")>
            Public Property Subject() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: The time the note was last updated
            ''' Permissions: generic access_token or user_notes or friends_notes
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: icon
            ''' Description: The icon that Facebook displays with notes
            ''' Permissions: generic access_token or user_notes or friends_notes
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="icon")>
            Public Property Icon() As String
        End Class
    End Class
End Namespace
