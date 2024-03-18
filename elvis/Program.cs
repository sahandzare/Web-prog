using elvis;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Text.Json;


var client = new RestClient();
var request = new RestRequest("http://webservies.be/eurosong/Songs", Method.Get);
var response = client.Execute(request);
Console.WriteLine(response.Content);


List<song> songs = System.Text.Json.JsonSerializer.Deserialize<List<song>>(response.Content);

Console.WriteLine(String.Join("\n", songs));

Console.WriteLine("songs");

int id = Convert.ToInt32(Console.ReadLine());

song songg = (song)songs.Find(x => x.id == id);
Console.WriteLine(songg);

request = new RestRequest("http://webservies.be/eurosong/Artists/" + songg.artist, Method.Get);
response = client.Execute(request);
Artist artist = System.Text.Json.JsonSerializer.Deserialize<Artist>(response.Content);


Console.WriteLine("Artist = \n");
Console.WriteLine(artist);
Console.WriteLine("Song = \n");
Console.WriteLine(songg);