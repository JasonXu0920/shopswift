using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}