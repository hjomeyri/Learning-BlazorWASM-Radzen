using System.ComponentModel.DataAnnotations;
using Resources;

namespace Models.Base
{
    public abstract class ExtendedEntity : Entity
    {
        public ExtendedEntity() : base()
        {
            Ordering = 10000;
            IsActive = true;
        }

        // **********
        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.IsActive))]
        public bool IsActive { get; set; }
        // **********
        
        // **********
        [Display
        (ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.Ordering))]
        public int Ordering { get; set; }
        // **********
    }
}