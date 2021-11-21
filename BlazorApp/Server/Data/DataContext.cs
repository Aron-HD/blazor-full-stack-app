using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // add data through seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Judge>().HasData(
                new Judge
                {
                    Id = 1,
                    Chair = true,
                    FirstName = "Zena",
                    LastName = "Srivatsa Arnold",
                    Role = "Chief Digital & Marketing Officer",
                    Company = "Kimberly-Clark",
                    Category = "Instant Impact",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/zena-arnold.jpg",
                    Bio = "Zena is an accomplished executive across CPG and Technology marketing and general management. She recently joined Kimberly-Clark, leading the company’s global marketing teams and driving initiatives to accelerate digital transformation. She was previously at Google, where she was most recently in Business and Operations leadership roles running the US Chromebooks organization and subsequently starting a Global Growth team."
                },
                new Judge
                {
                    Id = 2,
                    Chair = true,
                    FirstName = "Suresh",
                    LastName = "Balaji",
                    Role = "Chief Marketing Officer, Asia Pacific",
                    Company = "HSBC",
                    Category = "Sustained Growth",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/suresh-balaji.jpg",
                    Bio = "Suresh is also the Global Head of Marketing, HSBC Life. He has held various leadership roles in strategy, sales, products, media and advertising at HSBC, WPP and GSK. Suresh is the Co-chair for Male Allies Hong Kong, a BALANCE Ambassador, an Advisory Board Member of the CMO Council, and a Male Ally for UN Women."
                },
                new Judge
                {
                    Id = 3,
                    Chair = true,
                    FirstName = "Michael",
                    LastName = "Flatt",
                    Role = "Director, Global Integrated Marketing",
                    Company = "Xbox",
                    Category = "Collaboration & Culture",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/michael-flatt.jpg",
                    Bio = "Michael has worked on global brands since the beginning of his career. Starting at Ad Agencies DDB and Leo Burnett London, working on Volkswagen and McDonalds, he joined another global brand, Xbox, in 2008. Michael’s marketing campaigns aim to resonate through culture, while rethinking how Xbox can connect with completely new audiences."
                },
                new Judge
                {
                    Id = 4,
                    Chair = true,
                    FirstName = "Akira",
                    LastName = "Mitsumasu",
                    Role = "VP of CX, Data Analytics and Global Marketing",
                    Company = "Japan Airlines",
                    Category = "Customer Experience",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/akira-mitsumasu.jpg",
                    Bio = "Akira brings over 30 years of aviation industry experience and has held multiple leadership roles within the company, including his previous role as VP of Products and Services. Akira has been named one of Asia’s Best Marketers and among the 50 Most Influential Global Marketing Leaders. He currently serves as an advisory member of several boards."
                },
                new Judge
                {
                    Id = 5,
                    Chair = true,
                    FirstName = "Ann",
                    LastName = "Mukherjee",
                    Role = "Chairman & CEO",
                    Company = "Pernod Ricard North America",
                    Category = "Brand Purpose",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/ann-mukherjee.jpg",
                    Bio = "In December 2019, Ann Mukherjee joined Pernod Ricard North America as Chairman &amp; CEO. The first industry outsider and woman of colour to assume the position, she has demonstrated her ability to advance through ambiguity, while delivering both ROI and ROR (return on responsibility). Ann joined Pernod Ricard from S.C. Johnson and Company, as its first-ever Global Chief Marketing Officer."
                },
                new Judge
                {
                    Id = 6,
                    Chair = true,
                    FirstName = "Antonia",
                    LastName = "Wade",
                    Role = "Global Chief Marketing Officer",
                    Company = "PwC Network",
                    Category = "Business-to-Business",
                    Headshot = "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/antonia-wade.jpg",
                    Bio = "Antonia leads PwC’s Global Marketing Organisation, which brings together all aspects of brand, digital, communications, thought leadership, marketing and business development. Previously, Antonia was the Chief Marketing Officer for Capita where she led a brand refresh and marketing transformation. Prior to that she ran global marketing for Thomson Reuters/ Refinitiv and spent ten years in marketing at Accenture."
                }
            );
        }
        // set the name for the DB Table = Judges
        public DbSet<Judge> Judges { get; set; }
    }
}
