﻿namespace NotQuiteLisp.Visitors
{
    public static class VisitorExtensions
    {
        public static TResult Accept<TResult>(this object item, object visitor)
        {
            var visitableItem = new VisitableItem<TResult>(item);
            return visitableItem.Accept(visitor);
        }
    }
}