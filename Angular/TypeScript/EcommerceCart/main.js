"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const ecommerce_service_1 = require("./services/ecommerce.service");
const ecommerce = new ecommerce_service_1.ECommerceService();
ecommerce.showProducts();
ecommerce.addToCart(1, 1); // Laptop x1
ecommerce.addToCart(2, 2); // Jeans x2
ecommerce.addToCart(3, 1); // Rice Bag x1
ecommerce.removeFromCart(2); // Remove Jeans
ecommerce.showCart();
ecommerce.showProducts(); // See updated stock
