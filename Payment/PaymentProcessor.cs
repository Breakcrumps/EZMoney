public static class PaymentProcessor {
  public static void ProcessPayment(Wallet addresser, Wallet addressee, decimal amountUSD) {
    if(addresser.CountUSD < amountUSD) {
      Console.WriteLine("Insufficient funds.");
      return;
    }
    Console.WriteLine($@"{amountUSD} USD was transferred
      from {addresser.Address} {addresser.GetType()}
      to {addressee.Address} {addressee.GetType()}.");
    return;
  }
}