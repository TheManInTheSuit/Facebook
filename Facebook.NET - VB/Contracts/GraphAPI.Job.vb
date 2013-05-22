Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Job
            <DataMember(Name:="employer")>
            Public Property Employer() As GraphApi.Domain
            <DataMember(Name:="position")>
            Public Property Position() As GraphApi.Domain
            <DataMember(Name:="description")>
            Public Property Description() As String
            <DataMember(Name:="start_date")>
            Public Property StartDate() As String
            <DataMember(Name:="end_date")>
            Public Property EndDate() As String
        End Class
    End Class
End Namespace