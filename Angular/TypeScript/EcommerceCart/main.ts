import { ECommerceService } from './services/ecommerce.service';

const ecommerce = new ECommerceService();

ecommerce.showProducts();

ecommerce.addToCart(1, 1);  // Laptop x1
ecommerce.addToCart(2, 2);  // Jeans x2
ecommerce.addToCart(3, 1);  // Rice Bag x1

ecommerce.removeFromCart(2);  // Remove Jeans

ecommerce.showCart();

ecommerce.showProducts();  // See updated stock
