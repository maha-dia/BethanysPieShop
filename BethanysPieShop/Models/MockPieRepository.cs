using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository;

        public MockPieRepository(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId=1,Name="Strawberry Pie", Price=15.95M,ShortDescription="Lore",LongDescription="", AllergyInformation="",InStock=true,IsPieOfTheWeek=true, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",ImageThumbnailUrl="",Category = _categoryRepository.AllCategories.ToList()[0]},
                new Pie{PieId=2,Name="Cheese cake", Price=15.95M,ShortDescription="Lore",LongDescription="", AllergyInformation="",InStock=true,IsPieOfTheWeek=true, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",ImageThumbnailUrl="",Category = _categoryRepository.AllCategories.ToList()[1]},
                new Pie{PieId=3,Name="Rhubarb Pie", Price=15.95M,ShortDescription="Lore",LongDescription="", AllergyInformation="",InStock=true,IsPieOfTheWeek=true, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",ImageThumbnailUrl="",Category = _categoryRepository.AllCategories.ToList()[2]},
                new Pie{PieId=4,Name="Pumpkin Pie", Price=15.95M,ShortDescription="Lore",LongDescription="", AllergyInformation="",InStock=true,IsPieOfTheWeek=true, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",ImageThumbnailUrl="",Category = _categoryRepository.AllCategories.ToList()[0]}

            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById (int pieId)   
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
         }
    }
}
