using System;

namespace rabbit_queue_publisher_and_receiver.net
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var msgEnviar = new ObjetoPersonalizado { Id = Guid.NewGuid(), Mensagem = "Olá" + new Random().Next(1, 8).ToString() };

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    public class ObjetoPersonalizado
    {
        public Guid Id { get; set; }
        public string Mensagem { get; set; }
    }
}
