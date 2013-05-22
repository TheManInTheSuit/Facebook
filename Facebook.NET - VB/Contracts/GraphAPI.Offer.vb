Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Offer
            ''' <summary>
            ''' Name: id
            ''' Description: The offer ID
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: from
            ''' Description: The ID, category, and name of the page that published the offer
            ''' Permissions: access_token
            ''' Return: object containing the id, category, and name fields
            ''' </summary>
            <DataMember(Name:="from")>
            Public Property From() As GraphApi.Page
            ''' <summary>
            ''' Name: title
            ''' Description: The title of the offer
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="title")>
            Public Property Title() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: The time the offer was created
            ''' Permissions: access_token
            ''' Return: string containing ISO-8601 date-time datetime
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As String
            ''' <summary>
            ''' Name: expiration_time
            ''' Description: The expiration time of the offer (for display purposes)
            ''' Permissions: access_token
            ''' Return: string containing ISO-8601 date-time datetime
            ''' </summary>
            <DataMember(Name:="expiration_time")>
            Public Property ExpirationTime() As String
            ''' <summary>
            ''' Name: terms
            ''' Description: The terms of the offer
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="terms")>
            Public Property Terms() As String
            ''' <summary>
            ''' Name: image_url
            ''' Description: The URL for the offer's image
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="image_url")>
            Public Property ImageUrl() As String
            ''' <summary>
            ''' Name: coupon_type
            ''' Description: The type of offer
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="coupon_type")>
            Public Property CouponType() As String
            ''' <summary>
            ''' Name: claim_limit
            ''' Description: The maximum number of times the offer can be claimed
            ''' Permissions: access_token
            ''' Return: integer
            ''' </summary>
            <DataMember(Name:="claim_limit")>
            Public Property ClaimLimit() As Integer
            ''' <summary>
            ''' Name: redemption_link
            ''' Description: The URL where the offer may be redeemed
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="redemption_link")>
            Public Property RedemptionLink() As String
            ''' <summary>
            ''' Name: redemption_code
            ''' Description: A code to to receive the discount or promotion
            ''' Permissions: access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="redemption_code")>
            Public Property RedemptionCode() As String
        End Class
    End Class
End Namespace
