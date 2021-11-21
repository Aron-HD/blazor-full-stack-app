using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Judges",
                columns: new[] { "Id", "Bio", "Category", "Chair", "Company", "Email", "FirstName", "Headshot", "LastName", "Role" },
                values: new object[,]
                {
                    { 1, "Zena is an accomplished executive across CPG and Technology marketing and general management. She recently joined Kimberly-Clark, leading the company’s global marketing teams and driving initiatives to accelerate digital transformation. She was previously at Google, where she was most recently in Business and Operations leadership roles running the US Chromebooks organization and subsequently starting a Global Growth team.", "Instant Impact", true, "Kimberly-Clark", null, "Zena", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/zena-arnold.jpg", "Srivatsa Arnold", "Chief Digital & Marketing Officer" },
                    { 2, "Suresh is also the Global Head of Marketing, HSBC Life. He has held various leadership roles in strategy, sales, products, media and advertising at HSBC, WPP and GSK. Suresh is the Co-chair for Male Allies Hong Kong, a BALANCE Ambassador, an Advisory Board Member of the CMO Council, and a Male Ally for UN Women.", "Sustained Growth", true, "HSBC", null, "Suresh", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/suresh-balaji.jpg", "Balaji", "Chief Marketing Officer, Asia Pacific" },
                    { 3, "Michael has worked on global brands since the beginning of his career. Starting at Ad Agencies DDB and Leo Burnett London, working on Volkswagen and McDonalds, he joined another global brand, Xbox, in 2008. Michael’s marketing campaigns aim to resonate through culture, while rethinking how Xbox can connect with completely new audiences.", "Collaboration & Culture", true, "Xbox", null, "Michael", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/michael-flatt.jpg", "Flatt", "Director, Global Integrated Marketing" },
                    { 4, "Akira brings over 30 years of aviation industry experience and has held multiple leadership roles within the company, including his previous role as VP of Products and Services. Akira has been named one of Asia’s Best Marketers and among the 50 Most Influential Global Marketing Leaders. He currently serves as an advisory member of several boards.", "Customer Experience", true, "Japan Airlines", null, "Akira", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/akira-mitsumasu.jpg", "Mitsumasu", "VP of CX, Data Analytics and Global Marketing" },
                    { 5, "In December 2019, Ann Mukherjee joined Pernod Ricard North America as Chairman &amp; CEO. The first industry outsider and woman of colour to assume the position, she has demonstrated her ability to advance through ambiguity, while delivering both ROI and ROR (return on responsibility). Ann joined Pernod Ricard from S.C. Johnson and Company, as its first-ever Global Chief Marketing Officer.", "Brand Purpose", true, "Pernod Ricard North America", null, "Ann", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/ann-mukherjee.jpg", "Mukherjee", "Chairman & CEO" },
                    { 6, "Antonia leads PwC’s Global Marketing Organisation, which brings together all aspects of brand, digital, communications, thought leadership, marketing and business development. Previously, Antonia was the Chief Marketing Officer for Capita where she led a brand refresh and marketing transformation. Prior to that she ran global marketing for Thomson Reuters/ Refinitiv and spent ten years in marketing at Accenture.", "Business-to-Business", true, "PwC Network", null, "Antonia", "https://cdn.warc.com/Images/WARCSiteContent/landing-pages/awards/effectiveness/judges/antonia-wade.jpg", "Wade", "Global Chief Marketing Officer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Judges",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
