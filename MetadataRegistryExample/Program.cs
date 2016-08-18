using Newtonsoft.Json;
using System.IO;

namespace MetadataRegistryExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            Envelope envelope = Envelope.CreateEnvelope(args[0], args[1], File.ReadAllText(args[2]));
            System.Console.WriteLine(JsonConvert.SerializeObject(envelope));
        }
    }
}
