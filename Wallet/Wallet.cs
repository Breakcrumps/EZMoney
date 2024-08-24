public abstract class Wallet {
  public static string AlphaNumeric => "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
  public static string Numeric => "01234567890";
  public decimal CountUSD { get; set; } = 0;
  public abstract string Address { get; }
}
