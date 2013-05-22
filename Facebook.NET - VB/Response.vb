Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        Private Sub New()
        End Sub
        
        <DataContract()>
        Public Class Response(Of T)
            <DataMember(Name:="error")>
            Public Property [Error]() As GraphApi.Error
            <DataMember(Name:="data")>
            Public Property Data() As T
        End Class
    End Class
End Namespace