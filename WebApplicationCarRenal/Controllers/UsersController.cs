﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace WebApplicationCarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result=_userService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("add")]
        //public IActionResult Add(User user)
        //{
        //    var result = _userService.AddUser(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("delete")]
        //public IActionResult Delete(User user)
        //{
        //    var result = _userService.DeleteUser(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        //[HttpPost("update")]
        //public IActionResult Update(User user)
        //{
        //    var result = _userService.UpdateUser(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}
