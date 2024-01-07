using ChallengeApp;

User user1 = new User("Adam", "123qwe");    
User user2 = new User("Jan", "123qwe");
User user3 = new User("Barbara", "123qwe");
User user4 = new User("Katarzyna", "123qwe");

user1.AddScore(5);
user1.AddScore(10);
user1.AddScore(15);

var ResultUser1 = user1.Result;

Console.WriteLine(ResultUser1);
Console.WriteLine(user1.Result);

var Game = User.GameName;
Console.WriteLine(Game);

