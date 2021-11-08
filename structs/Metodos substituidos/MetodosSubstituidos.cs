namespace Programming1.Metodos_substituidos
{
    public class MetodosSubstituidos
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato { Nome = "bichana" };
            gata.Beber();
            gata.Comer();
            gata.Andar();
        }
    }
    class Animal
    {
        public string Nome { get; set; }

        public void Beber()
        {
            System.Console.WriteLine("animal.beber");
        }
        //o virtual permite que faça uma substituição de método:
        public virtual void Comer()
        {
            System.Console.WriteLine("animal.comer");
        }
        public void Andar()
        {
            System.Console.WriteLine("animal.andar");
        }
    }

    class Gato : Animal
    {
        public void Beber()
        {
            System.Console.WriteLine("gato.beber");
        }
        public override void Comer()
        {
            System.Console.WriteLine("gato.comer");
        }
        public void Andar()
        {
            System.Console.WriteLine("gato.andar");
        }
}