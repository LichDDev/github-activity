
using github_activity.DIsplayers;
using github_activity.Models;
using github_activity.Services;
using github_activity.Validator;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;

//configure http client
var client = new HttpClient();

client.BaseAddress = new Uri("https://api.github.com/");

client.DefaultRequestHeaders.Add("User-Agent", "github-activity-app");

if (!args[0].Equals("github-activity") || !UserValidator.ValidateAndGetUsername(args[1]))
{
    Console.WriteLine("Usage: github-activity <username>");
    return;
}

var user = args[1];

var service = new GithubService(client);

var events = await service.GetUserActivity(user);

if (events.Count() == 0 ||events == null)
{
    Console.WriteLine("No activity found for the user.");
    return;
}

var activityDisplay = new List<IDisplay>();

foreach (var activity in events)
{
    switch (activity.type)
    {
        case "PushEvent":
            var pushDisplay = new DisplayPushEvent(activity);
            activityDisplay.Add(pushDisplay);
            break;
        case "IssuesEvent":
            var issuesDisplay = new DisplayIssuesEvent(activity);
            activityDisplay.Add(issuesDisplay);
            break;
        case "WatchEvent":
            var watchDisplay = new DisplayWatchEvent(activity);
            activityDisplay.Add(watchDisplay);
            break;
        case "CreateEvent":
            var createDisplay = new DisplayCreateEvent(activity);
            activityDisplay.Add(createDisplay);
            break;
        case "ForkEvent":
            var forkDisplay = new DisplayForkEvent(activity);
            activityDisplay.Add(forkDisplay);
            break;
        default:
            var defaultDisplay = new DisplayWatchEvent(activity);
            activityDisplay.Add(defaultDisplay);
            break;
    }
}

activityDisplay.ForEach(display => display.showActivity());
