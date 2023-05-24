using FluentValidation;

namespace Freelancer.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            if (context != null)
            {
                var result = validator.Validate(context);
                if (result.Errors.Count > 0) throw new ValidationException(result.Errors);
            }
            // İlgili işlemler veya hata yönetimi
        }
    }
}