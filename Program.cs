decimal gastoNoMes, investimento;
double dividendYield;

Console.WriteLine("-Adulto Simulator-\n");

Console.Write("Gastos mensais (em R$)...:");
gastoNoMes = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");
dividendYield = Convert.ToDouble(Console.ReadLine());

investimento = gastoNoMes / Convert.ToDecimal(dividendYield / 100);

Console.WriteLine($"\nPara receber {gastoNoMes:C} por mês com rendimentos de {dividendYield:N1}% você precisa ter investido {investimento:C}.");