using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class Tweet : HasId, ITweetRepo
{
    public int Id{get; set;}
    public string Content{get; set;}
    public User User{get; set;}
    public Tweet ReplyTo{get; set;}
    public bool IsRetweet{get; set;}
    public List<Tag> Tags{get; set;}
    public List<Like> Likes{get; set;}
    public List<Tweet> Retweets{get; set;}
    public DateTime CreatedAt{get; set;}

    private List<Tweet> tweets = new List<Tweet>();

    public void add(Tweet t){
        tweets.Add(t);
    }
    // public void getAll(Tweet t){
    //     tweets.getAll(t);
    }



public class TweetList : HasId {
    public int Id { get; set; }
    public string Summary { get; set; }
    public List<Tweet> Tweets { get; set; }
}

public class Twitclone : HasId {
    public int Id { get; set; }
    public List<TweetList> Lists { get; set; }
}
// public partial class DB : DbContext {
//     public DbSet<Tweet> Tweets { get; set; }
//     public DbSet<TweetList> TweetLists { get; set; }
//     public DbSet<Tweet> Twitclone { get; set; }
// }