using StructuralDesignPatterns.Proxy.BadSln.Package;
using StructuralDesignPatterns.Proxy.BadSln;

var videoList = new VideoList();
String[] videoIds = { "123", "abcd", "efgh"};

foreach(var videoId in videoIds)
{
    videoList.Add(new YoutubeVideo(videoId));
}
videoList.Watch("123");