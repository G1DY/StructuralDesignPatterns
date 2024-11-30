using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralDesignPatterns.Proxy.BadSln.Package;

namespace StructuralDesignPatterns.Proxy.GoodSln
{
    public class YoutubeVideoProxy : Video
    {
        private string _videoId;
        private YoutubeVideo _youtubeVideo;
        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youtubeVideo == null)
            {
                _youtubeVideo = new YoutubeVideo(_videoId);
            }
            _youtubeVideo.Render();
        }
    }
} 
// CLIENTSIDECODE:
// var videoList = new VideoList();
// String[] videoIds = { "123", "abcd", "efgh"};

// foreach(var videoId in videoIds)
// {
//     videoList.Add(new YoutubeVideoProxy(videoId));
// }
// videoList.Watch("123");