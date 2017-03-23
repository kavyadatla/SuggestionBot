using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Newtonsoft.Json;

[LuisModel("", "")]
[Serializable]

public class MyLuisDialog : LuisDialog<object>
{
    [LuisIntent("")]
    [LuisIntent("None")]
    public async Task None(IDialogContext context, LuisResult luisResult)
    {
        string message = "Sorry, I have limited suggestions. I can help you with Restaurants, SightSeeing places and Malls";
        await context.PostAsync(message);
        context.Wait(this.MessageReceived);
    }
    [LuisIntent("greeting")]
    public async Task greeting(IDialogContext context, LuisResult luisResult)
    {
        string message = "Hello from Suggestion Bot. You can ask me about Restaurants, SightSeeing places and Malls ";
        await context.PostAsync(message);
        context.Wait(this.MessageReceived);
    }
    [LuisIntent("FavouriteRestaurants")]
    public async Task FavouriteRestaurants(IDialogContext context, LuisResult luisResult)
    {
        string message = "Pok-Pok " + "Thai Tom " + "Panda Express";
        await context.PostAsync(message);
        context.Wait(this.MessageReceived);
    }
    [LuisIntent("Sightseeing")]
    public async Task Sightseeing(IDialogContext context, LuisResult luisResult)
    {
        string message = "Space Needle " + "Seattle Aquarium " + "Alki Beach";
        await context.PostAsync(message);
        context.Wait(this.MessageReceived);
    }
    [LuisIntent("malls")]
    public async Task malls(IDialogContext context, LuisResult luisResult)
    {
        string message = "CrossRoads Mall " + "Bellevue Square Mall";
        await context.PostAsync(message);
        context.Wait(this.MessageReceived);
    }

}
