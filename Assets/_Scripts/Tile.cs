namespace _Scripts
{
    public class Tile : ProductContainer
    {
        public int x => _x;
        public int y => _y;
        
        private int _x, _y;
        
        public void Initialize(int x,int y)
        {
            _x = x;
            _y = y;
        }

        public void TryPutProduct (ProductBase settedProduct)
        {
            //aynı tipteyse atlat
            //değilse yer değiştir
            //nullsa bişey yapma
        }
        
    }
}