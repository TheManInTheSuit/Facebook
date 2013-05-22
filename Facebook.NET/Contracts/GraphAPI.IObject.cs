using System;

namespace Facebook
{
    public static partial class GraphApi
    {
        public interface IObject
        {
            string ID { get; set; }

            string Name { get; set; }
        }
    }
}