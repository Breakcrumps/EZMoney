class Program {
  public static void Main() {
    EZmoneyAccount account = new();

    PayPalWallet payPal = new();

    CreditCardWallet creditCard = new();

    Console.WriteLine(account.GetWalletsAddresses());

    account.AddWallet("My first PayPal!", payPal);
    Console.WriteLine(account.GetWalletsAddresses());

    account.AddWallet("My first credit card!", creditCard);
    Console.WriteLine(account.GetWalletsAddresses());
    
    account.AddWallet("My first professional PayPal.", payPal);
    Console.WriteLine(account.GetWalletsAddresses());
  }
}