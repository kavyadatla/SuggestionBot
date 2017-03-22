
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Dialogs;

namespace SuggestionBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {

        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        ///
        public async Task<HttpResponseMessage> PostMes([FromBody]Activity activity)
        {
            if(activity.Type == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, () => new MyLuisDialog());
            }
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }
    }
}