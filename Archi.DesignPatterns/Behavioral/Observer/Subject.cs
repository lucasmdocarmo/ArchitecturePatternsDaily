using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Behavioral.Observer
{
    internal class Subject : IObservable
    {
        public List<IObserver> observerList = new List<IObserver>();

        private bool _HasChanged = false;
        public bool HasChanged
        {
            get
            {
                return _HasChanged;
            }
            set
            {
                _HasChanged = value;
            }
        }

        public int Value { get; set; }

        public void ChangeValue(int value)
        {
            if (Value != value)
            {
                Value = value;
                Notify(value);
            }
        }
        public void Notify(int value)
        {
            foreach (var item in observerList)
            {
                item.Update(value);
            }
        }

        public void Register(IObserver _observer)
        {
            observerList.Add(_observer);
        }

        public void Unregister(IObserver _observer)
        {
            observerList.Remove(_observer);
        }
    }
}
