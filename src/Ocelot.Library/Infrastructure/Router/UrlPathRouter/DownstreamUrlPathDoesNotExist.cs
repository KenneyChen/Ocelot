using Ocelot.Library.Infrastructure.Responses;

namespace Ocelot.Library.Infrastructure.Router.UrlPathRouter
{
    public class DownstreamUrlPathTemplateDoesNotExist : Error
    {
        public DownstreamUrlPathTemplateDoesNotExist() 
            : base("This key does not exist")
        {
        }
    }
}