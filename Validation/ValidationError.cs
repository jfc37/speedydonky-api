﻿using Common.Extensions;

namespace Validation
{
    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }

        public ValidationError(string property, string error)
        {
            PropertyName = property;
            ErrorMessage = error;
        }

        public ValidationError()
        {
            
        }

        public override string ToString()
        {
            return this.ToDebugString(nameof(PropertyName), nameof(ErrorMessage));
        }
    }
}
