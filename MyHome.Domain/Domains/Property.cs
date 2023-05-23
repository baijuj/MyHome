using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MyHome.Domain
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        public int GroupId { get; set; }

        public virtual CustomData? CustomData { get; set; }

        public DateTime RefreshedOn { get; set; }

        public virtual Location? Location { get; set; }

        [MaxLength(256)]
        public string? Address { get; set; }

        [MaxLength(256)]
        public string? GroupPhoneNumber { get; set; }

        [MaxLength(256)]
        public string? GroupEmail { get; set; }

        [MaxLength(256)]
        public string? GroupName { get; set; }

        [MaxLength(256)]
        public string? GroupAddress { get; set; }

        [MaxLength(256)]
        public string? GroupUrlSlugIdentifier { get; set; }

        public virtual Negotiator? Negotiator { get; set; }

        public DateTime CreatedOnDate { get; set; }

        public DateTime ActivatedOn { get; set; }

        public bool IsNew { get; set; }

        public bool IsSaleAgreed { get; set; }

        [MaxLength(256)]
        public string? GroupLogoBgColor { get; set; }

        [MaxLength(256)]
        public string? GroupPremiumHeadTextColour { get; set; }

        [MaxLength(256)]
        public string? GroupLogoUrl { get; set; }

        [MaxLength(256)]
        public string? GroupPremiumLogoUrl { get; set; }

        [MaxLength(256)]
        public string? GroupPremiumJointLogoUrl { get; set; }

        [MaxLength(256)]
        public string? GroupRectangularLogoUrl { get; set; }

        [MaxLength(256)]
        public string? JointGroupRectangularLogoUrl { get; set; }

        [MaxLength(256)]
        public string? JointGroupPremiumJointLogo { get; set; }

        [MaxLength(256)]
        public string? GroupUrl { get; set; }

        public bool IsPremiumAd { get; set; }

        public bool IsBuildToRent { get; set; }

        public bool IsBuildToRentDevelopment { get; set; }

        public bool IsPrivateLandlord { get; set; }

        public bool IsBrandBooster { get; set; }

        public bool IsActive { get; set; }

        public int SaleTypeId { get; set; }

        public bool IsFavourite { get; set; }

        public bool HasVideos { get; set; }

        public bool HasWebP { get; set; }

        public bool IsMappedAccurately { get; set; }

        public bool IsTopSpot { get; set; }

        public int Beds { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual BrochureMap BrochureMap { get; set; }

        public int SizeStringMeters { get; set; }

        public bool PriceChangeIsIncrease { get; set; }

        [MaxLength(256)]
        public string? DisplayAddress { get; set; }

        public int PropertyClassId { get; set; }

        [MaxLength(256)]
        public string? PropertyClass { get; set; }

        [MaxLength(256)]
        public string? PropertyClassUrlSlug { get; set; }

        [MaxLength(256)]
        public string? PropertyStatus { get; set; }

        [MaxLength(256)]
        public string? PropertyType { get; set; }

        public int Baths { get; set; }

        [MaxLength(256)]
        public string? BerRating { get; set; }

        [MaxLength(256)]
        public string? EnergyRatingMediaPath { get; set; }

        public virtual List<OpenViewing> OpenViewings { get; set; }
        public virtual List<VirtualViewing> VirtualViewings { get; set; }

        [MaxLength(256)]
        public string? OrderedDisplayAddress { get; set; }

        [MaxLength(256)]
        public string? SeoDisplayAddress { get; set; }

        [MaxLength(256)]
        public string? BrochureUrl { get; set; }

        [MaxLength(256)]
        public string? SeoUrl { get; set; }

        public int PhotoCount { get; set; }

        [MaxLength(256)]
        public string? MainPhoto { get; set; }

        [MaxLength(256)]
        public string? MainPhotoWeb { get; set; }

        public virtual List<Photo> Photos { get; set; }

        public virtual List<TravelTime> TravelTimes { get; set; }
        public virtual List<Auction> AuctionList { get; set; }
        public virtual List<AdditionalLogo> AdditionalLogoUrls { get; set; }
       

        public int RelatedPropertiesTotal { get; set; }
    }
}
