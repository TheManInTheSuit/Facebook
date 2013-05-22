Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Domain
        Implements IObject
            <DataMember(Name:="id")>
            Public Property ID() As String Implements IObject.ID

            <DataMember(Name:="name")>
            Public Property Name() As String Implements IObject.Name
        End Class
    End Class
End Namespace
