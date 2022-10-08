using System;

namespace TezKontrol.Models
{
    internal class foreignKeyAttribute : Attribute
    {
        private string v;

        public foreignKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}