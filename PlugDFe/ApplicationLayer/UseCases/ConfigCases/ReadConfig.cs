using PlugDFe.Domain.Entities;
using PlugDFe.Domain.Repositories;
using System.Collections.Generic;

namespace PlugDFe.ApplicationLayer.UseCases.ConfigCases
{
    public class ReadConfig
    {
        public IConfigRepository ConfigRepository { get; set; }

        public ReadConfig(IConfigRepository configRepository)
        {
            ConfigRepository = configRepository;
        }

        public List<Config> Execute()
        {
            return ConfigRepository.GetAll();
        }
    }
}
