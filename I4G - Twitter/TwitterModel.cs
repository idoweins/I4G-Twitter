using System.Collections.Generic;

namespace I4G___Twitter
{
    public class StatusMetadata
    {
        public string result_type { get; set; }
        public string iso_language_code { get; set; }
    }

    public class StatusUserEntitiesDescription
    {
        public List<object> urls { get; set; }
    }

    public class StatusUserEntities
    {
        public StatusUserEntitiesDescription description { get; set; }
    }

    public class StatusUser
    {
        public long id { get; set; }
        public string id_str { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public object url { get; set; }
        public StatusUserEntities entities { get; set; }
        public bool @protected { get; set; }
        public long followers_count { get; set; }
        public long friends_count { get; set; }
        public long listed_count { get; set; }
        public string created_at { get; set; }
        public long favourites_count { get; set; }
        public int? utc_offset { get; set; }
        public string time_zone { get; set; }
        public bool geo_enabled { get; set; }
        public bool verified { get; set; }
        public long statuses_count { get; set; }
        public string lang { get; set; }
        public bool contributors_enabled { get; set; }
        public bool is_translator { get; set; }
        public bool is_translation_enabled { get; set; }
        public string profile_background_color { get; set; }
        public string profile_background_image_url { get; set; }
        public string profile_background_image_url_https { get; set; }
        public bool profile_background_tile { get; set; }
        public string profile_image_url { get; set; }
        public string profile_image_url_https { get; set; }
        public string profile_banner_url { get; set; }
        public string profile_link_color { get; set; }
        public string profile_sidebar_border_color { get; set; }
        public string profile_sidebar_fill_color { get; set; }
        public string profile_text_color { get; set; }
        public bool profile_use_background_image { get; set; }
        public bool default_profile { get; set; }
        public bool default_profile_image { get; set; }
        public object following { get; set; }
        public object follow_request_sent { get; set; }
        public object notifications { get; set; }
    }

    public class StatusEntities
    {
        public List<object> hashtags { get; set; }
        public List<object> symbols { get; set; }
        public List<object> urls { get; set; }
        public List<object> user_mentions { get; set; }
    }

    public class RetweetedStatusMetadata
    {
        public string result_type { get; set; }
        public string iso_language_code { get; set; }
    }

    public class RetweetedStatusUserEntitiesDescription
    {
        public List<object> urls { get; set; }
    }

    public class UrlDetails
    {
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public List<int> indices { get; set; }
    }

    public class Url
    {
        public List<UrlDetails> urls { get; set; }
    }

    public class RetweetedStatusUserEntities
    {
        public RetweetedStatusUserEntitiesDescription description { get; set; }
        public Url url { get; set; }
    }

    public class RetweetedStatusUser
    {
        public long id { get; set; }
        public string id_str { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public RetweetedStatusUserEntities entities { get; set; }
        public bool @protected { get; set; }
        public long followers_count { get; set; }
        public long friends_count { get; set; }
        public long listed_count { get; set; }
        public string created_at { get; set; }
        public long favourites_count { get; set; }
        public int? utc_offset { get; set; }
        public string time_zone { get; set; }
        public bool geo_enabled { get; set; }
        public bool verified { get; set; }
        public long statuses_count { get; set; }
        public string lang { get; set; }
        public bool contributors_enabled { get; set; }
        public bool is_translator { get; set; }
        public bool is_translation_enabled { get; set; }
        public string profile_background_color { get; set; }
        public string profile_background_image_url { get; set; }
        public string profile_background_image_url_https { get; set; }
        public bool profile_background_tile { get; set; }
        public string profile_image_url { get; set; }
        public string profile_image_url_https { get; set; }
        public string profile_link_color { get; set; }
        public string profile_sidebar_border_color { get; set; }
        public string profile_sidebar_fill_color { get; set; }
        public string profile_text_color { get; set; }
        public bool profile_use_background_image { get; set; }
        public bool default_profile { get; set; }
        public bool default_profile_image { get; set; }
        public object following { get; set; }
        public object follow_request_sent { get; set; }
        public object notifications { get; set; }
        public string profile_banner_url { get; set; }
    }

    public class Geo
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Coordinates
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class BoundingBox
    {
        public string type { get; set; }
        public List<List<List<double>>> coordinates { get; set; }
    }

    public class Attributes
    {
    }

    public class Place
    {
        public string id { get; set; }
        public string url { get; set; }
        public string place_type { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public List<object> contained_within { get; set; }
        public BoundingBox bounding_box { get; set; }
        public Attributes attributes { get; set; }
    }

    public class RetweetedStatusEntities
    {
        public List<object> hashtags { get; set; }
        public List<object> symbols { get; set; }
        public List<object> urls { get; set; }
        public List<object> user_mentions { get; set; }
    }

    public class RetweetedStatus
    {
        public RetweetedStatusMetadata metadata { get; set; }
        public string created_at { get; set; }
        public object id { get; set; }
        public string id_str { get; set; }
        public string text { get; set; }
        public string source { get; set; }
        public bool truncated { get; set; }
        public object in_reply_to_status_id { get; set; }
        public object in_reply_to_status_id_str { get; set; }
        public object in_reply_to_user_id { get; set; }
        public object in_reply_to_user_id_str { get; set; }
        public object in_reply_to_screen_name { get; set; }
        public RetweetedStatusUser user { get; set; }
        public Geo geo { get; set; }
        public Coordinates coordinates { get; set; }
        public Place place { get; set; }
        public object contributors { get; set; }
        public long retweet_count { get; set; }
        public long favorite_count { get; set; }
        public RetweetedStatusEntities entities { get; set; }
        public bool favorited { get; set; }
        public bool retweeted { get; set; }
        public string lang { get; set; }
    }

    public class Status
    {
        public StatusMetadata metadata { get; set; }
        public string created_at { get; set; }
        public object id { get; set; }
        public string id_str { get; set; }
        public string text { get; set; }
        public string source { get; set; }
        public bool truncated { get; set; }
        public object in_reply_to_status_id { get; set; }
        public object in_reply_to_status_id_str { get; set; }
        public object in_reply_to_user_id { get; set; }
        public object in_reply_to_user_id_str { get; set; }
        public object in_reply_to_screen_name { get; set; }
        public StatusUser user { get; set; }
        public object geo { get; set; }
        public object coordinates { get; set; }
        public object place { get; set; }
        public object contributors { get; set; }
        public long retweet_count { get; set; }
        public long favorite_count { get; set; }
        public StatusEntities entities { get; set; }
        public bool favorited { get; set; }
        public bool retweeted { get; set; }
        public bool possibly_sensitive { get; set; }
        public string lang { get; set; }
        public RetweetedStatus retweeted_status { get; set; }
    }

    public class SearchMetadata
    {
        public double completed_in { get; set; }
        public long max_id { get; set; }
        public string max_id_str { get; set; }
        public string query { get; set; }
        public string refresh_url { get; set; }
        public long count { get; set; }
        public long since_id { get; set; }
        public string since_id_str { get; set; }
    }

    public class RootObject
    {
        public List<Status> statuses { get; set; }
        public SearchMetadata search_metadata { get; set; }
    }
}
