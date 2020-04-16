using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
    class UniqueItem
    {
        private int _id;

        private static int LastId = 1;

        public UniqueItem()
        {
            _id = LastId + 1;
            LastId = _id;
        }

        public UniqueItem(int id)
        {
            _id = id;
            LastId = _id;
        }
    }
}
