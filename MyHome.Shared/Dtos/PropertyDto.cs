using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Shared.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public int GroupId { get; set; }

        public DateTime RefreshedOn { get; set; }

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

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

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
        public int Beds { get; set; }
     
        public int Baths { get; set; }

        [MaxLength(256)]
        public string? BerRating { get; set; }

        [MaxLength(256)]
        public string? EnergyRatingMediaPath { get; set; }


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

        public int RelatedPropertiesTotal { get; set; }
    }
}
