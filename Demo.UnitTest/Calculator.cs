using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App
{
    /// <summary>
    /// Phép toán
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Tính tổng 2 số
        /// </summary>
        /// <param name="x">Số hạng thứ nhất</param>
        /// <param name="y">Số hạng thứ hai</param>
        /// <returns>Tổng 2 số</returns>
        public long Add(long x, long y)
        {
            return x + y;
        }

        /// <summary>
        /// Tính hiệu 2 số
        /// </summary>
        /// <param name="x">Số bị trừ</param>
        /// <param name="y">Số trừ</param>
        /// <returns>Hiệu 2 số</returns>
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Tính tích 2 số
        /// </summary>
        /// <param name="x">Thừa số thứ nhất</param>
        /// <param name="y">Thừa số thứ hai</param>
        /// <returns>Tích 2 số</returns>
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Tính thương 2 số
        /// </summary>
        /// <param name="x">Số bị chia</param>
        /// <param name="y">Số chia</param>
        /// <returns>Thương 2 số</returns>
        public double Divide(double x, double y)
        {
            if (y.Equals(0))
            {
                throw new DivideByZeroException(x + " khong chia duoc cho 0");
            }
            else
            {
                return Math.Round(x / y, 3);
            }

        }
    }
}
