using System.Threading;

namespace PartsUnlimited.Models
{
    // este es el supercambio
    public class Request
    {
        public CancellationToken CancellationToken { get; set; }
        public int Id { get; set; }
    }
}
