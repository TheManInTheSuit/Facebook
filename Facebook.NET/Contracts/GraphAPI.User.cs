using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        /// <summary>
        /// A user profile as represented in the Graph API.
        /// </summary>
        [DataContract]
        public sealed partial class User : GraphApi.IObject
        {
            /// <summary>
            /// Name: id
            /// Description: The user's Facebook ID
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>
            [DataMember(Name = "id")]
            public string ID { get; set; }

            /// <summary>
            /// Name: name
            /// Description: The user's full name
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Name: first_name
            /// Description: The user's first name
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "first_name")]
            public string FirstName { get; set; }

            /// <summary>
            /// Name: middle_name
            /// Description: The user's middle name
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>
            [DataMember(Name = "middle_name")]
            public string MiddleName { get; set; }

            /// <summary>
            /// Name: last_name
            /// Description: The user's last name
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "last_name")]
            public string LastName { get; set; }

            /// <summary>
            /// Name: gender
            /// Description: The user's gender: female or male
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "gender")]
            public string Gender { get; set; }

            /// <summary>
            /// Name: locale
            /// Description: The user's locale
            /// Permissions: No access_token required
            /// Returns: string containing the ISO Language Code and ISO Country Code
            /// </summary>            
            [DataMember(Name = "locale")]
            public string Locale { get; set; }

            /// <summary>
            /// Name: languuages
            /// Description: The user's languages
            /// Permissions: user_likes
            /// Returns: array of objects containing language id and name
            /// </summary>
            [DataMember(Name = "languages")]
            public GraphApi.Domain[] Languages { get; set; }

            /// <summary>
            /// Name: link
            /// Description: The URL of the profile for the user on Facebook
            /// Permissions: No access_token required
            /// Returns: string containing a valid URL
            /// </summary>            
            [DataMember(Name = "link")]
            public string Link { get; set; }

            /// <summary>
            /// Name: username
            /// Description: The user's Facebook username
            /// Permissions: No access_token required
            /// Returns: string
            /// </summary>
            [DataMember(Name = "username")]
            public string Username { get; set; }

            /// <summary>
            /// Name: age_range
            /// Description: The user's age range; only returned if specifically requested via the fields URL parameter
            /// Permissions: Requires access_token
            /// Returns: object containing min and max for the age range; Possible age ranges are 13-17, 18-20, and 21+; max is not set if the age is 21+
            /// </summary>            
            [DataMember(Name = "age_range")]
            public object AgeRange { get; set; }

            /// <summary>
            /// Name: third_party_id
            /// Description: An anonymous, but unique identifier for the user; only returned if specifically requested via the fields URL parameter
            /// Permissions: Requires access_token
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "third_party_id")]
            public string ThirdPartyID { get; set; }

            /// <summary>
            /// Name: installed
            /// Description: Specifies whether the user has installed the application associated with the app access token that is used to make the request; only returned if specifically requested via the fields URL parameter
            /// Permissions: Requires access_token
            /// Returns: object containing type (this is always "user"), id (the ID of the user), and optional installed field (always true if returned); The installed field is only returned if the user has installed the application, otherwise it is not part of the returned object
            /// </summary>            
            [DataMember(Name = "installed")]
            public bool? Installed { get; set; }

            /// <summary>
            /// Name: timezone
            /// Description: The user's timezone offset from UTC
            /// Permissions: Available only for the current user
            /// Returns: number
            /// </summary>            
            [DataMember(Name = "timezone")]
            public double? Timezone { get; set; }

            /// <summary>
            /// Name: updatedTime
            /// Description: The last time the user's profile was updated; changes to the languages, link, timezone, verified, interested_in, favorite_athletes, favorite_teams, and video_upload_limits are not not reflected in this value
            /// Permissions: Requires access_token
            /// Returns: string containing an ISO-8601 datetime
            /// </summary>            
            [DataMember(Name = "updated_time")]
            public string UpdatedTime { get; set; }

            /// <summary>
            /// Name: verified
            /// Description: The user's account verification status, either true or false (see below)
            /// Permissions: Requires access_token
            /// Returns: boolean
            /// </summary>            
            [DataMember(Name = "verified")]
            public bool? Verified { get; set; }

            /// <summary>
            /// Name: bio
            /// Description: The user's biography
            /// Permissions: user_about_me or friends_about_me
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "bio")]
            public string Bio { get; set; }

            /// <summary>
            /// Name: birthday
            /// Description: The user's birthday
            /// Permissions: user_birthday or friends_birthday
            /// Returns: Date string in MM/DD/YYYY format
            /// </summary>            
            [DataMember(Name = "birthday")]
            public string Birthday { get; set; }

            /// <summary>
            /// Name: cover
            /// Description: The user's cover photo (must be explicitly requested using fields=cover parameter)
            /// Permissions: Requires access_token
            /// Returns: array of fields id, source, and offset_y
            /// </summary>            
            [DataMember(Name = "cover")]
            public object[] Cover { get; set; }

            /// <summary>
            /// Name: currency
            /// Description: The user's currency settings (must be explicitly requested using a fields=currency URL parameter)
            /// Permissions: Requires access_token
            /// Returns: object with fields currency (detailed here), id
            /// </summary>            
            [DataMember(Name = "currency")]
            public Currency Currency { get; set; }

            /// <summary>
            /// Name: devices
            /// Description: A list of the user's devices beyond desktop
            /// Permissions: User access_token required; only available for friends of the current user
            /// Returns: array of objects containing os which may be a value of 'iOS' or 'Android', along with an additional field hardware which may be a value of 'iPad' or 'iPhone' if present, however may not be returned if we are unable to determine the hardware model - Note: this is a non-default field and must be explicitly specified as shown below
            /// </summary>            
            [DataMember(Name = "devices")]
            public object[] Devices { get; set; }

            /// <summary>
            /// Name: id
            /// Description: A list of the user's education history
            /// Permissions: user_education_history or friends_education_history
            /// Returns: array of objects containing year and type fields, and school object (name, id, type, and optional year, degree, concentration array, classes array, and with array )
            /// </summary>            
            [DataMember(Name = "education")]
            public GraphApi.Education[] Education { get; set; }

            /// <summary>
            /// Name: email
            /// Description: The proxied or contact email address granted by the user
            /// Permissions: email
            /// Returns: string containing a valid RFC822 email address
            /// </summary>            
            [DataMember(Name = "email")]
            public string Email { get; set; }

            /// <summary>
            /// Name: hometown
            /// Description: The user's hometown
            /// Permissions: user_hometown or friends_hometown
            /// Returns: object containing name and id
            /// </summary>            
            [DataMember(Name = "hometown")]
            public object Hometown { get; set; }

            /// <summary>
            /// Name: interested_in
            /// Description: The genders the user is interested in
            /// Permissions: user_relationship_details or friends_relationship_details
            /// Returns: array containing strings
            /// </summary>            
            [DataMember(Name = "interested_in")]
            public string[] InterestedIn { get; set; }

            /// <summary>
            /// Name: location
            /// Description: The user's current city
            /// Permissions: user_location or friends_location
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "location")]
            public object Location { get; set; }

            /// <summary>
            /// Name: political
            /// Description: The user's political view
            /// Permissions: user_religion_politics or friends_religion_politics
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "political")]
            public string Political { get; set; }

            /// <summary>
            /// Name: payment_pricepoints
            /// Description: The payment price-points available for that user
            /// Permissions: User access_token
            /// Returns: array of objects containing user_price, credits and local_currency fields
            /// </summary>            
            [DataMember(Name = "payment_pricepoints")]
            public PaymentPricePoint[] PaymentPricepoints { get; set; }

            /// <summary>
            /// Name: favorite_athletes
            /// Description: The user's favorite athletes; this field is deprecated and will be removed in the near future
            /// Permissions: user_likes or friends_likes
            /// Returns: array of objects containing id and name fields
            /// </summary>            
            [DataMember(Name = "favorite_athletes")]
            public object[] FavoriteAthletes { get; set; }

            /// <summary>
            /// Name: favorite_teams
            /// Description: The user's favorite teams; this field is deprecated and will be removed in the near future
            /// Permissions: user_likes or friends_likes
            /// Returns: array of objects containing id and name fields
            /// </summary>            
            [DataMember(Name = "favorite_teams")]
            public object[] FavoriteTeams { get; set; }

            /// <summary>
            /// Name: Picture
            /// Description: The URL of the user's profile pic (only returned if you explicitly specify a 'fields=picture' param)
            /// Permissions: access_token required for pages with whitelisting/targeting restrictions, otherwise no access_token required
            /// Returns: string; If the "October 2012 Breaking Changes" migration setting is enabled for your app, this field will be an object with the url and is_silhouette fields; is_silhouette is true if the user has not uploaded a profile picture
            /// </summary>            
            [DataMember(Name = "picture")]
            public string Picture { get; set; }

            /// <summary>
            /// Name: quotes
            /// Description: The user's favorite quotes
            /// Permissions: user_about_me or friends_about_me
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "quotes")]
            public string Quotes { get; set; }

            /// <summary>
            /// Name: relationship_status
            /// Description: The user's relationship status: Single, In a relationship, Engaged, Married, It's complicated, In an open relationship, Widowed, Separated, Divorced, In a civil union, In a domestic partnership
            /// Permissions: user_relationships or friends_relationships
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "relationship_status")]
            public string RelationshipStatus { get; set; }

            /// <summary>
            /// Name: religion
            /// Description: The user's religion
            /// Permissions: user_religion_politics or friends_religion_politics
            /// Returns: string
            /// </summary>            
            [DataMember(Name = "religion")]
            public string Religion { get; set; }

            /// <summary>
            /// Name: security_settings
            /// Description: Information about security settings enabled on the user's account (must be explicitly requested using a fields=security_settings URL parameter)
            /// Permissions: Available only for the current user
            /// Returns: object containing secure_browsing (an object with a single field, enabled, which indicates whether Secure Browsing is enabled)
            /// </summary>            
            [DataMember(Name = "security_settings")]
            public SecuritySettings SecuritySettings { get; set; }

            /// <summary>
            /// Name: significant_other
            /// Description: The user's significant other
            /// Permissions: user_relationships or friends_relationships
            /// Returns: object containing name and id
            /// </summary>            
            [DataMember(Name = "significant_other")]
            public object SignificantOther { get; set; }

            /// <summary>
            /// Name: video_upload_limits
            /// Description: The size of the video file and the length of the video that a user can upload; only returned if specifically requested via the fields URL parameter
            /// Permissions: Requires access_token
            /// Returns: object containing length and size of video
            /// </summary>            
            [DataMember(Name = "video_upload_limits")]
            public VideoUploadLimit VideoUploadLimits { get; set; }

            /// <summary>
            /// Name: website
            /// Description: The URL of the user's personal website
            /// Permissions: user_website or friends_website
            /// Returns: string containing a valid URL
            /// </summary>            
            [DataMember(Name = "website")]
            public string Website { get; set; }

            /// <summary>
            /// Name: work
            /// Description: A list of the user's work history
            /// Permissions: user_work_history or friends_work_history
            /// Returns: array of objects containing employer, location, position, start_date and end_date fields
            /// </summary>            
            [DataMember(Name = "work")]
            public Job[] Work { get; set; }
        }
    }
}