namespace InspiringDash.ArtService
{
    public interface IArtService
    {
        Task<List<Artwork>> GetArtworksAsync();
    }
}
