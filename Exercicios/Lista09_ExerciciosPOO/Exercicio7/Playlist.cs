using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Playlist
    {
        private List<Musica> listaDeMusicas = new List<Musica>();
        public string DonoPlaylist { get; set; }

        public Playlist(string donoPlaylist)
        {
            DonoPlaylist = donoPlaylist;
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }
    }
}
