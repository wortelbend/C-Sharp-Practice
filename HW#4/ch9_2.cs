using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9
{
    internal class ch9_2
    {
        public class Box
        {
            // 成員變數
            public double Width { get; set; }
            public double Height { get; set; }
            public double Length { get; set; }

            // 建構子
            public Box(double width, double height, double length)
            {
                Width = width;
                Height = height;
                Length = length;
            }

            // 計算體積
            public double Volume()
            {
                return Width * Height * Length;
            }

            // 計算表面積（兩面積相加再乘以 3 面）
            public double Area()
            {
                return 2 * (Width * Height + Width * Length + Height * Length);
            }
        }

    }
}
