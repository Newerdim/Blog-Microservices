﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.API.Models
{
    public class RegisterModel
    {
        /// <summary>
        /// Username
        /// <para>Minimum length is 3</para>
        /// <example>User123</example>
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Adress email
        /// <example>User123@gmail.com</example>
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// <para>Must contains one lower and one uppercase letter and one number</para>
        /// <para>Minimum length is 6</para>
        /// <example>User123@gmail.com</example>
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Url where user should be redirected when click email confirmation link
        /// <para>Example will redirect to www.mysite.com/emailConfirmation/{token}</para>
        /// <para>Note: Do not put slash at the end</para>
        /// <example>www.mysite.com/emailConfirmation</example>
        /// </summary>
        [Required]
        public string EmailConfirmationUrl { get; set; }
    }
}
