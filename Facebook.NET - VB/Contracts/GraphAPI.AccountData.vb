Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class AccountData
        Implements GraphApi.IObject
            <DataMember(Name:="id")>
            Public Property ID() As String Implements IObject.ID
            <DataMember(Name:="name")>
            Public Property Name() As String Implements IObject.Name
            <DataMember(Name:="category")>
            Public Property Category() As String
            <DataMember(Name:="access_token")>
            Public Property AccessToken() As String
            <DataMember(Name:="perms")>
            Public Property Permissions() As String()
        End Class
    End Class
End Namespace
