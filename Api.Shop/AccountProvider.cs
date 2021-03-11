using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Shop.Models;
using Api.ShopRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Shop
{
    public class AccountProvider
    {
        private Account account = null;
        private DbAccount dbAccount = null;
        private PostAccount postAcocunt = null;
        public AccountProvider()
        {
            account = new Account();
            dbAccount = new DbAccount();

        }
        public AccountProvider(PostAccount postAccount)
        {
            this.postAcocunt = postAccount;
            dbAccount = new DbAccount();
        } 

       public Result CreateAccount(PostAccount postAccount) 
        {
            Result result = new Result();
            //walidacja pól
            if (this.postAcocunt !=null)
            {
                result = AccountValidate(this.postAcocunt);
                if (!result.status)
                {
                    return result;
                }
                else
                {
                    // sprawdzznie duplikatu
                    if (account.Get(postAcocunt.UserEmail) == null)
                    {
                        result.status = false;
                        result.value = "Konto " + postAcocunt.UserEmail + " już istnieje !";
                        return result;
                    }
                    else
                    {
                        this.dbAccount = ModeltoDtoAccoutMapper.map(postAcocunt);
                        // mapowanie pól
                        if (dbAccount != null)
                            account.Add(dbAccount);
                        else
                        {
                            result.status = false;
                            result.value = "Błąd zapisu !";
                        }
                    }
                }
            }
            return result;
        }

        private Result AccountValidate(PostAccount account)
        {
            Result result = new Result();
            if (String.IsNullOrEmpty(account.UserEmail))
            {
                result.status = false;
                result.value = "Pole " + nameof(account.UserEmail) + " musi być uzupełnione";
            }
            if (String.IsNullOrEmpty(account.UserName))
            {
                result.status = false;
                result.value = "Pole " + nameof(account.UserName) + " musi być uzupełnione";
            }
            if (String.IsNullOrEmpty(account.UserPassword))
            {
                result.status = false;
                result.value = "Pole " + nameof(account.UserPassword) + " musi być uzupełnione";
            }
            return result;
        }
    }
}
