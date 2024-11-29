using StructuralDesignPatterns.Proxy.BadSln.Package;
using StructuralDesignPatterns.Proxy.BadSln;
using StructuralDesignPatterns.Proxy.GoodSln;

var videoList = new VideoList();
String[] videoIds = { "123", "abcd", "efgh"};

foreach(var videoId in videoIds)
{
    videoList.Add(new YoutubeVideoProxy(videoId));
}
videoList.Watch("123");