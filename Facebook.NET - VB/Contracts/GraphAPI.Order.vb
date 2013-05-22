Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Order
            ''' <summary>
            ''' Name: id
            ''' Description: id for the order
            ''' Permissions: app access_token
            ''' Return: name and id of the user
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As GraphApi.Domain
            ''' <summary>
            ''' Name: from
            ''' Description: userid associated with the order unless the user has uninstalled, in which case we return a third_party_id
            ''' Permissions: app access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As String
            ''' <summary>
            ''' Name: amount
            ''' Description: amount for the order
            ''' Permissions: app access_token
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="amount")>
            Public Property Amount() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: status
            ''' Description: status the order
            ''' Permissions: app access_token
            ''' Return: string - possible values are placed, settled, disputed, refunded, cancelled
            ''' </summary>
            <DataMember(Name:="status")>
            Public Property Status() As String
            ''' <summary>
            ''' Name: application
            ''' Description: application associated with the order
            ''' Permissions: app access_token
            ''' Return: name and id of the application
            ''' </summary>
            <DataMember(Name:="application")>
            Public Property Application() As GraphApi.Domain
            ''' <summary>
            ''' Name: country
            ''' Description: country associated with the order
            ''' Permissions: app access_token
            ''' Return: String containing ISO 3166 alpha 2 code representing the country
            ''' </summary>
            <DataMember(Name:="country")>
            Public Property Country() As String
            ''' <summary>
            ''' Name: refund_reason_code
            ''' Description: refund reason code if the order was refunded by Facebook
            ''' Permissions: app access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="refund_reason_code")>
            Public Property RefundReasonCode() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: time when the order was created
            ''' Permissions: app access_token
            ''' Return: string containing an ISO-8601 datetime
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: updated_time
            ''' Description: time when the order was last updated
            ''' Permissions: app access_token
            ''' Return: string containing an ISO-8601 datetime
            ''' </summary>
            <DataMember(Name:="updated_time")>
            Public Property UpdatedTime() As String
        End Class
    End Class
End Namespace
