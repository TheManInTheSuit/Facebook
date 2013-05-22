Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Array(Of T)
            <DataMember(Name:="count")>
            Public Property Count() As Integer
            <DataMember(Name:="items")>
            Public Property Items() As T()
        End Class
    End Class
End Namespace
