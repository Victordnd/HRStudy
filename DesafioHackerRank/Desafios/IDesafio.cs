namespace DesafioHackerRank.Desafios
{
    public interface IDesafio
    {
        string Codigo { get; }      
        string Nome { get; }       
        void Executar();            
    }
}
