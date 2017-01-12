using System.Drawing;

namespace Banana_Chess
{
    internal static class StatusImages
    {
        private static Image[] statusImages = new Image[]
        {
        Image.FromFile("../../chess figures/offline.png"), // olsUnknown = -1,
        Image.FromFile("../../chess figures/offline.png"), // olsOffline = 0,
        Image.FromFile("../../chess figures/online.png"), // olsOnline = 1,
        Image.FromFile("../../chess figures/away.png"), // olsAway = 2,
        Image.FromFile("../../chess figures/offline.png"), // olsNotAvailable = 3,
        Image.FromFile("../../chess figures/dontDisturb.png"), // olsDoNotDisturb = 4,
        Image.FromFile("../../chess figures/offline.png"), // olsSkypeOut = 5,
        Image.FromFile("../../chess figures/online.png"), // olsSkypeMe = 6
        };

        internal static Image GetStatusImage(SKYPE4COMLib.TOnlineStatus status)
        {
            return statusImages[(int)status + 1];   // shift the indexes
        }
    }
}
