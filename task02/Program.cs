int n = Convert.ToInt32(Console.ReadLine());
string n1 = Convert.ToString(n);
if (n1.Length > 2){
  Console.WriteLine("Third number - " + n1[2]);
}
else {
  Console.WriteLine("There's no third number");
}
