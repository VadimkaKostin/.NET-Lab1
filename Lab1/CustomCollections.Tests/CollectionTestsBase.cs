using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections.Tests
{
    public abstract class CollectionTestsBase
    {
        public class TestItem : IComparable<TestItem>
        {
            public int Value { get; set; }

            public int CompareTo(TestItem? other) => this.Value - other.Value;
        }

        public IEnumerable<int> GetDefaultSetForCollection(int amount = 5)
        {
            for (int i = 1; i <= amount; i++)
            {
                yield return i;
            }
        }
    }
}
