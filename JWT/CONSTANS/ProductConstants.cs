using JWT.Models;
using System.ComponentModel;

namespace JWT.CONSTANS
{
    public class ProductConstants
    {
        public static List<ProductModel> listaProducts = new List<ProductModel>() { 
            
            new ProductModel(){ name="agua", description="agua de la cara"},
            new ProductModel(){ name="leche", description="leche de la cara"},
            new ProductModel(){ name="papa", description="papa de la cara"},
            new ProductModel(){ name="tomate", description="totmate del caro"},
            new ProductModel(){ name="lechuga", description="lechuga de la cara"}
        };
    }
}
