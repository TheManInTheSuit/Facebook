Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class SecuritySettings
            <DataMember(Name:="secure_browsing")>
            Public Property SecureBrowsing() As Settings
        End Class
    End Class
End Namespace
