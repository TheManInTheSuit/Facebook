Imports System
Imports System.Collections.Generic
Imports System.Runtime.Serialization

Namespace Facebook
    Public NotInheritable Partial Class GraphApi
        <DataContract()>
        Public NotInheritable Class Page
            ''' <summary>
            ''' Name: id
            ''' Description: The Page's ID
            ''' Permissions: No access token or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: name
            ''' Description: The Page's name
            ''' Permissions: No access token or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: link
            ''' Description: Link to the page on Facebook
            ''' Permissions: No access token or user access_token
            ''' Return: string containing a valid URL
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: category_lists
            ''' Description: The Page's categories
            ''' Permissions: No access token or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="category_lists")>
            Public Property CategoryLists() As String
            ''' <summary>
            ''' Name: is_published
            ''' Description: Indicates whether the page is published and visible to non-admins
            ''' Permissions: No access token or user access_token
            ''' Return: boolean
            ''' </summary>
            <DataMember(Name:="is_published")>
            Public Property IsPublished() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: can_post
            ''' Description: Indicates whether the current session user can post on this Page
            ''' Permissions: No access token or user access_token
            ''' Return: boolean
            ''' </summary>
            <DataMember(Name:="can_post")>
            Public Property CanPost() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: likes
            ''' Description: The number of users who like the Page - For Global Brand Pages this is the count for all pages across the brand
            ''' Permissions: No access token or user access_token
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="likes")>
            Public Property Likes() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: location
            ''' Description: The Page's street address, latitude, and longitude (when available)
            ''' Permissions: No access token or user access_token
            ''' Return: dictionary
            ''' </summary>
            <DataMember(Name:="location")>
            Public Property Location() As GraphApi.Venue
            ''' <summary>
            ''' Name: phone
            ''' Description: The phone number (not always normalized for country code) for the Page
            ''' Permissions: No access token or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="phone")>
            Public Property Phone() As String
            ''' <summary>
            ''' Name: checkins
            ''' Description: The total number of users who have checked in to the Page
            ''' Permissions: No access token or user access_token
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="checkins")>
            Public Property Checkins() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: picture
            ''' Description: Link to the Page's profile picture
            ''' Permissions: No access token or user access_token
            ''' Return: string; If the "October 2012 Breaking Changes" migration setting is enabled for your app, this field will be an object with the url and is_silhouette fields; is_silhouette is true if the user has not uploaded a profile picture
            ''' </summary>
            <DataMember(Name:="picture")>
            Public Property Picture() As String
            ''' <summary>
            ''' Name: cover
            ''' Description: The JSON object including cover_id (the ID of the photo), source (the URL for the cover photo), and offset_y (the percentage offset from top [0-100])
            ''' Permissions: No access token or user access_token
            ''' Return: JSON object
            ''' </summary>
            <DataMember(Name:="cover")>
            Public Property Cover() As GraphApi.Cover
            ''' <summary>
            ''' Name: website
            ''' Description: Link to the external website for the page
            ''' Permissions: No access token or user access_token
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="website")>
            Public Property Website() As String
            ''' <summary>
            ''' Name: talking_about_count
            ''' Description: The number of people that are talking about this page (last seven days) - For Global Brand Pages this is the count for all pages across the brand
            ''' Permissions: No access token or user access_token
            ''' Return: number
            ''' </summary>
            <DataMember(Name:="talking_about_count")>
            Public Property TalkingAboutCount() As System.Nullable(Of Double)
            ''' <summary>
            ''' Name: global_brand_parent_page
            ''' Description: Id of this page and JSON Object with the name, category and id of the brand's parent page
            ''' Permissions: No access token or user access_token
            ''' Return: dictionary
            ''' </summary>
            <DataMember(Name:="global_brand_parent_page")>
            Public Property GlobalBrandParentPage() As Dictionary(Of String, String)
            ''' <summary>
            ''' Name: access_token
            ''' Description: A Page admin access_token for this page; The current user must be an administrator of this page; only returned if specifically requested via the fields URL parameter
            ''' Permissions: manage_pages
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="access_token")>
            Public Property AccessToken() As String
            ''' <summary>
            ''' Name: hours
            ''' Description: An updatable JSON object of the days when the business is open with keys like sat_1_open, sat_1_close, sat_2_open, sat_2_close and values like 08:00 and 17:00
            ''' Permissions: No access token or user access_token
            ''' Return: JSON object
            ''' </summary>
            <DataMember(Name:="hours")>
            Public Property Hours() As Dictionary(Of String, TimeSpan)
        End Class
    End Class
End Namespace
