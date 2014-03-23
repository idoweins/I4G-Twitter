using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
namespace I4G___Twitter
{


    public struct Tweet
    {


        public string Content { get; set; }
        public string ImageURL { get; set; }

        static readonly UTF8Encoding encoding = new UTF8Encoding();
        static readonly JavaScriptSerializer jss = new JavaScriptSerializer();
        /// <summary>
        /// Returns an IEnumerable<Tweet> of the most recent tweets which include "windows"
        /// </summary>
        /// <returns></returns>
        /// 

        public static IEnumerable<Tweet> GetTweets()
        {

            string bearer = GetToken(Properties.Resources.key, Properties.Resources.secret);
            List<Status> statuses = GetRawTweetsResponse(bearer).statuses;

            foreach (var rawstatus in statuses)
                yield return new Tweet() { Content = rawstatus.text, ImageURL = rawstatus.user.profile_image_url };

        }

        /// <summary>
        /// Gets a bearer token using the "Application-Only Authentication" method
        /// </summary>
        /// <param name="key">The key parameter of the signed Twitter application</param>
        /// <param name="secret">The secret parameter of the signed Twitter application</param>
        /// <returns>The bearer token as string</returns>
        private static string GetToken(string key, string secret)
        {
            string bearer = HttpUtility.UrlEncode(key) + ":" + HttpUtility.UrlEncode(secret);
            WebClient wc = new WebClient();
            wc.Headers["Authorization"] = "Basic " + Convert.ToBase64String(encoding.GetBytes(bearer));
            NameValueCollection nc = new NameValueCollection();
            nc["grant_type"] = "client_credentials";
            byte[] tweetsresponse = wc.UploadValues("https://api.twitter.com/oauth2/token", "POST", nc);
            return (jss.DeserializeObject(encoding.GetString(tweetsresponse)) as Dictionary<string, object>)["access_token"].ToString();
           
        }

        /// <summary>
        /// Gets the raw response from Twitter, using the bearer token of "Application-Only Authentication" method
        /// </summary>
        /// <param name="bearer">The bearer token of the request</param>
        /// <returns>A JObject instance containing all of the data inside the response</returns>
        private static RootObject GetRawTweetsResponse(string bearer)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("Authorization", "Bearer " + bearer);
            return jss.Deserialize<RootObject>(wc.DownloadString("https://api.twitter.com/1.1/search/tweets.json?q=windows"));
        }

        public override int GetHashCode()
        {
            return (this.Content + this.ImageURL).GetHashCode();
        }
    }

}
