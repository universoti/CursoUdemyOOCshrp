using System;
using System.Collections.Generic;
using System.Text;

namespace ListaNomesCachorro.Pessoas
{
    public class proprietario
    {
        public string nome { get; set; }

        private double _vlcarteira;

        public double vlcarteira
        {
            get { return _vlcarteira; }
            set { _vlcarteira = value; }
        }

        private double _vlcarteira2;

    }
}
