using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AmigoDono.Model.Helper.CustomValidator
{
    public class CustomValidationCPFAttribute : ValidationAttribute
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public CustomValidationCPFAttribute() { }

        /// <summary>
        /// Validação server
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            bool valido = Util.ValidaCPF(value.ToString());
            return valido;
        }

        /// <summary>
        /// Validação client
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <returns></returns>
  

        //public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
        //    System.Web.Mvc.ModelMetadata metadata, ControllerContext context)
        //{
        //    yield return new ModelClientValidationRule
        //    {
        //        ErrorMessage = this.FormatErrorMessage(null),
        //        ValidationType = "customvalidationcpf"
        //    };
        //}

    }
}
