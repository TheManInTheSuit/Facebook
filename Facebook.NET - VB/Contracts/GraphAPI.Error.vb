Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class [Error]
            <DataMember(Name:="message")>
            Public Property Message() As String
            <DataMember(Name:="type")>
            Public Property Type() As String
            <DataMember(Name:="code")>
            Public Property Code() As String
            <DataMember(Name:="error_subcode")>
            Public Property ErrorSubcode() As String
        End Class
    End Class
End Namespace