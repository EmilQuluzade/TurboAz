using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Turbo.az.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public virtual required List<Image> Image { get; set; }

        public virtual required List<VipPayment> VipPayments { get; set; }
        public virtual required List<PremiumPayment> PremiumPayments { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual required User User { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual required City City { get; set; }
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public virtual required Model Model { get; set; }
        public int YearId { get; set; }
        [ForeignKey("YearId")]
        public virtual required Year Year { get; set; }
        public int MilAge { get; set; }
        public int UnitOfLenghtId { get; set; }
        [ForeignKey("UnitOfLenghtId")]
        public virtual required Unitoflength Unitoflength { get; set; }
        public int ColorId { get; set; }
        [ForeignKey("ColorId")]
        public virtual required Colors Colors { get; set; }
        public int Price { get; set; }
        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId")]
        public virtual required Currency Currency { get; set; }
        public int OwnershipId { get; set; }
        [ForeignKey("OwnershipId")]
        public virtual required Ownership Ownership { get; set; }
        public int  StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual required Status Status { get; set; }
        public int SitsId { get; set; }
        [ForeignKey("SitsId")]
        public virtual required Sits Sits { get; set; }
        public int FuelId { get; set; }
        [ForeignKey("FuelId")]
        public virtual required Fuel Fuel { get; set; }
        public int TransmitternId { get; set; }
        [ForeignKey("TransmitterId")]
        public virtual required Transmitter Transmitter { get; set; }
        public int GearboxId { get; set; }
        [ForeignKey("GearboxId")]
        public virtual required Gearbox Gearbox { get; set; }
        public int EngineCapacityId { get; set; }
        [ForeignKey("EngineCapacityId")]
        public virtual required EngineCapacity EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual required Country Country { get; set; }
        public bool Credit { get; set; }
        public bool Barter { get; set; }
        public Cars()
        {
            Credit = false;
            Barter = false;
        }
        public string VinCode { get; set; }
        public string  MoreInfo { get; set;}
        public int EquipmentId { get; set; }
        public virtual List<EquipmentCar> EquipmentCar { get; set; }





    }
}
