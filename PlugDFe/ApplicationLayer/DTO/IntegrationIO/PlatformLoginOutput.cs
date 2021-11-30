using System;
using System.Collections.Generic;

namespace PlugDFe.ApplicationLayer.DTO.IntegrationIO
{
    public class PlatformLoginOutput
    {
        public int acao { get; set; }
        public bool autorizado { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string msg { get; set; }
        public string status { get; set; }
        public string ip { get; set; }
        public bool userAdmin { get; set; }
        public DateTime dtCad { get; set; }
        public List<object> empresa { get; set; }
    }
}
