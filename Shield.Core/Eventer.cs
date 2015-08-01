using System;
using Windows.UI.Xaml;

namespace Shield.Core
{
    public class Eventer
    {
        public event EventHandler Handler;



        protected virtual void OnHandler()
        {
            Handler?.Invoke(this, EventArgs.Empty);
        }
    }
}