Imports System
Imports System.Runtime.Serialization

Namespace Facebook
    Partial Public NotInheritable Class GraphApi
        <DataContract()>
        Public NotInheritable Class Application
            ''' <summary>
            ''' Name: id
            ''' Description: The application ID
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="id")>
            Public Property ID() As String
            ''' <summary>
            ''' Name: name
            ''' Description: The title of the application
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="name")>
            Public Property Name() As String
            ''' <summary>
            ''' Name: description
            ''' Description: The description of the application written by the 3rd party developers
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="description")>
            Public Property Description() As String
            ''' <summary>
            ''' Name: category
            ''' Description: The category of the application
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="category")>
            Public Property Category() As String
            ''' <summary>
            ''' Name: company
            ''' Description: The company the application belongs to
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="company")>
            Public Property Company() As String
            ''' <summary>
            ''' Name: icon_url
            ''' Description: The URL of the application's icon
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="icon_url")>
            Public Property IconUrl() As String
            ''' <summary>
            ''' Name: subcategory
            ''' Description: The subcategory of the application
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="subcategory")>
            Public Property SubCategory() As String
            ''' <summary>
            ''' Name: link
            ''' Description: A link to the Application on Facebook
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="link")>
            Public Property Link() As String
            ''' <summary>
            ''' Name: logo_url
            ''' Description: The URL of the application's logo
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="logo_url")>
            Public Property LogoUrl() As String
            ''' <summary>
            ''' Name: daily_active_users
            ''' Description: The number of daily active users the application has
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="daily_active_users")>
            Public Property DailyActiveUsers() As String
            ''' <summary>
            ''' Name: daily_active_users_rank
            ''' Description: Ranking of this app vs other apps comparing daily active users
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="daily_active_users_rank")>
            Public Property DailyActiveUsersRank() As String
            ''' <summary>
            ''' Name: weekly_active_users
            ''' Description: The number of weekly active users the application has
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="weekly_active_users")>
            Public Property WeeklyActiveUsers() As String
            ''' <summary>
            ''' Name: monthly_active_users
            ''' Description: The number of monthly active users the application has
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="monthly_active_users")>
            Public Property MonthlyActiveUsers() As String
            ''' <summary>
            ''' Name: monthly_active_users
            ''' Description: Ranking of this app vs other apps comparing monthly active users
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="monthly_active_users_rank")>
            Public Property MonthlyActiveUsersRank() As String
            ''' <summary>
            ''' Name: migrations
            ''' Description: Migrations settings for app profile (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="migrations")>
            Public Property Migrations() As String()
            ''' <summary>
            ''' Name: namespace
            ''' Description: The namespace for the app (Editable via API)
            ''' Permissions: No access_token required
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="namespace")>
            Public Property [Namespace]() As String
            ''' <summary>
            ''' Name: restrictions
            ''' Description: Demographic restrictions set for this app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: Object with one or more of the following fields: type, location, age, and age_distr
            ''' </summary>
            <DataMember(Name:="restrictions")>
            Public Property Restrictions() As GraphApi.Application.Restriction
            ''' <summary>
            ''' Name: app_domains
            ''' Description: Domains and subdomains this app can use (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="app_domains")>
            Public Property AppDomains() As String()
            ''' <summary>
            ''' Name: auth_dialog_data_help_url
            ''' Description: The URL of a special landing page that helps users of an app begin publishing Open Graph activity (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="auth_dialog_data_help_url")>
            Public Property AuthDialogDataHelpUrl() As String
            ''' <summary>
            ''' Name: auth_dialog_headline
            ''' Description: One line description of an app that appears in the Auth Dialog (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="auth_dialog_headline")>
            Public Property AuthDialogHeadline() As String
            ''' <summary>
            ''' Name: auth_dialog_perms_explanation
            ''' Description: The text to explain why an app needs additional permissions that appears in the Auth Dialog (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="auth_dialog_perms_explanation")>
            Public Property AuthDialogPermissionsExplanation() As String
            ''' <summary>
            ''' Name: auth_referral_user_perms
            ''' Description: Basic user permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="auth_referral_user_perms")>
            Public Property AuthReferralUserPermissions() As String()
            ''' <summary>
            ''' Name: auth_referral_friend_perms
            ''' Description: Basic friends permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="auth_referral_friend_perms")>
            Public Property AuthReferralFriendPermissions() As String()
            ''' <summary>
            ''' Name: auth_referral_default_activity_privacy
            ''' Description: The default privacy setting selected for Open Graph activities in the Auth Dialog (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string which is one of: SELF, EVERYONE, ALL_FRIENDS or NONE
            ''' </summary>
            <DataMember(Name:="auth_referral_default_activity_privacy")>
            Public Property AuthReferralDefaultActivityPrivacy() As String
            ''' <summary>
            ''' Name: auth_referral_enabled
            ''' Description: Indicates whether Authenticated Referrals are enabled (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: bool
            ''' </summary>
            <DataMember(Name:="auth_referral_enabled")>
            Public Property AuthReferralEnabled() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: auth_referral_extended_perms
            ''' Description: Extended permissions that a user can choose to grant when Authenticated Referrals are enabled (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: array
            ''' </summary>
            <DataMember(Name:="auth_referral_extended_perms")>
            Public Property AuthReferralExtendedPermissions() As String()
            ''' <summary>
            ''' Name: auth_referral_response_type
            ''' Description: The format that an app receives the Auth token from the Auth Dialog in (Editable via API) 
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string which is one of: code or token
            ''' </summary>
            <DataMember(Name:="auth_referral_response_type")>
            Public Property AuthReferralResponseType() As String
            ''' <summary>
            ''' Name: canvas_fluid_height
            ''' Description: Indicates whether app uses fluid or settable height values for Canvas (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: bool
            ''' </summary>
            <DataMember(Name:="canvas_fluid_height")>
            Public Property CanvasFluidHeight() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: canvas_fluid_width
            ''' Description: Indicates whether app uses fluid or fixed width values for Canvas (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: bool
            ''' </summary>
            <DataMember(Name:="canvas_fluid_width")>
            Public Property CanvasFluidWidth() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: canvas_url
            ''' Description: The non-secure URL from which Canvas app content is loaded (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="canvas_url")>
            Public Property CanvasUrl() As String
            ''' <summary>
            ''' Name: contact_email
            ''' Description: Email address listed for users to contact developers (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="contact_email")>
            Public Property ContactEmail() As String
            ''' <summary>
            ''' Name: created_time
            ''' Description: Unix timestamp that indicates when the app was created
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: int
            ''' </summary>
            <DataMember(Name:="created_time")>
            Public Property CreatedTime() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: creator_uid
            ''' Description: User ID of the creator of this app
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: int
            ''' </summary>
            <DataMember(Name:="creator_uid")>
            Public Property CreatorUid() As System.Nullable(Of Integer)
            ''' <summary>
            ''' Name: deauth_callback_url
            ''' Description: URL that is pinged whenever a user removes the app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="deauth_callback_url")>
            Public Property DeAuthCallbackUrl() As String
            ''' <summary>
            ''' Name: iphone_app_store_id
            ''' Description: ID of the app in the iPhone App Store
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="iphone_app_store_id")>
            Public Property IPhoneAppStoreID() As String
            ''' <summary>
            ''' Name: hosting_url
            ''' Description: Webspace created with one of our hosting partners for this app
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="hosting_url")>
            Public Property HostingUrl() As String
            ''' <summary>
            ''' Name: mobile_web_url
            ''' Description: URL to which Mobile users will be directed when using the app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="mobile_web_url")>
            Public Property MobileWebUrl() As String
            ''' <summary>
            ''' Name: page_tab_default_name
            ''' Description: The title of the app when used in a Page Tab (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="page_tab_default_name")>
            Public Property PageTabDefaultName() As String
            ''' <summary>
            ''' Name: page_tab_url
            ''' Description: The non-secure URL from which Page Tab app content is loaded (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="page_tab_url")>
            Public Property PageTabUrl() As String
            ''' <summary>
            ''' Name: privacy_policy_url
            ''' Description: The URL that links to a Privacy Policy for the app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="privacy_policy_url")>
            Public Property PrivacyPolicyUrl() As String
            ''' <summary>
            ''' Name: secure_canvas_url
            ''' Description: The secure URL from which Canvas app content is loaded (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="secure_canvas_url")>
            Public Property SecureCanvasUrl() As String
            ''' <summary>
            ''' Name: secure_page_tab_url
            ''' Description: The secure URL from which Page Tab app content is loaded (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="secure_page_tab_url")>
            Public Property SecurePageTabUrl() As String
            ''' <summary>
            ''' Name: server_ip_whitelist
            ''' Description: App requests must originate from this comma-separated list of IP addresses (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="server_ip_whitelist")>
            Public Property ServerIPWhitelist() As String
            ''' <summary>
            ''' Name: social_discovery
            ''' Description: Indicates whether app usage stories show up in the Ticker or News Feed (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: bool
            ''' </summary>
            <DataMember(Name:="social_discovery")>
            Public Property SocialDiscovery() As System.Nullable(Of Boolean)
            ''' <summary>
            ''' Name: terms_of_service_url
            ''' Description: URL to Terms of Service which is linked to in Auth Dialog (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="terms_of_service_url")>
            Public Property TermsOfServiceUrl() As String
            ''' <summary>
            ''' Name: user_support_email
            ''' Description: Main contact email for this app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="user_support_email")>
            Public Property UserSupportEmail() As String
            ''' <summary>
            ''' Name: user_support_url
            ''' Description: URL of support for users of an app shown in Canvas footer (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="user_support_url")>
            Public Property UserSupportUrl() As String
            ''' <summary>
            ''' Name: website_url
            ''' Description: URL of a website that integrates with this app (Editable via API)
            ''' Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            ''' Return: string
            ''' </summary>
            <DataMember(Name:="website_url")>
            Public Property WebsiteUrl() As String
            
            <DataContract()>
            Public Class Restriction
                <DataMember(Name:="type")>
                Public Property Type() As String
                <DataMember(Name:="location")>
                Public Property Location() As String
                <DataMember(Name:="age")>
                Public Property Age() As String
                <DataMember(Name:="age_distr")>
                Public Property AgeDistribution() As String
            End Class
        End Class
    End Class
End Namespace