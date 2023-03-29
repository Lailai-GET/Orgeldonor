using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orgeldonor
{
    internal class Kidney
    {
        private bool _isGood;

        public Kidney(bool isGood)
        {
            _isGood = isGood;
        }

        public bool IsGood()
        {
            return _isGood;
        }

        public void ChangeStatus()
        {
            _isGood = !_isGood;
        }
    }
}
