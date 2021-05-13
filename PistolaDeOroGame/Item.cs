using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
    public enum Artifacts { goldPistol = 1 };

    public class Item
    {
        public Artifacts ArtifactItem { get; }
        public List<Item> Items { get; } // do we want to have it be a List of Item or artifacts? shouldnt it be tied to the enum?

        public Item(Artifacts artifactItem)
        {
            ArtifactItem = artifactItem;
        }

        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
    }
}
