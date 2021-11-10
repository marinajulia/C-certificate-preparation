namespace Programming._2.Resolucao_de_Sobrecarga
{
    public class ResolucaoDeSobrecarga
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;
        }

        int Somar(int parcela1, int parcela2)
        {
            return parcela1 + parcela2;
        }
    }
}
