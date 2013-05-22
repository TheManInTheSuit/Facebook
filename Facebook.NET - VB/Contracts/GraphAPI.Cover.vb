Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Cover
            <DataMember(Name:="cover_id")>
            Public Property ID() As String
            <DataMember(Name:="source")>
            Public Property Source() As String
            <DataMember(Name:="offset_x")>
            Public Property OffsetX() As System.Nullable(Of Double)
            <DataMember(Name:="offset_y")>
            Public Property OffsetY() As System.Nullable(Of Double)
        End Class
    End Class
End Namespace
