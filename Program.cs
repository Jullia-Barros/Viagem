namespace Viagem
{
    internal class Program
    {
        static void main(String[] args)
        {
            Percurso p= new Percurso();
            Custo c=new Custos();

            int op=0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção"+ "\n1-Novo Percurso\n2- Listar Percurso\n3-Calcular Custos\n0-Sair");
                op=int.Parse(Console.ReadLine());

                switch (op)
                {
            case 0:
                 Environment.Exit(0);
                 break;
            case 1:
                 Console.WriteLine("Informe a Km Percorrida:");
                 double KmPercorrida=double.Parse(Console.ReadLine());
                 Console.WriteLine("Informe o valor do combustivel: ");
                 double valorCombustivel=double.Parse(Console.ReadLine());
                 Console.WriteLine ("Informe o valor do Pedagio:");
                 double valorPedagio=double.Parse(Console ReadLine());
                 p=new Percurso(KmPercorrida, valorCombustivel, valorPedagio);
                 break;
             case 2:
                  Console.WriteLine(p.listarPercurso());
                  break;
            case 3:
                  Console.WriteLine(c.calcularViagem(p));
                 break;

              default:
                Console.WriteLine("Opção Inválida!");
                break;
                }
                
                Console.ReadKey();

            }while (op!=0)
        }
    }
}