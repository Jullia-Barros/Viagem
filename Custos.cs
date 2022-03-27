
namespace Viagem
{
   internal class Custos
   {
       public Custos()
       {

       }
  
 public String calcularViagem(Percurso p)
 {
   return "totalPercurso= "+ p.getKmPercorrida()*p.getvalorCombustivel()
   +p.getvalorPedagio();
   
   }
  }
 }