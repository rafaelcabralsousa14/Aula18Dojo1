using System;

namespace Aula18Dojo1 {
    
    public class Jogador {

        public string Nome { get; set; }
        public string Posição { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        public string ConfirmarPosição(){
            if(Posição != "atacante"){
                return "Posição válida";
            }
            if(Posição != "meio campo"){
                return "Posição válida";
            }
            if(Posição != "defesa"){
                return "Posição válida";
            }else{
                System.Console.WriteLine("Digite uma posição válida! Sendo elas: 'defesa', 'atacante' e 'meio campo'");
                Posição = Console.ReadLine();
                return Posição;
            }
        }
        
        public string MostrarDados(){
            return $"Perfil do Jogador \n Nome: {Nome} \n Posição: {Posição} \n Data de nascimento: {Nascimento} \n Nacionalidade: {Nacionalidade} \n Altura: {Altura} \n Peso: {Peso}";
        }

        public int idade { get; set; }

        public int CalcularIdade(){
            int anoNascimento = Int32.Parse(Nascimento.ToString().Split('/', ' ')[2]);
            int data = Int32.Parse(DateTime.Now.ToString().Split('/')[2].Split(' ')[0]);
            idade = data - anoNascimento;
            return idade;
        }

        public int Aposentadoria { get; set; }


        public int CalcularAposentadoria(){
            if(Posição == "defesa"){
                Aposentadoria = 40 - idade ; 
                return Aposentadoria;           
            }
            if(Posição == "atacante"){
                Aposentadoria = 35 - idade;
                return Aposentadoria;
            }
            if(Posição == "meio campo"){
                Aposentadoria = 38 - idade;
                return Aposentadoria;
            }else{
                return 0; 
            }
        }



    }
}