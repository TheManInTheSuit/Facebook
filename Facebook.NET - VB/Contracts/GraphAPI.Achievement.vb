Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Achievement
            <DataMember(Name:="id")>
            Public Property ID() As String
            <DataMember(Name:="url")>
            Public Property Url() As String
            <DataMember(Name:="type")>
            Public Property Type() As String
            <DataMember(Name:="title")>
            Public Property Title() As String
        End Class
    End Class
End Namespace