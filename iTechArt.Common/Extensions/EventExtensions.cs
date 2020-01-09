using System;

namespace TicTacToe.Common.Extensions
{
    public static class EventExtensions
    {
        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) 
            where TEventArgs: EventArgs
        {
            eventHandler?.Invoke(sender, e);
        }

        public static void Raise(this EventHandler eventHandler, object sender)
        {
            eventHandler?.Invoke(sender, EventArgs.Empty);
        }
    }
}