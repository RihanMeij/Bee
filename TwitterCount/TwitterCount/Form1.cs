using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;


namespace TwitterCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TwitterService twitterService;
        OAuthRequestToken requestToken;

        public void SetupTwitterClient()
        {
            TwitterClientInfo twitterClient = new TwitterClientInfo();
            twitterClient.ConsumerKey = "4FTAZV9NXphr04Stq9yIpQ";
            twitterClient.ConsumerSecret = "ZJ5yGtPrOcxsZQzsajnf8G8hDaP8QAwlRfEM0HUqHcc";
            twitterService = new TwitterService(twitterClient);

        }

        private void GetCounts_Click(object sender, EventArgs e)
        {
            var accessToken = twitterService.GetAccessToken(requestToken, Pin.Text);
            twitterService.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);

            List<string> outputStrings = new List<string>(Input.Lines.Count());

            foreach (var line in Input.Lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var profileInfo = twitterService.GetUserProfileFor(new GetUserProfileForOptions() { ScreenName = line });
                    if (profileInfo != null)
                    {
                        outputStrings.Add(string.Format("{0} : {1}", line, profileInfo.FollowersCount));
                    }
                }
            }

            Output.Lines = outputStrings.ToArray();

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            SetupTwitterClient();
          
            requestToken = twitterService.GetRequestToken();
            var authUrl = twitterService.GetAuthorizationUri(requestToken);

            Process.Start(authUrl.ToString());
        }
    }

    
}
