using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AUCTIONonlineWeb.Models;
using System.Data;
using System.Data.Sql;
using System.Net.Mail;
using System.Net;
using System.Web.Security;

namespace AUCTIONonlineWeb.Controllers
{
    public class UserController : Controller
    {
        public string ReturnUrl { get; private set; }

        //Registration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        //Registration POST Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "IsEmailVerified,AuthenticationCode")] User user)
        {
            bool Status = false;
            string message = "";

            //model validation
            if (ModelState.IsValid)
            {
                #region //email already exist

                var isExist = IsEmailExist(user.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email  already exist");
                    return View(user);
                }
                #endregion

                #region generate activation code
                user.AuthenticationCode = Guid.NewGuid();
                #endregion

                #region password hashing
                user.Password = Crypto.Hash(user.Password);
                user.confirmPassword = Crypto.Hash(user.confirmPassword);
                #endregion
                user.IsEmailVerified = false;

                #region  save to db
                using (AuctionWebProjectEntities dc = new AuctionWebProjectEntities())
                {
                    dc.Users.Add(user);
                    dc.SaveChanges();

                    //send email to user
                    sendverificationemail(user.Email, user.AuthenticationCode.ToString());
                    message = "Registration successfully done, Account activation link is " +
                        "has been send to your email id;" + user.Email;
                    Status = true;

                }
                #endregion

            }
            else
            {
                message = "Invalid Request";
            }

            ViewBag.Message = message;
            ViewBag.Status = Status;
            return View(user);
        }
       //verify account 

            [HttpGet]
            public ActionResult VerifyAccount(string id)
        {
            bool Status = false;
            using (AuctionWebProjectEntities dc=new AuctionWebProjectEntities())
            {
                dc.Configuration.ValidateOnSaveEnabled = false;
                var v = dc.Users.Where(a => a.AuthenticationCode == new Guid(id)).FirstOrDefault();
                if(v!=null)
                {
                    v.IsEmailVerified = true;
                    dc.SaveChanges();
                    Status = true;
                }
                else
                {

                    ViewBag.Message = "Invalid Request";
                }
            }
            ViewBag.Status = Status;
            return View();
        }
        
        //Verify Email

        //verify email link

        //login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //login POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login, string ReturnUrl="")
        {
            string message = "";
           using(AuctionWebProjectEntities dc=new AuctionWebProjectEntities())
            {
                var v = dc.Users.Where(a => a.Email == login.EmailID).FirstOrDefault();
                if(v!=null)
                {
                    if(string.Compare(Crypto.Hash(login.Password),v.Password)==0)
                    {
                        int timeout = login.RememberMe ? 525600 : 20;
                        var ticket = new FormsAuthenticationTicket(login.EmailID, login.RememberMe, timeout);
                        string encrypted = FormsAuthentication.Encrypt(ticket);
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                        cookie.Expires = DateTime.Now.AddMinutes(timeout);
                        cookie.HttpOnly = true;
                        Response.Cookies.Add(cookie);

                        if(Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }

                    }
                    else
                    {
                        message = "Invalid credential provided";
                    }
                }
                else
                {
                    message = "Invalid credential provided";
                }
            }
            ViewBag.Message = message;
            return View();
        }

        //LOgout
        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }

        [NonAction]
        public bool IsEmailExist(string emailID)
        {
            using (AuctionWebProjectEntities dc = new AuctionWebProjectEntities())
            {
                var v = dc.Users.Where(a => a.Email == emailID).FirstOrDefault();
                return v != null;
            }
        }

        [NonAction]
        public void sendverificationemail(string emailID, string activationcode)
        {
            var verifyUrl = "/User/VerifyAccount/" + activationcode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("buyandsellaction@gmail.com", "Buy N Sell Auction");
            var toEmail = new MailAddress(emailID);
            var fromEmailPassword = "Buy&SellAuction";
            string subject = "Your Account is Successfully Created";

            string body = "<br/><br/>Welcome to Sell&Bid. We are excited to welcome you to the Auction World .Your Account on Sell&Bid is created. Please click on the below link to verify your account" + "<br/><br/><a href='" + link + "'>" + link + "</a>";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword),
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
         }
    }

}