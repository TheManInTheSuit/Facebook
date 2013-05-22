Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class QuestionObject
            ''' <summary>
            ''' Name: id
            ''' Description: Question ID
            ''' Permissions: user_questions or friends_questions
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: User who asked the question
            ''' Permissions: user_questions or friends_questions
            ''' Return: Object containing id and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Domain
            ''' <summary>
            ''' Name: question
            ''' Description: Text of the question
            ''' Permissions: user_questions or friends_questions
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="question")>
            Public Property Question() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: Time when question was created
            ''' Permissions: user_questions or friends_questions
            ''' Return: string containing ISO-8601 datetime
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: Time when question was last updated
            ''' Permissions: user_questions or friends_questions
            ''' Return: string containing ISO-8601 datetime
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
            ''' <summary>
            ''' Name: options
            ''' Description: The list of options available as answers to the question
            ''' Permissions: user_questions or friends_questions
            ''' Return: Object containing data[] array of options, as described in the options connection below
            ''' </summary>
            <DataMember(Name:="options")>
            Public Property Options() As Object()
        End Class
    End Class
End Namespace
