using OnSale.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Server.Infraestructure.Helper
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
