using System;

namespace JustWcfServiceCalc
{
    internal class CalculatorService : ICalculatorService
    {
        private readonly MySecretDatabase _database = MySecretDatabase.Instance;

        public CalcResponse Add(CalcContract contract)
        {
            if (!_database.CheckToken(contract.Token))
                return CalcResponse.Unauthorized();

            var result = contract.A + contract.B;
            return CalcResponse.FromResult(result);
        }

        public CalcResponse Substract(CalcContract contract)
        {
            if (!_database.CheckToken(contract.Token))
                return CalcResponse.Unauthorized();

            var result = contract.A - contract.B;
            return CalcResponse.FromResult(result);
        }

        public CalcResponse Divide(CalcContract contract)
        {
            if (!_database.CheckToken(contract.Token))
                return CalcResponse.Unauthorized();
            if (contract.B == 0)
                return CalcResponse.InvalidOperation();

            var result = Math.Round(contract.A / contract.B, 2);
            return CalcResponse.FromResult(result);
        }

        public CalcResponse Multiply(CalcContract contract)
        {
            if (!_database.CheckToken(contract.Token))
                return CalcResponse.Unauthorized();

            var result = contract.A * contract.B;
            return CalcResponse.FromResult(result);
        }
    }
}
