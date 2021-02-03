namespace Atividade03.Models
{
    public class Dados
    {
        public static Agendamento agendado = new Agendamento();

        public static void Inserir(Agendamento agenda){
            agendado.Nome = agenda.Nome;
            agendado.Telefone = agenda.Telefone;
            agendado.Data = agenda.Data;
            agendado.Animal = agenda.Animal;
            agendado.Necessidade = agenda.Necessidade;
        }

        public static Agendamento Listar(){
            return agendado;
        }
    }
}