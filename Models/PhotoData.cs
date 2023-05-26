namespace SearchPhoto.Models
{
    public class SearchPhotoData
    {
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public PhotoData[] Results { get; set; }
    }

    public class PhotoData
    {
        public string Id { get; set; }
        public string Slug { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset? PromotedAt { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public string Color { get; set; }
        public string BlurHash { get; set; }
        public string Description { get; set; }
        public string AltDescription { get; set; }
        public Urls Urls { get; set; }
        public Links Links { get; set; }
        public long Likes { get; set; }
        public bool LikedByUser { get; set; }
        public object[] CurrentUserCollections { get; set; }
        public Sponsorship Sponsorship { get; set; }
        public TopicSubmissions TopicSubmissions { get; set; }
        public User User { get; set; }
        public Tag[]? Tags { get; set; }
    }

    public class Links
    {
        public Uri Self { get; set; }
        public Uri Html { get; set; }
        public Uri Download { get; set; }
        public Uri DownloadLocation { get; set; }
    }

    public partial class Source
    {
        public Ancestry Ancestry { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public PhotoData PhotoData { get; set; }
    }

    public partial class Tag
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public Source Source { get; set; }
    }

    public class Sponsorship
    {
        public string[] ImpressionUrls { get; set; }
        public string Tagline { get; set; }
        public Uri TaglineUrl { get; set; }
        public User Sponsor { get; set; }
    }

    public partial class Ancestry
    {
        public Category Type { get; set; }
        public Category Category { get; set; }
        public Category Subcategory { get; set; }
    }

    public partial class Category
    {
        public string Slug { get; set; }
        public string PrettySlug { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TwitterUsername { get; set; }
        public Uri PortfolioUrl { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public UserLinks Links { get; set; }
        public ProfileImage ProfileImage { get; set; }
        public string InstagramUsername { get; set; }
        public long TotalCollections { get; set; }
        public long TotalLikes { get; set; }
        public long TotalPhotos { get; set; }
        public bool AcceptedTos { get; set; }
        public bool ForHire { get; set; }
        public Social Social { get; set; }
    }

    public class UserLinks
    {
        public Uri Self { get; set; }
        public Uri Html { get; set; }
        public Uri Photos { get; set; }
        public Uri Likes { get; set; }
        public Uri Portfolio { get; set; }
        public Uri Following { get; set; }
        public Uri Followers { get; set; }
    }

    public class ProfileImage
    {
        public Uri Small { get; set; }
        public Uri Medium { get; set; }
        public Uri Large { get; set; }
    }

    public class Social
    {
        public string InstagramUsername { get; set; }
        public Uri PortfolioUrl { get; set; }
        public string TwitterUsername { get; set; }
        public object PaypalEmail { get; set; }
    }

    public class TopicSubmissions
    {
        public BusinessWork BusinessWork { get; set; }
    }

    public class BusinessWork
    {
        public string Status { get; set; }
        public DateTimeOffset ApprovedOn { get; set; }
    }

    public class Urls
    {
        public Uri Raw { get; set; }
        public Uri Full { get; set; }
        public Uri Regular { get; set; }
        public Uri Small { get; set; }
        public Uri Thumb { get; set; }
        public Uri SmallS3 { get; set; }
    }
}
