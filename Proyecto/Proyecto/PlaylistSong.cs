﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class PlaylistSong
    {
        public string NombrePlaylist;
        public List<Song> Listplay = new List<Song>();
         
        public PlaylistSong(string _nombrepl)
        {
            this.NombrePlaylist = _nombrepl;
            
        }

       

        public void Agregar_cancion(object song);
        {
            
        }

    public string informationPLL()
        {
            string stringaux1 = " ";
            if (listplay.Count == 0)
            {
                return "No hay canciones en la playlist";

            }

            else
            {
                for (int i = 0; i < listplay.Count; i++)
                {
                    stringaux1 += "Cancion" + " " + (i + 1) + "\n";
                    stringaux1 += "============ \n";
                    stringaux1 += listplay[i].Informacioncancion() + "\n";

                    stringaux1 += " ";


                }
                return stringaux1;
            }
        }
    }

}
