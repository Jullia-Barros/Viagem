namespace Viagem
{
    internal class Percurso
{

 private double KmPercorrida;
 private double valorCombustivel;
 private double valorPedagio;

 public double getKmPercorrida()
 {
   return KmPercorrida;
 }
  public void setKmPercorrida(double KmPercorrida)
  {
      this.KmPercorrida=KmPercorrida;
  }
  public double getvalorCombustivel()
  {
      return valorCombustivel;
  }
  public void setvalorCombustivel(double valorCombustivel)
  {
      this.valorCombustivel=valorCombustivel;
  }
  public double getvalorPedagio()
  {
      return valorPedagio;
  }
  public void setvalorPedagio(double valorPedagio)
  {
     this.valorPedagio=valorPedagio;
  }

  public Percurso()
  {
       KmPercorrida=0;
       valorCombustivel=0;
       valorPedagio=0;
  }
  public Percurso(double KmPercorrida, double valorCombustivel, double valorPedagio)
   {
       this.KmPercorrida=KmPercorrida;
       this.valorCombustivel=valorCombustivel;
       this.valorPedagio=valorPedagio;
   } 

   public String listarPercurso()
   {
     {
<<<<<<< Updated upstream
         return "Km Percorrida"+ KmPercorrida + "\n
         valor do Combustivel" + valorCombustivel + 
         "\nvalor do Pedagio" +valorPedagio;
=======
         return "Km Percorrida"+ KmPercorrida +"\nvalor do Combustivel" + valorCombustivel \n
         valor do Pedagio :" +valorPedagio;
>>>>>>> Stashed changes
     }

   }
