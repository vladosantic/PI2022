using Microsoft.EntityFrameworkCore;

namespace PI2022.Models
{
    [Keyless]
    public class Dashboard
    {
        public IEnumerable<Employees>? Employees { get; set; }
        public IEnumerable<Jobs>? Jobs { get; set; }
        public IEnumerable<Equipment>? Equipment { get; set; }
    }
}
