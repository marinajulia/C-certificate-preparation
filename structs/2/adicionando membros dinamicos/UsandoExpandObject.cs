using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace Programming._2.Resolucao_de_Sobrecarga
{
    public class UsandoExpandObject
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = "olá, " + mensagem.Para;

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(()=>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "olá, " + mensagem.Para;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);

        }
        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }

}
