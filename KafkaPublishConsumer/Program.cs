using System;   
using KafkaNet;
using KafkaNet.Model;
using KafkaNet.Protocol;

namespace KafkaPublishConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new KafkaOptions(new Uri("http://evs01cpb592:9092"));
            var router = new BrokerRouter(options);
            var client = new KafkaNet.Producer(router);

            client.SendMessageAsync("testtopic", new[]{ new Message("Hi Hello! Welcome to Kafka!") }).Wait();
            Console.ReadLine();

        }
    }
}
