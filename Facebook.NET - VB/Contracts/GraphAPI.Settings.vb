Imports System
Imports System.Linq
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Settings
            <DataMember(Name:="enabled")>
            Public Property Enabled() As System.Nullable(Of Boolean)
        End Class
    End Class
End Namespace
