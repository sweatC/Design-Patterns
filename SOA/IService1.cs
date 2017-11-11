using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SystemActivityMonitorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        #region Common Methods

        /// <summary>
        /// проверка соединения
        /// </summary>
        /// <returns> OK </returns>
        [OperationContract]
        [WebInvoke(Method = "GET")]
        string TestConnection();

        /// <summary>
        /// получить все процессы локалки
        /// </summary>
        /// <returns> Dictionary<int, string> </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "processes")]
        Dictionary<int, string> GetProcesses();

        /// <summary>
        /// получить процесс локалки по имени
        /// </summary>
        /// <returns> Dictionary<int, string> </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "processes/{name}")]
        Dictionary<int, string> GetProcessByName(string name);
        #endregion

        #region Arithmetic

        /// <summary>
        /// сложение
        /// </summary>
        /// <param name="a"> слагаемое 1 </param>
        /// <param name="b"> слагаемое 2 </param>
        /// <returns> сумма </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Add?a={a}&b={b}")]
        double Addition(double a, double b);

        /// <summary>
        /// вычитание
        /// </summary>
        /// <param name="a"> уменьшаемое </param>
        /// <param name="b"> вычитаемое </param>
        /// <returns> разность </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Sub?a={a}&b={b}")]
        double Subtraction(double a, double b);

        /// <summary>
        /// умножение
        /// </summary>
        /// <param name="a"> множитель 1 </param>
        /// <param name="b"> множитель 2 </param>
        /// <returns> произведение </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Mul?a={a}&b={b}")]
        double Multiplication(double a, double b);

        /// <summary>
        /// деление
        /// </summary>
        /// <param name="a"> делимое </param>
        /// <param name="b"> делитель </param>
        /// <returns> частное </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Div?a={a}&b={b}")]
        double Division(double a, double b);

        #endregion
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
