using System.Runtime.Serialization;
using System.ServiceModel;

namespace JustWcfServiceCalc
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        CalcResponse Add(CalcContract contract);

        [OperationContract]
        CalcResponse Substract(CalcContract contract);

        [OperationContract]
        CalcResponse Multiply(CalcContract contract);

        [OperationContract]
        CalcResponse Divide(CalcContract contract);
    }


    [DataContract]
    public class CalcContract
    {
        [DataMember] public string Token { get; set; }
        [DataMember] public decimal A { get; set; }
        [DataMember] public decimal B { get; set; }
    }

    [DataContract]
    public class CalcResponse
    {
        [DataMember] public bool Success { get; set; }
        [DataMember] public decimal Result { get; set; }
        [DataMember] public string Message { get; set; }

        private CalcResponse() { }


        public static CalcResponse FromResult(decimal result)
        {
            return new CalcResponse
            {
                Success = true,
                Result = result,
            };
        }

        public static CalcResponse Unauthorized()
        {
            return new CalcResponse
            {
                Success = false,
                Message = "User not authorized",
            };
        }

        public static CalcResponse InvalidOperation()
        {
            return new CalcResponse
            {
                Success = false,
                Message = "Operation is not valid",
            };
        }
    }
}
