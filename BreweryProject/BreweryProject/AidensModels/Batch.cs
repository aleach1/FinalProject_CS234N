using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryProject
{
    public partial class Batch
    {
        public Batch()
        {
            BatchContainers = new HashSet<BatchContainer>();
        }

        public int BatchId {  get; set; }
        public int RecipeId { get; set; }
        public int EquipmentId {  get; set; }
        public double Volume { get; set; }
        public DateTime ScehduledStartDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedFinishDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes {  get; set; }
        public string TasteNotes { get; set; }
        public double TasteRating { get; set; }
        public double OG {  get; set; }
        public double FG { get; set; }
        public double Carbonation { get; set; }
        public int FermentaionStages { get; set; }
        public double PrimaryAge { get; set; }
        public double PrimaryTemp { get; set; }
        public double SecondaryAge { get; set; }
        public double SecondaryTemp { get; set; }
        public double TertiaryAge { get; set; }
        public double Age { get; set; }
        public double Temp { get; set; }
        public double IBU {  get; set; }
        public string IBUMethod { get; set; }
        public double ABV { get; set; }
        public double ActualEfficiency { get; set; }
        public double Calories { get; set; }
        public string CarbonationUsed { get; set; }
        public Int16 ForcedCarbonation { get; set; }
        public double KegPrimingFactor { get; set; }
        public double CarbonationTemp { get; set; }

        public virtual ICollection<BatchContainer> BatchContainers { get; set; }

    }
}
