using System.ComponentModel.DataAnnotations;

namespace lablink.app.Enums
{
    public enum ResultStatus
    {
        Pending,
        [Display(Name = "Ready for Claim")]
        ReadyForClaim,
        Notified,
        Claimed
    }
}
