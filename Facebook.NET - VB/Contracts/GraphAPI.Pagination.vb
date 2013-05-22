Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Partial Public NotInheritable Class Pagination
            <DataMember(Name:="cursors")>
            Public Property Cursors() As GraphApi.Pagination.Cursor
            <DataMember(Name:="next")>
            Public Property Previous() As String
            <DataMember(Name:="next")>
            Public Property [Next]() As String
        End Class
    End Class
End Namespace
