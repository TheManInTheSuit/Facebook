Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Venue
            <DataMember(Name:="id")>
            Public Property ID() As String
            <DataMember(Name:="street")>
            Public Property Street() As String
            <DataMember(Name:="city")>
            Public Property City() As String
            <DataMember(Name:="state")>
            Public Property State() As String
            <DataMember(Name:="zip")>
            Public Property Zip() As String
            <DataMember(Name:="country")>
            Public Property Country() As String
            <DataMember(Name:="latitude")>
            Public Property Latitude() As String
            <DataMember(Name:="longitude")>
            Public Property Longitude() As String
        End Class
    End Class
End Namespace