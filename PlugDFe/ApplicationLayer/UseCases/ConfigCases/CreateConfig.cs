using PlugDFe.Infra.Repositories;
using System;

namespace PlugDFe.ApplicationLayer.UseCases.ConfigCases
{
    public class CreateConfig
    {
        public ConfigRepository ConfigRepository { get; set; }

        public CreateConfig(ConfigRepository configRepository)
        {
            ConfigRepository = configRepository;
        }

        public void Execute(decimal execInterval)
        {            
            ConfigRepository.Save(
                "Connect_Config_IntervaloExecucao",
                "N",
                Convert.ToInt32(execInterval).ToString()
            );
        }
    }
}
