using Fiorello_PB101.ViewModels.Categories;

namespace Fiorello_PB101.Helpers
{
    public class Paginate<T>
    {
        private IEnumerable<CategoryProductVM> mappedDatas;
       
        private int page;

        public IEnumerable<T> Datas { get; set; }
        public int TotalPage { get; set; }
        public int CurrentPage { get; set; }

        public Paginate(IEnumerable<T> datas, int totalPage, int currentPage)
        {
            Datas = datas;
            TotalPage = totalPage;
            CurrentPage = currentPage;
        }

        public Paginate(IEnumerable<CategoryProductVM> mappedDatas, int totalPage, int page)
        {
            this.mappedDatas = mappedDatas;
            TotalPage = totalPage;
            this.page = page;
        }

        public bool HasNext
        {
            get
            {
                return CurrentPage < TotalPage;
            }
        }

        public bool HasPrevious
        {
            get
            {
                return CurrentPage > 1;
            }
        }
    }
}
