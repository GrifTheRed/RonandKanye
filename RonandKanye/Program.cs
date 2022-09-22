using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


for {
    var client = new HttpClient();
    //Kanye
    var kanyeURL = "https://api.kanye.rest";
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
    var kanyeQoute = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    Console.WriteLine(kanyeResponse);

    //Ron
    var ronURL = " https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    var ronResponse = client.GetStringAsync(ronURL).Result;
    var ronObject = JArray.Parse(ronResponse);
    Console.WriteLine($"Ron: {ronObject[0]}");
    Console.WriteLine();
    }