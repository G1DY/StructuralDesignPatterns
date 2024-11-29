using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.BadSln.Package
{
    public class YoutubeVideo : Video
    {
        private string _videoId;
        public YoutubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }
        private void Download()
        {
            System.Console.WriteLine("Downloading video with id " + _videoId + " from Youtube API");
        }
        public void Render()
        {
            System.Console.WriteLine("Rendering video " + _videoId);
        }
        public string GetVideoId()
        {
            return _videoId;
        }
    }
}