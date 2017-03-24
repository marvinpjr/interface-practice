using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingWithInterfaces
{
    public interface IFlammable
    {
        bool IsOnFire { get; }
        void Burn();
    }

    public class Paper : IFlammable
    {
        private bool _isOnFire;

        public bool IsOnFire
        {
            get { return _isOnFire; }
        }

        public Paper()
        {
            _isOnFire = false;
        }

        public void Burn()
        {
            _isOnFire = true;
        }
    }

    public class TrashBag : IFlammable
    {
        private bool _isOnFire;
        private List<IFlammable> _trashItems;

        public TrashBag()
        {
            _trashItems = new List<IFlammable>();
            _isOnFire = false;
        }

        public bool IsOnFire
        {
            get { return _isOnFire; }
        }

        public void Add(IFlammable flammableItem)
        {
            _trashItems.Add(flammableItem);
        }

        public void Burn()
        {
            _isOnFire = true;
            foreach (IFlammable trashItem in _trashItems)
            {
                trashItem.Burn();
            }
        }
    }

    public class Car : IFlammable
    {
        private bool _isOnFire;
        private List<IFlammable> _itemsInTrunk;

        public Car()
        {
            _itemsInTrunk = new List<IFlammable>();
            _isOnFire = false;
        }

        public bool IsOnFire
        {
            get { return _isOnFire; }
        }

        public void ThrowInTrunk(IFlammable flammableItem)
        {
            _itemsInTrunk.Add(flammableItem);
        }

        public void Burn()
        {
            _isOnFire = true;
            foreach (IFlammable trashItem in _itemsInTrunk)
            {
                trashItem.Burn();
            }
        }
    }


    public class Furnace
    {
        private List<IFlammable> _kindle;
        public Furnace()
        {
            _kindle = new List<IFlammable>();
        }

        public void Add(IFlammable flammableItem)
        {
            _kindle.Add(flammableItem);
        }

        public void Light()
        {
            foreach (IFlammable flammableItem in _kindle)
            {
                flammableItem.Burn();
            }
        }
    }
}
