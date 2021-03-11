using Api.Shop.Models;
using Api.ShopRepository;
using System;

namespace Api.Shop
{
    internal class ModeltoDtoAccoutMapper
    {
        internal static DbAccount map(PostAccount postAcocunt)
        {
            DataCrypt dataCrypt = new DataCrypt();

            if (postAcocunt != null)
            {
                return new DbAccount()
                {
                    UserEmail = postAcocunt.UserEmail,
                    UserName = postAcocunt.UserName,
                    UserPassword = dataCrypt.Encrypt(postAcocunt.UserPassword),
                    UserCreatedOn = DateTime.Now
                };
            }
            else
            {
                return null;
            }
        }
    }
}