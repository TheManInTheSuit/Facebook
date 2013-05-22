Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Education
            <DataMember(Name:="school")>
            Public Property School() As Domain
            <DataMember(Name:="year")>
            Public Property Year() As Domain
            <DataMember(Name:="type")>
            Public Property Type() As String
            <DataMember(Name:="concentration")>
            Public Property Concentration() As GraphApi.Domain
        End Class
    End Class
End Namespace