using System.Text.Json;

namespace JokeApp
{
    public class JokeService
    {
        public static Joke GetRandomJoke()
        {
            return DoGetJoke("Any");
        }
        private static Joke DoGetJoke(string category)
        {
            category ??= "Any";
            using HttpClient client = new();
            String json = client.GetStringAsync($"https://v2.jokeapi.dev/joke/{category}?blacklistFlags=nsfw,racist,sexist&type=twopart").Result;
            Joke joke = JsonSerializer.Deserialize<Joke>(json);
            return joke;
        }

    }
}
