using Mana.Cards.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Services
{
    public interface ICardService
    {
        CardInfo GetCardInfo(string barcode);
        CardInfo Resolve(DateTime birthdate, string phone);
        RedeemRule GetRedeemRule();
    }
}
