using BaharShop.Application.DTOs.CartItems;
using BaharShop.Application.DTOs.Carts;
using BaharShop.Common;
using BaharShop.Domain.Entities.CartItems;
using BaharShop.Domain.Entities.Carts;
using BaharShop.Domain.Entities.Products;
using BaharShop.Domain.IReaders;
using BaharShop.Domain.IReaders.Carts;
using BaharShop.Domain.IRepositories;

namespace BaharShop.Application.Services.Carts
{
    public class CartServices : ICartServices
    {
        private readonly ICartReader _cartReader;
        private readonly IGenericReader<CartItem> _cartItemReader;
        private readonly IGenericReader<Product> _productReader;

        private readonly IGenericRepository<Cart> _cartRepository;
        private readonly IGenericRepository<CartItem> _cartItemRepository;

        public CartServices(ICartReader cartReader,
                            IGenericReader<CartItem> cartItemReader,
                            IGenericReader<Product> productReader,
                            IGenericRepository<Cart> cartRepository,
                            IGenericRepository<CartItem> cartItemRepository)
        {
            _cartReader = cartReader;
            _cartItemReader = cartItemReader;
            _productReader = productReader;
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;
        }

        public async Task<ResultDTO<CartDTO>> GetMyCart(Guid browserId)
        {
            try
            {
                var cart = await _cartReader.GetMyCart(browserId);

                if (cart == null)
                {
                    return new ResultDTO<CartDTO>()
                    {
                        Data = new CartDTO()
                        {
                            CartItems = new List<CartItemDTO>()
                        },
                        IsSuccess = false,
                    };
                }

                return new ResultDTO<CartDTO>()
                {
                    Data = new CartDTO()
                    {
                        ProductCount = cart.CartItems.Count(),
                        SumAmount = cart.CartItems.Sum(p => p.Price * p.Count),
                        CartItems = cart.CartItems.Select(p => new CartItemDTO
                        {
                            Count = p.Count,
                            Price = p.Price,
                            Product = p.Product.Title,
                            Id = p.Id,
                            Images = p.Product?.ProductImages?.FirstOrDefault()?.Src ?? "",
                        }).ToList(),
                    },
                    IsSuccess = true,
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResultDTO> AddToCart(int productId, Guid browserId)
        {
            var carts = await _cartReader.GetList(p => p.BrowserId == browserId && p.Finished == false);
            Cart cart = carts.ToList().FirstOrDefault();

            if (cart == null)
            {
                Cart newCart = new Cart()
                {
                    Finished = false,
                    BrowserId = browserId,
                };
                await _cartRepository.Create(newCart);
                cart = newCart;
            }

            var product = await _productReader.GetById(productId);

            var cartItems = await _cartItemReader.GetList(p => p.ProductId == productId && p.CartId == cart.Id);
            CartItem cartItem = cartItems.ToList().FirstOrDefault();
            if (cartItem != null)
            {
                cartItem.Count++;
                await _cartItemRepository.Update(cartItem);
            }
            else
            {
                CartItem newCartItem = new CartItem()
                {
                    Cart = cart,
                    Count = 1,
                    Price = product.Price,
                    Product = product,
                };
                await _cartItemRepository.Create(cartItem);
            }

            return new ResultDTO()
            {
                IsSuccess = true,
                Message = $"محصول  {product.Title} با موفقیت به سبد خرید شما اضافه شد ",
            };
        }

        public async Task<ResultDTO> RemoveFromCart(Guid browserId)
        {
            var cartItems = await _cartItemReader.GetList(p => p.Cart.BrowserId == browserId);
            CartItem cartItem = cartItems.ToList().FirstOrDefault();
            if (cartItem != null)
            {
                cartItem.IsRemoved = true;
                cartItem.RemoveDate = DateTime.Now;
                await _cartItemRepository.Update(cartItem);
                return new ResultDTO
                {
                    IsSuccess = true,
                    Message = "محصول از سبد خرید شما حذف شد"
                };
            }
            else
            {
                return new ResultDTO
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
        }

        public async Task<ResultDTO> Increase(int cartItemId)
        {
            var cartItem = await _cartItemReader.GetById(cartItemId);
            cartItem.Count++;
            await _cartItemRepository.Update(cartItem);
            return new ResultDTO()
            {
                IsSuccess = true,
            };
        }

        public async Task<ResultDTO> Decrease(int cartItemId)
        {
            var cartItem = await _cartItemReader.GetById(cartItemId);

            if (cartItem.Count <= 1)
            {
                return new ResultDTO()
                {
                    IsSuccess = false,
                };
            }
            cartItem.Count--;
            await _cartItemRepository.Update(cartItem);
            return new ResultDTO()
            {
                IsSuccess = true,
            };
        }
    }
}
