using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Dias";
contaDoAndre.numero_agencia = 22;
contaDoAndre.conta = "1234-5";
contaDoAndre.DefinirSaldo(250);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Noites";
contaDaMaria.numero_agencia = 13;
contaDaMaria.conta = "5454-6";
contaDaMaria.DefinirSaldo(100);

contaDoAndre.Depositar(150);
contaDoAndre.Transferir(45, contaDaMaria);

Console.WriteLine($"O saldo da conta do André é de {contaDoAndre.saldo}");
Console.WriteLine($"O saldo da conta da Maria é de {contaDaMaria.saldo}");