namespace contact_Manger.DTOs
{
    public record ContactDto(
        int Id, string Name, string Phone, string Address, DateTime CretedAd, string DOB, string Remark);
}
