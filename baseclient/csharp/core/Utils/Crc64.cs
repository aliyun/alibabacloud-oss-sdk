namespace AlibabaCloud.OSS.Utils
{
    internal class Crc64
    {
        private ulong[] _table;
        private object _lock = new object();
        private const int GF2_DIM = 64; /* dimension of GF(2) vectors (length of CRC) */

        public ulong CrcValue { get; private set; }

        internal Crc64()
        {
            InitECMA();
        }

        private void GenStdCrcTable(ulong poly)
        {

            _table = new ulong[256];

            for (uint n = 0; n < 256; n++)
            {
                ulong crc = n;
                for (int k = 0; k < 8; k++)
                {
                    if ((crc & 1) == 1)
                    {
                        crc = (crc >> 1) ^ poly;
                    }
                    else
                    {
                        crc = (crc >> 1);
                    }
                }
                _table[n] = crc;
            }
        }

        private ulong TableValue(ulong[] table, byte b, ulong crc)
        {
            unchecked
            {
                return (crc >> 8) ^ table[(crc ^ b) & 0xffUL];
            }
        }

        internal void Init(ulong poly)
        {
            if (_table == null)
            {
                lock(_lock)
                {
                    if (_table == null)
                    {
                        GenStdCrcTable(poly);
                    }
                }
            }
        }

        private void InitECMA()
        {
            Init(0xC96C5795D7870F42);
        }

        internal ulong Compute(byte[] bytes, int start, int size, ulong crc)
        {
            crc = ~crc;
            for (var i = start; i < start + size; i++)
            {
                crc = TableValue(_table, bytes[i], crc);
            }
            crc = ~crc;

            CrcValue = crc;
            return crc;
        }

        internal ulong Compute(byte[] bytes, int start, int size)
        {
            CrcValue = ~CrcValue;
            for (var i = start; i < start + size; i++)
            {
                CrcValue = TableValue(_table, bytes[i], CrcValue);
            }
            CrcValue = ~CrcValue;

            return CrcValue;
        }

    }
}
