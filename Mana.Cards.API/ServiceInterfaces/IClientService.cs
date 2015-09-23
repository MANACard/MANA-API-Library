using Mana.Cards.API.Domain;
using Mana.Cards.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.ServiceInterfaces
{
    public interface IClientService
    {
        void CreateClient(Client c, string card);
        void UpdateClient(Client c, string card);
        IEnumerable<ClientViewModel> Search(string firstname, string lastname, string email, string phone);

    }
}
