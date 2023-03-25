﻿using System;
using Xeptions;

namespace DemoCenter.Models.Students.Exceptions
{
    public class LockedStudentException : Xeption
    {
        public LockedStudentException(Exception innerException)
            :base (message : "Student is locked, please try again.", innerException)
        {}
    }
}
