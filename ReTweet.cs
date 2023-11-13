class ReTweet
{
    public string NickName {get; set;}
    public string UserName {get; set;}
    public Tweet OriginalTweet {get; set;}
    public ReTweet(string nickname, string username, Tweet originalTweet)
    {
        NickName = nickname;
        UserName = username;
        OriginalTweet = originalTweet;
    }
}