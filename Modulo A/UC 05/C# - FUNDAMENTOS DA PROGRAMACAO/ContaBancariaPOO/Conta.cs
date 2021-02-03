namespace ContaBancariaPOO
{
    public class Conta
    {
        public int numero;
        public int digitoVerificador;
        public double saldo;
        public string titular;
        public bool RelizarSaque(double valor){
            if(saldo  > valor)
            {
                saldo = saldo - valor;
                return true;
            }
            else
            {
                return false; //saldo insuficiente
            }
        }
        public void RealizarDeposito(double valor)
        {
            if(valor > 0)
            {
                saldo = saldo + valor;
            }
        }
    }
}