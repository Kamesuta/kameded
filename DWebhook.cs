using System;
using System.Collections.Specialized;
using System.Net;

namespace kameded
{
    public class DWebHook : IDisposable
    {
        private readonly WebClient _dWebClient;
        private static readonly NameValueCollection DiscordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }

        public DWebHook()
        {
            _dWebClient = new WebClient();
        }


        public void SendMessage(string msgSend)
        {
            if (UserName != null)
                DiscordValues.Add("username", UserName);
            if (ProfilePicture != null)
                DiscordValues.Add("avatar_url", ProfilePicture);
            DiscordValues.Add("content", msgSend);

            _dWebClient.UploadValues(WebHook, DiscordValues);
        }

        public void Dispose()
        {
            _dWebClient.Dispose();
        }
    }
}