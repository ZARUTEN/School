using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class1
    {
        private static Entities3 _context;
        public static Entities3 GetContext()
        {
            if (_context == null)
                _context = new Entities3();
            return _context;
        }
    }
}
