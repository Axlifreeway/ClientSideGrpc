using AnimalHealth.Application.Models;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideGrpc
{
    public class ClientFacade
    {
        private InspectionProto.InspectionProtoClient InspectionClient { get; set; }
        private VaccinationProto.VaccinationProtoClient VaccinationClient { get; set; }
        private ContractProto.ContractProtoClient ContractClient { get; set; }

        private OrganizationProto.OrganizationProtoClient OrganisationClient { get; set; }


        /// <summary>
        /// Конструктор фасада, инициализирующий подключение и клиентов
        /// </summary>
        public ClientFacade()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:8080");
            InspectionClient = new InspectionProto.InspectionProtoClient(channel);
            VaccinationClient = new VaccinationProto.VaccinationProtoClient(channel);
            ContractClient = new ContractProto.ContractProtoClient(channel);      
            OrganisationClient = new OrganizationProto.OrganizationProtoClient(channel);
        }

        /// <summary>
        /// Метод фасада для добавления контракта принимает на вход модель контракта
        /// </summary>
        public void AddContract(ContractAddModel model)
        {
            ContractClient.AddContract(model);
        }

        /// <summary>
        /// Метод фасада для удаления контракта принимает на вход модель контракта
        /// </summary>
        public void DeleteContract(ContractLookup model)
        {
            ContractClient.DeleteContract(model);
        }

        /// <summary>
        /// Метод фасада для изменить контракт принимает на вход модель контракта
        /// </summary>
        public void EditContract(ContractModel model)
        {
            ContractClient.UpdateContract(model);
        }

        /// <summary>
        /// Метод фасада для ... принимает на вход запрос протобаф
        /// </summary>
        public ContractModelList GetContracts(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return ContractClient.GetContracts(request);
        }

        /// <summary>
        /// Метод фасада для добавления организации принимает на вход модель организации
        /// </summary>
        public void AddOrganisation(OrganizationAddModel model)
        {
            OrganisationClient.AddOrganization(model);
        }

        /// <summary>
        /// Метод фасада для удаления организации принимает на вход модель организации
        /// </summary>
        public void DeleteOrganisation(OrganizationLookup model)
        {
            OrganisationClient.DeleteOrganization(model);
        }

        /// <summary>
        /// Метод фасада для изменения организации принимает на вход модель организации
        /// </summary>
        public void EditOrganisation(OrganizationModel model)
        {
            OrganisationClient.UpdateOrganization(model);
        }

        /// <summary>
        /// Метод фасада для получения листа организаций принимает на вход запрос протобаф
        /// </summary>
        public OrganizationModelList GetOrganisations(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return OrganisationClient.GetOrganizations(request);
        }

        /// <summary>
        /// Метод фасада для добавления вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void AddVaccination(VaccinationAddModel model)
        {
            VaccinationClient.AddVaccination(model);
        }

        /// <summary>
        /// Метод фасада для удаления вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void DeleteVaccination(VaccinationLookup model)
        {
            VaccinationClient.DeleteVaccination(model);
        }

        /// <summary>
        /// Метод фасада для изменения вакцинации принимает на вход модель вакцинации
        /// </summary>
        public void EditVaccination(VaccinationModel model)
        {
            VaccinationClient.UpdateVaccination(model);
        }

        /// <summary>
        /// Метод фасада для получения листа вакцинаций принимает на вход запрос протобаф
        /// </summary>
        public VaccinationModelList GetVaccinations(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return VaccinationClient.GetVaccinations(request);
        }

        /// <summary>
        /// Метод фасада для добавления осмотра принимает на вход модель модель
        /// </summary>
        public void AddInspection(InspectionAddModel model)
        {
            InspectionClient.AddInspection(model);
        }

        /// <summary>
        /// Метод фасада для удаления осмотра принимает на вход модель осмотра
        /// </summary>
        public void DeleteInspection(InspectionLookup model)
        {
            InspectionClient.DeleteInspection(model);
        }

        /// <summary>
        /// Метод фасада для изменения осмотра принимает на вход модель осмотра
        /// </summary>
        public void EditInspection(InspectionModel model)
        {
            InspectionClient.UpdateInspection(model);
        }

        /// <summary>
        /// Метод фасада для получения листа осмотров принимает на вход запрос протобаф
        /// </summary>
        public InspectionModelList GetInspections(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return InspectionClient.GetInspections(request);
        }
    }
}
