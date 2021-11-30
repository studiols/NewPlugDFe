using PlugDFe.Domain.Enums;
using PlugDFe.Domain.Services;
using PlugDFe.Domain.ValueObjects;
using System;

namespace PlugDFe.Domain.Entities
{
    public class PlugTask : Notifiable<Notification>
    {
        public PlugTask(int idPlugAddress, int action, int readMode, DateTime lastExecuteDate) : base()
        {
            IdPlugAddress = idPlugAddress;                        
            Action = ConvertAction(action);
            ReadMode = ConvertReadMode(readMode);
            LastExecuteDate = lastExecuteDate;
        }

        public int Id { get; private set; }
        public int IdPlugAddress { get; private set; }
        public int IdConnectViewer { get; set; }        
        public EReadMode ReadMode { get; private set; }
        public EAction Action { get; private set; }        
        public DateTime LastExecuteDate { get; private set; }

        public string GetAction()
        {
            if (Action == EAction.MANTER) { return "Manter"; }
            else if (Action == EAction.EXCLUIR) { return "Excluir"; }
            else if (Action == EAction.ENVIAR_PERDIDOS_E_EXCLUIR) { return "Enviar Documentos Perdidos E Excluir"; }
            else if (Action == EAction.EXCLUIR_REGISTROS_VELHOS) { return "Excluir Registros Velhos"; }
            else { return "Inválido"; }
        }

        public string GetReadMode()
        {
            if (ReadMode == EReadMode.DOCUMENTOS_ATUAIS) { return "Documentos Atuais"; }
            else if (ReadMode == EReadMode.DOCUMENTOS_DO_DIA_ANTERIOR) { return "Documentos Do Dia Anterior"; }
            else if (ReadMode == EReadMode.DOCUMENTOS_CRIADOS_APOS_ULTIMA_EXECUCAO) { return "Documentos Criados Após Ultima Data De Execução"; }
            else { return "Não Encontrado"; }
        }

        public EAction ConvertAction(int action)
        {
            if (action == 1) { return EAction.MANTER; }
            else if (action == 2) { return EAction.EXCLUIR; }
            else if (action == 3) { return EAction.ENVIAR_PERDIDOS_E_EXCLUIR; }
            else if (action == 4) { return EAction.EXCLUIR_REGISTROS_VELHOS; }
            else { return EAction.INVALIDO; }
        }
        
        public EReadMode ConvertReadMode(int readMode)
        {
            if (readMode == 1) { return EReadMode.DOCUMENTOS_ATUAIS; }
            else if (readMode == 2) { return EReadMode.DOCUMENTOS_DO_DIA_ANTERIOR; }
            else if (readMode == 3) { return EReadMode.DOCUMENTOS_CRIADOS_APOS_ULTIMA_EXECUCAO; }
            else { return EReadMode.INVALIDO; }
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public void SetIdConnectViewer(int idConnectViewer)
        {
            IdConnectViewer = idConnectViewer;
        }

        public void SetLastExecuteDate(DateTime lastExecuteDate)
        {
            this.LastExecuteDate = lastExecuteDate;
        }
    }
}
