using DependencyInjectionn.Data_DataAccess.Entities;
using System.Collections.Generic;

namespace DependencyInjectionn.Data_DataAccess.Repositoies
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
