Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class VideoUploadLimit
            <DataMember(Name:="length")>
            Public Property Length() As System.Nullable(Of Double)
            <DataMember(Name:="size")>
            Public Property Size() As System.Nullable(Of Long)
        End Class
    End Class
End Namespace