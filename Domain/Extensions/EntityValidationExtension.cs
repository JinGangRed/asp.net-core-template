using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Domain.Extensions
{
    public static class EntityValidationExtension
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }
        
    }
}