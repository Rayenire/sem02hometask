int n = Convert.ToInt32(Console.ReadLine());

void n1 (int n) {
  if (n == 6 || n == 7) {
  Console.WriteLine("this is weekend");
  }
  else if (n < 1 || n > 7) {
    Console.WriteLine("this is not the day of the week at all");
  }
  else Console.WriteLine("this isn't weekend");
}

n1(n);

