namespace Sample.App.UnitTests
{
    internal class CalculatorTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        public void Add_ValidInput_ReturnsCorrectSum(long x, long y, long expectedResult)
        {
            //arrange - chuẩn bị đầu vào dữ liệu và kết quả mong muấn
            var caculator = new Calculator();

            //act - gọi vào hàm cần test
            long actualResult = caculator.Add(x, y);

            // assert - kiểm tra kết quả mong muấn với thực tế
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void Add_BillNumber_ReturnCorrectSum()
        {
            long x = 2000000000;
            long y = 2000000000;
            var expectedResult = 4000000000;
            var caculator = new Calculator();
            long actualResult = caculator.Add(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(1, 2, 0.5)]
        [TestCase(2, 1, 2)]
        [TestCase(4, 2, 2)]
        [TestCase(-4, 2, -2)]
        [TestCase(-4, -2, 2)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 3, 0.333)]
        public void Divide_ValidInput_ReturnCorrectDevide(int x, int y, double expectedResult)
        {
            //arrage - chuẩn bị dữ liệu đầu vào và kết quả mong muấn
            var caculator = new Calculator();

            //act - gọi hàm cần test
            double actualResult = caculator.Divide(x, y);

            //assert - kiểm tra kết quả mong muấn với thực tế

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 0)]
        [TestCase(-1, 0)]
        public void Divide_DivideBy0_ThrowException(double x, double y)
        {
            //arrage - dữ liệu đầu vào và kết quả mong muấn
            var calculator = new Calculator();

            //act - gọi hàm cần test
            var ex = Assert.Throws<DivideByZeroException>(() =>
            {
                calculator.Divide(x, y);
            });
            //assest - kiểm tra kết quả mong muấn với thực tế
            Assert.AreEqual(x + " khong chia duoc cho 0", ex.Message.ToString());
        }

    }
}
