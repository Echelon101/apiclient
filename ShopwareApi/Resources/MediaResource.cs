using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Media;
using RestSharp;

namespace ShopwareApi.Resources
{
    public class MediaResource : SuperResource<Media>, IMediaResource
    {
        public MediaResource(IRestClient client)
            :base (client)
        {
            this.resourceUrl = "media";
        }
        
        new public void Add(Media media)
        {
            if(media.album != null
                && media.file != null
                && media.description != null)
            {
                base.Add(media);
                return;
            }
            throw new Exception("Minimum required fields for media add: media.album, media.file, media.description");
        }

        new public void Update(Media media)
        {
            if(media.id != null
                && media.file != null)
            {
                base.ExecuteUpdate(media, media.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for media update: media.id, media.file");
        }
    }
}
