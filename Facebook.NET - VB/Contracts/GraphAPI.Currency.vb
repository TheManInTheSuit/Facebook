Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Currency
            <DataMember(Name:="user_currency")>
            Public Property UserCurrency() As String
            <DataMember(Name:="currency_exchange")>
            Public Property CurrencyExchange() As System.Nullable(Of Double)
            <DataMember(Name:="currency_exchange_inverse")>
            Public Property CurrencyExchangeInverse() As System.Nullable(Of Double)
            <DataMember(Name:="usd_exchange")>
            Public Property UsdExchange() As System.Nullable(Of Double)
            <DataMember(Name:="usd_exchange_inverse")>
            Public Property UsdExchangeInverse() As System.Nullable(Of Double)
            <DataMember(Name:="currency_offset")>
            Public Property CurrencyOffset() As System.Nullable(Of Double)
        End Class
    End Class
End Namespace
