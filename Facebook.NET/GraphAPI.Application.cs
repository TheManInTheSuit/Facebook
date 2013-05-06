using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphAPI
    {
        public sealed class Application
        {
            /// <summary>
            /// Name: id
            /// Description: The application ID
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The title of the application
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: description
            /// Description: The description of the application written by the 3rd party developers
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Name: category
            /// Description: The category of the application
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "category")]
            public string Category { get; set; }

            /// <summary>
            /// Name: company
            /// Description: The company the application belongs to
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "company")]
            public string Company { get; set; }

            /// <summary>
            /// Name: icon_url
            /// Description: The URL of the application's icon
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "icon_url")]
            public string IconUrl { get; set; }

            /// <summary>
            /// Name: subcategory
            /// Description: The subcategory of the application
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "subcategory")]
            public string SubCategory { get; set; }

            /// <summary>
            /// Name: link
            /// Description: A link to the Application on Facebook
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: logo_url
            /// Description: The URL of the application's logo
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "logo_url")]
            public string LogoUrl { get; set; }

            /// <summary>
            /// Name: daily_active_users
            /// Description: The number of daily active users the application has
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "daily_active_users")]
            public string DailyActiveUsers { get; set; }

            /// <summary>
            /// Name: daily_active_users_rank
            /// Description: Ranking of this app vs other apps comparing daily active users
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "daily_active_users_rank")]
            public string DailyActiveUsersRank { get; set; }

            /// <summary>
            /// Name: weekly_active_users
            /// Description: The number of weekly active users the application has
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "weekly_active_users")]
            public string WeeklyActiveUsers { get; set; }

            /// <summary>
            /// Name: monthly_active_users
            /// Description: The number of monthly active users the application has
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "monthly_active_users")]
            public string MonthlyActiveUsers { get; set; }

            /// <summary>
            /// Name: monthly_active_users
            /// Description: Ranking of this app vs other apps comparing monthly active users
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "monthly_active_users_rank")]
            public string MonthlyActiveUsersRank { get; set; }

            /// <summary>
            /// Name: migrations
            /// Description: Migrations settings for app profile (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: array
            /// </summary>
            [DataMember(Name = "migrations")]
            public string[] Migrations { get; set; }

            /// <summary>
            /// Name: namespace
            /// Description: The namespace for the app (Editable via API)
            /// Permissions: No access_token required
            /// Return: string
            /// </summary>
            [DataMember(Name = "namespace")]
            public string Namespace { get; set; }

            /// <summary>
            /// Name: restrictions
            /// Description: Demographic restrictions set for this app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: Object with one or more of the following fields: type, location, age, and age_distr
            /// </summary>
            [DataMember(Name = "restrictions")]
            public GraphAPI.Application.Restriction Restrictions { get; set; }

            /// <summary>
            /// Name: app_domains
            /// Description: Domains and subdomains this app can use (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: array
            /// </summary>
            [DataMember(Name = "app_domains")]
            public string[] AppDomains { get; set; }

            /// <summary>
            /// Name: auth_dialog_data_help_url
            /// Description: The URL of a special landing page that helps users of an app begin publishing Open Graph activity (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "auth_dialog_data_help_url")]
            public string AuthDialogDataHelpUrl { get; set; }

            /// <summary>
            /// Name: auth_dialog_headline
            /// Description: One line description of an app that appears in the Auth Dialog (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "auth_dialog_headline")]
            public string AuthDialogHeadline { get; set; }

            /// <summary>
            /// Name: auth_dialog_perms_explanation
            /// Description: The text to explain why an app needs additional permissions that appears in the Auth Dialog (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "auth_dialog_perms_explanation")]
            public string AuthDialogPermissionsExplanation { get; set; }

            /// <summary>
            /// Name: auth_referral_user_perms
            /// Description: Basic user permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: array
            /// </summary>
            [DataMember(Name = "auth_referral_user_perms")]
            public string[] AuthReferralUserPermissions { get; set; }

            /// <summary>
            /// Name: auth_referral_friend_perms
            /// Description: Basic friends permissions that a user must grant when Authenticated Referrals are enabled (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: array
            /// </summary>
            [DataMember(Name = "auth_referral_friend_perms")]
            public string[] AuthReferralFriendPermissions { get; set; }

            /// <summary>
            /// Name: auth_referral_default_activity_privacy
            /// Description: The default privacy setting selected for Open Graph activities in the Auth Dialog (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string which is one of: SELF, EVERYONE, ALL_FRIENDS or NONE
            /// </summary>
            [DataMember(Name = "auth_referral_default_activity_privacy")]
            public string AuthReferralDefaultActivityPrivacy { get; set; }

            /// <summary>
            /// Name: auth_referral_enabled
            /// Description: Indicates whether Authenticated Referrals are enabled (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: bool
            /// </summary>
            [DataMember(Name = "auth_referral_enabled")]
            public bool? AuthReferralEnabled { get; set; }

            /// <summary>
            /// Name: auth_referral_extended_perms
            /// Description: Extended permissions that a user can choose to grant when Authenticated Referrals are enabled (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: array
            /// </summary>
            [DataMember(Name = "auth_referral_extended_perms")]
            public string[] AuthReferralExtendedPermissions { get; set; }

            /// <summary>
            /// Name: auth_referral_response_type
            /// Description: The format that an app receives the Auth token from the Auth Dialog in (Editable via API) 
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string which is one of: code or token
            /// </summary>
            [DataMember(Name = "auth_referral_response_type")]
            public string AuthReferralResponseType { get; set; }

            /// <summary>
            /// Name: canvas_fluid_height
            /// Description: Indicates whether app uses fluid or settable height values for Canvas (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: bool
            /// </summary>
            [DataMember(Name = "canvas_fluid_height")]
            public bool? CanvasFluidHeight { get; set; }

            /// <summary>
            /// Name: canvas_fluid_width
            /// Description: Indicates whether app uses fluid or fixed width values for Canvas (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: bool
            /// </summary>
            [DataMember(Name = "canvas_fluid_width")]
            public bool? CanvasFluidWidth { get; set; }

            /// <summary>
            /// Name: canvas_url
            /// Description: The non-secure URL from which Canvas app content is loaded (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "canvas_url")]
            public string CanvasUrl { get; set; }

            /// <summary>
            /// Name: contact_email
            /// Description: Email address listed for users to contact developers (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "contact_email")]
            public string ContactEmail { get; set; }

            /// <summary>
            /// Name: created_time
            /// Description: Unix timestamp that indicates when the app was created
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: int
            /// </summary>
            [DataMember(Name = "created_time")]
            public int? CreatedTime { get; set; }

            /// <summary>
            /// Name: creator_uid
            /// Description: User ID of the creator of this app
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: int
            /// </summary>
            [DataMember(Name = "creator_uid")]
            public int? CreatorUid { get; set; }

            /// <summary>
            /// Name: deauth_callback_url
            /// Description: URL that is pinged whenever a user removes the app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "deauth_callback_url")]
            public string DeAuthCallbackUrl { get; set; }

            /// <summary>
            /// Name: iphone_app_store_id
            /// Description: ID of the app in the iPhone App Store
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "iphone_app_store_id")]
            public string IPhoneAppStoreID { get; set; }

            /// <summary>
            /// Name: hosting_url
            /// Description: Webspace created with one of our hosting partners for this app
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "hosting_url")]
            public string HostingUrl { get; set; }

            /// <summary>
            /// Name: mobile_web_url
            /// Description: URL to which Mobile users will be directed when using the app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "mobile_web_url")]
            public string MobileWebUrl { get; set; }

            /// <summary>
            /// Name: page_tab_default_name
            /// Description: The title of the app when used in a Page Tab (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "page_tab_default_name")]
            public string PageTabDefaultName { get; set; }

            /// <summary>
            /// Name: page_tab_url
            /// Description: The non-secure URL from which Page Tab app content is loaded (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "page_tab_url")]
            public string PageTabUrl { get; set; }

            /// <summary>
            /// Name: privacy_policy_url
            /// Description: The URL that links to a Privacy Policy for the app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "privacy_policy_url")]
            public string PrivacyPolicyUrl { get; set; }

            /// <summary>
            /// Name: secure_canvas_url
            /// Description: The secure URL from which Canvas app content is loaded (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "secure_canvas_url")]
            public string SecureCanvasUrl { get; set; }

            /// <summary>
            /// Name: secure_page_tab_url
            /// Description: The secure URL from which Page Tab app content is loaded (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "secure_page_tab_url")]
            public string SecurePageTabUrl { get; set; }

            /// <summary>
            /// Name: server_ip_whitelist
            /// Description: App requests must originate from this comma-separated list of IP addresses (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "server_ip_whitelist")]
            public string ServerIPWhitelist { get; set; }

            /// <summary>
            /// Name: social_discovery
            /// Description: Indicates whether app usage stories show up in the Ticker or News Feed (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: bool
            /// </summary>
            [DataMember(Name = "social_discovery")]
            public bool? SocialDiscovery { get; set; }

            /// <summary>
            /// Name: terms_of_service_url
            /// Description: URL to Terms of Service which is linked to in Auth Dialog (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "terms_of_service_url")]
            public string TermsOfServiceUrl { get; set; }

            /// <summary>
            /// Name: user_support_email
            /// Description: Main contact email for this app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "user_support_email")]
            public string UserSupportEmail { get; set; }

            /// <summary>
            /// Name: user_support_url
            /// Description: URL of support for users of an app shown in Canvas footer (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "user_support_url")]
            public string UserSupportUrl { get; set; }

            /// <summary>
            /// Name: website_url
            /// Description: URL of a website that integrates with this app (Editable via API)
            /// Permissions: App access_token required; only returned if specifically requested via the fields URL parameter
            /// Return: string
            /// </summary>
            [DataMember(Name = "website_url")]
            public string WebsiteUrl { get; set; }

            [DataContract]
            public class Restriction
            {
                [DataMember(Name = "type")]
                public string Type { get; set; }

                [DataMember(Name = "location")]
                public string Location { get; set; }

                [DataMember(Name = "age")]
                public string Age { get; set; }

                [DataMember(Name = "age_distr")]
                public string AgeDistribution { get; set; }
            }
        }



    }
}
