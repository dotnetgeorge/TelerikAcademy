namespace BitArray64Program.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong[] bits;
        private int position;

        public BitArray64()
        {
            this.bits = new ulong[0];
            this.position = int.MinValue;
        }

        public BitArray64(int length)
        {
            this.bits = new ulong[length];
            this.position = 0;
        }

        public int Length
        {
            get { return this.bits.Length; }
        }

        public ulong this[int index]
        {
            get { return this.bits[index]; }
            set { this.bits[index] = value; }
        }

        public void Add(ulong bit)
        {
            if (this.position >= this.bits.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.bits[position] = bit;
            this.position++;
        }

        public override bool Equals(object value)
        {
            BitArray64 bitArray64 = (BitArray64)value;
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != bitArray64[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                ulong hashCode = 19;
                foreach (var item in this.bits)
                {
                    hashCode += (ulong)item.GetHashCode();
                    hashCode *= 23;
                }
                hashCode += (ulong)this.bits.Length.GetHashCode();
                return (int)hashCode;
            }
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }

        public BitArray64Enum GetEnumerator()
        {
            return new BitArray64Enum(bits);
        }
    }
}
