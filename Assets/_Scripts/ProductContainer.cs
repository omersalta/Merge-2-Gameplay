using UnityEngine;

namespace _Scripts
{
    public class ProductContainer : MonoBehaviour
    {
        private ProductBase _currentProduct;
        public ProductBase CurrentProduct => _currentProduct;
        
        public void SetProduct (ProductBase settedProduct)
        {
            _currentProduct = settedProduct;
        }
        
    }
}