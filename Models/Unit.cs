using System.ComponentModel.DataAnnotations;
using Models.Base;
using Resources;

namespace Models
{
    public class Unit : ExtraExtendedEntity
    {
        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.Name))]
        [Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Messages),
            ErrorMessageResourceName = nameof(Messages.Required))]
        [MaxLength
        (Constant.Length.GENERAL_NAME,
            ErrorMessageResourceType = typeof(Messages),
            ErrorMessageResourceName = nameof(Messages.MaxLength))]
        public string Name { get; set; }

        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.LatinName))]
        [MaxLength
        (Constant.Length.GENERAL_NAME,
            ErrorMessageResourceType = typeof(Messages),
            ErrorMessageResourceName = nameof(Messages.MaxLength))]
        public string LatinName { get; set; }
    }
}