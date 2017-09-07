using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cafe
    {
        private float preco;
        private float saldo;
        private float deposito;
        private int venda;

        public Cafe()
        {
            // Vende cafezinhos por um valor único  
            preco = 5.00F;
        }

        // Fornece preço do café
        public float getPreco()
        {
            return preco;
        }

        // Permite o depósito de moedas (Só aceita moedas)
        public void setDeposito(float _deposito)
        {
            deposito += _deposito;
        }

        // Fornece total já inserido para compra de cada café
        public float getDeposito()
        {
            return deposito;
        }

        // Devolve troco
        public float getTroco()
        {
            float troco = deposito;
            deposito = 0;
            return troco;
        }

        // Retorna a quantidade de cafés vendidos
        public int getVenda()
        {
            return venda;
        }

        // Emite total arrecadado acumulado
        public float getSaldo()
        {
            return saldo;
        }

        // Comprar o cafe
        public bool comprar()
        {
            if ((deposito - preco) > 0)
            {
                deposito -= preco;
                saldo += preco;
                venda += 1;
                return true;
            }
            return false;
        }

        // Reinicia as vendas
        public void reset()
        {
            saldo = 0F;
            deposito = 0F;
            venda = 0;
        }
    }
}
