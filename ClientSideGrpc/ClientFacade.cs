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

        public ClientFacade()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:8080");
            InspectionClient = new InspectionProto.InspectionProtoClient(channel);
            VaccinationClient = new VaccinationProto.VaccinationProtoClient(channel);
        }

        public void AddContract(ContractModel model)
        {
            //не реализованочы
        }

        public void DeleteContract(ContractModel model)
        {
            //не реализовано
        }

        public void EditContract(ContractModel model)
        {
            //не реализовано
        }

        public List<string> GetContracts(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return null;
        }

        public void AddOrganisation(OrganizationModel model)
        {
            //не реализовано
        }

        public void DeleteOrganisation(OrganizationModel model)
        {
            //не реализовано
        }

        public void EditOrganisation(OrganizationModel model)
        {
            //не реализовано
        }

        public List<string> GetOrganisations()
        {
            return null;
        }

        public void AddVaccination(VaccinationAddModel model)
        {
            VaccinationClient.AddVaccination(model);
        }

        public void DeleteVaccination(VaccinationLookup model)
        {
            VaccinationClient.DeleteVaccination(model);
        }

        public void EditVaccination(VaccinationModel model)
        {
            VaccinationClient.UpdateVaccination(model);
        }

        public VaccinationModelList GetVaccinations(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return VaccinationClient.GetVaccinations(request);
        }

        public void AddInspection(InspectionAddModel model)
        {
            InspectionClient.AddInspection(model);
        }

        public void DeleteInspection(InspectionLookup model)
        {
            InspectionClient.DeleteInspection(model);
        }

        public void EditInspection(InspectionModel model)
        {
            InspectionClient.UpdateInspection(model);
        }

        public InspectionModelList GetInspections(Google.Protobuf.WellKnownTypes.Empty request)
        {
            return InspectionClient.GetInspections(request);
        }
    }
}
