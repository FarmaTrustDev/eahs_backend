using System.Collections.Generic;
using System;

namespace EAHS.DTOS
{
    public class FiltersRequestDTO : PaginateDTO
    {
        public int? Id { get; set; }
        public int? ExcludedId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public List<int> Ids { get; set; }
        public int? OrganizationId { get; set; }
        public List<int> OrganizationsId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAlias { get; set; }
        public int? OrganizationTypeId { get; set; }
        public int? HospitalId { get; set; }
        public List<int?> HospitalIds { get; set; }
        public string OrganizationTypeName { get; set; }
        public string OrganizationTypeAlias { get; set; }
        public int? ScreeningTemplateId { get; set; }
        public bool? ScreeningStatus { get; set; }
        public int? ScreeningCategoryId { get; set; }
        public int? TreatmentTypeId { get; set; }
        public int? Type { get; set; }
        public int? TreatmentId { get; set; }
        public bool? Active { get; set; }
        public int? ManufacturerId { get; set; }
        public int? LogisticId { get; set; }
        public int? CountryId { get; set; }
        public string CountryCode { get; set; }
        public string Iso { get; set; }
        public bool? IsSchedule { get; set; }
        public bool? HospitalCollectionStatus { get; set; }
        public int? Status { get; set; }
        public List<int> Statuses { get; set; }
        public string Name { get; set; }
        public string PatientEnrollmentNumber { get; set; }
        public int? Gender { get; set; }
        public string ManufacturerPUID { get; set; }
        public string HospitalPUID { get; set; }
        public string LogisticPUID { get; set; }
        public string Email { get; set; }
        public string PUID { get; set; }
        public Guid GlobalId { get; set; }
        public int? ManufacturerStatus { get; set; }
        public int? LogisticStatus { get; set; }
        public int? LogisticStatusNot { get; set; }
        public bool? IsShipmentReceived { get; set; }
        public int? Direction { get; set; }
        public string TreatmentTypeName { get; set; }
        public bool? OnlyTodayTreatment { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime NewAppointmentDate { get; set; }
    }
}
