using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponAPI.Data;
using CouponAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CouponAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponApiController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponApiController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId ==id);
                return obj;
            }
            catch (Exception ex)
            {
                return NotFound("Coupon not found!");
            }
        }

    }
}