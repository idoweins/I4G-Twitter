using System.Collections.ObjectModel;
using System.Linq;

namespace I4G___Twitter
{
    /// <summary>
    /// A wrapper class of ObservableCollection<Tweet>
    /// </summary>
    class TweetsList : ObservableCollection<Tweet>
    {

        public TweetsList():base()
        {
            Update();
        }

        public void Update()
        {
            foreach (var tweet in Tweet.GetTweets())
                if (!this.Contains(tweet))
                    this.InsertItem(0, tweet);
        }
    }
}
