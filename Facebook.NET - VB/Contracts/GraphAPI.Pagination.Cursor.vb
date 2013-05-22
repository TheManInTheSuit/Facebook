Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        Partial Public NotInheritable Class Pagination
            <DataContract()>
            Public NotInheritable Class Cursor
                <DataMember(Name:="after")>
                Public Property After() As String
                <DataMember(Name:="before")>
                Public Property Before() As String
            End Class
        End Class
    End Class
End Namespace
