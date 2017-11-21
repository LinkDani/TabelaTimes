using System.Collections.Generic;


namespace Tabela
{
    public class Campeonato
    {

        public List<Equipe> equipes;

        public Campeonato(){
            this.equipes = new List<Equipe>();
        }

        public void resultado(){
            this.equipes.ForEach(delegate(Equipe e){
                System.Console.WriteLine($"Equipe: {e.nome} - Pontuação: {e.pontuacao}");
            });

        }

        public void rebaixados(){
             if(equipes.Count == 1){
                System.Console.WriteLine("Contém Apenas: ");
                System.Console.WriteLine(equipes[equipes.Count - 1].nome);
             }
             else
             {
                 System.Console.WriteLine("Rebaixado: ");
                 System.Console.WriteLine(equipes[equipes.Count - 1].nome);
             }
        }

         public void Campeão(){
                System.Console.WriteLine("Campeão: ");
                System.Console.WriteLine(equipes[0].nome);
             }
    }

}

