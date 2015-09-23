using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class SaleDescriptorField
    {
        public string Name { get; set; }

        public string DisplayName
        {
            get
            {
                return string.IsNullOrEmpty(_displayName) ? Name : _displayName;
            }
            set
            {
                _displayName = value;
            }

        }

        private string _displayName { get; set; }
        public object Value { get; set; }
    }
}
