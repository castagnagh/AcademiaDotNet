using System;
using System.Collections.Generic;

namespace TestandoASPNETMVC.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Emails = new HashSet<Email>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<Email> Emails { get; set; }
    }
}
