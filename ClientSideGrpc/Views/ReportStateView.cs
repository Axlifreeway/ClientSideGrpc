namespace ClientSideGrpc.Views
{
    public class ReportStateView
    {
        public string Name { get; set; }   

        public UserView Changer { get; set; }

        public DateTime DateChange { get; set; }

        public ReportStateView() { }

        public override string ToString()
        {
            return Name;
        }
    }
}