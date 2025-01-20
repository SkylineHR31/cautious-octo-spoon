for (int i = 0; i < 3; i++) {
    string name;
    string product;
    string productPrice;
    string address;
    int orderNo = i + 1; // added it because cant use just {++i} in template string, idk why. It just incremented i on loop without i = ++i;

    Console.WriteLine("Enter client`s name");
    name = Console.ReadLine();
    Console.WriteLine("Enter product`s name");
    product = Console.ReadLine();
    Console.WriteLine("Enter product`s price");
    productPrice = Console.ReadLine();    
    Console.WriteLine("Enter address");
    address = Console.ReadLine();

    Console.WriteLine($"Order No {orderNo} \n Client: {name}. \n Product: {product}, price {productPrice} EUR. \n Address: {address}. \n");
}