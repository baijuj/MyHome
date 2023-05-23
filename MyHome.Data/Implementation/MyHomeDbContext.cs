using Microsoft.EntityFrameworkCore;
using MyHome.Data;
using MyHome.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHome.Data
{
    public class MyHomeDbContext : DbContext, IMyHomeDbContext
    {
        public MyHomeDbContext(DbContextOptions<MyHomeDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<BrochureMap> BrochureMaps { get; set; }
        public DbSet<CustomData> CustomDatas { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Negotiator> Negotiators { get; set; }
        public DbSet<Photo> Photos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Seeding an admin user
            User adminUser = new User
            {
                Id = 1,
                UserName = "admin"
            };

            // create password hash and salt
            CreatePasswordHash("admin", out byte[] passwordHash, out byte[] passwordSalt);

            adminUser.PasswordHash = passwordHash;
            adminUser.PasswordSalt = passwordSalt;
            modelBuilder.Entity<User>().HasData(adminUser);

            // seed property
            modelBuilder.Entity<Property>().HasData(
            new Property
            {
                Id = 1,
                GroupId = 254910,
                RefreshedOn = new DateTime(2023, 03, 31, 0, 0, 0),
                Address = "46 Ashfield Avenue",
                GroupPhoneNumber = "Ray Cooke Auctioneers",
                GroupEmail = "tallaght@raycooke.ie",
                GroupName = "Ray Cooke Auctioneers",
                GroupAddress = "6 Village Green, Tallaght, Dublin 24",
                GroupUrlSlugIdentifier = "ray-cooke-auctioneers-tallaght",
                CreatedOnDate = new DateTime(2023, 03, 31, 0, 0, 0),
                ActivatedOn = new DateTime(2023, 03, 31, 0, 0, 0),
                IsNew = false,
                IsSaleAgreed = false,
                GroupLogoBgColor = "#000000",
                GroupPremiumHeadTextColour = "#FFFFFF",
                GroupLogoUrl = "https://photos-a.propertyimages.ie/groups/0/1/9/254910/logo.jpg",
                Baths=2,
                Beds=3,
                Price= 465000,
                GroupUrl = "/estate-agents/ray-cooke-auctioneers-tallaght-254910",
                BerRating= "C2",
                EnergyRatingMediaPath="//photos-a.propertyimages.ie/static/images/energyRating/C2.png",
                OrderedDisplayAddress= "46 ashfield avenue kingswood dublin 24",
                SeoDisplayAddress= "46-ashfield-avenue-kingswood-dublin-24",
                BrochureUrl= "/residential/brochure/46-ashfield-avenue-kingswood-dublin-24/4690496",
                SeoUrl= "/residential/brochure/46-ashfield-avenue-kingswood-dublin-24/4690496"
                //..

            },
            new Property
            {
                Id = 2,
                GroupId = 5598,
                RefreshedOn = new DateTime(2023, 03, 31, 9, 0, 0, 0),
                Address = "96 Navan Road",
                GroupPhoneNumber = "Mason Estates Phibsboro",
                GroupEmail = "phibsboro@masonestates.ie",
                GroupName = "Mason Estates Phibsboro",
                GroupAddress = "148 Phibsboro Road, Phibsboro, Dublin 7",
                GroupUrlSlugIdentifier = "mason-estates-phibsboro",

                CreatedOnDate = new DateTime(2023, 03, 31, 9, 0, 0, 0),
                ActivatedOn = new DateTime(2023, 03, 31, 9, 0, 0, 0),
                IsNew = false,
                IsSaleAgreed = false,
                GroupLogoBgColor = "#70d0f4",
                GroupPremiumHeadTextColour = "#FFFFFF",
                GroupLogoUrl = "https://photos-a.propertyimages.ie/groups/8/9/5/5598/logo.jpg",
                Baths = 3,
                Beds = 4,
                Price = 565600,
                GroupUrl = "/estate-agents/mason-estates-phibsboro-5598",
                BerRating = "E2",
                EnergyRatingMediaPath = "//photos-a.propertyimages.ie/static/images/energyRating/E2.png",
                OrderedDisplayAddress = "96 navan road navan road   dublin 7",
                SeoDisplayAddress = "96-navan-road-navan-road-dublin-7",
                BrochureUrl = "/residential/brochure/96-navan-road-navan-road-dublin-7/4690493",
                SeoUrl = "/residential/brochure/96-navan-road-navan-road-dublin-7/4690493"
                //..
            }
            );

            modelBuilder.Entity<Negotiator>().HasData(
            new Negotiator
            {
                NegotiatorId = 1,
                PropertyId = 1,
                Name = "Ray Cooke Sales",
                Phone = "016875800",
                Email = "Raycookesales@raycooke.ie",
                WebSite = "http://www.raycooke.ie"
            },
            new Negotiator
            {
                NegotiatorId = 2,
                PropertyId = 2,
                Name = "Fiona McGowan",
                Phone = "01 8304000",
                Email = "fiona.mcgowan@masongroup.ie",
                WebSite = "http://www.masonestates.ie/"
            }

            );

            modelBuilder.Entity<CustomData>().HasData(
            new CustomData
            {
                Id = 1,
                PropertyId = 1,
                IsMyHomePassport = false,
            },
            new CustomData
            {
                Id = 2,
                PropertyId = 2,
                PromotionalSnippet = "",
                IsMyHomePassport = false,
                DevelopmentLogoBgColour = ""
            }

            );

            modelBuilder.Entity<Photo>().HasData(
            new Photo
            {
                Id = 1,
                PropertyId = 2,
                PhotoURL = "https://photos-a.propertyimages.ie/media/3/9/4/4690493/ee2ff749-6d34-4f9f-922e-80e225d9cfda_l.jpg"
            },
            new Photo
            {
                Id = 2,
                PropertyId = 2,
                PhotoURL = "https://photos-a.propertyimages.ie/media/3/9/4/4690493/5c9d3934-1f14-4039-a96b-68fe61e94035_l.jpg",
            },
            new Photo
            {
                Id = 3,
                PropertyId = 1,
                PhotoURL = "https://photos-a.propertyimages.ie/media/6/9/4/4690496/b9f74d3a-fe89-400a-830a-060311ea24a1_l.jpg",
            },
             new Photo
             {
                 Id =4,
                 PropertyId = 1,
                 PhotoURL = "https://photos-a.propertyimages.ie/media/6/9/4/4690496/48d310d0-de63-4a9b-ae83-db8834c52b59_l.jpg",
             }

            );

            modelBuilder.Entity<Location>().HasData(
           new Location
           {
               Id = 1,
               PropertyId = 1,
               Lat=0,
               Lon=0
           },
           new Location
           {
               Id = 2,
               PropertyId = 2,
               Lat = 0,
               Lon = 0
           }

           );

        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }

}
