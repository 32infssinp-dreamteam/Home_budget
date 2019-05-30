namespace Models.Models
{
    public class CategoriesViewGuiProperties
    {
        public bool IsCategoryDetailsReadonly { get; set; }
        
        public bool IsButtonEnable {
            get => !IsCategoryDetailsReadonly;
            set { }
        }
    }
}