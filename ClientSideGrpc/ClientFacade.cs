using AnimalHealth.Application.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;

namespace ClientSideGrpc
{
    public class ClientFacade
    {
        private InspectionProto.InspectionProtoClient inspectionClient { get; set; }
        private VaccinationProto.VaccinationProtoClient vaccinationClient { get; set; }
        private ContractProto.ContractProtoClient contractClient { get; set; }
        private OrganizationProto.OrganizationProtoClient organisationClient { get; set; }
        private OtherResourceProto.OtherResourceProtoClient otherResourceClient { get; set; }
        private ReportProto.ReportProtoClient reportClient { get; set; }

        private AuthProto.AuthProtoClient roleClient { get; set; }

        /// <summary>
        /// Конструктор фасада, инициализирующий подключение и клиентов
        /// </summary>
        public ClientFacade()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:8080");
            inspectionClient = new InspectionProto.InspectionProtoClient(channel);
            vaccinationClient = new VaccinationProto.VaccinationProtoClient(channel);
            contractClient = new ContractProto.ContractProtoClient(channel);      
            organisationClient = new OrganizationProto.OrganizationProtoClient(channel);
            otherResourceClient = new OtherResourceProto.OtherResourceProtoClient(channel);
            reportClient = new ReportProto.ReportProtoClient(channel);
            roleClient = new AuthProto.AuthProtoClient(channel);
        }

        public RoleModel Authorize(UserLoginModel user)
        {
            return roleClient.Authorize(user);
        }

        /// <summary>
        /// Метод фасада для добавления контракта принимает на вход модель контракта
        /// </summary>
        public void AddContract(ContractAddModel model)
        {
            contractClient.GetContracts(new Empty());
            contractClient.AddContract(model);
        }

        /// <summary>
        /// Метод фасада для удаления контракта принимает на вход модель контракта
        /// </summary>
        public void DeleteContract(ContractLookup model)
        {
            contractClient.DeleteContract(model);
        }

        /// <summary>
        /// Метод фасада для изменить контракт принимает на вход модель контракта
        /// </summary>
        public void EditContract(ContractModel model)
        {
            contractClient.GetContracts(new Empty());
            contractClient.UpdateContract(model);
        }

        /// <summary>
        /// Метод фасада для ... принимает на вход запрос протобаф
        /// </summary>
        public ContractModelList GetContracts(Empty request)
        {
            return contractClient.GetContracts(request);
        }

        /// <summary>
        /// Метод фасада для добавления организации принимает на вход модель организации
        /// </summary>
        public void AddOrganisation(OrganizationAddModel model)
        {
            organisationClient.GetOrganizations(new Empty());
            organisationClient.AddOrganization(model);
        }

        /// <summary>
        /// Метод фасада для удаления организации принимает на вход модель организации
        /// </summary>
        public void DeleteOrganisation(OrganizationLookup model)
        {
            organisationClient.DeleteOrganization(model);
        }

        /// <summary>
        /// Метод фасада для изменения организации принимает на вход модель организации
        /// </summary>
        public void EditOrganisation(OrganizationModel model)
        {
            organisationClient.GetOrganizations(new Empty());
            organisationClient.UpdateOrganization(model);
        }

        /// <summary>
        /// Метод фасада для получения листа организаций принимает на вход запрос протобаф
        /// </summary>
        public OrganizationModelList GetOrganisations(Empty request)
        {
            return organisationClient.GetOrganizations(request);
        }

        /// <summary>
        /// Метод фасада для добавления вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void AddVaccination(VaccinationAddModel model)
        {
            vaccinationClient.GetVaccinations(new Empty());
            vaccinationClient.AddVaccination(model);
        }

        /// <summary>
        /// Метод фасада для удаления вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void DeleteVaccination(VaccinationLookup model)
        {
            vaccinationClient.DeleteVaccination(model);
        }

        /// <summary>
        /// Метод фасада для изменения вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void EditVaccination(VaccinationModel model)
        {
            vaccinationClient.GetVaccinations(new Empty());
            vaccinationClient.UpdateVaccination(model);
        }

