using StorageSystem.Models;

namespace StorageSystem.Services
{
    public class StorageService
    {
        public Storage storage; 

        public string AddProduct(Product product)
        {
            if (product != null)
            {
                storage.Products.Add(product);
                return "Товар успешно добавлен";
            }
            else
            {
                return "Ошибка! Нет информации о товаре.";
            }
        }
    }
}
