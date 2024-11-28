using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.BadSln.Package
{
    public interface Video
    {
        void Render();
        string GetVideoId();
    }
}