using Service.Entitys;
using Service.Requests;
using Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceContract" в коде и файле конфигурации.
    public class ServiceContract : IServiceContract
    {
        public BaseResponse Autorization(Authorization request)
        {
            using (Context db = new Context())
            {
                var us = db.users.Where(p => p.login == request.login && p.password == request.password).FirstOrDefault();
                if (us == null)
                {
                    return new BaseResponse() { message = "Password or login not founded" };
                }
                us = db.users.Where(p => p.password == request.password).FirstOrDefault();
                if (us == null)
                {
                    return new BaseResponse { message = "Введен неверный пароль!" };
                }

                return new BaseResponse() { message = "Sucessful" };
            }
        }

        public BaseResponse OrderFood(OrderFood request)
        {
            using (Context db = new Context())
            {
                Order order = new Order() { adress = request.adress, numbers = request.numbers, products = request.products };
                db.orders.Add(order);
                db.SaveChanges();
            }
            return new BaseResponse() { message = "You order is complete" };
        }

        public BaseResponse Registration(Registration request)
        {
            using (Context db = new Context())
            {
                var result = db.users.Where(p => p.login == request.login).FirstOrDefault();
                if (result != null)
                {
                    return new BaseResponse { message = "Пользователь с таким логином уже имеется!" };
                }
                User user = new User { login = request.login, password = request.password };
                db.users.Add(user);
                db.SaveChanges();
                return new BaseResponse { message = "Регистрация прошла успешно!" };
            }
        }

    }
}
