using RNG = System.Security.Cryptography.RandomNumberGenerator;

public class PayPalWallet : Wallet {
  readonly string address = RNG.GetString(AlphaNumeric, 13);
  public override string Address => address;
}

public class CreditCardWallet : Wallet {
  readonly string address = GenerateCreditCardNumber();
  public override string Address => address;

  static string GenerateCreditCardNumber() {
    string[] result = new string[4];
    for (int i = 0; i < result.Length; i++) {
      result[i] = RNG.GetString(Numeric, 4);
    }
    return string.Join("-", result);
  }
}

public class CriptoWallet : Wallet {
  readonly string address = RNG.GetString(AlphaNumeric, 13);
  public override string Address => address;
}