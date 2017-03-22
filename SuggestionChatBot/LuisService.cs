using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Newtonsoft.Json;

[LuisModel("326d6bbc-2659-40c5-9b72-dc774088ef6d", "f09fba0b852143f5a46136109125f680")]
[Serializable]

public class MyLuisDialog : LuisDialog<object>
{
    [LuisIntent("")]
    [LuisIntent("None")]
    public async Task None(IDialogContext context, LuisResult luisResult)
    {
        string message = "Sorry, I have limited suggestions";
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
    [LuisIntent("SightSeeing")]
    public async Task SightSeeing(IDialogContext context, LuisResult luisResult)
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