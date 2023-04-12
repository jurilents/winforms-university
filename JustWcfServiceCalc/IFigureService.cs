using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JustWcfServiceCalc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFigureService
    {
        [OperationContract]
        void Save(FigureContract figure);

        [OperationContract]
        FigureContract Load();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "JustWcfServiceCalc.ContractType".

    [DataContract]
    public class FigureContract
    {
        [DataMember] public int OffsetTop { get; set; } = 100;
        [DataMember] public int OffsetLeft { get; set; } = 100;
        [DataMember] public int Width { get; set; } = 100;
        [DataMember] public int Height { get; set; } = 100;
        [DataMember] public string Color { get; set; } = "#ff0000"; // red by default
    }
}
