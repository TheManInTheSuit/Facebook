Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class PricePoint
            <DataMember(Name:="user_price")>
            Public Property UserPrice() As String
            <DataMember(Name:="user_price")>
            Public Property Credits() As System.Nullable(Of Double)
            <DataMember(Name:="user_price")>
            Public Property LocalCurrency() As String
        End Class
    End Class
End Namespace
