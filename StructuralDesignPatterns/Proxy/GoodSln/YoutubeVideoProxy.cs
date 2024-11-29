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