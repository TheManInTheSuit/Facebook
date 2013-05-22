Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class PaymentPricePoint
            <DataMember(Name:="mobile")>
            Public Property Mobile() As GraphApi.PricePoint()
        End Class
    End Class
End Namespace
