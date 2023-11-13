// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        // Skapa två användare (user, user2)
        User user = new User("Kev", "Kevin", "12949219AKW");
        User user2 = new User("Bubben", "Bob", "1041204040");

        Tweet tweet1 = new Tweet("FOtboll", "Zlatan är bäst");
        Tweet tweet2 = new Tweet("Jag är hungrig", "Vet inte varför...");
        
        // Skapa ett retweet utav tweet1
        ReTweet retweet1 = new ReTweet("Kev", "Kevin", tweet1);
        ReTweet retweet2 = new ReTweet("Bubben", "Bob", tweet2); 

        // Binder användaren(user) till tweet1 och retweet1
        user.Tweets.Add(tweet1);
        user.Retweets.Add(retweet1);

        // Binder användaren(user) till tweet2 och retweet2
        user2.Tweets.Add(tweet2);
        user.Retweets.Add(retweet2);

        foreach (Tweet tweet in user.Tweets)
        {
            Console.WriteLine($"{user.NickName} tweeted: {tweet.Title} {tweet.Message}");
        }

        foreach (ReTweet rTweet in user.Retweets)
        {
            Console.WriteLine($"{user.NickName} retweeted: {rTweet.OriginalTweet} from {rTweet.NickName}");
        }
    }
}

