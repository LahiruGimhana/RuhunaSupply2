﻿using Microsoft.AspNetCore.Http;
using RuhunaSupply.Data;
using RuhunaSupply.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RuhunaSupply.Common
{
    public static class Functions
    {
        #region Object
        public static UserAccount GetCurrentUser(HttpContext httpContext,ApplicationDbContext _db)
        {
            int userId = int.Parse(httpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value);
            return _db.UserAccounts.FirstOrDefault(u => u.Id == userId);
        }
        public static int GetCurrentUserId(HttpContext httpContext, ApplicationDbContext _db)
        {
            int userId;
            if (int.TryParse(httpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value, out userId))
                return userId;
            throw new Exception("Authentication Failed");
        }
        internal static void UpdateErrorLog(string errorText,Exception ex)
        {
            UpdateErrorLog(errorText, ex.Message, ex.StackTrace);
        }
        internal static void UpdateErrorLog(string errorText, string message, string stackTrace)
        {
            string[] s = { "Date : " + DateTime.Today.ToShortDateString() + " | Time : "
                    + DateTime.Now.ToShortTimeString(),"Error Text:", errorText, "Message:",
                message, "Stack Trace:", stackTrace, "-------------------------------------" +
                 "-------------------------------------"};
            File.AppendAllLines("Log.txt", s);
        }
        #endregion
    }
}
