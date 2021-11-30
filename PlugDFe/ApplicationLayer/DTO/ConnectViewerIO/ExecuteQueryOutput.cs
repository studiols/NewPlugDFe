using System.Data;

namespace PlugDFe.ApplicationLayer.DTO.ConnectViewerIO
{
    public class ExecuteQueryOutput
    {
        public ExecuteQueryOutput(DataTable dt, bool success)
        {
            Dt = dt;
            Success = success;
        }

        public DataTable Dt { get; set; }
        public bool Success { get; set; }
    }
}
