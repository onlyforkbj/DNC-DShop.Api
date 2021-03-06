﻿using DShop.Common.Types;
using DShop.Services.Storage.Models.Orders;
using DShop.Services.Storage.Models.Queries;
using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DShop.Api.ServiceForwarders
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface IOrdersStorage
    {
        [AllowAnyStatusCode]
        [Get("orders/{id}")]
        Task<OrderDetails> GetAsync([Path] Guid id);

        [AllowAnyStatusCode]
        [Get("orders")]
        Task<PagedResult<Order>> BrowseAsync([Query] BrowseOrders query);
    }
}
