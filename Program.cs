// Задача 5  Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("TASK 5 ");
Console.Write("INTER THREE DIGIT NUMBER: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("SECOND Digit -> "+stringNumber[1]);

Console.WriteLine("TASK 13 ");

Console.Write("INTER DIGIT: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Third digit -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> No third digit");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Inter digit which means day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Dayoff) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("There is no day of the week");
  }
  else Console.WriteLine("(There is not a dayoff) -> No");
}

CheckingTheDayOfTheWeek(dayNumber);