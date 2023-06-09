﻿using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
          
        }
    }
}
