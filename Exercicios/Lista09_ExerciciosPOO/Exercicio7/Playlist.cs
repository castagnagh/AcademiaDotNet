using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Playlist : Musica
    {
        private List<Musica> listaDeMusicas = new List<Musica>();
        private string donoPlaylist;

        public Playlist(string donoPlaylist)
        {
            this.donoPlaylist = donoPlaylist;
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }

        public string EscolherMusica()
        {
            if (listaDeMusicas.Count == 0)
            {
                return "Nenhuma música na playlist";
            }

            Random r = new Random();
            int qtElementosLista = listaDeMusicas.Count;
            int numSorteado = r.Next(0, qtElementosLista);
            return listaDeMusicas[numSorteado].Nome;
        }
    }


}
