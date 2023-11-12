double salarioHora, horasExtras, horasTotais;

Console.WriteLine("      Horas Extras\n");

Console.WriteLine("Digite seu salário por hora:");
salarioHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite quantas horas foram trabalhadas no mês:");
horasTotais = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite quantas horas extras foram feitas:");
horasExtras = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"salario-hora {salarioHora:C}, {horasTotais} horas, sendo {0} horas-extra, salário = {Salario(salarioHora, horasTotais, 0):C}");
Console.WriteLine($"salario-hora {salarioHora:C}, {horasTotais} horas, sendo {horasExtras} horas-extra, salário = {Salario(salarioHora, horasTotais, horasExtras):C}");

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}