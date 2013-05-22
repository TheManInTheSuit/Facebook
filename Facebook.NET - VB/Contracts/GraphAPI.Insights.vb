Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Insights
            ''' <summary>
            ''' Name: id
            ''' Description: ID of the insight
            ''' Permissions: generic access_token or read_insights
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: name
            ''' Description: Name of the metric
            ''' Permissions: generic access_token or read_insights
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: period
            ''' Description: Length of the period during which the insights were collected
            ''' Permissions: generic access_token or read_insights
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="period")>
            Public Property Period() As String
            ''' <summary>
            ''' Name: values
            ''' Description: Individual data points for the insight
            ''' Permissions: generic access_token or read_insights
            ''' Return: array of objects containing value and end_time
            ''' </summary>
            <DataMember(Name:="values")>
            Public Property Values() As GraphApi.Values()
            ''' <summary>
            ''' Name: description
            ''' Description: The full description of the metric
            ''' Permissions: generic access_token or read_insights
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
        End Class
    End Class
End Namespace