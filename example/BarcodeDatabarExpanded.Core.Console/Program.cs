using System.Threading.Tasks;

namespace BarcodeDatabarExpanded.Core.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // See each barcode file to see how you can save to a file or a MemoryStream.
            await ExampleDatabarExpanded.CreateAsync("barcode_databarexpanded.png");
        }
    }
}
