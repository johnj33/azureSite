using Owin;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

namespace WorkerRole1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseFileServer(new FileServerOptions()
            {
                RequestPath = PathString.Empty,
                FileSystem = new PhysicalFileSystem(@".\app"),
            });
        }
    }
}