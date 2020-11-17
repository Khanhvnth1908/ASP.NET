using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace AppTea.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Sont",
                        Desciption = "De sous au froide et guidé or immobilités la enivrantes aux regrette d'horreurs mes que le des ou et sais",
                        Discount = 0.2,
                        Price = 30,
                        Status = "A",
                        Img = "Image1",
                        Category = "Tea"
                    },
                    new Product
                    {
                        Name = "J'étais",
                        Desciption = "Alcun e pericoli e non cose da per d'angoscia di per e che avvedimento nella la transitorie piú in con",
                        Discount = 0.3,
                        Price = 23,
                        Status = "B",
                        Img = "Image2",
                        Category = "Tea",
                    },
                    new Product
                    {
                        Name = "Crevant",
                        Desciption = "Parapets dont freles sous les mes dont qui a les sans le de les noyé comme mer sanglot sur dérades",
                        Discount = 0.1,
                        Price = 11,
                        Status = "A",
                        Img = "Image3",
                        Category = "Tea"
                    },
                    new Product
                    {
                        Name = "Tempete",
                        Desciption = "Nym sepedyk sydou kynzathul en kunuel syrou wklelue fyodumtul uiraga fugwa ere qui thez iumhumnok wylag yg walasth fyodum iumhumnok",
                        Discount = 0.15,
                        Price = 23,
                        Status = "B",
                        Img = "Image4",
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Roulant",
                        Desciption = "Ainsi je doux un dont leurs vers île ma un les île noirs les haleurs ardents ayant le d'or une",
                        Discount = 0.32,
                        Price = 46,
                        Status = "C",
                        Img = "Image5",
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Dans",
                        Desciption = "Papillon trouais monitors sans énormes j'ai d'astres nacreux infusé moi ces arbres yeux sur comme de les d'or et pour",
                        Discount = 0.11,
                        Price = 11,
                        Status = "B",
                        Img = "Image6",
                        Category = "Coffee"
                    },
                    new Product
                    {
                        Name = "Verte",
                        Desciption = "Et au n'auraient victimes sillage un maritimes l'assaut cinquante les bercé aux lors a serpents enivrantes de mers des revé",
                        Discount = 0.22,
                        Price = 65,
                        Status = "C",
                        Img = "Image7",
                        Category = "Milk"
                    },
                    new Product
                    {
                        Name = "Ce",
                        Desciption = "Eggen fyaal wirud wegh ezes sydou buabeleul keguggethuk yg bel vh syrou thez fyom arad wirud thudothlon halal aniath the",
                        Discount = 0.26,
                        Price = 23,
                        Status = "A",
                        Img = "Image8",
                        Category = "Milk"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
