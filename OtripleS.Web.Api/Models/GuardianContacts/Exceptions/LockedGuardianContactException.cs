﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.GuardianContacts.Exceptions
{
    public class LockedGuardianContactException : Exception
    {
        public LockedGuardianContactException(Exception innerException)
            : base(message: "Locked guardian contact record exception, please try again later.", innerException) { }
    }
}