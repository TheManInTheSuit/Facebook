Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Review
            ''' <summary>
            ''' Name: id
            ''' Description: The Facebook ID of the review
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The user that created the review
            ''' Permissions: No access_token required
            ''' Return: object containing the id and name of the creating user
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: to
            ''' Description: The application to which this review applies
            ''' Permissions: No access_token required
            ''' Return: object containing the id and name of the application
            ''' </summary>
            <DataMember(Name:="to")>
            Public Property [To]() As GraphApi.Domain
            ''' <summary>
            ''' Name: message
            ''' Description: The review text (optional)
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="message")>
            Public Property Message() As String
            ''' <summary>
            ''' Name: rating
            ''' Description: The review rating
            ''' Permissions: No access_token required
            ''' Return: int between 1 and 5
            ''' </summary>
            <DataMember(Name:="rating")>
            Public Property Rating() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: created_time
            ''' Description: The timedate the review was created
            ''' Permissions: No access_token required
            ''' Return: string containing ISO-8601 date-time
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
        End Class
    End Class
End Namespace
