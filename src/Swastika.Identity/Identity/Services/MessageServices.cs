﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;

namespace Swastika.Identity.Services
{
    public class AuthEmailMessageSender : IEmailSender
    {
        /// <summary>
        /// Sends the email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }

    public class AuthSMSMessageSender : ISmsSender
    {
        /// <summary>
        /// Sends the SMS asynchronous.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}