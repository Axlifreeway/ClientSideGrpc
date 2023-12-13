using AnimalHealth.Application.Models;


namespace ClientSideGrpc.Extentions
{
    public static class StateExtetion
    {
        public static string ToString(this ReportStateModel state)
        {
            return state.Name;
        }
    }
}
