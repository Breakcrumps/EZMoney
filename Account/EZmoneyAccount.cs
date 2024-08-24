class EZmoneyAccount {
  static Dictionary<Type, Dictionary<string, Wallet>> Wallets => [];

  public string GetWalletsAddresses() {
    var result = "";
    foreach (var typeToAliasAndWallet in Wallets) {
      var walletsOfType = "";
      foreach (var aliasAndWallet in typeToAliasAndWallet.Value)
        walletsOfType += $"{aliasAndWallet.Key} {aliasAndWallet.Value.Address}\n";
      result += $"{typeToAliasAndWallet.Key}:\n {walletsOfType}\n";
    }
    return result + "\n\n";
  }
  public string GetWallets() {
    var result = "";
    foreach (var typeToAliasAndWallet in Wallets) {
      var walletsOfType = "";
      foreach (var aliasAndWallet in typeToAliasAndWallet.Value)
        walletsOfType += $"{aliasAndWallet.Key} {aliasAndWallet.Value}\n";
      result += $"{typeToAliasAndWallet.Key}:\n {walletsOfType}\n";
    }
    return result + "\n\n";
  }

  public void AddWallet(string alias, Wallet wallet) {
    var walletType = wallet.GetType();
    if (Wallets.TryGetValue(walletType, out var value)) {
      Wallets[walletType].Add(alias, wallet);
      return;
    }
    Wallets.Add(wallet.GetType(), new Dictionary<string, Wallet>() {[alias] = wallet});
  }
}