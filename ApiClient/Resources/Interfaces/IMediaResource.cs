using System;
using System.Collections.Generic;
using ShopwareApi.Models.Media;

namespace ShopwareApi.Resources
{
    public interface IMediaResource
    {
        List<Media> GetAll();

        Media Get(int id);

        Media Get(string id);

        void Add(Media media);

        void Update(Media media);
    }
}
