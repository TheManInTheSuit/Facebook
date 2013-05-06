using System;

namespace Facebook
{
    public static partial class GraphAPI
    {
        public interface IObject
        {
            string ID { get; set; }
            string Name { get; set; }
        }
    }
}
