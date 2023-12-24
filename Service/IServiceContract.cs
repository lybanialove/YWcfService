using Service.Requests;
using Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IServiceContract" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        BaseResponse Autorization(Authorization request);
        [OperationContract]
        BaseResponse Registration(Registration request);
        [OperationContract]
        BaseResponse OrderFood(OrderFood request);
    }
}
