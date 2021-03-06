﻿using Action.PrivateLessons;
using FluentValidation;
using Models.PrivateLessons;
using NodaTime;

namespace Validation.Validators.PrivateLessons
{
    /// <summary>
    /// Validator for setting opening hours
    /// </summary>
    public class SetOpeningHoursValidator : AbstractValidator<TimeSlot>, IActionValidator<SetOpeningHours, TimeSlot>
    {
        public SetOpeningHoursValidator()
        {
            RuleFor(x => x.Day)
                .NotEqual(IsoDayOfWeek.None).WithMessage(ValidationMessages.InvalidOpeningDay);

            RuleFor(x => x.OpeningTime)
                .NotNull().WithMessage(ValidationMessages.InvalidOpeningTime);

            RuleFor(x => x.ClosingTime)
                .NotNull().WithMessage(ValidationMessages.InvalidClosingTime)
                .GreaterThan(x => x.OpeningTime).WithMessage(ValidationMessages.ClosingTimeAfterOpeningTime);
        }
    }
}