        /// <summary>
        /// Метод фасада для получения листа вакцинаций принимает на вход запрос протобаф
        /// </summary>
        public VaccinationModelList GetVaccinations(Empty request)
        {
            return vaccinationClient.GetVaccinations(request);
        }

        /// <summary>
        /// Метод фасада для добавления осмотра принимает на вход модель модель
        /// </summary>
        public void AddInspection(InspectionAddModel model)
        {
            inspectionClient.GetInspections(new Empty());
            inspectionClient.AddInspection(model);
        }

        /// <summary>
        /// Метод фасада для удаления осмотра принимает на вход модель осмотра
        /// </summary>
        public void DeleteInspection(InspectionLookup model)
        {
            inspectionClient.DeleteInspection(model);
        }

        /// <summary>
        /// Метод фасада для изменения осмотра принимает на вход модель осмотра
        /// </summary>
        public void EditInspection(InspectionModel model)
        {
            inspectionClient.GetInspections(new Empty());
            inspectionClient.UpdateInspection(model);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public InspectionModelList GetInspections(Empty request)
        {
            return inspectionClient.GetInspections(request);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public AnimalModelList GetAnimals(Empty request)
        {
            return otherResourceClient.GetAnimals(request);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public LocalityModelList GetLocalities(Empty request)
        {
            return otherResourceClient.GetLocalities(request);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public UserModelList GetUsers(Empty request)
        {
            return otherResourceClient.GetUsers(request);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public VaccineModelList GetVaccines(Empty request)
        {
            return otherResourceClient.GetVaccines(request);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public DiseaseModelList GetDiseases(Empty request)
        {
            return otherResourceClient.GetDiseases(request);
        }

        /// <summary>
        /// Метод реестра осмотров для получения отчёта с группировкой по населённым пунктам и болезням.
        /// </summary>
        /// <param name="GetReport">Данные для формирования отчёта</typeparam>
        public ReportModel GetDiseaseReport(GetReport request)
        {
            return inspectionClient.GetDiseaseReport(request);
        }

        /// <summary>
        /// Метод реестра осмотров для получения отчёта с группировкой 
        /// по населённым пунктам и типам животных.
        /// </summary>
        /// <param name="GetReport">Данные для формирования отчёта</typeparam>
        public ReportModel GetAnimalTypeReport(GetReport request)
        {
            return inspectionClient.GetAnimalTypeReport(request);
        }

        /// <summary>
        /// Метод реестра вакцинаций для получения отчёта с группировкой 
        /// по населённым пунктам и типам животных.
        /// </summary>
        /// <param name="GetReport">Данные для формирования отчёта</typeparam>
        public ReportModel GetVaccinationReport(GetReport request)
        {
            return vaccinationClient.GetVaccinationReport(request);
        }

        /// <summary>
        /// Метод реестра отчётов для получения отчётов пользователя
        /// </summary>
        /// <param name="ReportUserName">Данные пользователя</typeparam>
        public ReportModel GetReport(ReportLookup request)
        {     
            return reportClient.GetReport(request);
        }

        /// <summary>
        /// Метод реестра отчётов для удаления пользователя
        /// </summary>
        /// <param name="ReportLookup">Id отчёта</typeparam>
        public void DeleteReport(ReportLookup request)
        {
            reportClient.DeleteReport(request);
        }

        /// <summary>
        /// Метод реестра отчётов для получения отчётов по пользователю
        /// </summary>
        public ReportModelList GetReportsByUser(UserModel request)
        {
            return reportClient.GetReportsByUser(request);
        }

        /// <summary>
        /// Метод реестра отчётов для получения отчётов по периоду дат.
        /// </summary>
        public ReportModelList GetReportsByPeriod(DatesPeriod request)
        {
            return reportClient.GetReportsByPeriod(request);
        }


        /// <summary>
        /// Метод реестра отчётов для изменения состояния отчёта.
        /// </summary>
        public void GoNextState(ChangeReportState request)
        {
            reportClient.GoNextState(request);
        }

        /// <summary>
        /// Метод реестра отчётов для получения данных об отчётах
        /// </summary>
        public ReportMetaData GetReportMetaData(Empty request)
        {
            return reportClient.GetReportMetaData(request);
        }
    }
}
    