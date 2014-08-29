namespace BitArray64Program.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray64Enum : IEnumerator
    {
        protected ulong[] bits;
        private int position = -1;

        public BitArray64Enum()
        {
            this.bits = new ulong[0];
        }

        public BitArray64Enum(ulong[] bits)
        {
            this.bits = bits;
        }

        public bool MoveNext()
        {
            this.position++;
            return (this.position < this.bits.Length);
        }

        public void Reset()
        {
            this.position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return this.bits[this.position];
                }
                catch (IndexOutOfRangeException ioore)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
