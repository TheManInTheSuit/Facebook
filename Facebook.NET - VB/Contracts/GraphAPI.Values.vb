Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Values
            <DataMember(Name:="value")>
            Public Property Value() As String
            <DataMember(Name:="end_time")>
            Public Property EndTime() As String
        End Class
    End Class
End Namespace
