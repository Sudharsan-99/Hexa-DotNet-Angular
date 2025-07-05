import { Product } from '../models/product.model';
import { CartItem } from '../models/cart-item.model';
import { Category } from '../models/category.enum';

export class ECommerceService {
    private products: Product[] = [
        { id: 1, name: "Laptop", price: 45000, stock: 3, category: Category.Electronics },
        { id: 2, name: "Jeans", price: 1500, stock: 10, category: Category.Clothing },
        { id: 3, name: "Rice Bag", price: 700, stock: 5, category: Category.Grocery }
    ];

    private cart: CartItem[] = [];

    showProducts(): void {
        console.log("Available Products:\n");
        for (const p of this.products) {
            console.log(`${p.name} | ₹${p.price} | In Stock: ${p.stock} | Category: ${p.category}`);
        }
        console.log("");
    }

    addToCart(productId: number, quantity: number): void {
        const product = this.products.find(p => p.id === productId);

        if (!product) {
            console.log("Product not found.");
            return;
        }

        if (product.stock < quantity) {
            console.log(`Only ${product.stock} units of ${product.name} available.`);
            return;
        }

        const existingItem = this.cart.find(item => item.product.id === productId);

        if (existingItem) {
            existingItem.quantity += quantity;
        } else {
            this.cart.push({ product, quantity });
        }

        product.stock -= quantity;
        console.log(`${quantity} x ${product.name} added to cart.`);
    }

    removeFromCart(productId: number): void {
        const index = this.cart.findIndex(item => item.product.id === productId);

        if (index !== -1) {
            const removedItem = this.cart[index];
            removedItem.product.stock += removedItem.quantity;
            this.cart.splice(index, 1);
            console.log(`${removedItem.product.name} removed from cart.`);
        } else {
            console.log("Item not in cart.");
        }
    }

    showCart(): void {
        if (this.cart.length === 0) {
            console.log("Cart is empty.\n");
            return;
        }

        console.log("\nCart Summary:\n");

        let total = 0;

        for (const item of this.cart) {
            const subtotal = item.product.price * item.quantity;
            console.log(`${item.product.name} - ₹${item.product.price} x ${item.quantity}`);
            total += subtotal;
        }

        let discount = 0;
        if (total >= 10000) discount = 0.15;
        else if (total >= 5000) discount = 0.10;

        const discountedTotal = total - total * discount;

        console.log(`\nTotal: ₹${total}`);
        if (discount > 0) {
            console.log(`Discounted Total: ₹${discountedTotal}`);
        }
        console.log("");
    }
}
