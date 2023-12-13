using System.ComponentModel;

namespace ClientSideGrpc.Views
{
    public class ReportView
    {
        public int Id { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Создатель")]
        public UserView Creator { get; set; }
        [DisplayName("Состояние")]
        public ReportStateView State { get; set; }  

        public List<ReportValueView> Values { get; set; } = new List<ReportValueView>();

        public ReportView() { } 
    }
}
