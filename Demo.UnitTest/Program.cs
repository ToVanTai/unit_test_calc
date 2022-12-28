/*
 *  Chạy thử ứng dụng 
 *  Tạo project NUnit: Sample.App.UnitTests
 *  Tạo class CalculatorTests --> Test class Calculator
 *  Thực hiện viết unit test cho 2 hàm Add và Divide
 *  Thêm case test cho hàm Divide và refactor hàm Divide trong class Calculator
 */

using Sample.App;

var calculator = new Calculator();
int x, y;

x = 1;
y = 2;
var resultAdd = calculator.Add(x, y);
Console.WriteLine($"Ket qua phep cong: {x} + {y} = {resultAdd}");

x = 4;
y = 2;
var resultDivide = calculator.Divide(4, 2);
Console.WriteLine($"Ket qua phep chia: {x} / {y} = {resultDivide}");
