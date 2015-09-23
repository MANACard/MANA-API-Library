using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class SaleDescriptor
    {
        public SaleDescriptor()
        {
            Fields = new HashSet<SaleDescriptorField>(new SaleDescriptorFieldEqualityComparer());
        }

        public string Id { get; set; }

        public HashSet<SaleDescriptorField> Fields { get; private set; }
    }

    class SaleDescriptorFieldEqualityComparer : IEqualityComparer<SaleDescriptorField>
    {
        public bool Equals(SaleDescriptorField x, SaleDescriptorField y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(SaleDescriptorField obj)
        {
            return obj.GetHashCode();
        }
    }
}
