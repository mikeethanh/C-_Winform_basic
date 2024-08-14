using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1_btvn
{
    internal class dayso
    {
        private int[] numbers;

        public void NhapDaySo(string input)
        {
            numbers = input.Split(',').Select(int.Parse).ToArray();
        }

        public void SapXepDaySo()
        {
            Array.Sort(numbers);
        }

        public string InDaySo()
        {
            return string.Join(", ", numbers);
        }
    }
}
