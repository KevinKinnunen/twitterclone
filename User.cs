class User 
{
    public string NickName {get; set;}
    public string UserName {get; set;}
    public string Password {get; set;}
    public List<Tweet> Tweets {get; set;}
    public List<ReTweet> Retweets {get; set;}
    
    public User(string nickname, string username, string password)
    {
        NickName = nickname; 
        UserName = username;
        Password = password;
        Tweets = new List<Tweet>();
        Retweets = new List<ReTweet>();
    }


    // TODO: 
    public static void PostTweet(string message){
        
    }

    public static void DeleteTweet(){

    }

    public static bool RegisterUser(string username, string password){
        return true; 
    }

    public static bool LoginUser(string username, string password){
        return true; 
    }
    public static bool FollowUser(string username){
        return true; 
    }

    public static bool UnFollowUser(string username){
        return true; 
    }
}
