class Tweet
{
    public string Title { get; set; }
    public string Message { get; set; }

    public Tweet(string title, string message){
        Title = title;
        Message = message;
    }

}

class TweetSearch
{
    public static List<Tweet> SearchTweets(string title, string message)
    {
        
        // Your search logic goes here

        List<Tweet> searchResults = new List<Tweet>
        {
            // Empty list atm
        };

        // Filtering based on title and message
        List<Tweet> filteredTweets = searchResults
            .Where(tweet => tweet.Title.Contains(title, StringComparison.OrdinalIgnoreCase) &&
                            tweet.Message.Contains(message, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return filteredTweets;
    }
}
