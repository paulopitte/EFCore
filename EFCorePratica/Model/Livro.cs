﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePratica.Model
{
   public  class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int AnoPublicacao { get; set; }

    }
}
