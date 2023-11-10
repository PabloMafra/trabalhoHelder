namespace ProjetoGuardaChuva.Models
{
    public class Medidas 
    {
        public int Id { get; set; }
        public int IdEndereco { get; set; }
        public double Altura { get; set; }
        public double Base { get; set; }
        public double AnguloInclinacao { get; set; }

        public Medidas(double altura, double @base, double anguloInclinacao)
        {
            Altura = altura;
            Base = @base;
            AnguloInclinacao = anguloInclinacao;
        }

        public Medidas(int id, int idEndereco, double altura, double @base, double anguloInclinacao)
        {
            Id = id;
            IdEndereco = idEndereco;
            Altura = altura;
            Base = @base;
            AnguloInclinacao = anguloInclinacao;
        }
    }
}
